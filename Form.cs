using System;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

/* Arguments for ffmpeg
 * 
 * Cutting duration
 * -ss startTime -t endTime -i "input.mp4" -c copy "./1.mp4"
 * 
 * Pass one
 * -y -i "./1.mp4" -c:v libx264 -b:v 4500k -pass 1 -an -f null NULL
 * 
 * Pass two
 * -i "./1.mp4" -c:v libx264 -b:v 4500k -pass 2 -c:a aac -b:a 128k "output.mp4"
 */


namespace VideoCutter
{
    public partial class Form : System.Windows.Forms.Form
    {

        private const float VER = 0.06F;
        private const string URL = "http://alexfeetham.duckdns.org/videocutter/";
        enum Stack
        {
            compress_1,
            compress_2,
            complete
        }

        public Form()
        {
            InitializeComponent();
            updateClient();
            fileNameLbl.Text = "";
            outputNameLbl.Text = "";
            this.Text += " | Version: " + VER.ToString();

        }
        private void updateClient()
        {
            //Variables
            float serverVer;
            WebClient wc = new WebClient();

            // Check for update
            try { serverVer = float.Parse(wc.DownloadString(URL + "version.txt")); }
            catch (Exception) { return; } // Couldn't connect to site, probably down or lack of internet

            if (VER >= serverVer)
                return;

            // if server has new version update
            if (MessageBox.Show("Would you like to update to the latest version?", "Update!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Process proc = new Process();
            proc.StartInfo.FileName = "Updater.exe";
            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.Verb = "runas";
            proc.Start();
            Environment.Exit(0);
        }

        #region Grabbing files
        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            //Open file dialog
            inputVideoFile.ShowDialog();
        }
        private void openVideoFile_FileOk(object sender, CancelEventArgs e)
        {
            // Grab video information
            fileNameLbl.Text = inputVideoFile.FileName;
            // Grab video length
            using (ShellObject shell = ShellObject.FromParsingName(inputVideoFile.FileName))
            {
                splitDuration(shell.Properties.System.Media.Duration.FormatForDisplay(PropertyDescriptionFormatOptions.None));
            }
        }
        private void confirmBtn_Click(object sender, EventArgs e)
        {
            outputFileDialog.ShowDialog();
        }
        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            outputNameLbl.Text = outputFileDialog.FileName;
        }
        #endregion

        private void splitDuration(string v)
        {
            string[] data = v.Split(":");
            endH.Text = data[0];
            endM.Text = data[1];
            endS.Text = data[2].Split(".")[0];
        }

        private TimeSpan[] combine()
        {
            TimeSpan[] times = {
                TimeSpan.Parse(startH.Text + ":" + startM.Text + ":" + startS.Text),
                TimeSpan.Parse(endH.Text + ":" + endM.Text + ":" + endS.Text)
            };

            return times;
        }
        private bool validInputs()
        {
            try
            {
                if (int.Parse(startH.Text) >= 100)
                    return false;
                if (int.Parse(startM.Text) >= 60)
                    return false;
                if (double.Parse(startS.Text) >= 60)
                    return false;

                if (int.Parse(endH.Text) >= 100)
                    return false;
                if (int.Parse(endM.Text) >= 60)
                    return false;
                if (double.Parse(endS.Text) >= 60)
                    return false;
                if (float.Parse(bitrateTxt.Text) < 0)
                    return false;

            } catch(Exception) {
                return false;
            }
            return true;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if (statusLbl.Text != "Complete." && statusLbl.Text != "Idle")
                return;
            // Check for valid files
            if(outputNameLbl.Text == "" || fileNameLbl.Text == "")
            {
                MessageBox.Show("Missing file path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Format boxes
            if (!validInputs())
            {
                MessageBox.Show("Invalid input settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            statusLbl.Text = "Cutting video time...";
            var times = combine();
            string args = "-ss " + times[0].ToString() + " -t " + (times[1] - times[0]).ToString() + " -i " + '\"' + inputVideoFile.FileName + "\" -c copy \"./1.mp4\"";

            Stack status = compressionCheck.Checked ? Stack.compress_1 : Stack.complete;
            SetText("Trimming video.", statusLbl);
            _ = ffmpeg(args, status);
        }

        private async Task<int> ffmpeg(string args, Stack status) {
            try
            {
                Debug.WriteLine(args);
                var tcs = new TaskCompletionSource<int>();
                var process = new Process
                {
                    StartInfo = {
                    FileName = @"./ffmpeg.exe",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = args,
                    UseShellExecute = false,
                    CreateNoWindow = true
                },
                    EnableRaisingEvents = true
                };


                process.Exited += (sender, e) =>
                {
                    // Calculate bitrate to achieve target file size
                    var times = combine();
                    double duration = (times[1] - times[0]).TotalSeconds;
                    double n = (int)((8192 * double.Parse(bitrateTxt.Text)) / duration) - 128;
                    int bitrate = (int)(Math.Floor(n / 50.0) * 50.0);
                    if (bitrate > 4500)
                        bitrate = 4500;

                    string args;

                    switch (status)
                    {
                        case Stack.complete:
                            File.Delete("./1.mp4");
                            // Reset locks
                            SetText("Complete.", statusLbl);
                            break;

                        case Stack.compress_1:
                            args = "-y -i \"./1.mp4\" -c:v libx264 -b:v " + bitrate + "k -pass 1 -an -f mp4 NULL";
                            SetText("Compression (1/2).", statusLbl);
                            _ = ffmpeg(args, Stack.compress_2);
                            break;

                        case Stack.compress_2:
                            args = "-i \"./1.mp4\" -c:v libx264 -b:v " + bitrate + "k -pass 2 -c:a aac \"" + outputFileDialog.FileName + '\"';
                            SetText("Compression (2/2).", statusLbl);
                            _ = ffmpeg(args, Stack.complete);
                            break;
                    }
                };

                process.Start();
                // Use asynchronous read operations on at least one of the streams.
                // Reading both streams synchronously would generate another deadlock.
                process.BeginOutputReadLine();
                string tmpErrorOut = await process.StandardError.ReadToEndAsync();


                return await tcs.Task;
            }
            catch (Exception ee)
            {
                Debug.WriteLine(ee.Message);
            }
            return -1;
        }

        delegate void SetTextCallback(string text, Label lbl);
        private void SetText(string text, Label lbl)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.statusLbl.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                this.Invoke(d, new object[] { text, lbl });
            }
            else
            {
                lbl.Text = text;
            }
        }

    }
}
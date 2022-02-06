using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;

namespace VideoCutter
{
    public partial class Form : System.Windows.Forms.Form
    {

        private const float VER = 0.01F;
        private const string URL = "http://alexfeetham.duckdns.org/videocutter/";
        private ffMpeg.Converter fmc;
        private ffMpeg.VideoFile loadedFile;
        private bool fileLockOne = true;
        private bool fileLockTwo = true;

        public Form()
        {
            InitializeComponent();
            updateClient();

            fmc = new ffMpeg.Converter(@"./ffmpeg.exe");
            openVideoFile.Filter = "Mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
            saveFileDialog.Filter = "Mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
            fileNameLbl.Text = "";
            outputNameLbl.Text = "";
        }

        private void updateClient()
        {
            //Variables
            float serverVer = 0F;
            WebClient wc = new WebClient();

            // Check for update
            try
            {
                serverVer = float.Parse(wc.DownloadString(URL + "version.txt"));
            }
            catch (Exception e) { return; } // Couldn't connect to site, probably down or lack of internet

            if (VER >= serverVer)
                return;

            // if server has new version update
            if (MessageBox.Show("Would you like to update to the latest version?", "Update!",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            Process.Start(@"./Updater.exe");
            this.Close();
        }

        private void loadFileBtn_Click(object sender, EventArgs e)
        {
            //Open file dialog
            openVideoFile.ShowDialog();
        }

        private void openVideoFile_FileOk(object sender, CancelEventArgs e)
        {
            // Grab video information
            loadedFile = new ffMpeg.VideoFile(openVideoFile.FileName);
            fmc.GetVideoInfo(loadedFile);
            fileNameLbl.Text = loadedFile.Path;
            splitDuration(loadedFile.Duration.ToString());
            fileLockOne = false;
            if (!fileLockTwo)
                startBtn.Enabled = true;
        }

        private void splitDuration(string v)
        {
            string[] data = v.Split(":");
            endH.Text = data[0];
            endM.Text = data[1];
            endS.Text = data[2];

            startH.Text = "00";
            startM.Text = "00";
            startS.Text = "00.00";
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            outputNameLbl.Text = saveFileDialog.FileName;
            fileLockTwo = false;
            if (!fileLockOne)
                startBtn.Enabled = true;
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

            } catch(Exception e) {
                return false;
            }
            return true;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            if(fileLockOne || fileLockTwo)
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

            cutFile(
                startH.Text + ":" + startM.Text + ":" + startS.Text,
                endH.Text + ":" + endM.Text + ":" + endS.Text,
                loadedFile, saveFileDialog.FileName, compressionCheck.Checked);
        }

        public void cutFile(String start, String end, ffMpeg.VideoFile input, string outputFile, bool compress)
        {
            startBtn.Enabled = false;
            string args = "-progress - -nostats -ss " + start + " -i " + '\"' + input.Path + '\"' + " -to " + end + " -c copy \"" + outputFile + '\"';
            statusLbl.Text = "Cutting video...";
            _ = trimVideo(args, compress, outputFile);
        }

        public async Task<int> trimVideo(string args, bool compress, string fileToCompress)
        {
            try
            {
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


                process.Exited += (sender, args) =>
                {
                    if (compress)
                    {
                        SetText("Compressing...", statusLbl);
                        _ = compressFile(fileToCompress);
                    }
                    else
                        Complete();
                    tcs.SetResult(process.ExitCode);
                    process.Dispose();
                };

                process.Start();
                // Use asynchronous read operations on at least one of the streams.
                // Reading both streams synchronously would generate another deadlock.
                process.BeginOutputReadLine();
                string tmpErrorOut = await process.StandardError.ReadToEndAsync();
                //process.WaitForExit();


                return await tcs.Task;
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            return -1;
        }
        public async Task<int> compressFile(string fileToCompress)
        {
            try
            {
                // Grabbing file data
                ffMpeg.VideoFile compressLocation = new ffMpeg.VideoFile(fileToCompress);
                fmc.GetVideoInfo(compressLocation);

                // Calculate bitrate
                double duration = compressLocation.Duration.TotalSeconds;
                double n = (int)(65536 / duration) - 128;
                int bitrate = (int)(Math.Floor(n / 50.0) * 50.0);
                if (bitrate > 4500)
                    bitrate = 4500;

                var tcs = new TaskCompletionSource<int>();

                var process = new Process
                {
                    StartInfo = {
                    FileName = @"./ffmpeg.exe",
                    RedirectStandardOutput = true,
                    RedirectStandardError = true,
                    Arguments = "-progress - -nostats -y -i \"" + fileToCompress + "\" -c:v libx264 -b:v " + bitrate + "k temp.mp4",
                    UseShellExecute = false,
                    CreateNoWindow = true
                },
                    EnableRaisingEvents = true
                };


                process.Exited += (sender, args) =>
                {
                    Complete(fileToCompress);
                    tcs.SetResult(process.ExitCode);
                    process.Dispose();
                };

                process.Start();
                // Use asynchronous read operations on at least one of the streams.
                // Reading both streams synchronously would generate another deadlock.
                process.BeginOutputReadLine();
                string tmpErrorOut = await process.StandardError.ReadToEndAsync();
                //process.WaitForExit();


                return await tcs.Task;
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            return -1;
        }
        private void Complete(string fileName = null)
        {
            if(fileName != null) //no compression
            {
                SetText("Moving file...", statusLbl);
                File.Delete(fileName);
                File.Move(@".\temp.mp4", fileName);
            }

            // Reset locks
            SetText("", fileNameLbl);
            SetText("", outputNameLbl);
            fileLockOne = true;
            fileLockTwo = true;
            SetText("Complete.", statusLbl);
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
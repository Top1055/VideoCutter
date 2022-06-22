using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;
using System.Text.RegularExpressions;

namespace Video_Cutter
{
    public partial class VidoCutter : Form
    {

        private Video_settings src_video;
        private const float VER = 0.08F;
        private const string URL = "https://alexfeetham.ddns.net/videocutter";
        enum Stack
        {
            compress_1,
            compress_2,
            complete
        }

        class Video_settings
        {

            #region properties

            private int frame_rate;
            private int width;
            private int height;
            private float file_size;
            private string start_time;
            private string end_time;

            public Video_settings(int frames, int w, int h, float fs, string st, string et)
            {
                frame_rate = frames;
                width = w;
                height = h;
                file_size = fs;
                start_time = st;
                end_time = et;
            }

            public Video_settings()
            {
                frame_rate = -1;
                width = -1;
                height = -1;
                file_size = -1;
                start_time = null;
                end_time = null;
            }

            public int FPS
            {
                get { return frame_rate; }
                set { frame_rate = value; }
            }

            public int Width
            {
                get { return width; }
                set { width = value; }
            }

            public int Height
            {
                get { return height; }
                set { height = value; }
            }

            public string EndTime
            {
                get { return end_time; }
                set { end_time = value; }
            }

            public string StartTime
            {
                get { return start_time; }
                set { start_time = value; }
            }

            public float FileSize
            {
                get { return file_size; }
                set { file_size = value; }
            }

            #endregion

            public bool validate(Video_settings src)
            {
                if(frame_rate < src.frame_rate)
                    return false;
                if(file_size < src.file_size)
                    return false;

                //Implement time check here

                return true;
            }
        }

        public VidoCutter()
        {
            InitializeComponent();
            updateClient();
            fileNameLbl.Text = "";
            outputNameLbl.Text = "";
            Text += " | Version: " + VER.ToString();
        }

        private void updateClient()
        {
            //Variables
            float serverVer;
            WebClient wc = new WebClient();

            // Check for update
            try { serverVer = float.Parse(wc.DownloadString(URL + "/version.txt")); }
            catch (Exception) { return; } // Couldn't connect to site, site down or lack of internet

            Debug.WriteLine(serverVer);

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

        #region Files
        private void load_btn_Click(object sender, EventArgs e)
        {
            load_file.ShowDialog();
        }

        private void save_btn_Click(object sender, EventArgs e)
        {
            save_file.ShowDialog();
        }

        private void load_file_FileOk(object sender, CancelEventArgs e)
        {
            fileNameLbl.Text = load_file.FileName;
            // Grab video data
            using (ShellFile shell = ShellFile.FromFilePath(load_file.FileName))
            {
                string length = shell.Properties.System.Media.Duration.FormatForDisplay(PropertyDescriptionFormatOptions.None);
                int fps = ((int)(shell.Properties.System.Video.FrameRate.Value / 1000));
                int width = (int)shell.Properties.System.Video.FrameWidth.Value;
                int height = (int)shell.Properties.System.Video.FrameHeight.Value;
                float file_size = new FileInfo(load_file.FileName).Length / (1024 * 1024);

                // Create source video settings
                src_video = new Video_settings(fps, width, height, file_size, "00:00:00", length);

                // Set fields on form
                video_fps.Text = fps.ToString();
                video_width.Text = width.ToString();
                video_height.Text = height.ToString();
                video_size.Text = file_size.ToString();
                end_time.Text = length;

                // Enable forms
                time_box.Enabled = true;
                setting_box.Enabled = true;
            }
            if (outputNameLbl.Text != "")
            {
                start_btn.Enabled = true;
            }
        }

        private void save_file_FileOk(object sender, CancelEventArgs e)
        {
            outputNameLbl.Text = save_file.FileName;
            if (fileNameLbl.Text != "")
            {
                start_btn.Enabled = true;
            }
        }


        #endregion

        #region Enabling input

        private void res_checkbox_CheckedChanged(object sender, EventArgs e)
        {
            video_width.Enabled = res_checkbox.Checked;
            video_height.Enabled = res_checkbox.Checked;
        }

        private void change_fps_CheckedChanged(object sender, EventArgs e)
        {
            video_fps.Enabled = change_fps.Checked;
        }

        private void compress_checked_CheckedChanged(object sender, EventArgs e)
        {
            video_size.Enabled = compress_checked.Checked;
        }

        private void audio_checked_CheckedChanged(object sender, EventArgs e)
        {
            audio_size.Enabled = audio_checked.Checked;
        }

        private void no_audio_CheckedChanged(object sender, EventArgs e)
        {
            audio_checked.Enabled = !no_audio.Checked;
            if (audio_checked.Checked)
            {
                audio_size.Enabled = false;
                audio_checked.Checked = false;
                
            }
        }



        #endregion

        private bool valid_inputs()
        {
            // Check time
            if( new Regex(@"(?:[01]\d|2[0-3]):(?:[0-5]\d):(?:[0-5]\d)").IsMatch(start_time.Text) == false ) {
                MessageBox.Show("Incorrect time format (HH:MM:SS.MS)", "Error: Time input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (new Regex(@"(?:[01]\d|2[0-3]):(?:[0-5]\d):(?:[0-5]\d)").IsMatch(end_time.Text) == false)
            {
                MessageBox.Show("Incorrect time format (HH:MM:SS.MS)", "Error: Time input",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (change_fps.Checked)
                try
                {
                    if (Convert.ToInt16(video_fps.Text) > src_video.FPS) {
                        MessageBox.Show("FPS higher than source video", "Error: FPS input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                } catch
                {
                    MessageBox.Show("FPS input must be a number", "Error: FPS input",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            return true;
        }

        private void start_btn_Click(object sender, EventArgs e)
        {
            if (valid_inputs() == false)
                return;

            // ffmpeg -i movie.mp4 -ss 00:00:03 -t 00:00:08 -async 1 -strict -2 cut.mp4
            string temp_path = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            temp_path += "\\Video Cutter\\";
            Directory.CreateDirectory(temp_path);
            temp_path += "temp.mp4";

            TimeSpan start = TimeSpan.Parse(start_time.Text);
            TimeSpan end = TimeSpan.Parse(end_time.Text);

            string audio_bitrate = audio_checked.Checked ? audio_size.Text : "128K";
            string res = res_checkbox.Checked ? video_width.Text + "x" + video_height.Text : src_video.Width + "x" + src_video.Height;
            string fps = change_fps.Checked ? video_fps.Text : src_video.FPS.ToString();

            Process cmd = new Process();
            cmd.StartInfo.FileName = @"powershell.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = false;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.Start();


            cmd.StandardInput.WriteLine($"./ffmpeg.exe -y -i '{fileNameLbl.Text}' -ss {start_time.Text} -t {end - start} -async 1 -strict -2 -s {res} -r {fps} -b:a {audio_bitrate} '{temp_path}'");
            cmd.StandardInput.Flush();
            cmd.StandardInput.Close();
            cmd.WaitForExit();

            if(compress_checked.Checked)
            {
                // Calculate bitrate to achieve target file size
                double duration = (end - start).TotalSeconds;
                double n = (int)((8192 * double.Parse(video_size.Text)) / duration) - 128;
                int bitrate = (int)(Math.Floor(n / 50.0) * 50.0);
                if (bitrate > 3000)
                    bitrate = 3000; // Capping bitrate to save time

                cmd.Start();
                cmd.StandardInput.WriteLine($"./ffmpeg.exe -y -i '{temp_path}' -c:v libx264 -b:v {bitrate}k -pass 1 -an -f mp4 NULL");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();

                cmd.Start();
                cmd.StandardInput.WriteLine($"./ffmpeg.exe -y -i '{temp_path}' -c:v libx264 -b:v {bitrate}k -pass 2 -c:a aac '{outputNameLbl.Text}'");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            } else
            {
                cmd.Start();
                cmd.StandardInput.WriteLine($"Move-Item -Path '{temp_path}' -Destination '{outputNameLbl.Text}'");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
            }

            // Clean up temp files because we're good developers
            if (File.Exists(temp_path))
            {
                File.Delete(temp_path);
            }

            MessageBox.Show("Complete", "Complete");
        }
    }
}

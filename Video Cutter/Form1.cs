using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net;
using System.Diagnostics;
using System.IO;
using Microsoft.WindowsAPICodePack.Shell;
using Microsoft.WindowsAPICodePack.Shell.PropertySystem;

namespace Video_Cutter
{
    public partial class VidoCutter : Form
    {

        private Video_settings src_video;
        private Video_settings output_video = new Video_settings();
        private const float VER = 0.07F;
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
            try { serverVer = float.Parse(wc.DownloadString(URL + "version.txt")); }
            catch (Exception) { return; } // Couldn't connect to site, site down or lack of internet

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



    }
}

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

namespace VideoCutter
{
    public partial class Form : System.Windows.Forms.Form
    {

        private const float VER = 0.01F;
        private const string URL = "http://alexfeetham.duckdns.org/videocutter/";
        private ffMpeg.Converter fmc;
        private ffMpeg.VideoFile loadedFile;

        public Form()
        {
            InitializeComponent();
            updateClient();

            fmc = new ffMpeg.Converter(@"./ffmpeg.exe");
            openVideoFile.Filter = "Mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
            saveFileDialog.Filter = "Mp4 files (*.mp4)|*.mp4|All files (*.*)|*.*";
            fileName.Text = "";
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
            fileName.Text = loadedFile.Path;
            startS.Text = loadedFile.Duration.ToString();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            // Format boxes
            if (!validInputs())
            {
                MessageBox.Show("Invalid input settings", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            fmc.cutFile(startH.Text, startS.Text, loadedFile, saveFileDialog.FileName, compressionCheck.Checked);
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
    }
}
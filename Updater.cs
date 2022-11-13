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
using System.IO;
using System.Diagnostics;
using System.IO.Compression;

namespace Updater
{
    public partial class Updater : Form
    {

        private const string URL = "https://alexfeetham.ddns.net/videocutter/";

        public Updater()
        {
            InitializeComponent();

            WebClient wc = new WebClient();
            try
            {
                System.Threading.Thread.Sleep(1000);
                File.Delete(@".\VideoCutter.exe");
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(wc_DownloadProgressChanged);
                wc.DownloadFile(URL + "VideoCutter.exe", @".\VideoCutter.exe");
            }
            catch(Exception e) { MessageBox.Show(e.Message); }

            Process.Start(@".\VideoCutter.exe");
            Environment.Exit(0);
        }

        public void wc_DownloadProgressChanged(Object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgress.Value = e.ProgressPercentage;
        }
    }
}

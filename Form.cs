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
        private const string URL = "";

        public Form()
        {
            InitializeComponent();
            updateClient();
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

            Process.Start(URL + "VideoCutter.exe");
            this.Close();
        }
    }
}
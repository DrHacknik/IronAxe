﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Minecraft_Launcher
{
    public partial class dev_get_java : Form
    {
        private WebClient jv;
        private Stopwatch sw = new Stopwatch();
        private string cd = Application.StartupPath;

        public dev_get_java()
        {
            InitializeComponent();
        }

        private void dev_get_java_Load(object sender, EventArgs e)
        {
            if (File.Exists(cd + "\\jPortable_8_Update_121.paf.exe"))
            {
                File.Delete(cd + "\\jPortable_8_Update_121.paf.exe");
            }

            //Prepare to Download Java
            WebClient client = new WebClient();
            client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            client.DownloadFileCompleted += new AsyncCompletedEventHandler(client_DownloadFileCompleted);

            //Starts the download
            client.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable_8_Update_121.paf.exe"), cd + "\\jPortable_8_Update_121.paf.exe");

            lbl_status.Text = "Download In Progress (JRE)";
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            prog_down.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lbl_status.Text = "Download Completed";

            dev_tmr.Stop();
            try
            {
                if (File.Exists(cd + "\\jPortable_8_Update_121.paf.exe"))
                {
                    Process.Start(cd + "\\jPortable_8_Update_121.paf.exe");
                }
                else
                {
                }
            }
            catch
            {
            }
            dev_tmr2.Start();
        }

        private void dev_tmr2_Tick(object sender, EventArgs e)
        {
            dev_tmr2.Stop();
            lbl_status.Text = "Download In Progress (MC)";
            //Prepare to Dowmnload Minecraft
            prog_down.Value = 0;
            WebClient get_mc = new WebClient();
            get_mc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(getmc_DownloadProgressChanged);
            get_mc.DownloadFileCompleted += new AsyncCompletedEventHandler(getmc_DownloadFileCompleted);

            //Starts the download
            get_mc.DownloadFileAsync(new Uri("https://s3.amazonaws.com/Minecraft.Download/launcher/Minecraft.jar"), cd + "\\bin\\minecraft.jar");
        }

        private void getmc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            prog_down.Value = int.Parse(Math.Truncate(percentage).ToString());
        }

        private void getmc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lbl_status.Text = "Download Completed";
            lbl_status.Enabled = true;
            dev_tmr2.Stop();

            Properties.Settings.Default.dev_download_res = "1";
            Properties.Settings.Default.Save();
            this.Close();
        }

        private void tmr_chck_Tick(object sender, EventArgs e)
        {
            if (prog_down.Value == 100)
            {
                dev_tmr.Stop();
                dev_tmr2.Start();
            }
        }

        private void lbl_status_Click(object sender, EventArgs e)
        {
            dev_tmr.Stop();
            tmr_chck.Stop();
            dev_tmr2.Start();
        }

        private void lbl_can_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
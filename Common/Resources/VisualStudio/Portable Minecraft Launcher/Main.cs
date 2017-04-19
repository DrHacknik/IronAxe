using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Minecraft_Launcher
{
    public partial class Main : Form
    {
        private bool is64Bit = System.Environment.Is64BitOperatingSystem;
        private string cd = Application.StartupPath;

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (is64Bit == true)
            {
                if (Properties.Settings.Default.dev_overide_arch == "1")
                {
                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | DEBUG BUILD | 32bit mode";
                    this.Text = "IronAxe Minecraft Launcher: Main ";
                    if (Properties.Settings.Default.dev_download_res == "")
                    {
                        Form fm = new dev_get_java();
                        fm.Show();
                    }
                }
                else
                {
                    this.Text = "IronAxe Minecraft Launcher: Main ";
                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | DEBUG BUILD | 64bit mode";
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to Reset ALL OF THE SETTINGS TO THEIR DEFAULTS!?", "dev_", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
            switch (dr)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    Properties.Settings.Default.dev_agree = "0";
                    Properties.Settings.Default.Save();
                    Application.Restart();
                    break;

                case System.Windows.Forms.DialogResult.No:

                    break;
            }
        }

        private void client_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
        }

        private void btn_down_Click(object sender, EventArgs e)
        {
            //Check to see if the folder(s) exists
            if (Directory.Exists(cd + "\\bin"))
            {
            }
            else
            {
                Directory.CreateDirectory(cd + "\\bin");
            }

            if (Directory.Exists(cd + "\\data") == false)
            {
                Directory.CreateDirectory(cd + "\\data");
                Directory.CreateDirectory(cd + "\\data\\profiles");
            }
            else
            {
            }
            //Now, check for the files
            if (File.Exists(cd + "\\bin\\minecraft.jar") == false)
            {
            }

            //Grab Java

            Form java = new dev_get_java();
            java.Show();
        }

        private void btn_profile_load_Click_1(object sender, EventArgs e)
        {
            Form fm = new dev_profile_load();
            fm.Show();
        }

        private void btn_profile_create_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(cd + "\\bin\\commonfiles") == false)
            {
                Directory.CreateDirectory(cd + "\\bin\\commonfiles");
            }
            else
            {
                Form fm = new dev_profile_create();
                fm.Show();
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            // MessageBox.Show("Sorry, but this Feature isn't yet implemented.", "dev_", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            lbl_ver.Text = "Connecting to GitHub...";
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Form ds = new dev_settings();
            ds.Show();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This program is made in C#, and uses some Batch scripts. \r\n \r\nOrginal Scripts by MarioMasta64. \r\nThis program is licensed under the Open GNU GPL Source Agreement (v3). \r\n \r\nYou are using version: " + Application.ProductVersion, "dev_about", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
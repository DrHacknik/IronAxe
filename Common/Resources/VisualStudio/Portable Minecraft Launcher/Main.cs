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
                lbl_ver.Text = "Version: " + Application.ProductVersion + " | DEBUG BUILD | x64bit mode";
            }
            else
            {
                lbl_ver.Text = "Version: " + Application.ProductVersion + " | DEBUG BUILD";
                this.Text = "IronAxe Minecraft Launcher: Main ";
                if (Properties.Settings.Default.dev_download_res == "")
                {
                    Form fm = new dev_get_java();
                    fm.Show();
                }
                else
                {
                }
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dev_agree = "0";
            Properties.Settings.Default.Save();
            Application.Restart();
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
            MessageBox.Show("Sorry, but this Feature isn't yet implemented.", "dev_", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            Form ds = new dev_settings();
            ds.Show();
        }
    }
}
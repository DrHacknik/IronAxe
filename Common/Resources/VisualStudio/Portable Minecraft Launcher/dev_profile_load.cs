using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Minecraft_Launcher
{
    public partial class dev_profile_load : Form
    {
        private string cd = Application.StartupPath;

        public dev_profile_load()
        {
            InitializeComponent();
        }

        private void btn_load_Click(object sender, EventArgs e)
        {
            if (Directory.Exists(cd + "\\data\\profiles\\" + txt_prof_name.Text) == false)
            {
                MessageBox.Show("Unable to find the Profile you asked for. Please create this Profile first.", "dev_", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_prof_name.Text = null;
                return;
            }
            else
            {
                try
                {
                    if (txt_prof_name.Text == "")
                    {
                        MessageBox.Show("Please enter a valid profile name!", "dev_", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                    if (Properties.Settings.Default.dev_def_prof == "")
                    {
                        DialogResult dr = MessageBox.Show("Would you like to set this Profile as the Default one to be loaded in the future?", "dev_", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                        switch (dr)
                        {
                            case System.Windows.Forms.DialogResult.Yes:
                                Properties.Settings.Default.dev_def_prof = txt_prof_name.Text;
                                Properties.Settings.Default.Save();
                                break;

                            case System.Windows.Forms.DialogResult.No:

                                break;
                        }
                    }
                    if (Properties.Settings.Default.dev_def_prof == txt_prof_name.Text == false)
                    {
                        DialogResult dr = MessageBox.Show("Would you like to set this Profile as the Default one to be loaded in the future?", "dev_", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                        switch (dr)
                        {
                            case System.Windows.Forms.DialogResult.Yes:
                                Properties.Settings.Default.dev_def_prof = txt_prof_name.Text;
                                Properties.Settings.Default.Save();
                                break;

                            case System.Windows.Forms.DialogResult.No:

                                break;
                        }
                    }
                    if (chck_default.Checked == true)
                    {
                        //Directory.CreateDirectory(cd + "\\data\\Profiles\\Default");
                        //Directory.Move("\\Users" + SystemInformation.UserName + "\\AppData\\Roaming\\.minecraft", cd + "\\data\\Profiles\\Default");
                        lbl_header.Text = "Importing .minecraft --> Profile_default";
                        if (chck_java.Checked == true)
                        {
                            File.WriteAllText(cd + "\\profile.txt", txt_prof_name.Text);
                            Process.Start(cd + "\\start_mc_jre.bat");
                            Application.Exit();
                        }
                        else
                        {
                            File.WriteAllText(cd + "\\profile.txt", txt_prof_name.Text);
                            Process.Start(cd + "\\start_mc_sys.bat");
                            Application.Exit();
                        }
                    }
                    else
                    {
                        if (chck_java.Checked == true)
                        {
                            File.WriteAllText(cd + "\\profile.txt", txt_prof_name.Text);
                            Process.Start(cd + "\\start_mc_jre.bat");
                            Application.Exit();
                        }
                        else
                        {
                            File.WriteAllText(cd + "\\profile.txt", txt_prof_name.Text);
                            Process.Start(cd + "\\start_mc_sys.bat");
                            Application.Exit();
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Unable to find the minecraft.jar File within the \\bin directory! Make sure it's there.", "dev_", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
        }

        private void chck_default_CheckStateChanged(object sender, EventArgs e)
        {
            if (chck_default.Checked == true)
            {
                txt_prof_name.Enabled = false;
                txt_prof_name.Text = "Default";
            }
            else
            {
                txt_prof_name.Enabled = true;
                txt_prof_name.Text = "";
                if (Properties.Settings.Default.dev_def_prof == "")
                {
                    txt_prof_name.Text = "";
                }
                else
                {
                    txt_prof_name.Text = Properties.Settings.Default.dev_def_prof;
                }
            }
        }

        private void dev_profile_load_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_def_prof == "")
            {
                txt_prof_name.Text = "";
            }
            else
            {
                txt_prof_name.Text = Properties.Settings.Default.dev_def_prof;
            }
        }
    }
}
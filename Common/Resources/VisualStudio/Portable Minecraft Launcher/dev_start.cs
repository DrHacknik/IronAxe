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
    public partial class dev_start : Form
    {
        private bool is64Bit = System.Environment.Is64BitOperatingSystem;
        private string cd = Application.StartupPath;

        public dev_start()
        {
            InitializeComponent();
        }

        private void tmr_int_Tick(object sender, EventArgs e)
        {
            prg_prog.Value += 1;
            if (prg_prog.Value == 100)
            {
                if (Properties.Settings.Default.dev_def_prof_st_java == "1")
                {
                    File.WriteAllText(cd + "\\profile.txt", Properties.Settings.Default.dev_def_prof);
                    Process jre = new Process();
                    jre.StartInfo.FileName = cd + "\\start_mc_jre.bat";
                    jre.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    jre.Start();
                    jre.WaitForExit();
                }
                else
                {
                    File.WriteAllText(cd + "\\profile.txt", Properties.Settings.Default.dev_def_prof);
                    Process sys = new Process();
                    sys.StartInfo.FileName = cd + "\\start_mc_sys.bat";
                    sys.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    sys.Start();
                    sys.WaitForExit();
                }
                tmr_int.Stop();
                if (Properties.Settings.Default.dev_runbck == "1")
                {
                    if (Properties.Settings.Default.dev_runbck_min == "1")
                    {
                        if (Properties.Settings.Default.dev_qtx_gui_en == "1")
                        {
                            Form qtx = new Main();
                            qtx.Show();
                            qtx.WindowState = FormWindowState.Minimized;
                            tmr_int.Stop();
                            Hide();
                        }
                        else
                        {
                            Form mn = new dev_gui();
                            mn.Show();
                            mn.WindowState = FormWindowState.Minimized;
                            tmr_int.Stop();
                            Hide();
                        }
                    }
                    else
                    {
                        if (Properties.Settings.Default.dev_qtx_gui_en == "1")
                        {
                            Form qtx = new Main();
                            qtx.Show();
                            tmr_int.Stop();
                            Hide();
                        }
                        else
                        {
                            Form mn = new dev_gui();
                            mn.Show();
                            tmr_int.Stop();
                            Hide();
                        }
                    }
                }
                else
                {
                    Application.Exit();
                }
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_qtx_gui_en == "1")
            {
                Form qtx = new Main();
                qtx.Show();
                tmr_int.Stop();
                Hide();
            }
            else
            {
                Form mn = new dev_gui();
                mn.Show();
                tmr_int.Stop();
                Hide();
            }
        }

        private void dev_start_Load(object sender, EventArgs e)
        {
            if (is64Bit == true)
            {
                if (Directory.Exists(cd + "\\bin\\CommonFiles\\Java64"))
                {
                    Directory.Move(cd + "\\bin\\CommonFiles\\Java64", cd + "\\bin\\CommonFiles\\Java");
                }
                lbl_start_tiny.Text = "When the Progressbar is filled. Press CTRL and Q to cancel. \r\nStarting profile: " + Properties.Settings.Default.dev_def_prof + "\r\nPortable Java = " + Properties.Settings.Default.dev_def_prof_st_java;
            }
        }
    }
}
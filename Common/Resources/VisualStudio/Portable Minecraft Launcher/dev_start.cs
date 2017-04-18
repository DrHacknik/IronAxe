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
                    Process.Start(cd + "\\start_mc_jre.bat");
                    Application.Exit();
                }
                else
                {
                    File.WriteAllText(cd + "\\profile.txt", Properties.Settings.Default.dev_def_prof);
                    Process.Start(cd + "\\start_mc_sys.bat");
                    Application.Exit();
                }
            }
        }

        private void cancelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form mn = new Main();
            mn.Show();
            tmr_int.Stop();
            Hide();
        }

        private void dev_start_Load(object sender, EventArgs e)
        {
            if (is64Bit == true)
            {
                if (Directory.Exists(cd + "\\bin\\CommonFiles\\Java64"))
                {
                    Directory.Move(cd + "\\bin\\CommonFiles\\Java64", cd + "\\bin\\CommonFiles\\Java");
                }
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Minecraft_Launcher
{
    public partial class dev_settings : Form
    {
        public dev_settings()
        {
            InitializeComponent();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (chck_upd.Checked == true)
            {
                Properties.Settings.Default.dev_auto_upd = "1";
            }
            else
            {
                Properties.Settings.Default.dev_auto_upd = "0";
            }
            if (chck_overide_bit.Checked == true)
            {
                Properties.Settings.Default.dev_overide_arch = "1";
            }
            else
            {
                Properties.Settings.Default.dev_overide_arch = "0";
            }
            if (chck_def_prof_st.Checked == true)
            {
                Properties.Settings.Default.dev_def_prof_st = "1";
            }
            else
            {
                Properties.Settings.Default.dev_def_prof_st = "0";
            }
            if (chck_def_pof_st_java.Checked == true)
            {
                Properties.Settings.Default.dev_def_prof_st_java = "1";
            }
            else
            {
                Properties.Settings.Default.dev_def_prof_st_java = "0";
            }
            if (chck_upd.Checked == true)
            {
            }
            Properties.Settings.Default.Save();
            Close();
        }

        private void btn_reset_cache_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dev_def_prof = "";
            Properties.Settings.Default.Save();
            MessageBox.Show("The Default Profile data has been reset to nothing!", "dev_ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void chck_def_prof_st_CheckedChanged(object sender, EventArgs e)
        {
            if (chck_def_prof_st.Checked == true)
            {
                chck_def_pof_st_java.Enabled = true;
            }
            else
            {
                chck_def_pof_st_java.Enabled = false;
            }
        }

        private void dev_settings_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.dev_auto_upd == "1")
            {
                chck_upd.Checked = true;
            }
            if (Properties.Settings.Default.dev_overide_arch == "1")
            {
                chck_overide_bit.Checked = true;
            }
            if (Properties.Settings.Default.dev_def_prof_st == "1")
            {
                chck_def_prof_st.Checked = true;
            }
            if (Properties.Settings.Default.dev_def_prof_st_java == "1")
            {
                chck_def_pof_st_java.Checked = true;
            }
        }
    }
}
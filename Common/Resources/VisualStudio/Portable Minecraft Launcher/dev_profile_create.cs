using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Minecraft_Launcher
{
    public partial class dev_profile_create : Form
    {
        private string cd = Application.StartupPath;

        public dev_profile_create()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            if (File.Exists(cd + "\\profile.txt") == false)
            {
                File.Delete(cd + "\\profile.txt");
                File.WriteAllText(cd + "\\profile.txt", txt_prof_name.Text);
            }
            else
            {
                File.Delete(cd + "\\profile.txt");
                File.WriteAllText(cd + "\\profile.txt", txt_prof_name.Text);
            }
            Directory.CreateDirectory(cd + "\\data\\profiles\\" + txt_prof_name.Text);
            MessageBox.Show("We have Created the profile: " + txt_prof_name.Text, "dev_", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
    }
}
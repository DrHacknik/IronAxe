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
    public partial class dev_whatisnew : Form
    {
        public dev_whatisnew()
        {
            InitializeComponent();
        }

        private void dev_whatisnew_Load(object sender, EventArgs e)
        {
            lbl_main.Text = "IronAxe: What is new in version " + Application.ProductVersion + "?";
        }

        private void btn_gotcha_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.dev_what_new = Application.ProductVersion;
            Properties.Settings.Default.Save();
            this.Close();
        }
    }
}
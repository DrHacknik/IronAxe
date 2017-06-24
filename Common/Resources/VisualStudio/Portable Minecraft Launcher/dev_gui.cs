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
    public partial class dev_gui : Form
    {
        private string cd = Application.StartupPath;
        private bool is64Bit = System.Environment.Is64BitOperatingSystem;
        private DirectoryInfo obj = new DirectoryInfo(Application.StartupPath + "\\data\\profiles\\");

        private void set_top(Object sender)
        {
            indi.Top = ((Control)sender).Top;
            indi.Height = ((Control)sender).Height;
        }

        public dev_gui()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            set_top(sender);
            tab_menu.SelectedTab = tab_main;
        }

        private void btn_profiles_Click(object sender, EventArgs e)
        {
            set_top(sender);
            tab_menu.SelectedTab = tab_prof;
            DirectoryInfo obj = new DirectoryInfo(Application.StartupPath + "\\data\\profiles\\");
            DirectoryInfo[] folders = obj.GetDirectories();
            cmb_prof.DataSource = folders;

            if (Properties.Settings.Default.dev_def_prof == "")
            {
                cmb_prof.Text = "Default";
            }
            else
            {
                cmb_prof.Text = Properties.Settings.Default.dev_def_prof;
            }
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            set_top(sender);
            tab_menu.SelectedTab = tab_settings;

            if (Properties.Settings.Default.dev_qtx_gui_en == "1")
            {
                chck_qtx.Checked = true;
            }
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
            if (Properties.Settings.Default.dev_runbck == "1")
            {
                chck_runbck.Checked = true;
            }
        }

        private void btn_help_Click(object sender, EventArgs e)
        {
            set_top(sender);
            tab_menu.SelectedTab = tab_help;
        }

        private void btn_close_MouseHover(object sender, EventArgs e)
        {
            btn_close.BackColor = Color.DarkGreen;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_close_MouseLeave(object sender, EventArgs e)
        {
            btn_close.BackColor = Color.Transparent;
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_minimize_MouseHover(object sender, EventArgs e)
        {
            btn_minimize.BackColor = Color.DarkGreen;
        }

        private void btn_minimize_MouseLeave(object sender, EventArgs e)
        {
            btn_minimize.BackColor = Color.Transparent;
        }

        private void dev_gui_Load(object sender, EventArgs e)
        {
            tab_menu.SelectedTab = tab_main;
            lbl_ver.Text += Application.ProductVersion;

            if (Properties.Settings.Default.dev_what_new == Application.ProductVersion == false)
            {
                Form wn = new dev_whatisnew();
                wn.Show();
            }
            else
            {
            }
            if (Properties.Settings.Default.dev_def_prof == " ")
            {
                lbl_def.Text += " Nothing";
            }
            else
            {
                lbl_def.Text += " " + Properties.Settings.Default.dev_def_prof;
            }
            if (Directory.Exists(cd + "\\bin\\commonfiles\\java") == true)
            {
                lbl_jre.Text += " Yes";
            }
            else
            {
                lbl_jre.Text += " No";
            }
            if (is64Bit == true)
            {
                if (Properties.Settings.Default.dev_overide_arch == "1")
                {
                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";

                    if (Properties.Settings.Default.dev_download_res == "")
                    {
                        Form fm = new dev_get_java();
                        fm.Show();
                    }
                    else
                    {
                        lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                    }
                }
                else
                {
                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                }

                if (File.Exists(cd + "\\jPortable_8_Update_121.paf.exe"))
                {
                    if (File.Exists(cd + "\\bin\\JRE_32.exe"))
                    {
                        File.Delete(cd + "\\bin\\JRE_32.exe");
                        File.Move(cd + "\\jPortable_8_Update_121.paf.exe", cd + "\\bin\\JRE_32.exe");
                    }
                    else
                    {
                        File.Move(cd + "\\jPortable_8_Update_121.paf.exe", cd + "\\bin\\JRE_32.exe");
                    }
                }
                if (File.Exists(cd + "\\jPortable64_8_Update_121.paf.exe"))
                {
                    if (File.Exists(cd + "\\bin\\JRE_64.exe"))
                    {
                        File.Delete(cd + "\\bin\\JRE_64.exe");
                        File.Move(cd + "\\jPortable64_8_Update_121.paf.exe", cd + "\\bin\\JRE_64.exe");
                    }
                    else
                    {
                        File.Move(cd + "\\jPortable64_8_Update_121.paf.exe", cd + "\\bin\\JRE_64.exe");
                    }
                }
                if (File.Exists(cd + "\\upd_fin.exe"))
                {
                    File.Delete(cd + "\\upd_fin.exe");
                }
                if (File.Exists(cd + "\\Update_Info.ini"))
                {
                    File.Delete(cd + "\\Update_Info.ini");
                }

                if (File.Exists(cd + "\\upd_fin.exe"))
                {
                    File.Delete(cd + "\\upd_fin.exe");
                }
                if (File.Exists(cd + "\\Update_Info.ini"))
                {
                    File.Delete(cd + "\\Update_Info.ini");
                }

                if (Properties.Settings.Default.dev_download_res == "")
                {
                    set_top(btn_help);
                    tab_menu.SelectedTab = tab_help;

                    if (File.Exists(cd + "\\jPortable_8_Update_121.paf.exe"))
                    {
                        if (File.Exists(cd + "\\bin\\JRE_32.exe"))
                        {
                            File.Delete(cd + "\\bin\\JRE_32.exe");
                            File.Move(cd + "\\jPortable_8_Update_121.paf.exe", cd + "\\bin\\JRE_32.exe");
                        }
                        else
                        {
                            File.Move(cd + "\\jPortable_8_Update_121.paf.exe", cd + "\\bin\\JRE_32.exe");
                        }
                    }
                    if (File.Exists(cd + "\\jPortable64_8_Update_121.paf.exe"))
                    {
                        if (File.Exists(cd + "\\bin\\JRE_64.exe"))
                        {
                            File.Delete(cd + "\\bin\\JRE_64.exe");
                            File.Move(cd + "\\jPortable64_8_Update_121.paf.exe", cd + "\\bin\\JRE_64.exe");
                        }
                        else
                        {
                            File.Move(cd + "\\jPortable64_8_Update_121.paf.exe", cd + "\\bin\\JRE_64.exe");
                        }
                    }
                    //Prepare to Download Java
                    WebClient client = new WebClient();
                    client.DownloadProgressChanged += new DownloadProgressChangedEventHandler(down_DownloadProgressChanged);
                    client.DownloadFileCompleted += new AsyncCompletedEventHandler(down_DownloadFileCompleted);

                    //Starts the download
                    if (is64Bit == true)
                    {
                        if (Properties.Settings.Default.dev_overide_arch == "1")
                        {
                            client.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable_8_Update_121.paf.exe"), cd + "\\jPortable_8_Update_121.paf.exe");
                        }
                        else
                        {
                            client.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable64_8_Update_121.paf.exe"), cd + "\\jPortable64_8_Update_121.paf.exe");
                        }
                    }
                }
                else
                {
                }
                if (Properties.Settings.Default.dev_auto_upd == "1")
                {
                    lbl_upd.Visible = true;
                    pcx_upd.Visible = true;

                    try
                    {
                        if (is64Bit == true)
                        {
                            if (Properties.Settings.Default.dev_auto_upd == "1")
                            {
                                //Read latest update and convert to string
                                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Update_Info.ini");
                                WebResponse response = request.GetResponse();
                                Stream dataStream = response.GetResponseStream();
                                StreamReader upd_rd = new StreamReader(dataStream);
                                string upd_get = upd_rd.ReadToEnd();

                                //Get and read latest update info, then grab it
                                //But first delete old files, and continue.
                                WebClient get_info = new WebClient();
                                string cd = Application.StartupPath;

                                lbl_upd.Text = "Downloading Update info...";
                                pcx_upd.BackgroundImage = Properties.Resources.Downloading_Updates_48;
                                this.Refresh();
                                WebClient upd_dwld = new WebClient();

                                upd_dwld.DownloadProgressChanged += new DownloadProgressChangedEventHandler(upd_dwld_DownloadProgressChanged);
                                upd_dwld.DownloadFileCompleted += new AsyncCompletedEventHandler(upd_dwld_DownloadFileCompleted);

                                using (Stream upd = get_info.OpenRead("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Update_Info.ini"))
                                {
                                    using (StreamReader reader = new StreamReader(upd))
                                    {
                                        string rd_upd = null;

                                        rd_upd = reader.ReadToEnd();

                                        if (rd_upd == Application.ProductVersion)
                                        {
                                            if (is64Bit == true)
                                            {
                                                if (Properties.Settings.Default.dev_overide_arch == "1")
                                                {
                                                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                                                }
                                                else
                                                {
                                                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                                                }
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            DialogResult dr = MessageBox.Show("There's an Update available" + " (" + upd_get + ")" + "\r\nDo you wish to update?", "IronAxe: Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                            switch (dr)
                                            {
                                                case System.Windows.Forms.DialogResult.Yes:
                                                    lbl_upd.Text = "Downloading Update...";
                                                    this.Refresh();
                                                    upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Latest_32.exe"), cd + "\\IronAxe Minecraft Launcher_new.exe");
                                                    WebClient get_fin = new WebClient();
                                                    lbl_upd.Text = "Preparing update...";
                                                    this.Refresh();
                                                    get_fin.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                                    Process.Start(cd + "\\upd_fin.exe");

                                                    Application.Exit();
                                                    break;

                                                case System.Windows.Forms.DialogResult.No:
                                                    if (is64Bit == true)
                                                    {
                                                        if (Properties.Settings.Default.dev_overide_arch == "1")
                                                        {
                                                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                                                        }
                                                        else
                                                        {
                                                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                                                        }
                                                        pcx_upd.BackgroundImage = Properties.Resources.Shield_48;
                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                //Read latest update and convert to string
                                WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Update_Info.ini");
                                WebResponse response = request.GetResponse();
                                Stream dataStream = response.GetResponseStream();
                                StreamReader upd_rd = new StreamReader(dataStream);
                                string upd_get = upd_rd.ReadToEnd();

                                //Get and read latest update info, then grab it
                                //But first delete old files, and continue.
                                WebClient get_info = new WebClient();
                                string cd = Application.StartupPath;

                                lbl_upd.Text = "Downloading Update info...";
                                pcx_upd.BackgroundImage = Properties.Resources.Downloading_Updates_48;
                                this.Refresh();
                                WebClient upd_dwld = new WebClient();

                                upd_dwld.DownloadProgressChanged += new DownloadProgressChangedEventHandler(upd_dwld_DownloadProgressChanged);
                                upd_dwld.DownloadFileCompleted += new AsyncCompletedEventHandler(upd_dwld_DownloadFileCompleted);

                                using (Stream upd = get_info.OpenRead("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Update_Info.ini"))
                                {
                                    using (StreamReader reader = new StreamReader(upd))
                                    {
                                        string rd_upd = null;

                                        rd_upd = reader.ReadToEnd();

                                        if (rd_upd == Application.ProductVersion)
                                        {
                                            if (is64Bit == true)
                                            {
                                                if (Properties.Settings.Default.dev_overide_arch == "1")
                                                {
                                                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                                                }
                                                else
                                                {
                                                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                                                }
                                                return;
                                            }
                                        }
                                        else
                                        {
                                            DialogResult dr = MessageBox.Show("There's an Update available" + " (" + upd_get + ")" + "\r\nDo you wish to update?", "IronAxe: Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                            switch (dr)
                                            {
                                                case System.Windows.Forms.DialogResult.Yes:
                                                    lbl_upd.Text = "Downloading Update...";
                                                    this.Refresh();
                                                    upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Latest_64.exe"), cd + "\\IronAxe Minecraft Launcher_new.exe");
                                                    WebClient get_fin = new WebClient();
                                                    lbl_upd.Text = "Preparing update...";
                                                    this.Refresh();
                                                    get_fin.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                                    Process.Start(cd + "\\upd_fin.exe");

                                                    Application.Exit();
                                                    break;

                                                case System.Windows.Forms.DialogResult.No:
                                                    if (is64Bit == true)
                                                    {
                                                        if (Properties.Settings.Default.dev_overide_arch == "1")
                                                        {
                                                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                                                        }
                                                        else
                                                        {
                                                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                                                        }
                                                        pcx_upd.BackgroundImage = Properties.Resources.Shield_48;
                                                    }
                                                    break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                    catch
                    {
                        lbl_upd.Text = "Update error: Unable to connect.";
                        pcx_upd.BackgroundImage = Properties.Resources.Error_48;
                        if (Properties.Settings.Default.dev_overide_arch == "1")
                        {
                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                        }
                        else
                        {
                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                        }
                    }
                }
            }
        }

        private void upd_dwld_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            lbl_ver.Text = "Downloading update: " + int.Parse(Math.Truncate(percentage).ToString());
        }

        private void upd_dwld_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lbl_ver.Text = "Download Completed";
        }

        private void btn_load_profile_Click(object sender, EventArgs e)
        {
            if (is64Bit == true)
            {
                if (Directory.Exists(cd + "\\bin\\CommonFiles\\Java64"))
                {
                    Directory.Move(cd + "\\bin\\CommonFiles\\Java64", cd + "\\bin\\CommonFiles\\Java");
                }
            }
            if (Directory.Exists(cd + "\\data\\profiles\\" + cmb_prof.Text) == false)
            {
                MessageBox.Show("Unable to find the Profile you asked for. Please create this Profile first.", "dev_", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_prof.Text = null;
                return;
            }
            else
            {
                try
                {
                    if (cmb_prof.Text == "")
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
                                Properties.Settings.Default.dev_def_prof = cmb_prof.Text;
                                Properties.Settings.Default.Save();
                                break;

                            case System.Windows.Forms.DialogResult.No:

                                break;
                        }
                    }
                    if (Properties.Settings.Default.dev_def_prof == cmb_prof.Text == false)
                    {
                        DialogResult dr = MessageBox.Show("Would you like to set this Profile as the Default one to be loaded in the future?", "dev_", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2);
                        switch (dr)
                        {
                            case System.Windows.Forms.DialogResult.Yes:
                                Properties.Settings.Default.dev_def_prof = cmb_prof.Text;
                                Properties.Settings.Default.Save();
                                break;

                            case System.Windows.Forms.DialogResult.No:

                                break;
                        }
                    }

                    if (chck_java.Checked == true)
                    {
                        File.WriteAllText(cd + "\\profile.txt", cmb_prof.Text);
                        Process.Start(cd + "\\start_mc_jre.bat");
                        if (Properties.Settings.Default.dev_runbck == "1")
                        {
                            return;
                        }
                        else
                        {
                            Application.Exit();
                        }
                    }
                    else
                    {
                        File.WriteAllText(cd + "\\profile.txt", cmb_prof.Text);
                        Process.Start(cd + "\\start_mc_sys.bat");
                        if (Properties.Settings.Default.dev_runbck == "1")
                        {
                            return;
                        }
                        else
                        {
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

        private void btn_create_prof_Click(object sender, EventArgs e)
        {
            Directory.CreateDirectory(cd + "\\data\\profiles\\" + txt_prof.Text);
            DirectoryInfo[] folders = obj.GetDirectories();
            cmb_prof.DataSource = folders;

            DialogResult dr = MessageBox.Show("The following profile was created: " + txt_prof.Text + ". Is that okay?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            switch (dr)
            {
                case System.Windows.Forms.DialogResult.Yes:

                    break;

                case System.Windows.Forms.DialogResult.No:
                    Directory.Delete(cd + "\\data\\profiles\\" + txt_prof.Text, true);
                    DirectoryInfo obj = new DirectoryInfo(Application.StartupPath + "\\data\\profiles\\");

                    cmb_prof.DataSource = folders;
                    break;
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void btn_settings_apply_Click(object sender, EventArgs e)
        {
            if (chck_qtx.Checked == true)
            {
                Properties.Settings.Default.dev_qtx_gui_en = "1";
                MessageBox.Show("Do remember that the OLD GUI contains outdated code, and resources. It may not work as smoothly, and is no longer updated!", "IronAxe: Settings - Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                Properties.Settings.Default.dev_qtx_gui_en = "0";
            }
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
            if (chck_runbck.Checked == true)
            {
                Properties.Settings.Default.dev_runbck = "1";
            }
            else
            {
                Properties.Settings.Default.dev_runbck = "0";
            }
            if (chck_upd.Checked == true)
            {
            }
            Properties.Settings.Default.Save();
            btn_settings_apply.Text = "   Settings Applied";
            sett_applied.Start();
        }

        private void sett_applied_Tick(object sender, EventArgs e)
        {
            btn_settings_apply.Text = "Apply Settings";
            sett_applied.Stop();
        }

        private void tab_prof_Click(object sender, EventArgs e)
        {
        }

        private void btn_extensions_Click(object sender, EventArgs e)
        {
            set_top(sender);
            tab_menu.SelectedTab = tab_extensions;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pcx_upd.Visible = true;
            lbl_upd.Visible = true;

            try
            {
                if (is64Bit == true)
                {
                    if (Properties.Settings.Default.dev_auto_upd == "1")
                    {
                        //Read latest update and convert to string
                        WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Update_Info.ini");
                        WebResponse response = request.GetResponse();
                        Stream dataStream = response.GetResponseStream();
                        StreamReader upd_rd = new StreamReader(dataStream);
                        string upd_get = upd_rd.ReadToEnd();

                        //Get and read latest update info, then grab it
                        //But first delete old files, and continue.
                        WebClient get_info = new WebClient();
                        string cd = Application.StartupPath;

                        lbl_upd.Text = "Downloading Update info...";
                        pcx_upd.BackgroundImage = Properties.Resources.Downloading_Updates_48;
                        this.Refresh();
                        WebClient upd_dwld = new WebClient();

                        upd_dwld.DownloadProgressChanged += new DownloadProgressChangedEventHandler(upd_dwld_DownloadProgressChanged);
                        upd_dwld.DownloadFileCompleted += new AsyncCompletedEventHandler(upd_dwld_DownloadFileCompleted);

                        using (Stream upd = get_info.OpenRead("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Update_Info.ini"))
                        {
                            using (StreamReader reader = new StreamReader(upd))
                            {
                                string rd_upd = null;

                                rd_upd = reader.ReadToEnd();

                                if (rd_upd == Application.ProductVersion)
                                {
                                    if (is64Bit == true)
                                    {
                                        if (Properties.Settings.Default.dev_overide_arch == "1")
                                        {
                                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                                            lbl_upd.Text = "No new updates";
                                            pcx_upd.BackgroundImage = Properties.Resources.Error_48;
                                            this.Refresh();
                                        }
                                        else
                                        {
                                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                                            lbl_upd.Text = "No new updates";
                                            pcx_upd.BackgroundImage = Properties.Resources.Error_48;
                                            this.Refresh();
                                        }
                                        return;
                                    }
                                }
                                else
                                {
                                    DialogResult dr = MessageBox.Show("There's an Update available" + " (" + upd_get + ")" + "\r\nDo you wish to update?", "IronAxe: Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                    switch (dr)
                                    {
                                        case System.Windows.Forms.DialogResult.Yes:
                                            lbl_upd.Text = "Downloading Update...";
                                            this.Refresh();
                                            upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Latest_32.exe"), cd + "\\IronAxe Minecraft Launcher_new.exe");
                                            WebClient get_fin = new WebClient();
                                            lbl_upd.Text = "Preparing update...";
                                            this.Refresh();
                                            get_fin.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                            Process.Start(cd + "\\upd_fin.exe");

                                            Application.Exit();
                                            break;

                                        case System.Windows.Forms.DialogResult.No:
                                            if (is64Bit == true)
                                            {
                                                if (Properties.Settings.Default.dev_overide_arch == "1")
                                                {
                                                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                                                }
                                                else
                                                {
                                                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                                                }
                                                pcx_upd.BackgroundImage = Properties.Resources.Shield_48;
                                                lbl_upd.Text = "Update Check Canceled";
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        //Read latest update and convert to string
                        WebRequest request = WebRequest.Create("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Update_Info.ini");
                        WebResponse response = request.GetResponse();
                        Stream dataStream = response.GetResponseStream();
                        StreamReader upd_rd = new StreamReader(dataStream);
                        string upd_get = upd_rd.ReadToEnd();

                        //Get and read latest update info, then grab it
                        //But first delete old files, and continue.
                        WebClient get_info = new WebClient();
                        string cd = Application.StartupPath;

                        lbl_upd.Text = "Downloading Update info...";
                        pcx_upd.BackgroundImage = Properties.Resources.Downloading_Updates_48;
                        this.Refresh();
                        WebClient upd_dwld = new WebClient();

                        upd_dwld.DownloadProgressChanged += new DownloadProgressChangedEventHandler(upd_dwld_DownloadProgressChanged);
                        upd_dwld.DownloadFileCompleted += new AsyncCompletedEventHandler(upd_dwld_DownloadFileCompleted);

                        using (Stream upd = get_info.OpenRead("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Update_Info.ini"))
                        {
                            using (StreamReader reader = new StreamReader(upd))
                            {
                                string rd_upd = null;

                                rd_upd = reader.ReadToEnd();

                                if (rd_upd == Application.ProductVersion)
                                {
                                    if (is64Bit == true)
                                    {
                                        if (Properties.Settings.Default.dev_overide_arch == "1")
                                        {
                                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                                            lbl_upd.Text = "No new updates";
                                            pcx_upd.BackgroundImage = Properties.Resources.Error_48;
                                            this.Refresh();
                                        }
                                        else
                                        {
                                            lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                                            lbl_upd.Text = "No new updates";
                                            pcx_upd.BackgroundImage = Properties.Resources.Error_48;
                                            this.Refresh();
                                        }
                                        return;
                                    }
                                }
                                else
                                {
                                    DialogResult dr = MessageBox.Show("There's an Update available" + " (" + upd_get + ")" + "\r\nDo you wish to update?", "IronAxe: Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                    switch (dr)
                                    {
                                        case System.Windows.Forms.DialogResult.Yes:
                                            lbl_upd.Text = "Downloading Update...";
                                            this.Refresh();
                                            upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Latest_64.exe"), cd + "\\IronAxe Minecraft Launcher_new.exe");
                                            WebClient get_fin = new WebClient();
                                            lbl_upd.Text = "Preparing update...";
                                            this.Refresh();
                                            get_fin.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                            Process.Start(cd + "\\upd_fin.exe");

                                            Application.Exit();
                                            break;

                                        case System.Windows.Forms.DialogResult.No:
                                            if (is64Bit == true)
                                            {
                                                if (Properties.Settings.Default.dev_overide_arch == "1")
                                                {
                                                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                                                }
                                                else
                                                {
                                                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                                                }
                                                pcx_upd.BackgroundImage = Properties.Resources.Shield_48;
                                                lbl_upd.Text = "Update Check Canceled";
                                            }
                                            break;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
                lbl_upd.Text = "Update error: Unable to connect.";
                pcx_upd.BackgroundImage = Properties.Resources.Error_48;
                if (Properties.Settings.Default.dev_overide_arch == "1")
                {
                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                }
                else
                {
                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                }
            }
        }

        private void dev_gui_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btn_manage_prof_quick_Click(object sender, EventArgs e)
        {
            set_top(btn_profiles);
            tab_menu.SelectedTab = tab_prof;
            DirectoryInfo obj = new DirectoryInfo(Application.StartupPath + "\\data\\profiles\\");
            DirectoryInfo[] folders = obj.GetDirectories();
            cmb_prof.DataSource = folders;

            if (Properties.Settings.Default.dev_def_prof == "")
            {
                cmb_prof.Text = "Default";
            }
            else
            {
                cmb_prof.Text = Properties.Settings.Default.dev_def_prof;
            }
        }

        private void btn_help_jre_Click(object sender, EventArgs e)
        {
            WebClient get_jre = new WebClient();
            get_jre.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            get_jre.DownloadFileCompleted += new AsyncCompletedEventHandler(get_jre_DownloadFileCompleted);

            if (is64Bit == true)
            {
                if (Properties.Settings.Default.dev_overide_arch == "1")
                {
                    if (File.Exists(cd + "\\bin\\JRE_32.exe"))
                    {
                        Process.Start(cd + "\\bin\\JRE_32.exe");
                    }
                    else
                    {
                        get_jre.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable_8_Update_121.paf.exe"), cd + "\\jPortable_8_Update_121.paf.exe");
                    }
                }
                else
                {
                    if (File.Exists(cd + "\\bin\\JRE_64.exe"))
                    {
                        Process.Start(cd + "\\bin\\JRE_64.exe");
                    }
                    else
                    {
                        get_jre.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable64_8_Update_121.paf.exe"), cd + "\\jPortable64_8_Update_121.paf.exe");
                    }
                }
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            btn_help_jre.Text = "Downloading JRE: " + int.Parse(Math.Truncate(percentage).ToString());
        }

        private void get_jre_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (is64Bit == true)
            {
                if (Properties.Settings.Default.dev_overide_arch == "1")
                {
                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 32bit mode | QTXGUI";
                }
                else
                {
                    lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
                }
            }
            else
            {
                lbl_ver.Text = "You're using IronAxe Version: " + Application.ProductVersion + "\r\nBETA BUILD | 64bit mode | QTXGUI";
            }

            try
            {
                if (File.Exists(cd + "\\jPortable_8_Update_121.paf.exe"))
                {
                    btn_help_jre.Text = "Re-Install Java";
                    Process jv = new Process();
                    jv.StartInfo.FileName = cd + "\\jPortable_8_Update_121.paf.exe";
                    jv.StartInfo.Arguments = "/destination=" + cd + "\\bin\\";
                    jv.Start();
                }
                else
                {
                    btn_help_jre.Text = "Re-Install Java";
                    Process jv = new Process();
                    jv.StartInfo.FileName = cd + "\\jPortable64_8_Update_121.paf.exe";
                    jv.StartInfo.Arguments = "/destination=" + cd + "\\bin\\";
                    jv.Start();
                }
            }
            catch
            {
            }
        }

        private void btn_help_down_Click(object sender, EventArgs e)
        {
            if (File.Exists(cd + "\\jPortable_8_Update_121.paf.exe"))
            {
                if (File.Exists(cd + "\\bin\\JRE_32.exe"))
                {
                    File.Delete(cd + "\\bin\\JRE_32.exe");
                    File.Move(cd + "\\jPortable_8_Update_121.paf.exe", cd + "\\bin\\JRE_32.exe");
                }
                else
                {
                    File.Move(cd + "\\jPortable_8_Update_121.paf.exe", cd + "\\bin\\JRE_32.exe");
                }
            }
            if (File.Exists(cd + "\\jPortable64_8_Update_121.paf.exe"))
            {
                if (File.Exists(cd + "\\bin\\JRE_64.exe"))
                {
                    File.Delete(cd + "\\bin\\JRE_64.exe");
                    File.Move(cd + "\\jPortable64_8_Update_121.paf.exe", cd + "\\bin\\JRE_64.exe");
                }
                else
                {
                    File.Move(cd + "\\jPortable64_8_Update_121.paf.exe", cd + "\\bin\\JRE_64.exe");
                }
            }
            //Prepare to Download Java
            WebClient down = new WebClient();
            down.DownloadProgressChanged += new DownloadProgressChangedEventHandler(down_DownloadProgressChanged);
            down.DownloadFileCompleted += new AsyncCompletedEventHandler(down_DownloadFileCompleted);

            //Check to see if files already exist (Delete old backups), and back them up
            if (File.Exists(cd + "\\bin\\JRE_32.exe.old"))
            {
                File.Delete(cd + "\\bin\\JRE_32.exe.old");
            }
            else
            {
                if (File.Exists(cd + "\\bin\\JRE_64.exe.old"))
                {
                    File.Delete(cd + "\\bin\\JRE_64.exe.old");
                }
            }
            if (File.Exists(cd + "\\bin\\minecraft.jar.old"))
            {
                File.Delete(cd + "\\bin\\minecraft.jar.old");
            }

            if (File.Exists(cd + "\\bin\\JRE_32.exe"))
            {
                File.Move(cd + "\\bin\\JRE_32.exe", cd + "\\bin\\JRE_32.exe.old");
            }
            else
            {
                if (File.Exists(cd + "\\bin\\JRE_64.exe"))
                {
                    File.Move(cd + "\\bin\\JRE_64.exe", cd + "\\bin\\JRE_64.exe.old");
                }
            }
            if (File.Exists(cd + "\\bin\\minecraft.jar"))
            {
                File.Move(cd + "\\bin\\minecraft.jar", cd + "\\bin\\minecraft.jar.old");
            }
            else
            {
            }

            //Starts the download
            try
            {
                if (is64Bit == true)
                {
                    if (Properties.Settings.Default.dev_overide_arch == "1")
                    {
                        down.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable_8_Update_121.paf.exe"), cd + "\\jPortable_8_Update_121.paf.exe");
                    }
                    else
                    {
                        down.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable64_8_Update_121.paf.exe"), cd + "\\jPortable64_8_Update_121.paf.exe");
                    }
                }
            }
            catch
            {
                if (File.Exists(cd + "\\bin\\JRE_32.exe"))
                {
                    File.Delete(cd + "\\bin\\JRE_32.exe");
                }
                else
                {
                    if (File.Exists(cd + "\\bin\\JRE_64.exe"))
                    {
                        File.Delete(cd + "\\bin\\JRE_64.exe");
                    }
                }

                if (File.Exists(cd + "\\bin\\JRE_32.exe.old"))
                {
                    File.Move(cd + "\\bin\\JRE_32.exe.old", cd + "\\bin\\JRE_32.exe");
                }
                else
                {
                    if (File.Exists(cd + "\\bin\\JRE_64.exe.old"))
                    {
                        File.Move(cd + "\\bin\\JRE_64.exe.old", cd + "\\bin\\JRE_64.exe");
                    }
                }

                MessageBox.Show("We were unable to download the latest Java Runtime file form SourceForge's servers. So, the old one (If it was there) was restored.", "IronAxe: Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //Prepare to download Minecraft
            WebClient get_mc = new WebClient();
            get_mc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(getmc_DownloadProgressChanged);
            get_mc.DownloadFileCompleted += new AsyncCompletedEventHandler(getmc_DownloadFileCompleted);

            //Starts the download
            try
            {
                get_mc.DownloadFileAsync(new Uri("http://s3.amazonaws.com/Minecraft.Download/launcher/Minecraft.jar"), cd + "\\bin\\minecraft.jar");
            }
            catch
            {
                if (File.Exists(cd + "\\bin\\minecraft.jar"))
                {
                    File.Delete(cd + "\\bin\\minecraft.jar");
                }

                if (File.Exists(cd + "\\bin\\minecraft.jar.old"))
                {
                    File.Move(cd + "\\bin\\minecraft.jar.old", cd + "\\bin\\minecraft.jar");
                }
                else
                {
                }

                MessageBox.Show("We were unable to download the latest Minecraft.jar file form Mojang's servers. So, the old one (If it was there) was restored.", "IronAxe: Download error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void getmc_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            btn_help_down.Text = "Downloading..." + int.Parse(Math.Truncate(percentage).ToString());
        }

        private void getmc_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btn_help_down.Text = "Download Completed";
        }

        private void down_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            btn_help_down.Text = "Downloading..." + int.Parse(Math.Truncate(percentage).ToString());
        }

        private void down_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            btn_help_down.Text = "Download Completed";
            Properties.Settings.Default.dev_download_res = "1";
            Properties.Settings.Default.Save();
            try
            {
                if (File.Exists(cd + "\\jPortable_8_Update_121.paf.exe"))
                {
                    Process jv = new Process();
                    jv.StartInfo.FileName = cd + "\\jPortable_8_Update_121.paf.exe";
                    jv.StartInfo.Arguments = "/destination=" + cd + "\\bin\\";
                    jv.Start();
                }
                else
                {
                    Process jv = new Process();
                    jv.StartInfo.FileName = cd + "\\jPortable64_8_Update_121.paf.exe";
                    jv.StartInfo.Arguments = "/destination=" + cd + "\\bin\\";
                    jv.Start();
                }
            }
            catch
            {
            }
        }

        private void btn_help_get_support_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/rvwwgmM");
            btn_help_get_support.Text = "Boom goes the dinomite!";
        }

        private void btn_help_get_help_oldschool_Click(object sender, EventArgs e)
        {
            Process.Start("mailto: zoltx23inc.web.services@gmail.com?subject=[IronAxe-Support]&body=Diagnostics: \r\nApp Version: " + Application.ProductVersion + ". Now, please type what you have been experiencing here: ");

            btn_help_get_help_oldschool.Text = "A blast to the past?";
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

        private void btn_del_prof_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you wish to delete the profile: " + cmb_prof.SelectedItem + "? You will NOT be able to recover the deleted files!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            switch (dr)
            {
                case System.Windows.Forms.DialogResult.Yes:
                    Directory.Delete(cd + "\\data\\profiles\\" + cmb_prof.SelectedItem, true);
                    this.Refresh();
                    DirectoryInfo obj = new DirectoryInfo(Application.StartupPath + "\\data\\profiles\\");
                    DirectoryInfo[] folders = obj.GetDirectories();
                    cmb_prof.DataSource = folders;
                    break;

                case System.Windows.Forms.DialogResult.No:

                    break;
            }
        }
    }
}
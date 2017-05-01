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
        private WebClient jv;
        private Stopwatch sw = new Stopwatch();

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
                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                    this.Text = "IronAxe Minecraft Launcher: Main ";
                    if (Properties.Settings.Default.dev_download_res == "")
                    {
                        Form fm = new dev_get_java();
                        fm.Show();
                    }
                    else
                    {
                        lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                        this.Text = "IronAxe Minecraft Launcher: Main ";
                    }
                }
                else
                {
                    this.Text = "IronAxe Minecraft Launcher: Main ";
                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 64bit mode";
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

                try
                {
                    if (Properties.Settings.Default.dev_auto_upd == "1")
                    {
                        if (is64Bit == true)
                        {
                            //Read latest update and convert to string
                            WebRequest request = WebRequest.Create("https://github.com/zoltx23/IronAxe/blob/master/Common/Updates//Update_Info.ini?raw=true");
                            WebResponse response = request.GetResponse();
                            Stream dataStream = response.GetResponseStream();
                            StreamReader upd_rd = new StreamReader(dataStream);
                            string upd_get = upd_rd.ReadToEnd();

                            //Get and read latest update info, then grab it
                            //But first delete old files, and continue.
                            WebClient get_info = new WebClient();
                            string cd = Application.StartupPath;

                            lbl_ver.Text = "Downloading Update info...";
                            this.Refresh();

                            WebClient upd_dwld = new WebClient();
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
                                                lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                                                this.Text = "IronAxe Minecraft Launcher: Main ";
                                            }
                                            else
                                            {
                                                this.Text = "IronAxe Minecraft Launcher: Main ";
                                                lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 64bit mode";
                                            }
                                            return;
                                        }
                                        else
                                        {
                                            DialogResult dr = MessageBox.Show("There's an Update available" + " (" + upd_get + ")" + "\r\nDo you wish to update?", "IronAxe: Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                            switch (dr)
                                            {
                                                case System.Windows.Forms.DialogResult.Yes:
                                                    lbl_ver.Text = "Downloading Update...";
                                                    this.Refresh();
                                                    upd_dwld.DownloadFile(new Uri("https://github.com/zoltx23/IronAxe/blob/master/Common/Updates/Latest/Latest_64.exe?raw=true"), cd + "\\IronAxe Minecraft Launcher_new.exe");
                                                    WebClient get_fin = new WebClient();
                                                    lbl_ver.Text = "Preparing update...";
                                                    this.Refresh();
                                                    get_fin.DownloadFile(new Uri("https://github.com/zoltx23/IronAxe/blob/master/Common/Updates/upd_fin.exe?raw=true"), cd + "\\upd_fin.exe");
                                                    Process.Start(cd + "\\upd_fin.exe");

                                                    Application.Exit();
                                                    break;

                                                case System.Windows.Forms.DialogResult.No:

                                                    break;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        else
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
                                WebClient get_info = new WebClient();
                                string cd = Application.StartupPath;

                                lbl_ver.Text = "Downloading Update info...";
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
                                                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                                                    this.Text = "IronAxe Minecraft Launcher: Main ";
                                                }
                                                else
                                                {
                                                    this.Text = "IronAxe Minecraft Launcher: Main ";
                                                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 64bit mode";
                                                }
                                                return;
                                            }
                                            else
                                            {
                                                DialogResult dr = MessageBox.Show("There's an Update available" + " (" + upd_get + ")" + "\r\nDo you wish to update?", "IronAxe: Update", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                                                switch (dr)
                                                {
                                                    case System.Windows.Forms.DialogResult.Yes:
                                                        lbl_ver.Text = "Downloading Update...";
                                                        this.Refresh();
                                                        upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Latest_32.exe"), cd + "\\IronAxe Minecraft Launcher_new.exe");
                                                        WebClient get_fin = new WebClient();
                                                        lbl_ver.Text = "Preparing update...";
                                                        this.Refresh();
                                                        get_fin.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                                        Process.Start(cd + "\\upd_fin.exe");

                                                        Application.Exit();
                                                        break;

                                                    case System.Windows.Forms.DialogResult.No:

                                                        break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                            else
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

                                    lbl_ver.Text = "Downloading Update info...";
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
                                                        lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                                                        this.Text = "IronAxe Minecraft Launcher: Main ";
                                                    }
                                                    else
                                                    {
                                                        this.Text = "IronAxe Minecraft Launcher: Main ";
                                                        lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 64bit mode";
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
                                                        lbl_ver.Text = "Downloading Update...";
                                                        this.Refresh();
                                                        upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Latest_32.exe"), cd + "\\IronAxe Minecraft Launcher_new.exe");
                                                        WebClient get_fin = new WebClient();
                                                        lbl_ver.Text = "Preparing update...";
                                                        this.Refresh();
                                                        get_fin.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/upd_fin.exe"), cd + "\\upd_fin.exe");
                                                        Process.Start(cd + "\\upd_fin.exe");

                                                        Application.Exit();
                                                        break;

                                                    case System.Windows.Forms.DialogResult.No:

                                                        break;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                    lbl_ver.Text = "Update error: Unable to connect.";
                    this.Text = "IronAxe Minecraft Launcher: Main --UPDATE_ERROR ";
                    MessageBox.Show("An error has occurred when attempting to update. \r\nPlease make sure you have an internet connection.", "dev_", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                    this.Text = "IronAxe Minecraft Launcher: Main ";
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
            lbl_ver.Text = "Connecting to GitHub...";

            if (File.Exists(cd + "\\upd_fin.exe"))
            {
                File.Delete(cd + "\\upd_fin.exe");
            }
            if (File.Exists(cd + "\\Update_Info.ini"))
            {
                File.Delete(cd + "\\Update_Info.ini");
            }
            try
            {
                if (is64Bit == true)
                {
                    //Read latest update and convert to string
                    WebRequest get_upd = WebRequest.Create("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Update_Info.ini");
                    WebResponse response = get_upd.GetResponse();
                    Stream dataStream = response.GetResponseStream();
                    StreamReader upd_rd = new StreamReader(dataStream);
                    string upd_get = upd_rd.ReadToEnd();

                    //Get and read latest update info, then grab it
                    WebClient get_info = new WebClient();

                    string cd = Application.StartupPath;

                    lbl_ver.Text = "Downloading Update info...";
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
                                        lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                                        this.Text = "IronAxe Minecraft Launcher: Main ";
                                    }
                                    else
                                    {
                                        this.Text = "IronAxe Minecraft Launcher: Main ";
                                        lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 64bit mode";
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
                                        lbl_ver.Text = "Downloading Update...";
                                        this.Refresh();
                                        upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Latest_32.exe"), cd + "\\IronAxe Minecraft Launcher_new.exe");
                                        WebClient get_fin = new WebClient();
                                        lbl_ver.Text = "Preparing update...";
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
                                                lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                                                this.Text = "IronAxe Minecraft Launcher: Main ";
                                            }
                                            else
                                            {
                                                this.Text = "IronAxe Minecraft Launcher: Main ";
                                                lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 64bit mode";
                                            }
                                        }
                                        break;
                                }
                            }
                        }
                    }
                }
                else
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

                        lbl_ver.Text = "Downloading Update info...";
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
                                            lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                                            this.Text = "IronAxe Minecraft Launcher: Main ";
                                        }
                                        else
                                        {
                                            this.Text = "IronAxe Minecraft Launcher: Main ";
                                            lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 64bit mode";
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
                                            lbl_ver.Text = "Downloading Update...";
                                            this.Refresh();
                                            upd_dwld.DownloadFile(new Uri("https://raw.githubusercontent.com/zoltx23/IronAxe/master/Common/Updates/Latest/Latest_32.exe"), cd + "\\IronAxe Minecraft Launcher_new.exe");
                                            WebClient get_fin = new WebClient();
                                            lbl_ver.Text = "Preparing update...";
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
                                                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                                                    this.Text = "IronAxe Minecraft Launcher: Main ";
                                                }
                                                else
                                                {
                                                    this.Text = "IronAxe Minecraft Launcher: Main ";
                                                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 64bit mode";
                                                }
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
                lbl_ver.Text = "Update error: Unable to connect.";
                this.Text = "IronAxe Minecraft Launcher: Main --UPDATE_ERROR ";
                MessageBox.Show("An error has occurred when attempting to update. \r\nPlease make sure you have an internet connection.", "dev_", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                this.Text = "IronAxe Minecraft Launcher: Main ";
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

        private void get_fin_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            lbl_ver.Text = "Preparing update: " + int.Parse(Math.Truncate(percentage).ToString());
        }

        private void get_fin_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            lbl_ver.Text = "Preparatation Completed";
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

        private void btn_repair_Click(object sender, EventArgs e)
        {
            WebClient get_jre = new WebClient();
            get_jre.DownloadProgressChanged += new DownloadProgressChangedEventHandler(client_DownloadProgressChanged);
            get_jre.DownloadFileCompleted += new AsyncCompletedEventHandler(get_jre_DownloadFileCompleted);

            if (is64Bit == true)
            {
                if (File.Exists(cd + "\\bin\\JRE_64.exe"))
                {
                    Process.Start(cd + "\\bin\\JRE_64.exe");
                }
                else
                {
                    if (Properties.Settings.Default.dev_overide_arch == "1")
                    {
                        get_jre.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable_8_Update_121.paf.exe"), cd + "\\jPortable_8_Update_121.paf.exe");
                    }
                    else
                    {
                        get_jre.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable64_8_Update_121.paf.exe"), cd + "\\jPortable64_8_Update_121.paf.exe");
                    }
                }

                lbl_ver.Text = "Download In Progress (JRE)";
            }
            else
            {
                if (File.Exists(cd + "\\bin\\JRE_32.exe"))
                {
                    Process.Start(cd + "\\bin\\JRE_32.exe");
                }
                else
                {
                    if (Properties.Settings.Default.dev_overide_arch == "1")
                    {
                        get_jre.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable_8_Update_121.paf.exe"), cd + "\\jPortable_8_Update_121.paf.exe");
                    }
                    else
                    {
                        get_jre.DownloadFileAsync(new Uri("http://downloads.sourceforge.net/portableapps/jPortable_8_Update_121.paf.exe"), cd + "\\jPortable_8_Update_121.paf.exe");
                    }
                }
            }
        }

        private void client_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            double bytesIn = double.Parse(e.BytesReceived.ToString());
            double totalBytes = double.Parse(e.TotalBytesToReceive.ToString());
            double percentage = bytesIn / totalBytes * 100;

            lbl_ver.Text = "Downloading JRE: " + int.Parse(Math.Truncate(percentage).ToString() + "%");
        }

        private void get_jre_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
        {
            if (is64Bit == true)
            {
                if (Properties.Settings.Default.dev_overide_arch == "1")
                {
                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                    this.Text = "IronAxe Minecraft Launcher: Main ";
                    if (Properties.Settings.Default.dev_download_res == "")
                    {
                        Form fm = new dev_get_java();
                        fm.Show();
                    }
                    else
                    {
                        lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 32bit mode";
                        this.Text = "IronAxe Minecraft Launcher: Main ";
                    }
                }
                else
                {
                    this.Text = "IronAxe Minecraft Launcher: Main ";
                    lbl_ver.Text = "Version: " + Application.ProductVersion + " | BETA BUILD | 64bit mode";
                }
            }

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
    }
}
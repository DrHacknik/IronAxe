using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Portable_Minecraft_Launcher
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            if (Properties.Settings.Default.dev_agree == "1")
            {
                if (Properties.Settings.Default.dev_def_prof_st == "1")
                {
                    Application.Run(new dev_start());
                }
                else
                {
                    if (Properties.Settings.Default.dev_qtx_gui_en == "1")
                    {
                        Application.Run(new dev_gui());
                    }
                    else
                    {
                        Application.Run(new Main());
                    }
                }
            }
            else
            {
                Application.Run(new dev_agreement());
            }
        }
    }
}
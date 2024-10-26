using Auth;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace spoofer
{
     class SpoofTounry
    {
        internal bool StartProcess()
        {

            tty_system ttysystem = new tty_system();
            try
            {
                SpoofScreen screen = new SpoofScreen();
                screen.Show();
                ttysystem.FileExist(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\SIDCHG.exe");
                if (!ttysystem.DownloadFile("452542", Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\SIDCHG.exe"))
                {
                    ttysystem.ShowInfo("Download Failed!");
                }
                string sidKey = ttysystem.getWebInfo("SIDKey");
                Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\SIDCHG.exe", $"/KEY={sidKey} /R /FF");
                screen.Hide();
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}

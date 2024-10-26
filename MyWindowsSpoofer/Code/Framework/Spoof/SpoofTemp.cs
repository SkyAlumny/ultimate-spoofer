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
     class SpoofTemp
    {
        internal bool StartProcess(bool isMacChecked, bool isVolumeChecked, bool isWindowsChecked)
        {
            tty_system ttysystem = new tty_system();
            try
            {
                SpoofScreen screen = new SpoofScreen();
                screen.Show();
                ttysystem.FileExist(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\tty-spoofer.sys");
                ttysystem.FileExist(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\kdmapper_Release.exe");
                if (!ttysystem.DownloadFile("011712", Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\tty-spoofer.sys"))
                {
                    ttysystem.ShowInfo("Download Failed!");
                }
                if (!ttysystem.DownloadFile("030688", Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\kdmapper_Release.exe"))
                {
                    ttysystem.ShowInfo("Download Failed!");
                }
               
                ttysystem.executeCommand("kdmapper_Release.exe tty-spoofer.sys", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\tty-spoofer.sys");
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\kdmapper_Release.exe");
                if (isMacChecked)
                {
                    SpoofMac spoofMac = new SpoofMac();
                    if (!spoofMac.startProcess())
                    {
                        ttysystem.ShowInfo("Spoofing MAC Failed");
                        return false;
                    }
                }
                if (isVolumeChecked)
                {
                    SpoofVolume spoofVolume = new SpoofVolume();
                    if (!spoofVolume.startProcess())
                    {
                        ttysystem.ShowInfo("Spoofing Volume Failed");
                        return false;
                    }
                }
                if (isWindowsChecked)
                {
                    if (!ttysystem.ActiveWindows())
                    {
                        ttysystem.ShowInfo("Activating Windows Failed");
                        return false;
                    }
                }
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

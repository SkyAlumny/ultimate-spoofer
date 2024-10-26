using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spoofer
{
     class SpoofVolume
    {
        tty_system ttysystem = new tty_system();
        internal bool startProcess()
        {
            try
            {
                ttysystem.FileExist(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\Volumeid.exe");
                if (!ttysystem.DownloadFile("905677", Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\Volumeid.exe"))
                {
                    ttysystem.ShowInfo("Download Failed!");
                }

                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in allDrives)
                {
                    ttysystem.executeCommand($"Volumeid.exe {drive.Name} {ttysystem.Random(4)}-{ttysystem.Random(4)}", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                }
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\Volumeid.exe");
              
                return true;
            }
            catch
            {

                return false;
            }
        }
    }
}

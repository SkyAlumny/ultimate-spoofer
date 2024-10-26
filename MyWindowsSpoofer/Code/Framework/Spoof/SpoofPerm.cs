
using spoofer.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace spoofer
{
     class perm
    {
        tty_system ttysystem = new tty_system();
        internal static string[] spoofCommands = {
       $"AMIDEWINx64.exe /SU auto",
    $"AMIDEWINx64.exe /SS %random%-%random%",
    $"AMIDEWINx64.exe /BS %random%-%random%-%random%-%random%",
    $"AMIDEWINx64.exe /CS %random%-%random%-%random%",
    $"AMIDEWINx64.exe /CV %random%-%random%-%random%",
    $"AMIDEWINx64.exe /SK %random%-%random%",
    $"AMIDEWINx64.exe /SF %random%-%random% ",
    $"AMIDEWINx64.exe /BT %random%-%random% ",
    $"AMIDEWINx64.exe /BLC %random%-%random% ",
    $"AMIDEWINx64.exe /CA %random%-%random% ",
    $"AMIDEWINx64.exe /CSK %random%-%random% ",
    $"AMIDEWINx64.exe /CM %random%-%random% ",
    $"AMIDEWINx64.exe /IVN \"TTY Baseboard maker.\" ",
    $"AMIDEWINx64.exe /ID \"01/02/24\" ",
    $"AMIDEWINx64.exe /IV \"A.F2\" ",
    $"AMIDEWINx64.exe /SM \"The TTY Company\" ",
    $"AMIDEWINx64.exe /BM \"The TTY Company\" ",
    $"AMIDEWINx64.exe /SP \"ASUS-TTY Special Version\" ",
    $"AMIDEWINx64.exe /BP \"ASUS-TTY Special Version\" ",
    $"AMIDEWINx64.exe /BV %random%-%random% ",
    $"AMIDEWINx64.exe /SV %random%-%random% ",
    $"AMIDEWINx64.exe /PPN %random%-%random% ",
    $"AMIDEWINx64.exe /PAT %random%-%random% ",
    $"AMIDEWINx64.exe /PSN %random%-%random% ",
    $"AMIDEWINx64.exe /OS 1 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 2 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 3 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 4 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 5 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 6 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 7 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 8 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 9 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 10 %random%-%random% ",
    $"AMIDEWINx64.exe /OS 11 %random%-%random% ",

            };

        internal async void StartProcess(bool isMacChecked, bool isVolumeChecked, bool isWindowsChecked)
        {

            try
            {
                SpoofScreen spoofScreen = new SpoofScreen();
                spoofScreen.ChangeProgressValue(0);
                spoofScreen.Show();
                await Task.Delay(TimeSpan.FromSeconds(2));
                ttysystem.FileExist(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\AMIFLDRV64.SYS");
                spoofScreen.ChangeProgressValue(10);
                await Task.Delay(TimeSpan.FromSeconds(2));
                ttysystem.FileExist(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\AMIDEWINx64.exe");
                spoofScreen.ChangeProgressValue(25);
                await Task.Delay(TimeSpan.FromSeconds(2));
                if (!ttysystem.DownloadFile("446862", Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\AMIFLDRV64.SYS"))
                {
                 
                    ttysystem.ShowInfo("Download Failed!");
                    Console.WriteLine("Error");
                }
                Console.WriteLine("downloaded");
                spoofScreen.ChangeProgressValue(47);
                await Task.Delay(TimeSpan.FromSeconds(2));
                if (!ttysystem.DownloadFile("723441", Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\AMIDEWINx64.exe"))
                {
                   
                    ttysystem.ShowInfo("Download Failed!");
                }
                spoofScreen.ChangeProgressValue(50);
                await Task.Delay(TimeSpan.FromSeconds(2));
                foreach (string cmd in spoofCommands)
                {
                    Console.WriteLine("" + cmd + " | ");
                    ttysystem.executeCommand(cmd, Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\");
                  
                }
                spoofScreen.ChangeProgressValue(60);
                await Task.Delay(TimeSpan.FromSeconds(2));
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\AMIFLDRV64.SYS");
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\AMIDEWINx64.exe");
                spoofScreen.ChangeProgressValue(65);
                await Task.Delay(TimeSpan.FromSeconds(2));
                if (isMacChecked)
                {
                    SpoofMac spoofMac = new SpoofMac();
                    if(!spoofMac.startProcess())
                    {
                        ttysystem.ShowInfo("Spoofing MAC Failed");
                       
                    }
                }
                spoofScreen.ChangeProgressValue(70);
                await Task.Delay(TimeSpan.FromSeconds(2));
                if (isVolumeChecked)
                {
                    SpoofVolume spoofVolume = new SpoofVolume();   
                    if(!spoofVolume.startProcess())
                    {
                        ttysystem.ShowInfo("Spoofing Volume Failed");
                       
                    }
                }
                spoofScreen.ChangeProgressValue(80);
                await Task.Delay(TimeSpan.FromSeconds(2));
                if (isWindowsChecked)
                {
                    if (!ttysystem.ActiveWindows())
                    {
                        ttysystem.ShowInfo("Activating Windows Failed");
                        
                    }
                }
                spoofScreen.ChangeProgressValue(90);
                await Task.Delay(TimeSpan.FromSeconds(2));
                ttysystem.CleanUp();
                spoofScreen.ChangeProgressValue(100);
                await Task.Delay(TimeSpan.FromSeconds(2));
                spoofScreen.Hide();
              
            }
            catch
            {

               
            }
        }
    }
}

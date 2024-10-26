using spoofer.Forms.Misc;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Text;
using DiscordRPC;
using System.Runtime.InteropServices;
using Auth;

namespace spoofer
{
    class tty_system
    {
        
        internal readonly DiscordRpcClient rpc = new DiscordRpcClient("1167775065740415037");

        internal void SetRPC(string RPC)
        {
            rpc.SetPresence(new RichPresence
            {
                Details = $"{RPC}",
                State = "MY SPOOFER",
                Assets = new Assets { LargeImageKey = "static", LargeImageText = $"Perfect Solution" }
            });
        }

        internal bool executeCommand(string command, string path)
        {
            Process p = new Process();
            ProcessStartInfo pST = new ProcessStartInfo
            {
                FileName = "cmd.exe",
                Arguments = $"/c @echo off & {command}",
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                UseShellExecute = false,
                CreateNoWindow = true,
                WorkingDirectory = path
            };
            p.StartInfo = pST;
            p.Start();
            p.WaitForExit();
            return true;
        }




        static Random random = new Random();
        internal string Random(int lenght)
        {
            const string numbers = "0123456789";
            var newstring = new StringBuilder(lenght);

            for (int i = 0; i < lenght; ++i)
            {
                newstring.Append(numbers[random.Next(0, numbers.Length)]);
            }

            return newstring.ToString();
        }

        internal bool FileExist(string Path)
        {
            if(File.Exists(Path))
            {
                File.Delete(Path);
                return true;
            }
            else
            {
                return false;
            }
           
            
        }


        internal bool ActiveWindows()
        {

            try
            {
                FileExist(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\wact.bat");
                if (!DownloadFile("928687", Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\wact.bat"))
                {
                    ShowInfo("Download Failed!");
                }

                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in allDrives)
                {
                    executeCommand($"wact.bat", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                }
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\wact.bat");

                return true;
            }
            catch
            {

                return false;
            }
        }

        internal void CleanPC()
        {
            try
            {
                FileExist(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\cleaner.bat");
                if (!DownloadFile("718824", Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\cleaner.bat"))
                {
                    ShowInfo("Download Failed!");
                }

                DriveInfo[] allDrives = DriveInfo.GetDrives();
                foreach (DriveInfo drive in allDrives)
                {
                    executeCommand($"cleaner.bat", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                }
                File.Delete(Environment.GetFolderPath(Environment.SpecialFolder.Fonts) + "\\cleaner.bat");

                
            }
            catch
            {

               
            }
        }

        internal bool CleanUp()
        {
            try
            {
                executeCommand($"REG ADD HKLM\\SOFTWARE\\Microsoft\\Cryptography /v MachineGuid /t REG_SZ /d %random%%random%-%random%-%random%-%random% /f", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"REG ADD HKLM\\\\SOFTWARE\\\\Microsoft\\\\Windows\\\" \\\"NT\\\\CurrentVersion /v ProductId /t REG_SZ /d %random%%random%-%random%-%random%-%random% /f", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"REG ADD HKLM\\\\SOFTWARE\\\\Microsoft\\\\Windows\\\" \\\"NT\\\\CurrentVersion /v InstallDate /t REG_SZ /d %random%%random% /f", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\" \"NT\\CurrentVersion /v InstallTime /t REG_SZ /d %random% /f", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\" \"NT\\CurrentVersion /v InstallTime /t REG_SZ /d %random% /f", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"REG ADD HKLM\\SOFTWARE\\Microsoft\\Windows\" \"NT\\CurrentVersion /v BuildLabEx /t REG_SZ /d %random% /f", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"REG ADD HKLM\\\\SYSTEM\\\\CurrentControlSet\\\\Control\\\\IDConfigDB\\\\Hardware\\\" \\\"Profiles\\\\0001 /v HwProfileGuid /t REG_SZ /d {{%random%%random%-%random%-%random%-%random%%random%}} /f", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"wmic computersystem where name=%computername% call rename=%random%", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"netsh winsock reset", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"netsh winsock reset catalog", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"netsh int ip reset", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"netsh advfirewall reset", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"netsh int reset all", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"netsh int ipv4 reset", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"netsh int ipv6 reset", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"ipconfig /release", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"ipconfig /renew", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"ipconfig /flushdns", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"WMIC PATH WIN32_NETWORKADAPTER WHERE PHYSICALADAPTER=TRUE CALL DISABLE >nul 2>&1", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"WMIC PATH WIN32_NETWORKADAPTER WHERE PHYSICALADAPTER=TRUE CALL ENABLE >nul 2>&1", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"net stop winmgmt /y", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"net start winmgmt /y", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"sc stop winmgmt", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                executeCommand($"sc start winmgmt", Environment.GetFolderPath(Environment.SpecialFolder.Fonts));
                return true;
            }
            catch
            {
                ShowInfo("Applying Spoof failed");
                return false;
            }

        }
        internal bool DownloadFile(string FileID, string FilePath)
        {
            byte[] result = AuthenticationObject.AuthInstance.download(FileID);
            if (!AuthenticationObject.AuthInstance.response.success)
            {
                return false;
            }
            else
            {
                File.WriteAllBytes(FilePath, result);
                return true;
            }
        }
      
        [return: MarshalAs(UnmanagedType.Bool)]
        [DllImport("user32.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern void BlockInput([In, MarshalAs(UnmanagedType.Bool)] bool fBlockIt);

        internal bool ShowInfo(string InfoText)
        {
            InfoBox infoBox = new InfoBox();
            infoBox.ChangeInfoText(InfoText);
            infoBox.Visible = true;
            return true;
        }

        internal string getWebInfo(string body)
        {
            

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create("http://afgghawdehgadfragf.atwebpages.com/info.json");
            request.Method = "GET";

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.StatusCode == HttpStatusCode.OK)
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        if (responseStream != null)
                        {
                            StreamReader reader = new StreamReader(responseStream);
                            string jsonResponse = reader.ReadToEnd();

                            int contentIndex = jsonResponse.IndexOf($"\"{body}\"");

                            if (contentIndex != -1)
                            {
                                int startIndex = jsonResponse.IndexOf(':', contentIndex) + 2;

                                int endIndex = jsonResponse.IndexOf('"', startIndex);

                                // Extract the content value
                                string content = jsonResponse.Substring(startIndex, endIndex - startIndex);
                                return content;
                            }
                            else
                            {
                                return "Failed to recive Quote from Server";
                            }
                        }
                    }
                }
                else
                {
                    return "Failed to recive Quote from Server";

                }
                return "Failed to recive Quote from Server";
            }
        }


        internal bool Restart()
        {
            var appPath = Assembly.GetEntryAssembly().Location;
            if (appPath == null)
            {
                // Path not found to the application, Maybe moved??
                return false;
            }

            var newProcess = new ProcessStartInfo
            {
                UseShellExecute = true,
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = appPath,
                Verb = "runas" // Run as Admin
            };

            try
            {
                Process.Start(newProcess);
                Environment.Exit(0);
                return true;
            }
            catch
            {
                Environment.Exit(0);
                return false;
            }
            return true;
        }



    }
}

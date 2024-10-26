using System;
using System.Collections.Generic;
using System.IO;
using System.Management;

namespace spoofer.Code.Framework.SavingSystem
{
     class SaveSystem
    {

        internal void SaveStrings(List<string> stringsToSave)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("\\serials.txt"))
                {
                    foreach (string str in stringsToSave)
                    {
                        writer.WriteLine(str);
                    }
                }
                Console.WriteLine("Strings saved to file successfully!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving strings: {ex.Message}");
            }
        }

        internal string LoadString(int lineNumber)
        {
            string specificLine = null;
            try
            {
                using (StreamReader reader = new StreamReader(Path.Combine(Environment.GetEnvironmentVariable("SystemRoot"), "System32") + "\\serials.txt"))
                {
                    for (int i = 1; i <= lineNumber; i++)
                    {
                        specificLine = reader.ReadLine();
                        if (specificLine == null)
                        {
                            Console.WriteLine("Line number exceeds total lines in the file.");
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading line: {ex.Message}");
            }
            return specificLine;
        }

        internal List<string> GetSerials()
        {
            List<string> infoList = new List<string>();

    
            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    infoList.Add("Baseboard: " + obj["SerialNumber"]);
                }
            }

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_Processor"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    infoList.Add("CPU: " + obj["SerialNumber"]);
                }
            }

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT UUID FROM Win32_ComputerSystemProduct"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    infoList.Add("UUID: " + obj["UUID"]);
                }
            }

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_SystemEnclosure"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    infoList.Add("Chassis: " + obj["SerialNumber"]);
                }
            }

            using (ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BIOS"))
            {
                foreach (ManagementObject obj in searcher.Get())
                {
                    infoList.Add("System Serial Number: " + obj["SerialNumber"]);
                }
            }

            return infoList;
        }

    }
}

using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;

namespace spoofer
{
    class SpoofMac
    {
        internal bool startProcess()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            ManagementObjectCollection networkAdapters = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_NetworkAdapter WHERE PhysicalAdapter=True").Get();
            foreach (ManagementObject adapter in networkAdapters)
            {
                string netConnectionID = adapter["NetConnectionID"].ToString();
                string caption = adapter["Caption"].ToString();
                string name = adapter["Name"].ToString();
                string deviceId = adapter["DeviceID"].ToString().PadLeft(4, '0');
                if (caption.Contains("Bluetooth") || name.Contains("Bluetooth") || netConnectionID.Contains("Bluetooth"))
                {
                    continue;
                }
                byte[] macAddress = new byte[6];
                random.NextBytes(macAddress);
                string spoofedMacAddress = string.Concat(macAddress.Select(x => string.Format("{0}", x.ToString("X2"))).ToArray()).Insert(2, "-").Insert(5, "-").Insert(8, "-").Insert(11, "-").Insert(14, "-");
                using (RegistryKey registryKey = Registry.LocalMachine.OpenSubKey($"SYSTEM\\CurrentControlSet\\Control\\Class\\{{4D36E972-E325-11CE-BFC1-08002BE10318}}\\{deviceId}", true))
                {
                    registryKey.SetValue("NetworkAddress", spoofedMacAddress);
                }
                Process disableProcess = new Process();
                disableProcess.StartInfo.FileName = "netsh.exe";
                disableProcess.StartInfo.Arguments = $"interface set interface \"{netConnectionID}\" admin=disable";
                disableProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                disableProcess.Start();
                disableProcess.WaitForExit();
                Process enableProcess = new Process();
                enableProcess.StartInfo.FileName = "netsh.exe";
                enableProcess.StartInfo.Arguments = $"interface set interface \"{netConnectionID}\" admin=enable";
                enableProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                enableProcess.Start();
                enableProcess.WaitForExit();
                return true;
            }
            return true;
        }
    }
}


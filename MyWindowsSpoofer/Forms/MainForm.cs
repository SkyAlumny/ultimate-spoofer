using System;
using System.Collections.Generic;
using System.Windows.Forms;
using spoofer.Code.Framework.SavingSystem;
using System.Diagnostics;
using Auth;
using spoofer.Forms.Misc;
using System.Management;

namespace spoofer
{
    public partial class MainForm : Form
    {

        private static string BaseboardserialTemp = "Not Set!";
        private static string UUIDSerialTemp = null;
        private static string ChassisSerialTemp = null;
        private static string CPUSerialTemp = null;
        tty_system ttysystem = new tty_system();
        tty_protection ttyprotection = new tty_protection();    
        public MainForm()
        {
            InitializeComponent();
            NewsTextBox.Text = ttysystem.getWebInfo("news");
            CustomSerialPanel.Visible = false;
            PanelStart.Visible = true;
            PanelSpoof.Visible = false;
            PanelCleaner.Visible = false;
            PanelSettings.Visible = false;
            HomeSwitchButton.Enabled = false;
            if (ttysystem.getWebInfo("permenabled") == "true")
            {
                PermStatusTrue.Visible = true;
                PermStatusFalse.Visible = false;
            }
            else
            {
                PermStatusTrue.Visible = false;
                PermStatusFalse.Visible = true;
            }
            if (ttysystem.getWebInfo("tourneyenabled") == "true")
            {
                FortniteTourneyStatusTrue.Visible = true;
                FortniteTourneyStatusFalse.Visible = false;
            }
            else
            {
                FortniteTourneyStatusTrue.Visible = false;
                FortniteTourneyStatusFalse.Visible = true;
            }
            if (ttysystem.getWebInfo("tempenabled") == "true")
            {
                TempStatusTrue.Visible = true;
                TempStatusFalse.Visible = false;
            }
            else
            {
                TempStatusTrue.Visible = false;
                TempStatusFalse.Visible = true;
            }
        }

       

        public static void setCustomSerials(string Baseboard, string UUID, string Chassis, string CPU)
        {
            BaseboardserialTemp = Baseboard;
            UUIDSerialTemp = UUID;
            ChassisSerialTemp = Chassis;
            CPUSerialTemp = CPU;
        }

        public static DateTime UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            try
            {
                dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            }
            catch
            {
                dtDateTime = DateTime.MaxValue;
            }
            return dtDateTime;
        }


        private void RefreshSerials()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_BaseBoard");
            foreach (ManagementObject wmi in searcher.Get())
            {
                BaseBoardIDTextBox.Text = "Baseboard: " + wmi["SerialNumber"].ToString();
            }
            try
            {
                ManagementObjectSearcher searcherr = new ManagementObjectSearcher("SELECT * FROM Win32_LogicalDisk");
                MacAdressTextBox.AppendText("VolumeIDs:" + Environment.NewLine);
                foreach (ManagementObject disk in searcherr.Get())
                {
                    string volumeID = disk["VolumeSerialNumber"] != null ? disk["VolumeSerialNumber"].ToString() : "N/A";
                    string driveLetter = disk["DeviceID"] != null ? disk["DeviceID"].ToString() : "N/A";
                    if (volumeID.Length == 8)
                    {
                        volumeID = volumeID.Insert(4, "-");
                        MacAdressTextBox.AppendText($"{driveLetter} {volumeID}" + Environment.NewLine);
                    }
                    else
                    {
                        MacAdressTextBox.AppendText($"{driveLetter} {volumeID}" + Environment.NewLine);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            ManagementObjectSearcher disksearcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");

            foreach (ManagementObject disk in disksearcher.Get())
            {
                DiskSerialTextBox.Text = "Disk: " + disk["SerialNumber"].ToString();
            }

            ManagementObjectSearcher searcherChassis = new ManagementObjectSearcher("SELECT * FROM Win32_SystemEnclosure");

            foreach (ManagementObject obj in searcherChassis.Get())
            {
                ChassisSerialBox.Text = "Chassis: " + obj["SerialNumber"].ToString();
            }

            ManagementObjectSearcher searcherCPU = new ManagementObjectSearcher("SELECT * FROM Win32_Processor");

            foreach (ManagementObject obj in searcherCPU.Get())
            {
                CPUSerialBox.Text = "CPU: " + obj["SerialNumber"].ToString();
            }

            ManagementObjectSearcher searcherUUID = new ManagementObjectSearcher("SELECT UUID FROM Win32_ComputerSystemProduct");

            foreach (ManagementObject obj in searcherUUID.Get())
            {
                UUIDSerialTextBox.Text = "UUID: " + obj["UUID"].ToString();
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CoinsAmountTextBox.Text = AuthenticationObject.AuthInstance.getvar("coins");
            UsernameNavLabel.Text = AuthenticationObject.AuthInstance.user_data.username;
            RefreshSerials();
           

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void PermButton_Click(object sender, EventArgs e)
        {
            LoadingCircle.Visible = true;
            CoinsOnAccountBox.Text = AuthenticationObject.AuthInstance.getvar("coins");
            if (ttysystem.getWebInfo("permenabled") == "true")
            {
                SpoofStartBTN.Text = $"Loading...";
                TourneyButton.Checked = false;
                TempButton.Checked = false;
                CustomSerialPanel.Visible = true;
                AddonsPanel.Visible = true;
                CustomSerialSwitcher.Checked = false;
                SpoofStartBTN.Text = $"START ({ttysystem.getWebInfo("permprice")} {ttysystem.getWebInfo("coinsname")})";
                OptionTextBox.Text = "PERM";
                OptionInfoBox.Text = "Change all your Hardware Serials and they stay for ever";
                OptionCoast.Text = ttysystem.getWebInfo("permprice");
                LoadingCircle.Visible = false;
            }
            else
            {
                ttysystem.ShowInfo("Perm Spoof is disabled right now!");
                TourneyButton.Checked = false;
                TempButton.Checked = false;
                PermButton.Checked = false;
                LoadingCircle.Visible = false;
                EditSerialsButton.Visible = false;
                EditButtonBackground.Visible = false;


            }
        }

        private void TourneyButton_Click(object sender, EventArgs e)
        {
            LoadingCircle.Visible = true;
            if (ttysystem.getWebInfo("tourneyenabled") == "true")
            {
                CoinsOnAccountBox.Text = AuthenticationObject.AuthInstance.getvar("coins");
                SpoofStartBTN.Text = $"Loading...";
                PermButton.Checked = false;
                TempButton.Checked = false;
                CustomSerialPanel.Visible = false;
                AddonsPanel.Visible = false;
                EditSerialsButton.Visible = false;
                EditButtonBackground.Visible = false;
                SpoofStartBTN.Text = $"START ({ttysystem.getWebInfo("tourneyprice")} {ttysystem.getWebInfo("coinsname")})";
                OptionTextBox.Text = "TOURNEY";
                OptionInfoBox.Text = "Extra Option to only Spoof Fortnite Tourney or complex bans";
                OptionCoast.Text = ttysystem.getWebInfo("tourneyprice");
                LoadingCircle.Visible = false;
            }
            else
            {
                ttysystem.ShowInfo("Perm Spoof is disabled right now!");
                TourneyButton.Checked = false;
                TempButton.Checked = false;
                PermButton.Checked = false;
                LoadingCircle.Visible = false;


            }
        }

        private void TempButton_Click(object sender, EventArgs e)
        {
            LoadingCircle.Visible = true;
            if (ttysystem.getWebInfo("tempenabled") == "true")
            {
                CoinsOnAccountBox.Text = AuthenticationObject.AuthInstance.getvar("coins");
                SpoofStartBTN.Text = $"Loading...";
                PermButton.Checked = false;
                TourneyButton.Checked = false;
                CustomSerialPanel.Visible = false;
                AddonsPanel.Visible = true;
                EditSerialsButton.Visible = false;
                EditButtonBackground.Visible = false;
                SpoofStartBTN.Text = $"START ({ttysystem.getWebInfo("tempprice")} {ttysystem.getWebInfo("coinsname")})";
                OptionInfoBox.Text = "Change Disk and Hardware Serials until you restart your PC";
                OptionTextBox.Text = "TEMP";
                OptionCoast.Text = ttysystem.getWebInfo("tempprice");
                LoadingCircle.Visible = false;
            }
            else
            {
                ttysystem.ShowInfo("Perm Spoof is disabled right now!");
                TourneyButton.Checked = false;
                TempButton.Checked = false;
                PermButton.Checked = false;
                LoadingCircle.Visible = false;
            }
        }


        private void SpoofStartBTN_Click(object sender, EventArgs e)
        {
            if (!ttyprotection.Authenticated()) Environment.Exit(0);
            ttyprotection.executeProtection();
            if (PermButton.Checked && CustomSerialSwitcher.Checked == false)
            {

                if (int.Parse(AuthenticationObject.AuthInstance.getvar("coins")) >= int.Parse(ttysystem.getWebInfo("permprice")))
                {
                    int coinscac = int.Parse(AuthenticationObject.AuthInstance.getvar("coins")) - int.Parse(ttysystem.getWebInfo("permprice"));
                    AuthenticationObject.AuthInstance.setvar("coins", coinscac.ToString());
                  
                    if (AuthenticationObject.AuthInstance.response.success)
                    {
                        perm permspoof = new perm();
                        permspoof.StartProcess(MacSpoofSwitcher.Checked, VolumeSpoofSwitcher.Checked, ActiveWindowsSwitcher.Checked);
                    }
                    else
                    {
                        ttysystem.ShowInfo("Error while starting process: " + AuthenticationObject.AuthInstance.response.message);
                    }
                }
                else
                {
                    ttysystem.ShowInfo($"You dont have enought {ttysystem.getWebInfo("coinsname")} to use this Option");
                }
                
            }
            else if(PermButton.Checked && CustomSerialSwitcher.Checked == true)
            {
               if (BaseboardserialTemp == null || BaseboardserialTemp.Length == 0 || BaseboardserialTemp == "" || ChassisSerialTemp == null || ChassisSerialTemp.Length == 0 || ChassisSerialTemp == "" || CPUSerialTemp == null || CPUSerialTemp.Length == 0 || CPUSerialTemp == "" || ChassisSerialTemp == null || ChassisSerialTemp.Length == 0 || ChassisSerialTemp == "")
                {
                    ttysystem.ShowInfo("Please edit your Custom Serials");
                }
               else
                {
                    if (int.Parse(AuthenticationObject.AuthInstance.getvar("coins")) >= int.Parse(ttysystem.getWebInfo("permcustomprice")))
                    {

                        int coinscac = int.Parse(AuthenticationObject.AuthInstance.getvar("coins")) - int.Parse(ttysystem.getWebInfo("permcustomprice"));
                        AuthenticationObject.AuthInstance.setvar("coins", coinscac.ToString());
                        if (AuthenticationObject.AuthInstance.response.success)
                        {

                            custom customspoof = new custom();
                            customspoof.StartProcess(MacSpoofSwitcher.Checked, VolumeSpoofSwitcher.Checked, ActiveWindowsSwitcher.Checked, BaseboardserialTemp, ChassisSerialTemp, UUIDSerialTemp, CPUSerialTemp);
                        }
                        else
                        {
                            ttysystem.ShowInfo("Error while starting process");
                        }
                    }
                    else
                    {
                        ttysystem.ShowInfo($"You dont have enought {ttysystem.getWebInfo("coinsname")} to use this Option");
                    }
                }


            }
            else if (TempButton.Checked)
            {
                if (int.Parse(AuthenticationObject.AuthInstance.getvar("coins")) >= int.Parse(ttysystem.getWebInfo("tempprice")))
                {
                    int coinscac = int.Parse(AuthenticationObject.AuthInstance.getvar("coins")) - int.Parse(ttysystem.getWebInfo("tempprice"));
                    AuthenticationObject.AuthInstance.setvar("coins", coinscac.ToString());
                    if (AuthenticationObject.AuthInstance.response.success)
                    {
                        SpoofTemp spoofTemp = new SpoofTemp();
                        spoofTemp.StartProcess(MacSpoofSwitcher.Checked, VolumeSpoofSwitcher.Checked, ActiveWindowsSwitcher.Checked);
                    }
                    else
                    {
                        ttysystem.ShowInfo("Error while starting process");
                    }
                }
                else
                {
                    ttysystem.ShowInfo($"You dont have enought {ttysystem.getWebInfo("coinsname")} to use this Option");
                }

              

            }
            else if (TourneyButton.Checked)
            {

                if (int.Parse(AuthenticationObject.AuthInstance.getvar("coins")) >= int.Parse(ttysystem.getWebInfo("tourneyprice")))
                {
                    int coinscac = int.Parse(AuthenticationObject.AuthInstance.getvar("coins")) - int.Parse(ttysystem.getWebInfo("tourneyprice"));
                    AuthenticationObject.AuthInstance.setvar("coins", coinscac.ToString());
                    if (AuthenticationObject.AuthInstance.response.success)
                    {
                        SpoofTounry spoofTourney = new SpoofTounry();
                        spoofTourney.StartProcess();
                    }
                    else
                    {
                        ttysystem.ShowInfo("Error while starting process");
                    }
                }
                else
                {
                    ttysystem.ShowInfo($"You dont have enought {ttysystem.getWebInfo("coinsname")} to use this Option");
                }
             
            }
            else
            {
                ttysystem.ShowInfo("Please select a spoof Option");
            }

            CoinsOnAccountBox.Text = AuthenticationObject.AuthInstance.getvar("coins");
            CoinsAmountTextBox.Text = AuthenticationObject.AuthInstance.getvar("coins");


        }

        private void SpoofSwitchButton_Click(object sender, EventArgs e)
        {
            if (!PanelSpoof.Visible)
            {
                SpoofSwitchButton.Enabled = false;
                HomeSwitchButton.Enabled = true;
                CleanSwitcherButton.Enabled = true;
                SettingsSwitcherButton.Enabled = true;
                PanelStart.Visible = false;
                PanelSpoof.Visible = true;
                PanelCleaner.Visible = false;
                PanelSettings.Visible = false;
            }
        }

        private void HomeSwitchButton_Click(object sender, EventArgs e)
        {
            if (!PanelStart.Visible)
            {
                SpoofSwitchButton.Enabled = true;
                HomeSwitchButton.Enabled = false;
                CleanSwitcherButton.Enabled = true;
                SettingsSwitcherButton.Enabled = true;
                PanelStart.Visible = true;
                PanelSpoof.Visible = false;
                PanelCleaner.Visible = false;
                PanelSettings.Visible = false;
            }
        }

        private void CleanSwitcherButton_Click(object sender, EventArgs e)
        {
            if (!PanelCleaner.Visible)
            {
                SpoofSwitchButton.Enabled = true;
                HomeSwitchButton.Enabled = true;
                CleanSwitcherButton.Enabled = false;
                SettingsSwitcherButton.Enabled = true;
                PanelStart.Visible = false;
                PanelSpoof.Visible = false;
                PanelCleaner.Visible = true;
                PanelSettings.Visible = false;
            }
        }

        private void SettingsSwitcherButton_Click(object sender, EventArgs e)
        {
            if (!PanelSettings.Visible)
            {
                SpoofSwitchButton.Enabled = true;
                HomeSwitchButton.Enabled = true;
                CleanSwitcherButton.Enabled = true;
                SettingsSwitcherButton.Enabled = false;
                PanelStart.Visible = false;
                PanelSpoof.Visible = false;
                PanelCleaner.Visible = false;
                PanelSettings.Visible = true;
            }
        }

        private void CustomSerialSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            if(CustomSerialSwitcher.Checked)
            {
                SpoofStartBTN.Text = $"Loading...";
                EditSerialsButton.Visible = true;
                EditButtonBackground.Visible = true;
                SpoofStartBTN.Text = $"START ({ttysystem.getWebInfo("permcustomprice")} {ttysystem.getWebInfo("coinsname")})";
                OptionCoast.Text = ttysystem.getWebInfo("permcustomprice");
            }
            else
            {
                SpoofStartBTN.Text = $"Loading...";
                TourneyButton.Checked = false;
                TempButton.Checked = false;
                CustomSerialPanel.Visible = true;
                AddonsPanel.Visible = true;
                SpoofStartBTN.Text = $"START ({ttysystem.getWebInfo("permprice")} {ttysystem.getWebInfo("coinsname")})";
                OptionTextBox.Text = "PERM";
                OptionInfoBox.Text = "Change all your Hardware Serials and they stay for ever";
                OptionCoast.Text = ttysystem.getWebInfo("permprice");
                LoadingCircle.Visible = false;
            }
        }

        private void ActiveWindowsSwitcher_CheckedChanged(object sender, EventArgs e)
        {
            if(ActiveWindowsSwitcher.Checked)
            {
                WindowsWarningPanel.Visible = true;
               
            }
            else
            {
                WindowsWarningPanel.Visible = false;
                
            }
        }

        private void siticoneButton3_Click(object sender, EventArgs e)
        {
            SaveSystem saveSystem = new SaveSystem();   

            List<string> stringsToSave = new List<string>
        {
            "Hello",
            "This is",
            "A sample",
            "String"
        };

            saveSystem.SaveStrings(stringsToSave);
        }

        private void siticoneButton4_Click(object sender, EventArgs e)
        {
            SaveSystem saveSystem = new SaveSystem();
            int lineNumberToShow = 3;

            string specificLine = saveSystem.LoadString(lineNumberToShow);

            if (specificLine != null)
            {
                MessageBox.Show(specificLine);
            }
            else
            {
                Console.WriteLine("Unable to retrieve the specified line.");
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ttysystem.ShowInfo(AuthenticationObject.AuthInstance.user_data.username);
        }

        private void siticoneRoundedButton2_Click(object sender, EventArgs e)
        {
            Process.Start(ttysystem.getWebInfo("websitelink"));
        }

        private void SocialButton1_Click(object sender, EventArgs e)
        {
            Process.Start(ttysystem.getWebInfo("discordserverlink"));
        }

        private void SocialButton2_Click(object sender, EventArgs e)
        {
            Process.Start(ttysystem.getWebInfo("youtubelink"));
        }

        private void SocialButton3_Click(object sender, EventArgs e)
        {
            Process.Start(ttysystem.getWebInfo("tiktoklink"));
        }

        private void SaveSerialsButton_Click(object sender, EventArgs e)
        {
            SaveSystem saveSystem = new SaveSystem();
            
            saveSystem.SaveStrings(saveSystem.GetSerials());
        }

        private void LoadSerialsButton_Click(object sender, EventArgs e)
        {
            Process.Start("\\serials.txt");
        }


        private void EditSerialsButton_Click(object sender, EventArgs e)
        {
            OptionWindow optionWindow = new OptionWindow();
            optionWindow.Show();
        }

        private void RefreshSerialButton_Click(object sender, EventArgs e)
        {
            RefreshSerials();
        }


        private void startCleanerButton_Click(object sender, EventArgs e)
        {
            CleanerProgessCircle.Visible = true;
            ttysystem.CleanPC();
            CleanerProgessCircle.Visible = false;
        }

      

    }
}

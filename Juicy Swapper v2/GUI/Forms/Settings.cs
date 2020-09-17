using Juicy_Swapper_v2.Forms.Dialogs;
using Juicy_Swapper_v2.Properties;
using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Diagnostics;
using System.IO;
using System.Media;
using System.Text;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Forms
{
    public partial class SettingsMenu : Form
    {
        public SettingsMenu()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void selectPakPathButton_Click(object sender, EventArgs e)
        {
            var dialog = new CommonOpenFileDialog
            {
                Title = "Choose Pak File Directory",
                IsFolderPicker = true,
                InitialDirectory = "C:\\Program Files\\Epic Games\\Fortnite\\Content\\Paks"
            };
            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                if (File.Exists($"{dialog.FileName}\\pakchunk0-WindowsClient.pak"))
                {
                    pakPathTextbox.Text = dialog.FileName;
                    Settings.Default.pakPath = pakPathTextbox.Text;
                    Settings.Default.Save();
                    pakPathTextbox.Text = Settings.Default.pakPath;
                }
                else
                {
                    new PakError().ShowDialog();
                }
            }
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            pakPathTextbox.Text = Settings.Default.pakPath;
        }

        private void resetConfigButton_Click(object sender, EventArgs e)
        {
            new ResetConfirm().ShowDialog();
        }

        private void convertedItemsButton_Click(object sender, EventArgs e)
        {
            int num = 0;
            string text = "";
            //
            //Skins enabled
            //
            if (Settings.Default.renegadeRaiderEnabled == true)
            {
                num++;
                text += "Renegade Raider (Standard)," + " ";
            }
            if (Settings.Default.renegadeRaiderCEnabled == true)
            {
                num++;
                text += "Renegade Raider (Checkered)," + " ";
            }
            if (Settings.Default.skullTrooperEnabled == true)
            {
                num++;
                text += "Skull Trooper," + " ";
            }
            if (Settings.Default.ghoulTrooperEnabled == true)
            {
                num++;
                text += "Ghoul Trooper," + " ";
            }
            if (Settings.Default.fallenLoveRangerEnabled == true)
            {
                num++;
                text += "Fallen Love Ranger," + " ";
            }
            if (Settings.Default.dummyEnabled == true)
            {
                num++;
                text += "Dummy," + " ";
            }
            if (Settings.Default.galaxyEnabled == true)
            {
                num++;
                text += "Galaxy," + " ";
            }
            if (Settings.Default.galacticDiscEnabled == true)
            {
                num++;
                text += "Galactic Disc," + " ";
            }
            if (Settings.Default.stellarAxeEnabled == true)
            {
                num++;
                text += "Stellar Axe," + " ";
            }
            if (Settings.Default.raidersRevengeEnabled == true)
            {
                num++;
                text += "Raider's Revenge," + " ";
            }
            if (Settings.Default.merryMintAxeEnabled == true)
            {
                num++;
                text += "Merry Mint Axe," + " ";
            }
            if (Settings.Default.bootstrapsEnabled == true)
            {
                num++;
                text += "Bootstraps," + " ";
            }
            if (Settings.Default.driverEnabled == true)
            {
                num++;
                text += "Driver," + " ";
            }
            if (Settings.Default.harleyHitterEnabled == true)
            {
                num++;
                text += "Harley Hitter," + " ";
            }
            if (Settings.Default.widowsBiteEnabled == true)
            {
                num++;
                text += "Widow's Bite," + " ";
            }
            if (Settings.Default.candyAxeEnabled == true)
            {
                num++;
                text += "Candy Axe," + " ";
            }
            if (Settings.Default.studdedAxeEnabled == true)
            {
                num++;
                text += "Studded Axe," + " ";
            }
            if (Settings.Default.axeOfChampionsEnabled == true)
            {
                num++;
                text += "Axe Of Champions," + " ";
            }
            if (Settings.Default.rainbowCloverEnabled == true)
            {
                num++;
                text += "Rainbow Clover," + " ";
            }
            if (Settings.Default.goobaEnabled == true)
            {
                num++;
                text += "GOOBA," + " ";
            }
            if (Settings.Default.goosebumpsEnabled == true)
            {
                num++;
                text += "goosebumps," + " ";
            }
            if (Settings.Default.sickoModeEnabled == true)
            {
                num++;
                text += "SICKO MODE," + " ";
            }
            if (Settings.Default.stargazingEnabled == true)
            {
                num++;
                text += "STARGAZING (pt. II)," + " ";
            }
            if (Settings.Default.moneyMachineEnabled == true)
            {
                num++;
                text += "money machine," + " ";
            }
            if (Settings.Default.aerialAssaultOneEnabled == true)
            {
                num++;
                text += "Aerial Assault One," + " ";
            }
            if (Settings.Default.cloudStrikeEnabled == true)
            {
                num++;
                text += "Cloud Strike," + " ";
            }
            if (Settings.Default.discoveryEnabled == true)
            {
                num++;
                text += "Discovery," + " ";
            }
            if (Settings.Default.getDownEnabled == true)
            {
                num++;
                text += "Get Down!," + " ";
            }
            if (Settings.Default.goldUmbrellaEnabled == true)
            {
                num++;
                text += "Gold Umbrella," + " ";
            }
            if (Settings.Default.makoEnabled == true)
            {
                num++;
                text += "Mako," + " ";
            }
            if (Settings.Default.snowflakeEnabled == true)
            {
                num++;
                text += "Snowflake," + " ";
            }
            //
            if (num == 0)
            {
                MessageBox.Show(this, "You currently have no items converted!", "Juicy Swapper v2 - Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (num == 1)
            {
                MessageBox.Show(this, "You currently have 1 item converted: " + text.Remove(text.Length - 2) + ".", "Juicy Swapper v2 - Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (num > 1)
            {
                MessageBox.Show(this, "You currently have " + num.ToString() + " items converted: " + text.Remove(text.Length - 2) + ".", "Juicy Swapper v2 - Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void launchFortniteBtn_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            DialogResult restart = MessageBox.Show("Are you sure you want to launch Fortnite?", "Juicy Swapper v2 - Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (restart == DialogResult.Yes)
            {
                new FortniteLaunch().ShowDialog();
                StringBuilder stringBuilder = new StringBuilder(Settings.Default.pakPath, 1000);
                stringBuilder.Replace("Content\\Paks", "Binaries\\Win64\\");
                Process.Start(stringBuilder.ToString() + "FortniteClient-Win64-Shipping_EAC.exe");
                Environment.Exit(0);
            }
            else { }
        }

        private void restartSwapperBtn_Click(object sender, EventArgs e)
        {
            SystemSounds.Beep.Play();
            DialogResult restart = MessageBox.Show("Are you sure you want to restart?", "Juicy Swapper v2 - Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (restart == DialogResult.Yes)
            {
                Process.Start(Application.ExecutablePath);
                Environment.Exit(0);
            }
            else { }
        }

        private void checkPakDirBtn_Click(object sender, EventArgs e)
        {
            if (File.Exists(Settings.Default.pakPath + $"\\pakchunk0-WindowsClient.pak"))
            {
                MessageBox.Show("Successfully verified the selected .pak directory!", "Juicy Swapper v2 - Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                new PakError().ShowDialog();
            }
        }

        private void openPakDirBtn_Click(object sender, EventArgs e)
        {
            var OpenPaks = new ProcessStartInfo
            {
                FileName = @"c:\windows\system32\explorer.exe",
                Arguments = Settings.Default.pakPath
            };
            Process.Start(OpenPaks);
        }
    }
}

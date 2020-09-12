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

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
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
            //if (Settings.Default.pakCount == true)
            {
                num++;
                text += "Recon Specialist," + " ";
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

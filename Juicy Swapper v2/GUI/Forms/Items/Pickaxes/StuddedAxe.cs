﻿using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Pickaxes
{
    public partial class StuddedAxe : Form
    {
        public StuddedAxe()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.CrowbarIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.StuddedAxeIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.stellarAxeEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk24-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Stellar Axe swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Settings.Default.raidersRevengeEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk25-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Raider's Revenge swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Settings.Default.merryMintAxeEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk26-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Merry Mint Axe swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Settings.Default.bootstrapsEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk27-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Bootstraps swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Settings.Default.driverEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk28-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Driver swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Settings.Default.harleyHitterEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk29-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Harley Hitter swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (Settings.Default.widowsBiteEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk30-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Widow's Bite swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (swapBtn.Text == "Revert")
                {
                    JuicyUtilities.RemoveCustomPak("32", itemDialogTextBox, swapBtn);
                    Settings.Default.studdedAxeEnabled = false;
                }
                else if (swapBtn.Text == "Convert")
                {
                    JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754402200389812386/pakchunk69-WindowsClient.pak", "32", itemDialogTextBox, swapBtn);
                    Settings.Default.studdedAxeEnabled = true;
                }
            }
        }

        private void Bootstraps_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk32-WindowsClient.pak") || Settings.Default.studdedAxeEnabled == false)
            {
                swapBtn.Text = "Convert";
            }
            else
            {
                swapBtn.Text = "Revert";
            }
        }
    }
}
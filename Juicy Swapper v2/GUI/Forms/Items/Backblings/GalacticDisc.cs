﻿using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Backblings
{
    public partial class GalacticDisc : Form
    {
        public GalacticDisc()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.NeonWingsIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.GalacticDiscIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("23", itemDialogTextBox, swapBtn);
                Settings.Default.galacticDiscEnabled = false;
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754440825668239441/pakchunk69-WindowsClient.pak", "23", itemDialogTextBox, swapBtn);
                Settings.Default.galacticDiscEnabled = true;
            }                
        }
    }
}
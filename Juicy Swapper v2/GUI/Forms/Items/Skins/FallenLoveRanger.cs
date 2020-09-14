using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Skins
{
    public partial class FallenLoveRanger : Form
    {
        public FallenLoveRanger()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.WoolyWarriorIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.FallenLoveRangerIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.dummyEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk21-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Dummy swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (swapBtn.Text == "Revert")
                {
                    JuicyUtilities.RemoveCustomPak("20", itemDialogTextBox, swapBtn);
                    Settings.Default.fallenLoveRangerEnabled = false;
                    Settings.Default.Save();
                }
                else if (swapBtn.Text == "Convert")
                {
                    JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/745976266804559882/pakchunk69-WindowsClient.pak", "20", itemDialogTextBox, swapBtn);
                    Settings.Default.fallenLoveRangerEnabled = true;
                    Settings.Default.Save();
                }
            }
        }

        private void FallenLoveRanger_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk20-WindowsClient.pak") || Settings.Default.fallenLoveRangerEnabled == false)
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

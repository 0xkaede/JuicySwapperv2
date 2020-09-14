using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Skins
{
    public partial class RenegadeRaider : Form
    {
        public RenegadeRaider()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.BlazeIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.RenegadeRaiderIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.renegadeRaiderCEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk17-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Renegade Raider (Checkered) swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (swapBtn.Text == "Revert")
                {
                    JuicyUtilities.RemoveCustomPak("16", itemDialogTextBox, swapBtn);
                    Settings.Default.renegadeRaiderEnabled = false;
                }
                else if (swapBtn.Text == "Convert")
                {
                    JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754402343382024312/pakchunk69-WindowsClient.pak", "16", itemDialogTextBox, swapBtn);
                    Settings.Default.renegadeRaiderEnabled = true;
                }
            }
        }

        private void RenegadeRaider_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk16-WindowsClient.pak") || Settings.Default.renegadeRaiderEnabled == false)
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

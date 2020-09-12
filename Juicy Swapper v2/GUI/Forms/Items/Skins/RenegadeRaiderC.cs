using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Skins
{
    public partial class RenegadeRaiderC : Form
    {
        public RenegadeRaiderC()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.BlazeIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.RenegadeRaiderCIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.renegadeRaiderEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk16-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Renegade Raider swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (swapBtn.Text == "Revert")
                {
                    JuicyUtilities.RemoveCustomPak("17", itemDialogTextBox, swapBtn);
                    Settings.Default.renegadeRaiderCEnabled = false;
                }
                else if (swapBtn.Text == "Convert")
                {
                    JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754402394778894356/pakchunk69-WindowsClient.pak", "17", itemDialogTextBox, swapBtn);
                    Settings.Default.renegadeRaiderCEnabled = true;
                }
            }               
        }
    }
}

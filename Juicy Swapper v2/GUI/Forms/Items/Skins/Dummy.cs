using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Skins
{
    public partial class Dummy : Form
    {
        public Dummy()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.WoolyWarriorIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.DummyIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.fallenLoveRangerEnabled == true || File.Exists(Settings.Default.pakPath + "\\pakchunk20-WindowsClient.pak"))
            {
                MessageBox.Show("ERROR: Conflict found! You already have Fallen Love Ranger swapped. Please revert this item to swap the current item or disregard this message!", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (swapBtn.Text == "Revert")
                {
                    JuicyUtilities.RemoveCustomPak("21", itemDialogTextBox, swapBtn);
                    Settings.Default.dummyEnabled = false;
                }
                else if (swapBtn.Text == "Convert")
                {
                    JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754439682577662072/pakchunk69-WindowsClient.pak", "21", itemDialogTextBox, swapBtn);
                    Settings.Default.dummyEnabled = true;
                }
            }
        }
    }
}

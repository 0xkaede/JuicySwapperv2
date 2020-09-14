using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous
{
    public partial class CloudStrike : Form
    {
        public CloudStrike()
        {   
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.FoundersGliderIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.CloudStrikeIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("41", itemDialogTextBox, swapBtn);
                Settings.Default.cloudStrikeEnabled = false;
                Settings.Default.Save();
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754842309366906975/pakchunk69-WindowsClient.pak", "41", itemDialogTextBox, swapBtn);
                Settings.Default.cloudStrikeEnabled = true;
                Settings.Default.Save();
            }                
        }

        private void GalacticDisc_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk41-WindowsClient.pak") || Settings.Default.cloudStrikeEnabled == false)
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

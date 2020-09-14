using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous
{
    public partial class Discovery : Form
    {
        public Discovery()
        {   
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.FoundersGliderIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.DiscoveryIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("42", itemDialogTextBox, swapBtn);
                Settings.Default.discoveryEnabled = false;
                Settings.Default.Save();
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754842340069212220/pakchunk69-WindowsClient.pak", "42", itemDialogTextBox, swapBtn);
                Settings.Default.discoveryEnabled = true;
                Settings.Default.Save();
            }                
        }

        private void GalacticDisc_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk42-WindowsClient.pak") || Settings.Default.discoveryEnabled == false)
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

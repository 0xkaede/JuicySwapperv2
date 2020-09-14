using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Skins
{
    public partial class GhoulTrooper : Form
    {
        public GhoulTrooper()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.GhoulTrooperIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.GhoulTrooperPinkIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("19", itemDialogTextBox, swapBtn);
                Settings.Default.ghoulTrooperEnabled = false;
                Settings.Default.Save();
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754842962965299220/pakchunk69-WindowsClient.pak", "19", itemDialogTextBox, swapBtn);
                Settings.Default.ghoulTrooperEnabled = true;
                Settings.Default.Save();
            }
        }

        private void GhoulTrooper_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk19-WindowsClient.pak") || Settings.Default.ghoulTrooperEnabled == false)
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

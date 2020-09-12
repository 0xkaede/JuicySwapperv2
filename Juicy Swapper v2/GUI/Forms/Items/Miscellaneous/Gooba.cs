using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous
{
    public partial class Gooba : Form
    {
        public Gooba()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.BDayBeatsIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.GOOBAIcon;
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            JuicyUtilities.PlayPreview(Resources.GOOBAPreview, previewBtn);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("18", itemDialogTextBox, swapBtn);
                //Settings.Default.goobaEnabled = false;
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/739141580967116900/753715719560233000/pakchunk69-WindowsClient.pak", "18", itemDialogTextBox, swapBtn);
                //Settings.Default.goobaEnabled = true;
            }                
        }
    }
}

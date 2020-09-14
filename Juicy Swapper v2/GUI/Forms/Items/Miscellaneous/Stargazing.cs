using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous
{
    public partial class Stargazing : Form
    {
        public Stargazing()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.BDayBeatsIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.ASTRONOMICALIcon;
        }

        private void previewBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("There is not a preview available for this item yet.", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //JuicyUtilities.PlayPreview(Resources.goosebumpsPreview, previewBtn);
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("38", itemDialogTextBox, swapBtn);
                Settings.Default.stargazingEnabled = false;
                Settings.Default.Save();
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754843242893410405/pakchunk69-WindowsClient.pak", "38", itemDialogTextBox, swapBtn);
                Settings.Default.stargazingEnabled = true;
                Settings.Default.Save();
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Goosebumps_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk38-WindowsClient.pak") || Settings.Default.stargazingEnabled == false)
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

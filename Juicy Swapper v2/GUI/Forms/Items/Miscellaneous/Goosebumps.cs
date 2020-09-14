using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous
{
    public partial class Goosebumps : Form
    {
        public Goosebumps()
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
            JuicyUtilities.PlayPreview(Resources.goosebumpsPreview, previewBtn);
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("36", itemDialogTextBox, swapBtn);
                Settings.Default.goosebumpsEnabled = false;
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754842582156312636/pakchunk69-WindowsClient.pak", "36", itemDialogTextBox, swapBtn);
                Settings.Default.goosebumpsEnabled = true;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Goosebumps_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk36-WindowsClient.pak") || Settings.Default.goosebumpsEnabled == false)
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

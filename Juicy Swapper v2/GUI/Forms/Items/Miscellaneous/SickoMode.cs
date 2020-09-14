using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous
{
    public partial class SickoMode : Form
    {
        public SickoMode()
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
            JuicyUtilities.PlayPreview(Resources.SICKOMODEPreview, previewBtn);
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SickoMode_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk37-WindowsClient.pak") || Settings.Default.sickoModeEnabled == false)
            {
                swapBtn.Text = "Convert";
            }
            else
            {
                swapBtn.Text = "Revert";
            }
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("37", itemDialogTextBox, swapBtn);
                Settings.Default.sickoModeEnabled = false;
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754843093437644820/pakchunk69-WindowsClient.pak", "37", itemDialogTextBox, swapBtn);
                Settings.Default.sickoModeEnabled = true;
            }
        }
    }
}

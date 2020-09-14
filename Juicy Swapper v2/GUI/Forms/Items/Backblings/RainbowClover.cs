using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Backblings
{
    public partial class RainbowClover : Form
    {
        public RainbowClover()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.CombatWreathIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.RainbowCloverIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("34", itemDialogTextBox, swapBtn);
                Settings.Default.rainbowCloverEnabled = false;
                Settings.Default.Save();
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754673358494236702/pakchunk69-WindowsClient.pak", "34", itemDialogTextBox, swapBtn);
                Settings.Default.rainbowCloverEnabled = true;
                Settings.Default.Save();
            }                
        }

        private void RainbowClover_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk34-WindowsClient.pak") || Settings.Default.rainbowCloverEnabled == false)
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

using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Pickaxes
{
    public partial class AxeOfChampions : Form
    {
        public AxeOfChampions()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.GoldenKingIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.AxeOfChampionsIcon;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void swapBtn_Click(object sender, EventArgs e)
        {
            if (swapBtn.Text == "Revert")
            {
                JuicyUtilities.RemoveCustomPak("33", itemDialogTextBox, swapBtn);
                Settings.Default.axeOfChampionsEnabled = false;
                Settings.Default.Save();
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754673462265512086/pakchunk69-WindowsClient.pak", "33", itemDialogTextBox, swapBtn);
                Settings.Default.axeOfChampionsEnabled = true;
                Settings.Default.Save();
            }
        }

        private void HarleyHitter_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk33-WindowsClient.pak") || Settings.Default.axeOfChampionsEnabled == false)
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

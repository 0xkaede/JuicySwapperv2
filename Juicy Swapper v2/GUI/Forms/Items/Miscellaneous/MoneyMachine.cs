using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Properties;
using System;
using System.IO;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous
{
    public partial class MoneyMachine : Form
    {
        public MoneyMachine()
        {
            InitializeComponent();
        }

        private void itemDialogPictureBox_MouseEnter(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.TheCrackdownIcon;
        }

        private void itemDialogPictureBox_MouseLeave(object sender, EventArgs e)
        {
            itemDialogPictureBox.Image = Resources.MoneyMachineIcon;
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
                JuicyUtilities.RemoveCustomPak("39", itemDialogTextBox, swapBtn);
                Settings.Default.moneyMachineEnabled = false;
            }
            else if (swapBtn.Text == "Convert")
            {
                JuicyUtilities.AddCustomPak("https://cdn.discordapp.com/attachments/742462742312517713/754842848527909004/pakchunk69-WindowsClient.pak", "39", itemDialogTextBox, swapBtn);
                Settings.Default.moneyMachineEnabled = true;
            }
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Goosebumps_Load(object sender, EventArgs e)
        {
            if (!File.Exists(Settings.Default.pakPath + "\\pakchunk39-WindowsClient.pak") || Settings.Default.moneyMachineEnabled == false)
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

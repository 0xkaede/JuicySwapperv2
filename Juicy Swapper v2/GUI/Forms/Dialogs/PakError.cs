using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Forms.Dialogs
{
    public partial class PakError : Form
    {
        public PakError()
        {
            InitializeComponent();
            SystemSounds.Hand.Play();
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void closeDialogBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

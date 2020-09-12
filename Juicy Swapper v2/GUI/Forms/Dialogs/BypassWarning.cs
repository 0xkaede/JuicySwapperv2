using System;
using System.Diagnostics;
using System.Media;
using System.Windows.Forms;

namespace JuicySwapper.Main.GUI
{
    public partial class BypassWarning : Form
    {
        public BypassWarning()
        {
            InitializeComponent();
            SystemSounds.Exclamation.Play();
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void continueBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

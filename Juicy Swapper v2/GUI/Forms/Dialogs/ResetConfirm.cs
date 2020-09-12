using Juicy_Swapper_v2.Properties;
using System;
using System.Media;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Forms.Dialogs
{
    public partial class ResetConfirm : Form
    {
        public ResetConfirm()
        {
            InitializeComponent();
            SystemSounds.Question.Play();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            //Settings.Default.pakCount = false;
            //
            Settings.Default.Save();
            new ResetComplete().ShowDialog();
            Close();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

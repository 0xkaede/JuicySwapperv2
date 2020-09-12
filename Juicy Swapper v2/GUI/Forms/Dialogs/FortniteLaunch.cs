using System;
using System.Media;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Forms.Dialogs
{
    public partial class FortniteLaunch : Form
    {
        public FortniteLaunch()
        {
            InitializeComponent();
            SystemSounds.Beep.Play();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous;
using System;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.GUI.Forms.Items.Questions
{
    public partial class AstronomicalQuestion : Form
    {
        public AstronomicalQuestion()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void sickoModeFormLabel_Click(object sender, EventArgs e)
        {
            new SickoMode().ShowDialog();
        }

        private void goosebumpsFormLabel_Click(object sender, EventArgs e)
        {
            new Goosebumps().ShowDialog();
        }

        private void stargazingFormLabel_Click(object sender, EventArgs e)
        {
            new Stargazing().ShowDialog();
        }
    }
}

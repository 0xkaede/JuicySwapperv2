using System;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Panels
{
    public partial class EmotesPanel : UserControl
    {
        private static EmotesPanel _instance;      
        public static EmotesPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new EmotesPanel();
                return _instance;
            }
        }
        public EmotesPanel()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            //new Floss().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            //new Scenario().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            //new TakeTheL().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            //new NeverGonna().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            //new Slick().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            //new LazerBlast().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            //new Levitate().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            //new Poki().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            //new Llamacadabra().ShowDialog();
        }

        private void bunifuImageButton10_Click(object sender, EventArgs e)
        {
            //new Daydream().ShowDialog();
        }

        private void bunifuImageButton11_Click(object sender, EventArgs e)
        {
            //new Flapper().ShowDialog();
        }

        private void bunifuImageButton12_Click(object sender, EventArgs e)
        {
            //new Glowsticks().ShowDialog();
        }

        private void bunifuImageButton13_Click(object sender, EventArgs e)
        {
            //new PonyUp().ShowDialog();
        }

        private void bunifuImageButton14_Click(object sender, EventArgs e)
        {
            //new Infectious().ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

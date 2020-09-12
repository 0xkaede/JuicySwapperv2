using Juicy_Swapper_v2.GUI.Forms.Items.Miscellaneous;
using Juicy_Swapper_v2.GUI.Forms.Items.Questions;
using System;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Panels
{
    public partial class MiscPanel : UserControl
    {
        private static MiscPanel _instance;      
        public static MiscPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MiscPanel();
                return _instance;
            }
        }
        public MiscPanel()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new Gooba().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new AstronomicalQuestion().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            //new SuperOGMusic().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            //new JuicyEAC1().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            //new JuicyEAC2().ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

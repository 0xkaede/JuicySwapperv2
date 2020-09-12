using Juicy_Swapper_v2.GUI.Forms.Items.Pickaxes;
using System;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Panels
{
    public partial class PickaxesPanel : UserControl
    {
        private static PickaxesPanel _instance;      
        public static PickaxesPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new PickaxesPanel();
                return _instance;
            }
        }
        public PickaxesPanel()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new StellarAxe().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new RaidersRevenge().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new MerryMintAxe().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new Bootstraps().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new Driver().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new HarleyHitter().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            //new Reaper().ShowDialog();
        }

        private void bunifuImageButton8_Click(object sender, EventArgs e)
        {
            //new StellarAxe().ShowDialog();
        }

        private void bunifuImageButton9_Click(object sender, EventArgs e)
        {
            //new OGDefault().ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

using Juicy_Swapper_v2.GUI.Forms.Items.Skins;
using JuicySwapper.Main.GUI;
using System;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Panels
{
    public partial class SkinsPanel : UserControl
    {
        private static SkinsPanel _instance;      
        public static SkinsPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SkinsPanel();
                return _instance;
            }
        }
        public SkinsPanel()
        {
            InitializeComponent();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            new RenegadeRaider().ShowDialog();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            new RenegadeRaiderC().ShowDialog();
        }

        private void bunifuImageButton3_Click(object sender, EventArgs e)
        {
            new SkullTrooper().ShowDialog();
        }

        private void bunifuImageButton4_Click(object sender, EventArgs e)
        {
            new GhoulTrooper().ShowDialog();
        }

        private void bunifuImageButton5_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new FallenLoveRanger().ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Dummy().ShowDialog();
        }

        private void bunifuImageButton7_Click(object sender, EventArgs e)
        {
            new BypassWarning().ShowDialog();
            new Galaxy().ShowDialog();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

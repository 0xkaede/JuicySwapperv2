using DiscordRPC;
using Juicy_Swapper_v2.Classes;
using Juicy_Swapper_v2.Panels;
using Juicy_Swapper_v2.Properties;
using System;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Forms
{
    public partial class Home : Form
    {
        public Home()
        {
            JuicyUtilities.FindPaks();
            InitializeComponent();
            JuicyUtilities.SetRPCAction("In Dashboard", "dashimg");
            userWelcomeLabel.Text = "Welcome, " + Environment.UserName;
            if (!formWrapper.Controls.Contains(DashPanel.Instance))
            {
                formWrapper.Controls.Add(DashPanel.Instance);
                DashPanel.Instance.Dock = DockStyle.Fill;
                DashPanel.Instance.BringToFront();
            }
            else
                DashPanel.Instance.BringToFront();
        }

        private void displayDashPanelBtn_Click(object sender, EventArgs e)
        {
            JuicyUtilities.SetRPCAction("In Dashboard", "dashimg");
            if (!formWrapper.Controls.Contains(DashPanel.Instance))
            {
                formWrapper.Controls.Add(DashPanel.Instance);
                DashPanel.Instance.Dock = DockStyle.Fill;
                DashPanel.Instance.BringToFront();
            }
            else
                DashPanel.Instance.BringToFront();
        }

        private void displaySkinsPanelBtn_Click(object sender, EventArgs e)
        {
            if (Settings.Default.miscTabEnabled == false)
            {
                MessageBox.Show("This tab is currently disabled! Please wait for the development team to re-enable it.", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                JuicyUtilities.SetRPCLocation("Skins", "skinimg");
                if (!formWrapper.Controls.Contains(SkinsPanel.Instance))
                {
                    formWrapper.Controls.Add(SkinsPanel.Instance);
                    SkinsPanel.Instance.Dock = DockStyle.Fill;
                    SkinsPanel.Instance.BringToFront();
                }
                else
                    SkinsPanel.Instance.BringToFront();
            }
        }

        private void displayBackblingsPanelBtn_Click(object sender, EventArgs e)
        {
            JuicyUtilities.SetRPCLocation("Backblings", "backblingimg");
            if (!formWrapper.Controls.Contains(BackblingsPanel.Instance))
            {
                formWrapper.Controls.Add(BackblingsPanel.Instance);
                BackblingsPanel.Instance.Dock = DockStyle.Fill;
                BackblingsPanel.Instance.BringToFront();
            }
            else
                BackblingsPanel.Instance.BringToFront();
        }

        private void displayPickaxesPanelBtn_Click(object sender, EventArgs e)
        {
            JuicyUtilities.SetRPCLocation("Pickaxes", "pickaxeimg");
            if (!formWrapper.Controls.Contains(PickaxesPanel.Instance))
            {
                formWrapper.Controls.Add(PickaxesPanel.Instance);
                PickaxesPanel.Instance.Dock = DockStyle.Fill;
                PickaxesPanel.Instance.BringToFront();
            }
            else
                PickaxesPanel.Instance.BringToFront();
        }

        private void displayEmotesPanelBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This tab is currently disabled! Please wait for the development team to re-enable it.", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    JuicyUtilities.SetRPCLocation("Emotes", "emoteimg");
            //    if (!formWrapper.Controls.Contains(EmotesPanel.Instance))
            //    {
            //        formWrapper.Controls.Add(EmotesPanel.Instance);
            //        EmotesPanel.Instance.Dock = DockStyle.Fill;
            //        EmotesPanel.Instance.BringToFront();
            //    }
            //    else
            //        EmotesPanel.Instance.BringToFront();
        }

        private void displayMiscPanelTab_Click(object sender, EventArgs e)
        {
            if (Settings.Default.skinTabEnabled == false)
            {
                MessageBox.Show("This tab is currently disabled! Please wait for the development team to re-enable it.", "Juicy Swapper v2 - Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                JuicyUtilities.SetRPCLocation("Miscellaneous", "miscellaneousimg");
                if (!formWrapper.Controls.Contains(MiscPanel.Instance))
                {
                    formWrapper.Controls.Add(MiscPanel.Instance);
                    MiscPanel.Instance.Dock = DockStyle.Fill;
                    MiscPanel.Instance.BringToFront();
                }
                else
                    MiscPanel.Instance.BringToFront();
            }
        }

        private void displayItemShopFormBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature is currently work-in-progess. Thanks for your understanding!", "Juicy Swapper v2 - Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //new ItemShop().ShowDialog();
        }

        private void displaySettingsFormBtn_Click(object sender, EventArgs e)
        {
            JuicyUtilities.SetRPCLocation("Settings", "settingsimg");
            new SettingsMenu().ShowDialog();
        }
    }
}

using System;
using System.Windows.Forms;
using Juicy_Swapper_v2.Classes;

namespace Juicy_Swapper_v2.Forms
{
    public partial class Loader : Form
    {
        public Loader()
        {
            InitializeComponent();
            JuicyUtilities.CloseEpicProcesses();
            JuicyUtilities.DiscordRPC.Initialize();
            JuicyUtilities.SetRPCAction("Loading Swapper...", "");
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (loaderProgressBar.Value == 99)
            {
                timer.Enabled = false;
                Form Home = new Home();
                var HomeFormRunning = Home;
                HomeFormRunning.Closed += (s, args) => Close();
                Hide();
                HomeFormRunning.Show();
            }
            loaderProgressBar.Value += 1;
        }
    }
}

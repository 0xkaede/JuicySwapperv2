using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Media;
using System.Net;
using System.Windows.Forms;
using static Juicy_Swapper_v2.Classes.API.StatusAPI;

namespace Juicy_Swapper_v2.Forms.Dialogs
{ 
    public partial class OfflineMode : Form
    {
        public OfflineMode()
        {
            InitializeComponent();
            SystemSounds.Hand.Play();
            var StatusAPI = new WebClient().DownloadString("http://juicyswapper.xyz/api/status");
            Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);
            dialogMsgTextLabel.Text = (StatusResponse.OfflineMessage);
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void statusButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.statuspage.io/");
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

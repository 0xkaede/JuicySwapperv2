using Juicy_Swapper_v2.Classes;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Media;
using System.Net;
using System.Windows.Forms;
using static Juicy_Swapper_v2.Classes.API.StatusAPI;

namespace Juicy_Swapper_v2.Forms.Dialogs
{
    public partial class Update : Form
    {
        public Update()
        {
            InitializeComponent();
            SystemSounds.Hand.Play();
            var StatusAPI = new WebClient().DownloadString("http://juicyswapper.xyz/api/status");
            Status StatusResponse = JsonConvert.DeserializeObject<Status>(StatusAPI);
            dialogMsgTextLabel.Text = StatusResponse.OutOfDateMessage + StatusResponse.Version + "\nCurrent Build: v" + $"{ Application.ProductVersion}";
        }

        private void discordButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://juicyswapper.xyz/discord");
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            JuicyUtilities.ExecuteAsAdmin("Juicy Updater.exe");
            Environment.Exit(0);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

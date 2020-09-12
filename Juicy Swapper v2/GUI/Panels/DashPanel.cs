using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Net;
using System.Windows.Forms;
using static Juicy_Swapper_v2.Classes.API.ContentAPI;

namespace Juicy_Swapper_v2.Panels
{
    public partial class DashPanel : UserControl
    {
        private static DashPanel _instance;      
        public static DashPanel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new DashPanel();
                return _instance;
            }
        }
        public DashPanel()
        {
            InitializeComponent();
            GetContent();
        }

        public void GetContent()
        {
            //Downloads JSON from Juicy Swapper API.
            var ContentAPI = new WebClient().DownloadString("http://juicyswapper.xyz/api/content");

            //Deserializes JSON from Juicy Swapper API.
            Content StatusResponse = JsonConvert.DeserializeObject<Content>(ContentAPI);

            //Sets Form Items from API Response.
            newsTitleLabel.Text = StatusResponse.News.NewsTitle;
            newsTextLabel.Text = StatusResponse.News.NewsText;
            newsImagePictureBox.ImageLocation = StatusResponse.News.NewsImage;
            changelogTextLabel.Text = StatusResponse.Patchnotes.PatchnotesText;
            currentVersionLabel.Text = $"Current Version: v{Application.ProductVersion}";
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}

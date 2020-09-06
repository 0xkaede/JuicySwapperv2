using Newtonsoft.Json;
using System;
using System.Net;
using System.Windows.Forms;
using static Juicy_Swapper_v2.Classes.API.ContentAPI;

namespace Juicy_Swapper_v2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            GetContent();
            InitializeComponent();
        }

        public void GetContent()
        {
            var ContentAPI = new WebClient().DownloadString("http://juicyswapper.xyz/api/content");
            Content StatusResponse = JsonConvert.DeserializeObject<Content>(ContentAPI);
            Console.Write(StatusResponse.News.NewsTitle);
            //label1.Text = StatusResponse.News.NewsTitle;
            //richTextBox1.Text = StatusResponse.News.NewsText;
            //pictureBox1.ImageLocation = StatusResponse.News.NewsImage;
            //label2.Text = StatusResponse.Patchnotes.PatchnotesTitle;
            //richTextBox2.Text = StatusResponse.Patchnotes.PatchnotesText;
        }
    }
}

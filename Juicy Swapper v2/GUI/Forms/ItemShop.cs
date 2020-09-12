using Juicy_Swapper_v2.Classes.API;
using Juicy_Swapper_v2.Properties;
using System;
using System.Drawing;
using System.Drawing.Text;
using System.Net;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Juicy_Swapper_v2.Forms
{
    public partial class ItemShop : Form
    {
        public ItemShop()
        {
            InitializeComponent();
        }

        private async void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            var shit = await new ItemShopAPI().GetBRShop();
            label1.Text = shit.Data.Featured.Entries[0].Items[0].Name.ToUpper();
            label2.Text = shit.Data.Featured.Entries[0].FinalPrice.ToString();
            label4.Text = shit.Data.Featured.Entries[1].Items[0].Name.ToUpper();
            label3.Text = shit.Data.Featured.Entries[1].FinalPrice.ToString();

            PrivateFontCollection modernFont = new PrivateFontCollection();
            modernFont.AddFontFile("LuckiestGuy-Regular.ttf");
            label1.Font = new Font(modernFont.Families[0], 16);
            label2.Font = new Font(modernFont.Families[0], 14);
            label4.Font = new Font(modernFont.Families[0], 16);
            label3.Font = new Font(modernFont.Families[0], 14);

            var request = WebRequest.Create(shit.Data.Featured.Entries[0].Items[0].Images.Icon);
            using (var response = request.GetResponse())
            using (var stream = response.GetResponseStream())
            {
                Image original = Bitmap.FromStream(stream);
                Image resized = new Bitmap(original, new Size(original.Width / 2, original.Height / 2));
                pictureBox1.Image = new Bitmap(resized);
                pictureBox1.BackgroundImage = Resources.legendaryRarity;
            }

            var request2 = WebRequest.Create(shit.Data.Featured.Entries[1].Items[0].Images.Icon);
            using (var response = request2.GetResponse())
            using (var stream2 = response.GetResponseStream())
            {
                Image original2 = Bitmap.FromStream(stream2);
                Image resized2 = new Bitmap(original2, new Size(original2.Width / 2, original2.Height / 2));
                pictureBox6.Image = new Bitmap(resized2);
                pictureBox6.BackgroundImage = Resources.epicRarity;
            }
        }

        void TransparetBackground(Control C)
        {
            C.Visible = false;
            C.Refresh();
            Application.DoEvents();
            Rectangle screenRectangle = RectangleToScreen(ClientRectangle);
            int titleHeight = screenRectangle.Top - Top;
            int Right = screenRectangle.Left - Left;
            Bitmap bmp = new Bitmap(Width, Height);
            DrawToBitmap(bmp, new Rectangle(0, 0, Width, Height));
            Bitmap bmpImage = new Bitmap(bmp);
            bmp = bmpImage.Clone(new Rectangle(C.Location.X + Right, C.Location.Y + titleHeight, C.Width, C.Height), bmpImage.PixelFormat);
            C.BackgroundImage = bmp;
            C.Visible = true;
        }

        private void ItemShop_Load(object sender, EventArgs e)
        {
            TransparetBackground(label1);
            TransparetBackground(label2);
            TransparetBackground(label4);
            TransparetBackground(label3);
        }
    }
}

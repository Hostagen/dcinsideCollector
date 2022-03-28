using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using HtmlAgilityPack;

namespace dcinside_collector
{
    public partial class GallerySelecter : MetroFramework.Forms.MetroForm
    {

        public string gallUrl = null;

        public GallerySelecter()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            rangeDatePicker.MaxDate = DateTime.Now;
            rangeDatePicker.Value = DateTime.Now;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            gallUrl = $"https://gall.dcinside.com/mgallery/board/lists?id={gallidTextBox.Text}";

            HtmlWeb web = new HtmlWeb
            {
                UserAgent = "dcinside.app"
            };
            HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(gallUrl);

            HtmlNode headNode = htmlDoc.DocumentNode.SelectSingleNode("//head");
            bool minorGallery = true;

            if (headNode == null)
            {
                minorGallery = false;
                gallUrl = $"https://gall.dcinside.com/board/lists?id={gallidTextBox.Text}";
                htmlDoc = web.Load(gallUrl);
                headNode = htmlDoc.DocumentNode.SelectSingleNode("//head");

                if (headNode == null)
                {
                    MessageBox.Show(
                        $"갤러리 ID {gallidTextBox.Text}는 운영원칙을 위반한 갤러리입니다.",
                        "경고",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;
                }
            }

            HtmlNode titleNode = headNode.SelectSingleNode("//meta[@name='title']");

            HtmlNode articleNode = htmlDoc.DocumentNode.SelectSingleNode("//article");
            HtmlNode infoBoxNode = articleNode.SelectSingleNode("//div[@class='info_contbox']");

            switch(minorGallery)
            {
                case true when infoBoxNode == null:
                    gallUrl = null;

                    MessageBox.Show(
                        $"갤러리 ID {gallidTextBox.Text}를 찾지 못했습니다.",
                        "경고",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );

                    return;

                case true when infoBoxNode != null:
                    HtmlNodeCollection infoContNodes = infoBoxNode.SelectNodes("//div[@class='info_cont']");

                    foreach (HtmlNode node in infoContNodes)
                    {
                        managerTextBox.Text += node.InnerText;
                    }

                    break;
            }

            gallNameBox.Text = titleNode.Attributes["content"].Value;
            gallIDBox.Text = gallidTextBox.Text;

            HtmlNode body = htmlDoc.DocumentNode.SelectSingleNode("//body");

            //HtmlNode gallInfoBox = body.SelectNodes("//a[@class='mintro_imgbox in_img ']");
            //string rawCoverImageHref = coverImageNode.Attributes["href"].Value;

            //string[] coverImageURL = rawCoverImageHref.Split('\'');
        }   

        private void gallIdTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitButton_Click(sender, e);
            }
        }

        private void gallLinkBtn_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gallUrl))
            {
                System.Diagnostics.Process.Start(gallUrl);
            }
        }

        private void gallIDBox_Click(object sender, EventArgs e)
        {

        }

        private void managerTextBox_Click(object sender, EventArgs e)
        {

        }

        private void conformButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string GallURL
        {
            get
            {
                return gallUrl;
            }
        }

        public DateTimePicker GetRange
        {
            get
            {
                return rangeDatePicker;
            }
        }
    }
}

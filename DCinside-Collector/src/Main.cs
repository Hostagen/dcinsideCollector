using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace dcinside_collector
{
    public partial class Main : MetroFramework.Forms.MetroForm
    {

        public string gallURL = "";

        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileChecker checkForm = new FileChecker();
            checkForm.ShowDialog();
        }

        private readonly Regex TIME_REGEX = new Regex(@"[0-9]{2}:[0-9]{2}");
        private readonly Regex YMD_REGEX = new Regex(@"[0-9]{2}.[0-9]{2}.[0-9]{2}");

        public DateTime ConverToDate(string datetime)
        {

            if (TIME_REGEX.IsMatch(datetime))
            {
                return DateTime.ParseExact(datetime, "HH:mm", null);
            }

            if (YMD_REGEX.IsMatch(datetime))
            {
                return DateTime.ParseExact(datetime, "yy.MM.dd", null);
            }

            return DateTime.ParseExact(datetime, "MM.dd", null);
        }

        private List<Article> getArticles(HtmlAgilityPack.HtmlDocument doc)
        {
            HtmlNodeCollection articleNodes = doc.DocumentNode.SelectNodes("//tbody/tr");

            List<Article> results = new List<Article>();

            foreach (HtmlNode node in articleNodes)
            {
                HtmlNode articleSubjectNode = node.SelectSingleNode("./td[@class='gall_subject']");
                string articleSubject = articleSubjectNode.InnerText;

                HtmlNode articleSubjectP = articleSubjectNode.SelectSingleNode("./p");

                if (articleSubjectP != null)
                {
                    articleSubject = articleSubjectP.InnerText;
                }

                if (articleSubject == "설문" || articleSubject == "공지" && disableAnnounCheckBox.Checked)
                {
                    continue;
                }

                HtmlNode articleNameNode = node.SelectSingleNode("td/a");
                string articleName = articleNameNode.InnerText;

                HtmlNode authorName = node.SelectSingleNode(".//span[@class='nickname']");

                if (authorName == null)
                {
                    authorName = node.SelectSingleNode(".//span[@class='nickname in']");
                }
                
                HtmlNode authorIP = node.SelectSingleNode(".//span[@class='ip']");

                HtmlNode dateNode = node.SelectSingleNode("./td[@class='gall_date']");
                DateTime articleDate = ConverToDate(dateNode.InnerText);

                Article result = new Article(
                    subject: articleSubject,
                    title: articleName,
                    owner: authorName.InnerText,
                    datetime: articleDate
                );

                if (authorIP == null)
                {
                    result.FixNickname = true;
                }

                else
                {
                    result.author = $"{result.author}{authorIP.InnerText}";
                }

                results.Add(result);
            }

            return results;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            GallerySelecter newFrom = new GallerySelecter();
            newFrom.ShowDialog();
            gallURL = newFrom.gallUrl;

            if (gallURL == "" || gallURL == null)
            {
                return;
            }

            string baseURL = "{0}&list_num=100&page={1}";

            articleDataGrid.Rows.Clear();

            HtmlWeb web = new HtmlWeb();

            DateTime getRangeDate = newFrom.GetRange.Value;

            int i;

            for (i = 1; ; i++)
            {

                if (newFrom.PageLimit != 0 && i > newFrom.PageLimit)
                {
                    break;
                }

                string url = String.Format(baseURL, gallURL, i.ToString());
                HtmlAgilityPack.HtmlDocument htmlDoc = web.Load(url);

                if (web.ResponseUri.ToString() != url)
                {
                    break;
                }

                List<Article> articles = getArticles(htmlDoc);
                Article lastArticle = articles.Last();

                if (
                    !articles.Any() || 
                    lastArticle.Created_at.Year != getRangeDate.Year || 
                    lastArticle.Created_at.Month != getRangeDate.Month
                    )
                {
                    break;
                }

                foreach (Article article in articles)
                {
                    articleDataGrid.Rows.Add(article.Category, article.Name, article.author, article.Created_at);
                }
            }
        }
    }
    class Article
    {
        public string Category;
        public string Name;
        public string author;
        public DateTime Created_at;
        public bool FixNickname;

        public Article(
            string subject,
            string title,
            string owner,
            DateTime datetime,
            bool fix = false
            )
        {
            Category = subject;
            Name = title;
            author = owner;
            Created_at = datetime;
            FixNickname = fix;
        }
    }
}

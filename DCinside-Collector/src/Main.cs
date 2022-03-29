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

                HtmlNode articleNum = node.SelectSingleNode("./td[@class='gall_num']");

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

                HtmlNode replyNode = node.SelectSingleNode(".//span[@class='reply_num']");

                Article result = new Article(
                    articleNumber: articleNum.InnerText,
                    subject: articleSubject,
                    title: articleName,
                    owner: authorName.InnerText,
                    datetime: articleDate,
                    commentCount: 0
                );

                if (authorIP == null)
                {
                    result.FixNickname = true;
                }

                else
                {
                    result.Author = $"{result.Author}{authorIP.InnerText}";
                }

                if (replyNode != null)
                {
                    string stringReplyCount = Regex.Replace(replyNode.InnerText, @"[^0-9]", "");
                    result.CommentCount = int.Parse(stringReplyCount);
                }

                results.Add(result);
            }

            return results;
        }

        private Dictionary<string, Article> Articles = new Dictionary<string, Article>() { };

        private void metroButton1_Click(object sender, EventArgs e)
        {
            GallerySelecter newFrom = new GallerySelecter();

            if (newFrom.ShowDialog() == DialogResult.OK) { 
                gallURL = newFrom.gallUrl;

                string baseURL = "{0}&list_num=100&page={1}";

                articleDataGrid.Rows.Clear();

                HtmlWeb web = new HtmlWeb();

                DateTime getRangeDate = newFrom.EndDatePicker.Value;

                Articles.Clear();

                for (int i = 1; ; i++)
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
                        Articles.Add(article.GallNum, article);

                        articleDataGrid.Rows.Add(
                            article.Category,
                            article.Name,
                            article.Author,
                            article.Created_at,
                            article.CommentCount
                        );
                    }
                }
            }
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            if (htmlOutputFolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                HtmlAgilityPack.HtmlDocument outputDoc = new HtmlAgilityPack.HtmlDocument();

                var commentCountSpan = HtmlNode.CreateNode("<p><span style='font-size: 36pt;'>댓글 수 기준</span></p>");
                outputDoc.DocumentNode.AppendChild(commentCountSpan);

                Dictionary<Article, int> replyCount = new Dictionary<Article, int>();

                foreach (KeyValuePair<string, Article> item in Articles)
                {
                    replyCount.Add(item.Value, item.Value.CommentCount);
                }

                var sortedDict = from entry in replyCount orderby entry.Value descending select entry;

                int i = 0;

                HtmlNode brNode = HtmlNode.CreateNode("<br />");

                foreach (var entry in sortedDict)
                {
                    i += 1;

                    string href = $"{gallURL}&no={entry.Key.GallNum}";

                    Article article = entry.Key;

                    string paragraph = String.Format(
                        @"
                        <p>
                            <a href='{0}' target='_blank' class='tx-link'>
                                {1}. {2} / 달린 댓글 수 {3} / 작성자: {4}
                            </a>
                        </p>",
                        href,
                        i,
                        article.Name,
                        article.CommentCount,
                        article.Author
                    );

                    HtmlNode commentCountParagraph = HtmlNode.CreateNode(paragraph);

                    Console.WriteLine(paragraph);

                    outputDoc.DocumentNode.AppendChild(commentCountParagraph);

                    if (i >= 100)
                    {
                        break;
                    }
                }

                string fileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
                outputDoc.Save(htmlOutputFolderBrowserDialog.SelectedPath + String.Format(@"\{0}.html", fileName));
            }
        }
    }

    class Article
    {
        public string GallNum;
        public string Category;
        public string Name;
        public string Author;
        public DateTime Created_at;
        public int CommentCount;
        public bool FixNickname;

        public Article(
            string articleNumber,
            string subject,
            string title,
            string owner,
            DateTime datetime,
            int commentCount,
            bool fix = false
            )
        {
            GallNum = articleNumber;
            Category = subject;
            Name = title;
            Author = owner;
            Created_at = datetime;
            FixNickname = fix;
            CommentCount = commentCount;
        }
    }
}

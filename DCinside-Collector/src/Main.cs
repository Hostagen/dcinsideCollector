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
            //FileChecker checkForm = new FileChecker();
            //checkForm.ShowDialog();
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

        private readonly Regex REPLY_REGEX = new Regex(@"\[(.+)\]");

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

                HtmlNode viewNode = node.SelectSingleNode("./td[@class='gall_count']");
                HtmlNode recommendNode = node.SelectSingleNode("./td[@class='gall_recommend']");

                Article result = new Article(
                    articleNumber: articleNum.InnerText,
                    subject: articleSubject,
                    title: articleName,
                    owner: authorName.InnerText,
                    datetime: articleDate,
                    commentCount: 0,
                    views: int.Parse(viewNode.InnerText),
                    recommend: int.Parse(recommendNode.InnerText)
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
                    string stringReplyCount = REPLY_REGEX.Match(replyNode.InnerText).Groups[1].Value;

                    string[] replyCountSplit = stringReplyCount.Split(new string[] { "/" }, StringSplitOptions.None);

                    result.CommentCount = int.Parse(replyCountSplit[0]);
                }

                results.Add(result);
            }

            return results;
        }

        private Dictionary<string, Article> Articles = new Dictionary<string, Article>() { };

        private void loadGalleryButton_Click(object sender, EventArgs e)
        {
            GallerySelecter selecterForm = new GallerySelecter();

            if (selecterForm.ShowDialog() == DialogResult.OK) { 
                gallURL = selecterForm.gallUrl;

                string baseURL = "{0}&list_num=100&page={1}";

                articleDataGrid.Rows.Clear();

                HtmlWeb web = new HtmlWeb();

                DateTime startDatePickerValue = selecterForm.StartDatePicker.Value;
                DateTime endDatePickerValue = selecterForm.EndDatePicker.Value;

                Articles.Clear();


                for (int i = 1; ; i++)
                {

                    if (selecterForm.PageLimit != 0 && i > selecterForm.PageLimit)
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

                    if (!articles.Any())
                    {
                        break;
                    }

                    foreach (Article article in articles)
                    {
                        if (startDatePickerValue <= article.Created_at)
                        {
                            continue;
                        }

                        if (article.Created_at < endDatePickerValue)
                        {
                            break;
                        }

                        try
                        {
                            Articles.Add(article.GallNum, article);
                        }

                        catch(Exception)
                        {
                            continue;
                        }

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
            if (!Articles.Any())
            {
                MessageBox.Show(
                    "선택된 글이 아무것도 없습니다.",
                    "알림",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                return;
            }

            string fileName = DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss");
            htmlSaveDialog.FileName = fileName;

            if (htmlSaveDialog.ShowDialog() == DialogResult.OK)
            {
                HtmlAgilityPack.HtmlDocument outputDoc = new HtmlAgilityPack.HtmlDocument();
                HtmlNode brNode = HtmlNode.CreateNode("<div><br></div>");

                var commentCountSpan = HtmlNode.CreateNode("<p><span style='font-size: 36pt;'>댓글 수 기준</span></p>");
                outputDoc.DocumentNode.AppendChild(commentCountSpan);

                Dictionary<Article, int> replyCount = new Dictionary<Article, int>();

                foreach (KeyValuePair<string, Article> item in Articles)
                {
                    replyCount.Add(item.Value, item.Value.CommentCount);
                }

                var sortedDict = from entry in replyCount orderby entry.Value descending select entry;

                int i = 0;

                foreach (var entry in sortedDict)
                {
                    i += 1;

                    string href = $"{gallURL}&no={entry.Key.GallNum}";

                    Article article = entry.Key;

                    string paragraph = String.Format(
                        @"
                        <p>
                            <a href='{0}' target='_blank' class='tx-link'>
                                {1}. {2} / 달린 댓글 수: {3} / 작성자: {4}
                            </a>
                        </p>",
                        href,
                        i,
                        article.Name,
                        article.CommentCount,
                        article.Author
                    );

                    HtmlNode commentCountParagraph = HtmlNode.CreateNode(paragraph);

                    outputDoc.DocumentNode.AppendChild(commentCountParagraph);

                    if (i >= 100)
                    {
                        break;
                    }
                }
                
                for (i = 0; i > 3; i++)
                {
                    outputDoc.DocumentNode.AppendChild(brNode);
                }

                var recommendRankSpan = HtmlNode.CreateNode("<p><span style='font-size: 36pt;'>추천 수 기준</span></p>");
                outputDoc.DocumentNode.AppendChild(recommendRankSpan);

                Dictionary<Article, int> recommentRank = new Dictionary<Article, int>();

                foreach (KeyValuePair<string, Article> item in Articles)
                {
                    recommentRank.Add(item.Value, item.Value.Recommend);
                }

                sortedDict = from entry in recommentRank orderby entry.Value descending select entry;

                i = 0;

                foreach (var entry in sortedDict)
                {
                    i += 1;

                    string href = $"{gallURL}&no={entry.Key.GallNum}";

                    Article article = entry.Key;

                    string paragraph = String.Format(
                        @"
                        <p>
                            <a href='{0}' target='_blank' class='tx-link'>
                                {1}. {2} / 추천 수: {3} / 작성자: {4}
                            </a>
                        </p>",
                        href,
                        i,
                        article.Name,
                        article.Recommend,
                        article.Author
                    );

                    HtmlNode commentCountParagraph = HtmlNode.CreateNode(paragraph);

                    outputDoc.DocumentNode.AppendChild(commentCountParagraph);

                    if (i >= 100)
                    {
                        break;
                    }
                }

                for (i = 0; i > 3; i++)
                {
                    outputDoc.DocumentNode.AppendChild(brNode);
                }

                var viewRankSpan = HtmlNode.CreateNode("<p><span style='font-size: 36pt;'>조회수 기준</span></p>");
                outputDoc.DocumentNode.AppendChild(viewRankSpan);

                Dictionary<Article, int> viewRank = new Dictionary<Article, int>();

                foreach (KeyValuePair<string, Article> item in Articles)
                {
                    viewRank.Add(item.Value, item.Value.Views);
                }

                sortedDict = from entry in viewRank orderby entry.Value descending select entry;

                i = 0;

                foreach (var entry in sortedDict)
                {
                    i += 1;

                    string href = $"{gallURL}&no={entry.Key.GallNum}";

                    Article article = entry.Key;

                    string paragraph = String.Format(
                        @"
                        <p>
                            <a href='{0}' target='_blank' class='tx-link'>
                                {1}. {2} / 조회수: {3} / 작성자: {4}
                            </a>
                        </p>",
                        href,
                        i,
                        article.Name,
                        article.Views,
                        article.Author
                    );

                    HtmlNode commentCountParagraph = HtmlNode.CreateNode(paragraph);

                    outputDoc.DocumentNode.AppendChild(commentCountParagraph);

                    if (i >= 100)
                    {
                        break;
                    }
                }

                outputDoc.Save(htmlSaveDialog.FileName.ToString());
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
        public int Recommend;
        public int Views;

        public Article(
            string articleNumber,
            string subject,
            string title,
            string owner,
            DateTime datetime,
            int commentCount,
            bool fix = false,
            int recommend = 0,
            int views = 0
            )
        {
            GallNum = articleNumber;
            Category = subject;
            Name = title;
            Author = owner;
            Created_at = datetime;
            FixNickname = fix;
            CommentCount = commentCount;
            Recommend = recommend;
            Views = views;
        }
    }
}

using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Data.SQLite;

namespace dcinside_collector
{
    public partial class FileChecker : MetroFramework.Forms.MetroForm
    {
        public FileChecker()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = "디렉토리 확인 중...";

            List<string> dirPathList = new List<string>
            {
                "data",
            };

            progressSpinner.Maximum = dirPathList.Count;

            foreach (string path in dirPathList)
            {
                string dirPath = Application.StartupPath + $"\\{path}";
                DirectoryInfo dir = Directory.CreateDirectory(dirPath);

                if (!dir.Exists)
                {
                    dir.Create();
                };

                progressSpinner.Value += 1;
            }

            string sqliteDir = Application.StartupPath + "\\data\\collector.db";

            if (!File.Exists(sqliteDir))
            {
                SQLiteConnection.CreateFile(sqliteDir);
                SQLiteConnection connection = new SQLiteConnection($"Data Source={sqliteDir};Version=3;");
                connection.Open();

                string basePath = $"{Application.StartupPath}\\sql";

                string articleTableSQL = File.ReadAllText($"{basePath}\\createArticle.sql");
                SQLiteCommand command = new SQLiteCommand(articleTableSQL, connection);
                command.ExecuteNonQuery();

                connection.Close();
            }

            Close();
        }
    }
}

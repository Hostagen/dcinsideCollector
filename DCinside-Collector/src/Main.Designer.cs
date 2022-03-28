namespace dcinside_collector
{
    partial class Main
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.LoadGallButton1 = new MetroFramework.Controls.MetroButton();
            this.disableAnnounCheckBox = new System.Windows.Forms.CheckBox();
            this.articleDataGrid = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReplyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.htmlOutputFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // LoadGallButton1
            // 
            resources.ApplyResources(this.LoadGallButton1, "LoadGallButton1");
            this.LoadGallButton1.Name = "LoadGallButton1";
            this.LoadGallButton1.UseSelectable = true;
            this.LoadGallButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // disableAnnounCheckBox
            // 
            resources.ApplyResources(this.disableAnnounCheckBox, "disableAnnounCheckBox");
            this.disableAnnounCheckBox.Checked = true;
            this.disableAnnounCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disableAnnounCheckBox.Name = "disableAnnounCheckBox";
            this.disableAnnounCheckBox.UseVisualStyleBackColor = true;
            // 
            // articleDataGrid
            // 
            this.articleDataGrid.AllowUserToAddRows = false;
            this.articleDataGrid.AllowUserToResizeColumns = false;
            this.articleDataGrid.AllowUserToResizeRows = false;
            this.articleDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.articleDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.title,
            this.author,
            this.date,
            this.ReplyColumn});
            resources.ApplyResources(this.articleDataGrid, "articleDataGrid");
            this.articleDataGrid.Name = "articleDataGrid";
            this.articleDataGrid.ReadOnly = true;
            this.articleDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.articleDataGrid.RowHeadersVisible = false;
            this.articleDataGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.articleDataGrid.RowTemplate.Height = 23;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 55.3512F;
            resources.ApplyResources(this.Column1, "Column1");
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // title
            // 
            this.title.FillWeight = 82.04168F;
            resources.ApplyResources(this.title, "title");
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // author
            // 
            this.author.FillWeight = 73.72312F;
            resources.ApplyResources(this.author, "author");
            this.author.Name = "author";
            this.author.ReadOnly = true;
            // 
            // date
            // 
            this.date.FillWeight = 82.04168F;
            resources.ApplyResources(this.date, "date");
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // ReplyColumn
            // 
            this.ReplyColumn.FillWeight = 35F;
            resources.ApplyResources(this.ReplyColumn, "ReplyColumn");
            this.ReplyColumn.Name = "ReplyColumn";
            this.ReplyColumn.ReadOnly = true;
            // 
            // metroButton1
            // 
            resources.ApplyResources(this.metroButton1, "metroButton1");
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click_1);
            // 
            // Main
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.articleDataGrid);
            this.Controls.Add(this.disableAnnounCheckBox);
            this.Controls.Add(this.LoadGallButton1);
            this.Name = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.articleDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroButton LoadGallButton1;
        private System.Windows.Forms.CheckBox disableAnnounCheckBox;
        private System.Windows.Forms.DataGridView articleDataGrid;
        private MetroFramework.Controls.MetroButton metroButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ReplyColumn;
        private System.Windows.Forms.FolderBrowserDialog htmlOutputFolderBrowserDialog;
    }
}


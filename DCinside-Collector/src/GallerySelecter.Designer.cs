namespace dcinside_collector
{
    partial class GallerySelecter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GallerySelecter));
            this.submitButton = new MetroFramework.Controls.MetroButton();
            this.gallidTextBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gallNameLabel = new MetroFramework.Controls.MetroLabel();
            this.pageNumberLimit = new System.Windows.Forms.NumericUpDown();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.gallNameBox = new MetroFramework.Controls.MetroTextBox();
            this.gallIDBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.subMangerBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.endDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.gallLinkBtn = new MetroFramework.Controls.MetroLink();
            this.conformButton = new MetroFramework.Controls.MetroButton();
            this.mangerNameBox = new MetroFramework.Controls.MetroTextBox();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberLimit)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(415, 63);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(108, 23);
            this.submitButton.TabIndex = 0;
            this.submitButton.Text = "검색";
            this.submitButton.UseSelectable = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // gallidTextBox
            // 
            // 
            // 
            // 
            this.gallidTextBox.CustomButton.Image = null;
            this.gallidTextBox.CustomButton.Location = new System.Drawing.Point(364, 1);
            this.gallidTextBox.CustomButton.Name = "";
            this.gallidTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gallidTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gallidTextBox.CustomButton.TabIndex = 1;
            this.gallidTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gallidTextBox.CustomButton.UseSelectable = true;
            this.gallidTextBox.CustomButton.Visible = false;
            this.gallidTextBox.ForeColor = System.Drawing.Color.DarkGray;
            this.gallidTextBox.Lines = new string[] {
        "갤러리 ID를 입력"};
            this.gallidTextBox.Location = new System.Drawing.Point(23, 63);
            this.gallidTextBox.MaxLength = 32767;
            this.gallidTextBox.Name = "gallidTextBox";
            this.gallidTextBox.PasswordChar = '\0';
            this.gallidTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gallidTextBox.SelectedText = "";
            this.gallidTextBox.SelectionLength = 0;
            this.gallidTextBox.SelectionStart = 0;
            this.gallidTextBox.ShortcutsEnabled = true;
            this.gallidTextBox.Size = new System.Drawing.Size(386, 23);
            this.gallidTextBox.TabIndex = 1;
            this.gallidTextBox.Text = "갤러리 ID를 입력";
            this.gallidTextBox.UseSelectable = true;
            this.gallidTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gallidTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.gallidTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.gallIdTextBox_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(23, 92);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 239);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "갤러리 정보";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gallNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pageNumberLimit, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel5, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel4, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.startDatePicker, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.mangerNameBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.gallNameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gallIDBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel6, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.endDateTimePicker, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.subMangerBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(488, 194);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // gallNameLabel
            // 
            this.gallNameLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.gallNameLabel.AutoSize = true;
            this.gallNameLabel.Location = new System.Drawing.Point(3, 5);
            this.gallNameLabel.Name = "gallNameLabel";
            this.gallNameLabel.Size = new System.Drawing.Size(37, 19);
            this.gallNameLabel.TabIndex = 0;
            this.gallNameLabel.Text = "이름";
            // 
            // pageNumberLimit
            // 
            this.pageNumberLimit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pageNumberLimit.Location = new System.Drawing.Point(92, 116);
            this.pageNumberLimit.Name = "pageNumberLimit";
            this.pageNumberLimit.Size = new System.Drawing.Size(393, 21);
            this.pageNumberLimit.TabIndex = 10;
            // 
            // metroLabel5
            // 
            this.metroLabel5.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(3, 144);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(69, 19);
            this.metroLabel5.TabIndex = 11;
            this.metroLabel5.Text = "시작 날짜";
            // 
            // metroLabel4
            // 
            this.metroLabel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(3, 117);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(83, 19);
            this.metroLabel4.TabIndex = 11;
            this.metroLabel4.Text = "최대 페이지";
            // 
            // startDatePicker
            // 
            this.startDatePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.startDatePicker.CustomFormat = "yyyy-MM";
            this.startDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.startDatePicker.Location = new System.Drawing.Point(92, 143);
            this.startDatePicker.MaxDate = new System.DateTime(2022, 3, 24, 0, 0, 0, 0);
            this.startDatePicker.MinDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.ShowUpDown = true;
            this.startDatePicker.Size = new System.Drawing.Size(393, 21);
            this.startDatePicker.TabIndex = 8;
            this.startDatePicker.Value = new System.DateTime(2022, 3, 24, 0, 0, 0, 0);
            // 
            // gallNameBox
            // 
            this.gallNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.gallNameBox.CustomButton.Image = null;
            this.gallNameBox.CustomButton.Location = new System.Drawing.Point(371, 1);
            this.gallNameBox.CustomButton.Name = "";
            this.gallNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gallNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gallNameBox.CustomButton.TabIndex = 1;
            this.gallNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gallNameBox.CustomButton.UseSelectable = true;
            this.gallNameBox.CustomButton.Visible = false;
            this.gallNameBox.Enabled = false;
            this.gallNameBox.Lines = new string[0];
            this.gallNameBox.Location = new System.Drawing.Point(92, 3);
            this.gallNameBox.MaxLength = 32767;
            this.gallNameBox.Name = "gallNameBox";
            this.gallNameBox.PasswordChar = '\0';
            this.gallNameBox.ReadOnly = true;
            this.gallNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gallNameBox.SelectedText = "";
            this.gallNameBox.SelectionLength = 0;
            this.gallNameBox.SelectionStart = 0;
            this.gallNameBox.ShortcutsEnabled = true;
            this.gallNameBox.Size = new System.Drawing.Size(393, 23);
            this.gallNameBox.TabIndex = 1;
            this.gallNameBox.UseSelectable = true;
            this.gallNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gallNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gallIDBox
            // 
            this.gallIDBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.gallIDBox.CustomButton.Image = null;
            this.gallIDBox.CustomButton.Location = new System.Drawing.Point(371, 1);
            this.gallIDBox.CustomButton.Name = "";
            this.gallIDBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gallIDBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gallIDBox.CustomButton.TabIndex = 1;
            this.gallIDBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gallIDBox.CustomButton.UseSelectable = true;
            this.gallIDBox.CustomButton.Visible = false;
            this.gallIDBox.Enabled = false;
            this.gallIDBox.Lines = new string[0];
            this.gallIDBox.Location = new System.Drawing.Point(92, 32);
            this.gallIDBox.MaxLength = 32767;
            this.gallIDBox.Name = "gallIDBox";
            this.gallIDBox.PasswordChar = '\0';
            this.gallIDBox.ReadOnly = true;
            this.gallIDBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gallIDBox.SelectedText = "";
            this.gallIDBox.SelectionLength = 0;
            this.gallIDBox.SelectionStart = 0;
            this.gallIDBox.ShortcutsEnabled = true;
            this.gallIDBox.Size = new System.Drawing.Size(393, 23);
            this.gallIDBox.TabIndex = 3;
            this.gallIDBox.UseSelectable = true;
            this.gallIDBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gallIDBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 34);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID";
            // 
            // metroLabel2
            // 
            this.metroLabel2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 90);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "부매니저";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 63);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "매니저";
            // 
            // subMangerBox
            // 
            this.subMangerBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.subMangerBox.CustomButton.Image = null;
            this.subMangerBox.CustomButton.Location = new System.Drawing.Point(375, 2);
            this.subMangerBox.CustomButton.Name = "";
            this.subMangerBox.CustomButton.Size = new System.Drawing.Size(15, 15);
            this.subMangerBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.subMangerBox.CustomButton.TabIndex = 1;
            this.subMangerBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.subMangerBox.CustomButton.UseSelectable = true;
            this.subMangerBox.CustomButton.Visible = false;
            this.subMangerBox.Enabled = false;
            this.subMangerBox.Lines = new string[0];
            this.subMangerBox.Location = new System.Drawing.Point(92, 90);
            this.subMangerBox.MaxLength = 32767;
            this.subMangerBox.Name = "subMangerBox";
            this.subMangerBox.PasswordChar = '\0';
            this.subMangerBox.ReadOnly = true;
            this.subMangerBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.subMangerBox.SelectedText = "";
            this.subMangerBox.SelectionLength = 0;
            this.subMangerBox.SelectionStart = 0;
            this.subMangerBox.ShortcutsEnabled = true;
            this.subMangerBox.Size = new System.Drawing.Size(393, 20);
            this.subMangerBox.TabIndex = 7;
            this.subMangerBox.UseSelectable = true;
            this.subMangerBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.subMangerBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(3, 171);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(83, 19);
            this.metroLabel6.TabIndex = 11;
            this.metroLabel6.Text = "끝나는 날짜";
            // 
            // endDateTimePicker
            // 
            this.endDateTimePicker.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.endDateTimePicker.CustomFormat = "yyyy-MM";
            this.endDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.endDateTimePicker.Location = new System.Drawing.Point(92, 170);
            this.endDateTimePicker.MaxDate = new System.DateTime(2022, 3, 30, 0, 0, 0, 0);
            this.endDateTimePicker.MinDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.endDateTimePicker.Name = "endDateTimePicker";
            this.endDateTimePicker.ShowUpDown = true;
            this.endDateTimePicker.Size = new System.Drawing.Size(393, 21);
            this.endDateTimePicker.TabIndex = 8;
            this.endDateTimePicker.Value = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            // 
            // gallLinkBtn
            // 
            this.gallLinkBtn.Location = new System.Drawing.Point(415, 337);
            this.gallLinkBtn.Name = "gallLinkBtn";
            this.gallLinkBtn.Size = new System.Drawing.Size(108, 23);
            this.gallLinkBtn.TabIndex = 8;
            this.gallLinkBtn.Text = "바로가기";
            this.gallLinkBtn.UseSelectable = true;
            this.gallLinkBtn.Click += new System.EventHandler(this.gallLinkBtn_Click);
            // 
            // conformButton
            // 
            this.conformButton.Location = new System.Drawing.Point(23, 337);
            this.conformButton.Name = "conformButton";
            this.conformButton.Size = new System.Drawing.Size(386, 23);
            this.conformButton.TabIndex = 3;
            this.conformButton.Text = "확인";
            this.conformButton.UseSelectable = true;
            this.conformButton.Click += new System.EventHandler(this.conformButton_Click);
            // 
            // mangerNameBox
            // 
            this.mangerNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            // 
            // 
            // 
            this.mangerNameBox.CustomButton.Image = null;
            this.mangerNameBox.CustomButton.Location = new System.Drawing.Point(371, 1);
            this.mangerNameBox.CustomButton.Name = "";
            this.mangerNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.mangerNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.mangerNameBox.CustomButton.TabIndex = 1;
            this.mangerNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.mangerNameBox.CustomButton.UseSelectable = true;
            this.mangerNameBox.CustomButton.Visible = false;
            this.mangerNameBox.Enabled = false;
            this.mangerNameBox.Lines = new string[0];
            this.mangerNameBox.Location = new System.Drawing.Point(92, 61);
            this.mangerNameBox.MaxLength = 32767;
            this.mangerNameBox.Name = "mangerNameBox";
            this.mangerNameBox.PasswordChar = '\0';
            this.mangerNameBox.ReadOnly = true;
            this.mangerNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.mangerNameBox.SelectedText = "";
            this.mangerNameBox.SelectionLength = 0;
            this.mangerNameBox.SelectionStart = 0;
            this.mangerNameBox.ShortcutsEnabled = true;
            this.mangerNameBox.Size = new System.Drawing.Size(393, 23);
            this.mangerNameBox.TabIndex = 1;
            this.mangerNameBox.UseSelectable = true;
            this.mangerNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.mangerNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // GallerySelecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 383);
            this.Controls.Add(this.conformButton);
            this.Controls.Add(this.gallLinkBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gallidTextBox);
            this.Controls.Add(this.submitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GallerySelecter";
            this.Text = "Find Gallery";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pageNumberLimit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton submitButton;
        private MetroFramework.Controls.MetroTextBox gallidTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox subMangerBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink gallLinkBtn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel gallNameLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox gallNameBox;
        private MetroFramework.Controls.MetroTextBox gallIDBox;
        private MetroFramework.Controls.MetroButton conformButton;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private System.Windows.Forms.NumericUpDown pageNumberLimit;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private System.Windows.Forms.DateTimePicker endDateTimePicker;
        private MetroFramework.Controls.MetroTextBox mangerNameBox;
    }
}
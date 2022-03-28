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
            this.gallNameBox = new MetroFramework.Controls.MetroTextBox();
            this.gallIDBox = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.subMangersBox = new MetroFramework.Controls.MetroListView();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.managerTextBox = new MetroFramework.Controls.MetroTextBox();
            this.coverImageBox = new System.Windows.Forms.PictureBox();
            this.gallLinkBtn = new MetroFramework.Controls.MetroLink();
            this.rangeDatePicker = new System.Windows.Forms.DateTimePicker();
            this.conformButton = new MetroFramework.Controls.MetroButton();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImageBox)).BeginInit();
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
            this.groupBox1.Controls.Add(this.coverImageBox);
            this.groupBox1.Controls.Add(this.gallLinkBtn);
            this.groupBox1.Controls.Add(this.rangeDatePicker);
            this.groupBox1.Location = new System.Drawing.Point(23, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(500, 212);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "갤러리 정보";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CausesValidation = false;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.gallNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.gallNameBox, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.gallIDBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.subMangersBox, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel2, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.metroLabel3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.managerTextBox, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(6, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(204, 117);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // gallNameLabel
            // 
            this.gallNameLabel.AutoSize = true;
            this.gallNameLabel.Location = new System.Drawing.Point(3, 0);
            this.gallNameLabel.Name = "gallNameLabel";
            this.gallNameLabel.Size = new System.Drawing.Size(37, 19);
            this.gallNameLabel.TabIndex = 0;
            this.gallNameLabel.Text = "이름";
            // 
            // gallNameBox
            // 
            // 
            // 
            // 
            this.gallNameBox.CustomButton.Image = null;
            this.gallNameBox.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.gallNameBox.CustomButton.Name = "";
            this.gallNameBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gallNameBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gallNameBox.CustomButton.TabIndex = 1;
            this.gallNameBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gallNameBox.CustomButton.UseSelectable = true;
            this.gallNameBox.CustomButton.Visible = false;
            this.gallNameBox.Enabled = false;
            this.gallNameBox.Lines = new string[0];
            this.gallNameBox.Location = new System.Drawing.Point(74, 3);
            this.gallNameBox.MaxLength = 32767;
            this.gallNameBox.Name = "gallNameBox";
            this.gallNameBox.PasswordChar = '\0';
            this.gallNameBox.ReadOnly = true;
            this.gallNameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gallNameBox.SelectedText = "";
            this.gallNameBox.SelectionLength = 0;
            this.gallNameBox.SelectionStart = 0;
            this.gallNameBox.ShortcutsEnabled = true;
            this.gallNameBox.Size = new System.Drawing.Size(122, 23);
            this.gallNameBox.TabIndex = 1;
            this.gallNameBox.UseSelectable = true;
            this.gallNameBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gallNameBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // gallIDBox
            // 
            // 
            // 
            // 
            this.gallIDBox.CustomButton.Image = null;
            this.gallIDBox.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.gallIDBox.CustomButton.Name = "";
            this.gallIDBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.gallIDBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.gallIDBox.CustomButton.TabIndex = 1;
            this.gallIDBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.gallIDBox.CustomButton.UseSelectable = true;
            this.gallIDBox.CustomButton.Visible = false;
            this.gallIDBox.Enabled = false;
            this.gallIDBox.Lines = new string[0];
            this.gallIDBox.Location = new System.Drawing.Point(74, 32);
            this.gallIDBox.MaxLength = 32767;
            this.gallIDBox.Name = "gallIDBox";
            this.gallIDBox.PasswordChar = '\0';
            this.gallIDBox.ReadOnly = true;
            this.gallIDBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gallIDBox.SelectedText = "";
            this.gallIDBox.SelectionLength = 0;
            this.gallIDBox.SelectionStart = 0;
            this.gallIDBox.ShortcutsEnabled = true;
            this.gallIDBox.Size = new System.Drawing.Size(122, 23);
            this.gallIDBox.TabIndex = 3;
            this.gallIDBox.UseSelectable = true;
            this.gallIDBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.gallIDBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(3, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(21, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "ID";
            // 
            // subMangersBox
            // 
            this.subMangersBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.subMangersBox.FullRowSelect = true;
            this.subMangersBox.Location = new System.Drawing.Point(74, 61);
            this.subMangersBox.Name = "subMangersBox";
            this.subMangersBox.OwnerDraw = true;
            this.subMangersBox.Size = new System.Drawing.Size(121, 24);
            this.subMangersBox.TabIndex = 4;
            this.subMangersBox.UseCompatibleStateImageBehavior = false;
            this.subMangersBox.UseSelectable = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(3, 88);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(65, 19);
            this.metroLabel2.TabIndex = 5;
            this.metroLabel2.Text = "부매니저";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(3, 58);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "매니저";
            // 
            // managerTextBox
            // 
            // 
            // 
            // 
            this.managerTextBox.CustomButton.Image = null;
            this.managerTextBox.CustomButton.Location = new System.Drawing.Point(100, 1);
            this.managerTextBox.CustomButton.Name = "";
            this.managerTextBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.managerTextBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.managerTextBox.CustomButton.TabIndex = 1;
            this.managerTextBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.managerTextBox.CustomButton.UseSelectable = true;
            this.managerTextBox.CustomButton.Visible = false;
            this.managerTextBox.Enabled = false;
            this.managerTextBox.Lines = new string[0];
            this.managerTextBox.Location = new System.Drawing.Point(74, 91);
            this.managerTextBox.MaxLength = 32767;
            this.managerTextBox.Name = "managerTextBox";
            this.managerTextBox.PasswordChar = '\0';
            this.managerTextBox.ReadOnly = true;
            this.managerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.managerTextBox.SelectedText = "";
            this.managerTextBox.SelectionLength = 0;
            this.managerTextBox.SelectionStart = 0;
            this.managerTextBox.ShortcutsEnabled = true;
            this.managerTextBox.Size = new System.Drawing.Size(122, 23);
            this.managerTextBox.TabIndex = 7;
            this.managerTextBox.UseSelectable = true;
            this.managerTextBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.managerTextBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // coverImageBox
            // 
            this.coverImageBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.coverImageBox.Location = new System.Drawing.Point(324, 20);
            this.coverImageBox.Name = "coverImageBox";
            this.coverImageBox.Size = new System.Drawing.Size(170, 107);
            this.coverImageBox.TabIndex = 3;
            this.coverImageBox.TabStop = false;
            // 
            // gallLinkBtn
            // 
            this.gallLinkBtn.Location = new System.Drawing.Point(9, 183);
            this.gallLinkBtn.Name = "gallLinkBtn";
            this.gallLinkBtn.Size = new System.Drawing.Size(485, 23);
            this.gallLinkBtn.TabIndex = 8;
            this.gallLinkBtn.Text = "바로가기";
            this.gallLinkBtn.UseSelectable = true;
            this.gallLinkBtn.Click += new System.EventHandler(this.gallLinkBtn_Click);
            // 
            // rangeDatePicker
            // 
            this.rangeDatePicker.CustomFormat = "yyyy-MM";
            this.rangeDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.rangeDatePicker.Location = new System.Drawing.Point(6, 143);
            this.rangeDatePicker.MaxDate = new System.DateTime(2022, 3, 24, 0, 0, 0, 0);
            this.rangeDatePicker.MinDate = new System.DateTime(1999, 12, 31, 0, 0, 0, 0);
            this.rangeDatePicker.Name = "rangeDatePicker";
            this.rangeDatePicker.ShowUpDown = true;
            this.rangeDatePicker.Size = new System.Drawing.Size(204, 21);
            this.rangeDatePicker.TabIndex = 8;
            this.rangeDatePicker.Value = new System.DateTime(2022, 3, 24, 0, 0, 0, 0);
            // 
            // conformButton
            // 
            this.conformButton.Location = new System.Drawing.Point(23, 337);
            this.conformButton.Name = "conformButton";
            this.conformButton.Size = new System.Drawing.Size(500, 23);
            this.conformButton.TabIndex = 3;
            this.conformButton.Text = "확인";
            this.conformButton.UseSelectable = true;
            this.conformButton.Click += new System.EventHandler(this.conformButton_Click);
            // 
            // GallerySelecter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 383);
            this.Controls.Add(this.conformButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gallidTextBox);
            this.Controls.Add(this.submitButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GallerySelecter";
            this.Text = "Find Gallery";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroButton submitButton;
        private MetroFramework.Controls.MetroTextBox gallidTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private MetroFramework.Controls.MetroTextBox managerTextBox;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLink gallLinkBtn;
        private System.Windows.Forms.PictureBox coverImageBox;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private MetroFramework.Controls.MetroLabel gallNameLabel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox gallNameBox;
        private MetroFramework.Controls.MetroTextBox gallIDBox;
        private MetroFramework.Controls.MetroButton conformButton;
        private System.Windows.Forms.DateTimePicker rangeDatePicker;
        private MetroFramework.Controls.MetroListView subMangersBox;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}
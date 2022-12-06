namespace MES.seungmin_Forms
{
    partial class faulty_Detail
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
            this.Wofact = new System.Windows.Forms.ComboBox();
            this.PMName = new System.Windows.Forms.ComboBox();
            this.WO_GRID = new System.Windows.Forms.DataGridView();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.WO_DT_Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.WO_VIEW = new FontAwesome.Sharp.IconButton();
            this.WO_STAT_N = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.WO_ITEMS_N = new System.Windows.Forms.Label();
            this.WO_DATE_N = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.Wo_detail_close = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Wofact
            // 
            this.Wofact.Font = new System.Drawing.Font("굴림", 15F);
            this.Wofact.FormattingEnabled = true;
            this.Wofact.Items.AddRange(new object[] {
            "wc001",
            "wc002",
            "wc003"});
            this.Wofact.Location = new System.Drawing.Point(353, 9);
            this.Wofact.Name = "Wofact";
            this.Wofact.Size = new System.Drawing.Size(163, 28);
            this.Wofact.TabIndex = 26;
            // 
            // PMName
            // 
            this.PMName.Font = new System.Drawing.Font("굴림", 15F);
            this.PMName.FormattingEnabled = true;
            this.PMName.Items.AddRange(new object[] {
            "pme01",
            "pki01",
            "hri01"});
            this.PMName.Location = new System.Drawing.Point(92, 9);
            this.PMName.Name = "PMName";
            this.PMName.Size = new System.Drawing.Size(163, 28);
            this.PMName.TabIndex = 27;
            // 
            // WO_GRID
            // 
            this.WO_GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WO_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WO_GRID.Location = new System.Drawing.Point(78, 110);
            this.WO_GRID.Name = "WO_GRID";
            this.WO_GRID.RowTemplate.Height = 23;
            this.WO_GRID.Size = new System.Drawing.Size(1016, 381);
            this.WO_GRID.TabIndex = 18;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.panelTitleBar.Controls.Add(this.iconPictureBox1);
            this.panelTitleBar.Controls.Add(this.WO_DT_Label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1118, 58);
            this.panelTitleBar.TabIndex = 28;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 58);
            this.iconPictureBox1.TabIndex = 55;
            this.iconPictureBox1.TabStop = false;
            // 
            // WO_DT_Label1
            // 
            this.WO_DT_Label1.Font = new System.Drawing.Font("나눔고딕코딩", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_DT_Label1.ForeColor = System.Drawing.Color.White;
            this.WO_DT_Label1.Location = new System.Drawing.Point(299, 9);
            this.WO_DT_Label1.Name = "WO_DT_Label1";
            this.WO_DT_Label1.Size = new System.Drawing.Size(617, 41);
            this.WO_DT_Label1.TabIndex = 54;
            this.WO_DT_Label1.Text = "품질관리 상세 정보";
            this.WO_DT_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WO_DT_Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WO_DT_Label1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.WO_VIEW);
            this.panel1.Controls.Add(this.WO_STAT_N);
            this.panel1.Controls.Add(this.Wofact);
            this.panel1.Controls.Add(this.EndTime);
            this.panel1.Controls.Add(this.PMName);
            this.panel1.Controls.Add(this.WO_ITEMS_N);
            this.panel1.Controls.Add(this.WO_DATE_N);
            this.panel1.Controls.Add(this.StartTime);
            this.panel1.Location = new System.Drawing.Point(-1, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1120, 46);
            this.panel1.TabIndex = 48;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(779, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 42);
            this.label1.TabIndex = 48;
            this.label1.Text = "-";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_VIEW
            // 
            this.WO_VIEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.WO_VIEW.FlatAppearance.BorderSize = 0;
            this.WO_VIEW.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WO_VIEW.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_VIEW.ForeColor = System.Drawing.Color.White;
            this.WO_VIEW.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.WO_VIEW.IconColor = System.Drawing.Color.White;
            this.WO_VIEW.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WO_VIEW.IconSize = 30;
            this.WO_VIEW.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WO_VIEW.Location = new System.Drawing.Point(987, 7);
            this.WO_VIEW.Name = "WO_VIEW";
            this.WO_VIEW.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.WO_VIEW.Size = new System.Drawing.Size(106, 36);
            this.WO_VIEW.TabIndex = 50;
            this.WO_VIEW.Tag = "Button4";
            this.WO_VIEW.Text = "   조회";
            this.WO_VIEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WO_VIEW.UseVisualStyleBackColor = false;
            this.WO_VIEW.Click += new System.EventHandler(this.WO_VIEW_Click_1);
            // 
            // WO_STAT_N
            // 
            this.WO_STAT_N.BackColor = System.Drawing.SystemColors.Menu;
            this.WO_STAT_N.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_STAT_N.Location = new System.Drawing.Point(-1, 0);
            this.WO_STAT_N.Name = "WO_STAT_N";
            this.WO_STAT_N.Size = new System.Drawing.Size(87, 44);
            this.WO_STAT_N.TabIndex = 40;
            this.WO_STAT_N.Tag = "품목";
            this.WO_STAT_N.Text = "품목";
            this.WO_STAT_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // EndTime
            // 
            this.EndTime.CustomFormat = "";
            this.EndTime.Font = new System.Drawing.Font("굴림", 15F);
            this.EndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.EndTime.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.EndTime.Location = new System.Drawing.Point(822, 8);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(161, 30);
            this.EndTime.TabIndex = 34;
            // 
            // WO_ITEMS_N
            // 
            this.WO_ITEMS_N.BackColor = System.Drawing.SystemColors.Menu;
            this.WO_ITEMS_N.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_ITEMS_N.Location = new System.Drawing.Point(261, 1);
            this.WO_ITEMS_N.Name = "WO_ITEMS_N";
            this.WO_ITEMS_N.Size = new System.Drawing.Size(86, 44);
            this.WO_ITEMS_N.TabIndex = 39;
            this.WO_ITEMS_N.Tag = "공장";
            this.WO_ITEMS_N.Text = "공장";
            this.WO_ITEMS_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_DATE_N
            // 
            this.WO_DATE_N.BackColor = System.Drawing.SystemColors.Menu;
            this.WO_DATE_N.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_DATE_N.Location = new System.Drawing.Point(522, 0);
            this.WO_DATE_N.Name = "WO_DATE_N";
            this.WO_DATE_N.Size = new System.Drawing.Size(86, 44);
            this.WO_DATE_N.TabIndex = 41;
            this.WO_DATE_N.Text = "기간";
            this.WO_DATE_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartTime
            // 
            this.StartTime.CalendarFont = new System.Drawing.Font("굴림", 15F);
            this.StartTime.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.StartTime.CustomFormat = "";
            this.StartTime.Font = new System.Drawing.Font("굴림", 15F);
            this.StartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.StartTime.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.StartTime.Location = new System.Drawing.Point(614, 8);
            this.StartTime.Name = "StartTime";
            this.StartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartTime.Size = new System.Drawing.Size(163, 30);
            this.StartTime.TabIndex = 32;
            this.StartTime.Value = new System.DateTime(2022, 11, 23, 15, 33, 25, 0);
            // 
            // Wo_detail_close
            // 
            this.Wo_detail_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.Wo_detail_close.FlatAppearance.BorderSize = 0;
            this.Wo_detail_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wo_detail_close.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Wo_detail_close.ForeColor = System.Drawing.Color.White;
            this.Wo_detail_close.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.Wo_detail_close.IconColor = System.Drawing.Color.White;
            this.Wo_detail_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Wo_detail_close.IconSize = 30;
            this.Wo_detail_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wo_detail_close.Location = new System.Drawing.Point(988, 514);
            this.Wo_detail_close.Name = "Wo_detail_close";
            this.Wo_detail_close.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Wo_detail_close.Size = new System.Drawing.Size(103, 36);
            this.Wo_detail_close.TabIndex = 53;
            this.Wo_detail_close.Tag = "Button4";
            this.Wo_detail_close.Text = "  닫기";
            this.Wo_detail_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Wo_detail_close.UseVisualStyleBackColor = false;
            this.Wo_detail_close.Click += new System.EventHandler(this.Wo_detail_close_Click);
            // 
            // faulty_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1118, 562);
            this.Controls.Add(this.Wo_detail_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.WO_GRID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "faulty_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faulty_Detail";
            this.Load += new System.EventHandler(this.faulty_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Wofact;
        private System.Windows.Forms.ComboBox PMName;
        private System.Windows.Forms.DataGridView WO_GRID;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label WO_DT_Label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WO_STAT_N;
        private System.Windows.Forms.DateTimePicker EndTime;
        private System.Windows.Forms.Label WO_ITEMS_N;
        private System.Windows.Forms.Label WO_DATE_N;
        private System.Windows.Forms.DateTimePicker StartTime;
        private FontAwesome.Sharp.IconButton WO_VIEW;
        private FontAwesome.Sharp.IconButton Wo_detail_close;
    }
}
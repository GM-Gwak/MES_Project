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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Wofact = new System.Windows.Forms.ComboBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.WO_DT_Label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PMName = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.WO_VIEW = new FontAwesome.Sharp.IconButton();
            this.WO_STAT_N = new System.Windows.Forms.Label();
            this.EndTime = new System.Windows.Forms.DateTimePicker();
            this.WO_ITEMS_N = new System.Windows.Forms.Label();
            this.WO_DATE_N = new System.Windows.Forms.Label();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.Wo_detail_close = new FontAwesome.Sharp.IconButton();
            this.FA_GRID = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FA_GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // Wofact
            // 
            this.Wofact.BackColor = System.Drawing.SystemColors.Menu;
            this.Wofact.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Wofact.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Wofact.Font = new System.Drawing.Font("굴림", 15F);
            this.Wofact.FormattingEnabled = true;
            this.Wofact.Items.AddRange(new object[] {
            "wc001",
            "wc002",
            "wc003"});
            this.Wofact.Location = new System.Drawing.Point(395, 9);
            this.Wofact.Name = "Wofact";
            this.Wofact.Size = new System.Drawing.Size(163, 28);
            this.Wofact.TabIndex = 2;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.panelTitleBar.Controls.Add(this.label6);
            this.panelTitleBar.Controls.Add(this.label3);
            this.panelTitleBar.Controls.Add(this.label2);
            this.panelTitleBar.Controls.Add(this.iconPictureBox1);
            this.panelTitleBar.Controls.Add(this.WO_DT_Label1);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1213, 58);
            this.panelTitleBar.TabIndex = 28;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(1209, 2);
            this.label6.TabIndex = 67;
            this.label6.Text = "label6";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 58);
            this.label3.TabIndex = 66;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Location = new System.Drawing.Point(1211, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(2, 58);
            this.label2.TabIndex = 63;
            this.label2.Text = "label2";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(2, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 58);
            this.iconPictureBox1.TabIndex = 55;
            this.iconPictureBox1.TabStop = false;
            // 
            // WO_DT_Label1
            // 
            this.WO_DT_Label1.Font = new System.Drawing.Font("나눔고딕코딩", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_DT_Label1.ForeColor = System.Drawing.Color.White;
            this.WO_DT_Label1.Location = new System.Drawing.Point(467, 9);
            this.WO_DT_Label1.Name = "WO_DT_Label1";
            this.WO_DT_Label1.Size = new System.Drawing.Size(312, 41);
            this.WO_DT_Label1.TabIndex = 54;
            this.WO_DT_Label1.Text = "품질관리 상세 정보";
            this.WO_DT_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WO_DT_Label1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WO_DT_Label1_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.PMName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.WO_VIEW);
            this.panel1.Controls.Add(this.WO_STAT_N);
            this.panel1.Controls.Add(this.Wofact);
            this.panel1.Controls.Add(this.EndTime);
            this.panel1.Controls.Add(this.WO_ITEMS_N);
            this.panel1.Controls.Add(this.WO_DATE_N);
            this.panel1.Controls.Add(this.StartTime);
            this.panel1.Location = new System.Drawing.Point(-1, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1230, 46);
            this.panel1.TabIndex = 48;
            // 
            // PMName
            // 
            this.PMName.BackColor = System.Drawing.SystemColors.Menu;
            this.PMName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PMName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PMName.Font = new System.Drawing.Font("굴림", 15F);
            this.PMName.FormattingEnabled = true;
            this.PMName.IntegralHeight = false;
            this.PMName.Items.AddRange(new object[] {
            "pme01",
            "pki01",
            "hri01"});
            this.PMName.Location = new System.Drawing.Point(113, 9);
            this.PMName.Name = "PMName";
            this.PMName.Size = new System.Drawing.Size(163, 28);
            this.PMName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(846, 2);
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
            this.WO_VIEW.Location = new System.Drawing.Point(1077, 4);
            this.WO_VIEW.Name = "WO_VIEW";
            this.WO_VIEW.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.WO_VIEW.Size = new System.Drawing.Size(106, 36);
            this.WO_VIEW.TabIndex = 5;
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
            this.WO_STAT_N.Size = new System.Drawing.Size(107, 44);
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
            this.EndTime.Location = new System.Drawing.Point(888, 7);
            this.EndTime.Name = "EndTime";
            this.EndTime.Size = new System.Drawing.Size(161, 30);
            this.EndTime.TabIndex = 4;
            // 
            // WO_ITEMS_N
            // 
            this.WO_ITEMS_N.BackColor = System.Drawing.SystemColors.Menu;
            this.WO_ITEMS_N.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_ITEMS_N.Location = new System.Drawing.Point(282, 0);
            this.WO_ITEMS_N.Name = "WO_ITEMS_N";
            this.WO_ITEMS_N.Size = new System.Drawing.Size(107, 44);
            this.WO_ITEMS_N.TabIndex = 39;
            this.WO_ITEMS_N.Tag = "공장";
            this.WO_ITEMS_N.Text = "공장";
            this.WO_ITEMS_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_DATE_N
            // 
            this.WO_DATE_N.BackColor = System.Drawing.SystemColors.Menu;
            this.WO_DATE_N.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_DATE_N.Location = new System.Drawing.Point(564, 0);
            this.WO_DATE_N.Name = "WO_DATE_N";
            this.WO_DATE_N.Size = new System.Drawing.Size(107, 44);
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
            this.StartTime.Location = new System.Drawing.Point(677, 7);
            this.StartTime.Name = "StartTime";
            this.StartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartTime.Size = new System.Drawing.Size(163, 30);
            this.StartTime.TabIndex = 3;
            this.StartTime.Value = new System.DateTime(2022, 11, 23, 15, 33, 25, 0);
            // 
            // Wo_detail_close
            // 
            this.Wo_detail_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.Wo_detail_close.FlatAppearance.BorderSize = 0;
            this.Wo_detail_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wo_detail_close.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Wo_detail_close.ForeColor = System.Drawing.Color.White;
            this.Wo_detail_close.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.Wo_detail_close.IconColor = System.Drawing.Color.White;
            this.Wo_detail_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Wo_detail_close.IconSize = 30;
            this.Wo_detail_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wo_detail_close.Location = new System.Drawing.Point(558, 524);
            this.Wo_detail_close.Name = "Wo_detail_close";
            this.Wo_detail_close.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Wo_detail_close.Size = new System.Drawing.Size(103, 36);
            this.Wo_detail_close.TabIndex = 6;
            this.Wo_detail_close.Tag = "Button4";
            this.Wo_detail_close.Text = "  닫기";
            this.Wo_detail_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Wo_detail_close.UseVisualStyleBackColor = false;
            this.Wo_detail_close.Click += new System.EventHandler(this.Wo_detail_close_Click);
            // 
            // FA_GRID
            // 
            this.FA_GRID.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FA_GRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FA_GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.FA_GRID.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FA_GRID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.FA_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FA_GRID.DefaultCellStyle = dataGridViewCellStyle3;
            this.FA_GRID.EnableHeadersVisualStyles = false;
            this.FA_GRID.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.FA_GRID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.FA_GRID.Location = new System.Drawing.Point(41, 143);
            this.FA_GRID.MultiSelect = false;
            this.FA_GRID.Name = "FA_GRID";
            this.FA_GRID.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FA_GRID.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.FA_GRID.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.FA_GRID.RowTemplate.Height = 23;
            this.FA_GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FA_GRID.Size = new System.Drawing.Size(1131, 350);
            this.FA_GRID.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(1211, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 534);
            this.label7.TabIndex = 62;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 534);
            this.label8.TabIndex = 65;
            this.label8.Text = "label8";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(2, 590);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1209, 2);
            this.label5.TabIndex = 66;
            this.label5.Text = "label5";
            // 
            // faulty_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1213, 592);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.FA_GRID);
            this.Controls.Add(this.Wo_detail_close);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "faulty_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "faulty_Detail";
            this.Load += new System.EventHandler(this.faulty_Detail_Load);
            this.panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FA_GRID)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Wofact;
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
        private System.Windows.Forms.ComboBox PMName;
        private System.Windows.Forms.DataGridView FA_GRID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
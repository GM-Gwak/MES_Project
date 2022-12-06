namespace MES.Workorder_Form
{
    partial class WorkOrder
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.WO_DATE_N = new System.Windows.Forms.Label();
            this.WO_STAT_N = new System.Windows.Forms.Label();
            this.WO_ITEMS_N = new System.Windows.Forms.Label();
            this.PMName = new System.Windows.Forms.ComboBox();
            this.WO_GRID = new System.Windows.Forms.DataGridView();
            this.WoEndTime = new System.Windows.Forms.DateTimePicker();
            this.WoStat = new System.Windows.Forms.ComboBox();
            this.WoStartTime = new System.Windows.Forms.DateTimePicker();
            this.oracleCommandBuilder1 = new Oracle.ManagedDataAccess.Client.OracleCommandBuilder();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.WO_Detail = new FontAwesome.Sharp.IconButton();
            this.WO_VIEW = new FontAwesome.Sharp.IconButton();
            this.WO_CREATE = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.WO_LABEL = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-1, 744);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1356, 1);
            this.label1.TabIndex = 44;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_DATE_N
            // 
            this.WO_DATE_N.BackColor = System.Drawing.SystemColors.Menu;
            this.WO_DATE_N.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.WO_DATE_N.Location = new System.Drawing.Point(564, 0);
            this.WO_DATE_N.Name = "WO_DATE_N";
            this.WO_DATE_N.Size = new System.Drawing.Size(107, 44);
            this.WO_DATE_N.TabIndex = 41;
            this.WO_DATE_N.Text = "기간";
            this.WO_DATE_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_STAT_N
            // 
            this.WO_STAT_N.BackColor = System.Drawing.SystemColors.Menu;
            this.WO_STAT_N.Dock = System.Windows.Forms.DockStyle.Left;
            this.WO_STAT_N.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.WO_STAT_N.Location = new System.Drawing.Point(0, 0);
            this.WO_STAT_N.Name = "WO_STAT_N";
            this.WO_STAT_N.Size = new System.Drawing.Size(107, 44);
            this.WO_STAT_N.TabIndex = 40;
            this.WO_STAT_N.Text = "상태";
            this.WO_STAT_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_ITEMS_N
            // 
            this.WO_ITEMS_N.BackColor = System.Drawing.SystemColors.Menu;
            this.WO_ITEMS_N.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.WO_ITEMS_N.Location = new System.Drawing.Point(282, 0);
            this.WO_ITEMS_N.Name = "WO_ITEMS_N";
            this.WO_ITEMS_N.Size = new System.Drawing.Size(107, 44);
            this.WO_ITEMS_N.TabIndex = 39;
            this.WO_ITEMS_N.Text = "품목";
            this.WO_ITEMS_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PMName
            // 
            this.PMName.AllowDrop = true;
            this.PMName.BackColor = System.Drawing.SystemColors.Menu;
            this.PMName.DropDownHeight = 150;
            this.PMName.DropDownWidth = 150;
            this.PMName.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PMName.Font = new System.Drawing.Font("굴림", 15F);
            this.PMName.FormattingEnabled = true;
            this.PMName.IntegralHeight = false;
            this.PMName.ItemHeight = 20;
            this.PMName.Items.AddRange(new object[] {
            "고기만두(1봉)",
            "김치만두(1봉)",
            "갈비만두(1봉)"});
            this.PMName.Location = new System.Drawing.Point(395, 9);
            this.PMName.MaxDropDownItems = 5;
            this.PMName.Name = "PMName";
            this.PMName.Size = new System.Drawing.Size(163, 28);
            this.PMName.TabIndex = 38;
            // 
            // WO_GRID
            // 
            this.WO_GRID.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WO_GRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.WO_GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WO_GRID.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WO_GRID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.WO_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WO_GRID.DefaultCellStyle = dataGridViewCellStyle13;
            this.WO_GRID.EnableHeadersVisualStyles = false;
            this.WO_GRID.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.WO_GRID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.WO_GRID.Location = new System.Drawing.Point(17, 148);
            this.WO_GRID.MultiSelect = false;
            this.WO_GRID.Name = "WO_GRID";
            this.WO_GRID.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WO_GRID.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.WO_GRID.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.WO_GRID.RowTemplate.Height = 23;
            this.WO_GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WO_GRID.Size = new System.Drawing.Size(1320, 579);
            this.WO_GRID.TabIndex = 29;
            this.WO_GRID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WO_GRID_CellClick);
            // 
            // WoEndTime
            // 
            this.WoEndTime.CustomFormat = "";
            this.WoEndTime.Font = new System.Drawing.Font("굴림", 15F);
            this.WoEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WoEndTime.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.WoEndTime.Location = new System.Drawing.Point(890, 7);
            this.WoEndTime.Name = "WoEndTime";
            this.WoEndTime.Size = new System.Drawing.Size(161, 30);
            this.WoEndTime.TabIndex = 34;
            // 
            // WoStat
            // 
            this.WoStat.AllowDrop = true;
            this.WoStat.BackColor = System.Drawing.SystemColors.Menu;
            this.WoStat.DropDownHeight = 150;
            this.WoStat.DropDownWidth = 150;
            this.WoStat.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.WoStat.Font = new System.Drawing.Font("굴림", 15F);
            this.WoStat.FormattingEnabled = true;
            this.WoStat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.WoStat.IntegralHeight = false;
            this.WoStat.ItemHeight = 20;
            this.WoStat.Items.AddRange(new object[] {
            "S",
            "E",
            "P"});
            this.WoStat.Location = new System.Drawing.Point(113, 9);
            this.WoStat.MaxDropDownItems = 5;
            this.WoStat.Name = "WoStat";
            this.WoStat.Size = new System.Drawing.Size(163, 28);
            this.WoStat.TabIndex = 33;
            // 
            // WoStartTime
            // 
            this.WoStartTime.CalendarFont = new System.Drawing.Font("굴림", 15F);
            this.WoStartTime.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.WoStartTime.CustomFormat = "";
            this.WoStartTime.Font = new System.Drawing.Font("굴림", 15F);
            this.WoStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WoStartTime.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.WoStartTime.Location = new System.Drawing.Point(677, 7);
            this.WoStartTime.Name = "WoStartTime";
            this.WoStartTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.WoStartTime.Size = new System.Drawing.Size(163, 30);
            this.WoStartTime.TabIndex = 32;
            this.WoStartTime.Value = new System.DateTime(2022, 11, 23, 15, 33, 25, 0);
            // 
            // oracleCommandBuilder1
            // 
            this.oracleCommandBuilder1.CatalogLocation = System.Data.Common.CatalogLocation.End;
            this.oracleCommandBuilder1.CatalogSeparator = "@";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.WO_STAT_N);
            this.panel1.Controls.Add(this.WoEndTime);
            this.panel1.Controls.Add(this.PMName);
            this.panel1.Controls.Add(this.WoStat);
            this.panel1.Controls.Add(this.WO_ITEMS_N);
            this.panel1.Controls.Add(this.WO_DATE_N);
            this.panel1.Controls.Add(this.WoStartTime);
            this.panel1.Location = new System.Drawing.Point(-1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 46);
            this.panel1.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(846, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 42);
            this.label2.TabIndex = 48;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_Detail
            // 
            this.WO_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.WO_Detail.FlatAppearance.BorderSize = 0;
            this.WO_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WO_Detail.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_Detail.ForeColor = System.Drawing.Color.White;
            this.WO_Detail.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.WO_Detail.IconColor = System.Drawing.Color.White;
            this.WO_Detail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WO_Detail.IconSize = 30;
            this.WO_Detail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WO_Detail.Location = new System.Drawing.Point(1073, 16);
            this.WO_Detail.Name = "WO_Detail";
            this.WO_Detail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.WO_Detail.Size = new System.Drawing.Size(153, 36);
            this.WO_Detail.TabIndex = 48;
            this.WO_Detail.Tag = "Button4";
            this.WO_Detail.Text = "   지시서 상세";
            this.WO_Detail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WO_Detail.UseVisualStyleBackColor = false;
            this.WO_Detail.Click += new System.EventHandler(this.WO_Detail_Click_1);
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
            this.WO_VIEW.Location = new System.Drawing.Point(1232, 16);
            this.WO_VIEW.Name = "WO_VIEW";
            this.WO_VIEW.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.WO_VIEW.Size = new System.Drawing.Size(106, 36);
            this.WO_VIEW.TabIndex = 49;
            this.WO_VIEW.Tag = "Button4";
            this.WO_VIEW.Text = "   조회";
            this.WO_VIEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WO_VIEW.UseVisualStyleBackColor = false;
            this.WO_VIEW.Click += new System.EventHandler(this.WO_VIEW_Click_1);
            // 
            // WO_CREATE
            // 
            this.WO_CREATE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.WO_CREATE.FlatAppearance.BorderSize = 0;
            this.WO_CREATE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WO_CREATE.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_CREATE.ForeColor = System.Drawing.Color.White;
            this.WO_CREATE.IconChar = FontAwesome.Sharp.IconChar.PencilSquare;
            this.WO_CREATE.IconColor = System.Drawing.Color.White;
            this.WO_CREATE.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.WO_CREATE.IconSize = 30;
            this.WO_CREATE.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.WO_CREATE.Location = new System.Drawing.Point(755, 16);
            this.WO_CREATE.Name = "WO_CREATE";
            this.WO_CREATE.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.WO_CREATE.Size = new System.Drawing.Size(153, 36);
            this.WO_CREATE.TabIndex = 50;
            this.WO_CREATE.Tag = "Button4";
            this.WO_CREATE.Text = "   지시서 등록";
            this.WO_CREATE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.WO_CREATE.UseVisualStyleBackColor = false;
            this.WO_CREATE.Click += new System.EventHandler(this.WO_CREATE_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.iconButton1);
            this.panel2.Controls.Add(this.WO_LABEL);
            this.panel2.Controls.Add(this.WO_VIEW);
            this.panel2.Controls.Add(this.WO_CREATE);
            this.panel2.Controls.Add(this.WO_Detail);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 66);
            this.panel2.TabIndex = 51;
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(914, 16);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(153, 36);
            this.iconButton1.TabIndex = 53;
            this.iconButton1.Tag = "Button4";
            this.iconButton1.Text = "   지시서 삭제";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // WO_LABEL
            // 
            this.WO_LABEL.Font = new System.Drawing.Font("나눔고딕코딩", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_LABEL.Location = new System.Drawing.Point(80, 11);
            this.WO_LABEL.Name = "WO_LABEL";
            this.WO_LABEL.Size = new System.Drawing.Size(169, 41);
            this.WO_LABEL.TabIndex = 31;
            this.WO_LABEL.Text = "작업지시";
            this.WO_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 66;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 66);
            this.iconPictureBox1.TabIndex = 52;
            this.iconPictureBox1.TabStop = false;
            // 
            // WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1553, 824);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WO_GRID);
            this.Name = "WorkOrder";
            this.Text = "WorkOrder";
            this.Load += new System.EventHandler(this.WorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WO_DATE_N;
        private System.Windows.Forms.Label WO_STAT_N;
        private System.Windows.Forms.Label WO_ITEMS_N;
        private System.Windows.Forms.ComboBox PMName;
        private System.Windows.Forms.DataGridView WO_GRID;
        private System.Windows.Forms.DateTimePicker WoEndTime;
        private System.Windows.Forms.ComboBox WoStat;
        private System.Windows.Forms.DateTimePicker WoStartTime;
        private Oracle.ManagedDataAccess.Client.OracleCommandBuilder oracleCommandBuilder1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton WO_Detail;
        private FontAwesome.Sharp.IconButton WO_VIEW;
        private FontAwesome.Sharp.IconButton WO_CREATE;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label WO_LABEL;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}
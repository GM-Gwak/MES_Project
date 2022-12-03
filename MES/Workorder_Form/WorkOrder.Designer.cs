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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.WO_Detail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.WO_DATE_N = new System.Windows.Forms.Label();
            this.WO_STAT_N = new System.Windows.Forms.Label();
            this.WO_ITEMS_N = new System.Windows.Forms.Label();
            this.PMName = new System.Windows.Forms.ComboBox();
            this.WO_DEL = new System.Windows.Forms.Button();
            this.WO_CREATE = new System.Windows.Forms.Button();
            this.WO_VIEW = new System.Windows.Forms.Button();
            this.WO_GRID = new System.Windows.Forms.DataGridView();
            this.WoEndTime = new System.Windows.Forms.DateTimePicker();
            this.WoStat = new System.Windows.Forms.ComboBox();
            this.WoStartTime = new System.Windows.Forms.DateTimePicker();
            this.WO_LABEL = new System.Windows.Forms.Label();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.oracleCommandBuilder1 = new Oracle.ManagedDataAccess.Client.OracleCommandBuilder();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // WO_Detail
            // 
            this.WO_Detail.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_Detail.Location = new System.Drawing.Point(162, 34);
            this.WO_Detail.Name = "WO_Detail";
            this.WO_Detail.Size = new System.Drawing.Size(232, 53);
            this.WO_Detail.TabIndex = 45;
            this.WO_Detail.Text = "지시서 상세";
            this.WO_Detail.UseVisualStyleBackColor = true;
            this.WO_Detail.Click += new System.EventHandler(this.WO_Detail_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-1, 744);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1355, 1);
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
            // WO_DEL
            // 
            this.WO_DEL.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_DEL.Location = new System.Drawing.Point(745, 12);
            this.WO_DEL.Name = "WO_DEL";
            this.WO_DEL.Size = new System.Drawing.Size(232, 53);
            this.WO_DEL.TabIndex = 37;
            this.WO_DEL.Text = "지시서 삭제";
            this.WO_DEL.UseVisualStyleBackColor = true;
            // 
            // WO_CREATE
            // 
            this.WO_CREATE.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_CREATE.Location = new System.Drawing.Point(1041, 12);
            this.WO_CREATE.Name = "WO_CREATE";
            this.WO_CREATE.Size = new System.Drawing.Size(232, 53);
            this.WO_CREATE.TabIndex = 36;
            this.WO_CREATE.Text = "지시서 등록";
            this.WO_CREATE.UseVisualStyleBackColor = true;
            this.WO_CREATE.Click += new System.EventHandler(this.WO_CREATE_Click);
            // 
            // WO_VIEW
            // 
            this.WO_VIEW.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_VIEW.Location = new System.Drawing.Point(439, 25);
            this.WO_VIEW.Name = "WO_VIEW";
            this.WO_VIEW.Size = new System.Drawing.Size(232, 53);
            this.WO_VIEW.TabIndex = 35;
            this.WO_VIEW.Text = "조회";
            this.WO_VIEW.UseVisualStyleBackColor = true;
            this.WO_VIEW.Click += new System.EventHandler(this.WO_VIEW_Click);
            // 
            // WO_GRID
            // 
            this.WO_GRID.AllowUserToAddRows = false;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WO_GRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.WO_GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WO_GRID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.WO_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WO_GRID.DefaultCellStyle = dataGridViewCellStyle8;
            this.WO_GRID.EnableHeadersVisualStyles = false;
            this.WO_GRID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.WO_GRID.Location = new System.Drawing.Point(17, 198);
            this.WO_GRID.MultiSelect = false;
            this.WO_GRID.Name = "WO_GRID";
            this.WO_GRID.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WO_GRID.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Black;
            this.WO_GRID.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.WO_GRID.RowTemplate.Height = 23;
            this.WO_GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WO_GRID.Size = new System.Drawing.Size(1303, 530);
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
            // WO_LABEL
            // 
            this.WO_LABEL.AutoSize = true;
            this.WO_LABEL.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_LABEL.Location = new System.Drawing.Point(12, 9);
            this.WO_LABEL.Name = "WO_LABEL";
            this.WO_LABEL.Size = new System.Drawing.Size(144, 29);
            this.WO_LABEL.TabIndex = 31;
            this.WO_LABEL.Text = "작업 지시";
            this.WO_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconButton5
            // 
            this.iconButton5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton5.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButton5.ForeColor = System.Drawing.Color.White;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton5.IconColor = System.Drawing.Color.White;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton5.Location = new System.Drawing.Point(849, 92);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton5.Size = new System.Drawing.Size(153, 36);
            this.iconButton5.TabIndex = 46;
            this.iconButton5.Tag = "Button4";
            this.iconButton5.Text = "   지시서 삭제";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = false;
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
            this.panel1.Location = new System.Drawing.Point(-1, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1355, 46);
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
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 30;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(1008, 92);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton1.Size = new System.Drawing.Size(153, 36);
            this.iconButton1.TabIndex = 48;
            this.iconButton1.Tag = "Button4";
            this.iconButton1.Text = "   지시서 상세";
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            // 
            // iconButton2
            // 
            this.iconButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButton2.ForeColor = System.Drawing.Color.White;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton2.IconColor = System.Drawing.Color.White;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton2.Location = new System.Drawing.Point(1167, 92);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton2.Size = new System.Drawing.Size(153, 36);
            this.iconButton2.TabIndex = 49;
            this.iconButton2.Tag = "Button4";
            this.iconButton2.Text = "   조회";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = false;
            // 
            // iconButton3
            // 
            this.iconButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.iconButton3.ForeColor = System.Drawing.Color.White;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(690, 92);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.iconButton3.Size = new System.Drawing.Size(153, 36);
            this.iconButton3.TabIndex = 50;
            this.iconButton3.Tag = "Button4";
            this.iconButton3.Text = "   지시서 등록";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = false;
            // 
            // WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(1338, 762);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.WO_Detail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WO_DEL);
            this.Controls.Add(this.WO_CREATE);
            this.Controls.Add(this.WO_VIEW);
            this.Controls.Add(this.WO_GRID);
            this.Controls.Add(this.WO_LABEL);
            this.Name = "WorkOrder";
            this.Text = "WorkOrder";
            this.Load += new System.EventHandler(this.WorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button WO_Detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label WO_DATE_N;
        private System.Windows.Forms.Label WO_STAT_N;
        private System.Windows.Forms.Label WO_ITEMS_N;
        private System.Windows.Forms.ComboBox PMName;
        private System.Windows.Forms.Button WO_DEL;
        private System.Windows.Forms.Button WO_CREATE;
        private System.Windows.Forms.Button WO_VIEW;
        private System.Windows.Forms.DataGridView WO_GRID;
        private System.Windows.Forms.DateTimePicker WoEndTime;
        private System.Windows.Forms.ComboBox WoStat;
        private System.Windows.Forms.DateTimePicker WoStartTime;
        private System.Windows.Forms.Label WO_LABEL;
        private FontAwesome.Sharp.IconButton iconButton5;
        private Oracle.ManagedDataAccess.Client.OracleCommandBuilder oracleCommandBuilder1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private FontAwesome.Sharp.IconButton iconButton3;
    }
}
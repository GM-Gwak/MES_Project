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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.WO_Detail = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
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
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // WO_Detail
            // 
            this.WO_Detail.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_Detail.Location = new System.Drawing.Point(493, 596);
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
            this.label1.Location = new System.Drawing.Point(14, 679);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1060, 2);
            this.label1.TabIndex = 44;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Black;
            this.panel3.Location = new System.Drawing.Point(17, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1060, 1);
            this.panel3.TabIndex = 43;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(20, 132);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1060, 2);
            this.panel2.TabIndex = 42;
            // 
            // WO_DATE_N
            // 
            this.WO_DATE_N.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_DATE_N.Location = new System.Drawing.Point(17, 154);
            this.WO_DATE_N.Name = "WO_DATE_N";
            this.WO_DATE_N.Size = new System.Drawing.Size(63, 26);
            this.WO_DATE_N.TabIndex = 41;
            this.WO_DATE_N.Text = "기간";
            this.WO_DATE_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_STAT_N
            // 
            this.WO_STAT_N.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_STAT_N.Location = new System.Drawing.Point(255, 82);
            this.WO_STAT_N.Name = "WO_STAT_N";
            this.WO_STAT_N.Size = new System.Drawing.Size(63, 26);
            this.WO_STAT_N.TabIndex = 40;
            this.WO_STAT_N.Text = "상태";
            this.WO_STAT_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_ITEMS_N
            // 
            this.WO_ITEMS_N.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_ITEMS_N.Location = new System.Drawing.Point(17, 82);
            this.WO_ITEMS_N.Name = "WO_ITEMS_N";
            this.WO_ITEMS_N.Size = new System.Drawing.Size(63, 26);
            this.WO_ITEMS_N.TabIndex = 39;
            this.WO_ITEMS_N.Text = "품목";
            this.WO_ITEMS_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PMName
            // 
            this.PMName.AllowDrop = true;
            this.PMName.DropDownHeight = 150;
            this.PMName.DropDownWidth = 150;
            this.PMName.Font = new System.Drawing.Font("굴림", 12F);
            this.PMName.FormattingEnabled = true;
            this.PMName.IntegralHeight = false;
            this.PMName.ItemHeight = 16;
            this.PMName.Items.AddRange(new object[] {
            "고기만두(1봉)",
            "김치만두(1봉)",
            "갈비만두(1봉)"});
            this.PMName.Location = new System.Drawing.Point(86, 82);
            this.PMName.MaxDropDownItems = 5;
            this.PMName.Name = "PMName";
            this.PMName.Size = new System.Drawing.Size(163, 24);
            this.PMName.TabIndex = 38;
            // 
            // WO_DEL
            // 
            this.WO_DEL.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_DEL.Location = new System.Drawing.Point(255, 596);
            this.WO_DEL.Name = "WO_DEL";
            this.WO_DEL.Size = new System.Drawing.Size(232, 53);
            this.WO_DEL.TabIndex = 37;
            this.WO_DEL.Text = "지시서 삭제";
            this.WO_DEL.UseVisualStyleBackColor = true;
            // 
            // WO_CREATE
            // 
            this.WO_CREATE.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_CREATE.Location = new System.Drawing.Point(17, 596);
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
            this.WO_VIEW.Location = new System.Drawing.Point(845, 596);
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
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WO_GRID.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.WO_GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WO_GRID.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WO_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WO_GRID.DefaultCellStyle = dataGridViewCellStyle3;
            this.WO_GRID.EnableHeadersVisualStyles = false;
            this.WO_GRID.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.WO_GRID.Location = new System.Drawing.Point(17, 198);
            this.WO_GRID.MultiSelect = false;
            this.WO_GRID.Name = "WO_GRID";
            this.WO_GRID.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WO_GRID.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.WO_GRID.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.WO_GRID.RowTemplate.Height = 23;
            this.WO_GRID.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WO_GRID.Size = new System.Drawing.Size(1060, 372);
            this.WO_GRID.TabIndex = 29;
            this.WO_GRID.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.WO_GRID_CellClick);
            // 
            // WoEndTime
            // 
            this.WoEndTime.CustomFormat = "";
            this.WoEndTime.Font = new System.Drawing.Font("굴림", 12F);
            this.WoEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WoEndTime.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.WoEndTime.Location = new System.Drawing.Point(340, 154);
            this.WoEndTime.Name = "WoEndTime";
            this.WoEndTime.Size = new System.Drawing.Size(210, 26);
            this.WoEndTime.TabIndex = 34;
            // 
            // WoStat
            // 
            this.WoStat.AllowDrop = true;
            this.WoStat.DropDownHeight = 150;
            this.WoStat.DropDownWidth = 150;
            this.WoStat.Font = new System.Drawing.Font("굴림", 12F);
            this.WoStat.FormattingEnabled = true;
            this.WoStat.IntegralHeight = false;
            this.WoStat.ItemHeight = 16;
            this.WoStat.Items.AddRange(new object[] {
            "S",
            "E",
            "P"});
            this.WoStat.Location = new System.Drawing.Point(324, 82);
            this.WoStat.MaxDropDownItems = 5;
            this.WoStat.Name = "WoStat";
            this.WoStat.Size = new System.Drawing.Size(163, 24);
            this.WoStat.TabIndex = 33;
            // 
            // WoStartTime
            // 
            this.WoStartTime.CustomFormat = "";
            this.WoStartTime.Font = new System.Drawing.Font("굴림", 12F);
            this.WoStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WoStartTime.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.WoStartTime.Location = new System.Drawing.Point(86, 154);
            this.WoStartTime.Name = "WoStartTime";
            this.WoStartTime.Size = new System.Drawing.Size(210, 26);
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
            // WorkOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.WO_Detail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.WO_DATE_N);
            this.Controls.Add(this.WO_STAT_N);
            this.Controls.Add(this.WO_ITEMS_N);
            this.Controls.Add(this.PMName);
            this.Controls.Add(this.WO_DEL);
            this.Controls.Add(this.WO_CREATE);
            this.Controls.Add(this.WO_VIEW);
            this.Controls.Add(this.WO_GRID);
            this.Controls.Add(this.WoEndTime);
            this.Controls.Add(this.WoStat);
            this.Controls.Add(this.WoStartTime);
            this.Controls.Add(this.WO_LABEL);
            this.Name = "WorkOrder";
            this.Text = "WorkOrder";
            this.Load += new System.EventHandler(this.WorkOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button WO_Detail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
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
    }
}
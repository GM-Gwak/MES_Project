namespace WindowsFormsApp11515
{
    partial class WO
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.WO_LABEL = new System.Windows.Forms.Label();
            this.WoStartTime = new System.Windows.Forms.DateTimePicker();
            this.WoStat = new System.Windows.Forms.ComboBox();
            this.WoEndTime = new System.Windows.Forms.DateTimePicker();
            this.WO_GRID = new System.Windows.Forms.DataGridView();
            this.WO_VIEW = new System.Windows.Forms.Button();
            this.WO_CREATE = new System.Windows.Forms.Button();
            this.WO_DEL = new System.Windows.Forms.Button();
            this.PMName = new System.Windows.Forms.ComboBox();
            this.WO_ITEMS_N = new System.Windows.Forms.Label();
            this.WO_STAT_N = new System.Windows.Forms.Label();
            this.WO_DATE_N = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(40)))), ((int)(((byte)(45)))));
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 665);
            this.panel1.TabIndex = 7;
            // 
            // WO_LABEL
            // 
            this.WO_LABEL.AutoSize = true;
            this.WO_LABEL.Font = new System.Drawing.Font("굴림", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_LABEL.Location = new System.Drawing.Point(207, 9);
            this.WO_LABEL.Name = "WO_LABEL";
            this.WO_LABEL.Size = new System.Drawing.Size(144, 29);
            this.WO_LABEL.TabIndex = 8;
            this.WO_LABEL.Text = "작업 지시";
            this.WO_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WoStartTime
            // 
            this.WoStartTime.CustomFormat = "";
            this.WoStartTime.Font = new System.Drawing.Font("굴림", 12F);
            this.WoStartTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WoStartTime.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.WoStartTime.Location = new System.Drawing.Point(281, 154);
            this.WoStartTime.Name = "WoStartTime";
            this.WoStartTime.Size = new System.Drawing.Size(210, 26);
            this.WoStartTime.TabIndex = 9;
            this.WoStartTime.Value = new System.DateTime(2022, 11, 23, 15, 33, 25, 0);
            // 
            // WoStat
            // 
            this.WoStat.AllowDrop = true;
            this.WoStat.DropDownHeight = 150;
            this.WoStat.DropDownWidth = 200;
            this.WoStat.Font = new System.Drawing.Font("굴림", 12F);
            this.WoStat.FormattingEnabled = true;
            this.WoStat.IntegralHeight = false;
            this.WoStat.ItemHeight = 16;
            this.WoStat.Items.AddRange(new object[] {
            "S",
            "E",
            "P"});
            this.WoStat.Location = new System.Drawing.Point(519, 82);
            this.WoStat.MaxDropDownItems = 5;
            this.WoStat.Name = "WoStat";
            this.WoStat.Size = new System.Drawing.Size(163, 24);
            this.WoStat.TabIndex = 10;
            // 
            // WoEndTime
            // 
            this.WoEndTime.CustomFormat = "";
            this.WoEndTime.Font = new System.Drawing.Font("굴림", 12F);
            this.WoEndTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.WoEndTime.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.WoEndTime.Location = new System.Drawing.Point(535, 154);
            this.WoEndTime.Name = "WoEndTime";
            this.WoEndTime.Size = new System.Drawing.Size(210, 26);
            this.WoEndTime.TabIndex = 11;
            // 
            // WO_GRID
            // 
            this.WO_GRID.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WO_GRID.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.WO_GRID.Location = new System.Drawing.Point(212, 198);
            this.WO_GRID.Name = "WO_GRID";
            this.WO_GRID.RowTemplate.Height = 23;
            this.WO_GRID.Size = new System.Drawing.Size(1060, 372);
            this.WO_GRID.TabIndex = 12;
            // 
            // WO_VIEW
            // 
            this.WO_VIEW.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_VIEW.Location = new System.Drawing.Point(1040, 596);
            this.WO_VIEW.Name = "WO_VIEW";
            this.WO_VIEW.Size = new System.Drawing.Size(232, 53);
            this.WO_VIEW.TabIndex = 14;
            this.WO_VIEW.Text = "조회";
            this.WO_VIEW.UseVisualStyleBackColor = true;
            this.WO_VIEW.Click += new System.EventHandler(this.WO_VIEW_Click);
            // 
            // WO_CREATE
            // 
            this.WO_CREATE.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_CREATE.Location = new System.Drawing.Point(212, 596);
            this.WO_CREATE.Name = "WO_CREATE";
            this.WO_CREATE.Size = new System.Drawing.Size(232, 53);
            this.WO_CREATE.TabIndex = 15;
            this.WO_CREATE.Text = "지시서 등록";
            this.WO_CREATE.UseVisualStyleBackColor = true;
            // 
            // WO_DEL
            // 
            this.WO_DEL.Font = new System.Drawing.Font("굴림", 18F);
            this.WO_DEL.Location = new System.Drawing.Point(466, 596);
            this.WO_DEL.Name = "WO_DEL";
            this.WO_DEL.Size = new System.Drawing.Size(232, 53);
            this.WO_DEL.TabIndex = 16;
            this.WO_DEL.Text = "지시서 삭제";
            this.WO_DEL.UseVisualStyleBackColor = true;
            // 
            // PMName
            // 
            this.PMName.AllowDrop = true;
            this.PMName.DropDownHeight = 150;
            this.PMName.DropDownWidth = 200;
            this.PMName.Font = new System.Drawing.Font("굴림", 12F);
            this.PMName.FormattingEnabled = true;
            this.PMName.IntegralHeight = false;
            this.PMName.ItemHeight = 16;
            this.PMName.Items.AddRange(new object[] {
            "고기만두",
            "김치만두",
            "갈비만두"});
            this.PMName.Location = new System.Drawing.Point(281, 82);
            this.PMName.MaxDropDownItems = 5;
            this.PMName.Name = "PMName";
            this.PMName.Size = new System.Drawing.Size(163, 24);
            this.PMName.TabIndex = 19;
            // 
            // WO_ITEMS_N
            // 
            this.WO_ITEMS_N.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_ITEMS_N.Location = new System.Drawing.Point(212, 82);
            this.WO_ITEMS_N.Name = "WO_ITEMS_N";
            this.WO_ITEMS_N.Size = new System.Drawing.Size(63, 26);
            this.WO_ITEMS_N.TabIndex = 20;
            this.WO_ITEMS_N.Text = "품목";
            this.WO_ITEMS_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_STAT_N
            // 
            this.WO_STAT_N.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_STAT_N.Location = new System.Drawing.Point(450, 82);
            this.WO_STAT_N.Name = "WO_STAT_N";
            this.WO_STAT_N.Size = new System.Drawing.Size(63, 26);
            this.WO_STAT_N.TabIndex = 21;
            this.WO_STAT_N.Text = "상태";
            this.WO_STAT_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WO_DATE_N
            // 
            this.WO_DATE_N.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_DATE_N.Location = new System.Drawing.Point(212, 154);
            this.WO_DATE_N.Name = "WO_DATE_N";
            this.WO_DATE_N.Size = new System.Drawing.Size(63, 26);
            this.WO_DATE_N.TabIndex = 23;
            this.WO_DATE_N.Text = "기간";
            this.WO_DATE_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1196, 39);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(315, 122);
            this.textBox1.TabIndex = 25;
            // 
            // WO
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1584, 861);
            this.Controls.Add(this.textBox1);
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
            this.Controls.Add(this.panel1);
            this.Name = "WO";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.WO_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WO_GRID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WO_LABEL;
        private System.Windows.Forms.DateTimePicker WoStartTime;
        private System.Windows.Forms.ComboBox WoStat;
        private System.Windows.Forms.DateTimePicker WoEndTime;
        private System.Windows.Forms.DataGridView WO_GRID;
        private System.Windows.Forms.Button WO_VIEW;
        private System.Windows.Forms.Button WO_CREATE;
        private System.Windows.Forms.Button WO_DEL;
        private System.Windows.Forms.ComboBox PMName;
        private System.Windows.Forms.Label WO_ITEMS_N;
        private System.Windows.Forms.Label WO_STAT_N;
        private System.Windows.Forms.Label WO_DATE_N;
        private System.Windows.Forms.TextBox textBox1;
    }
}


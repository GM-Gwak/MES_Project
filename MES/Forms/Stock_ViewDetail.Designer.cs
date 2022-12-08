namespace MES
{
    partial class Stock_ViewDetail
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ST_DT_Label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ST_DT_View = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.ST_DT = new System.Windows.Forms.Label();
            this.ST_DT_DATE = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ST_Re_Exit = new FontAwesome.Sharp.IconButton();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("굴림", 15F);
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePicker1.CustomFormat = "yy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("굴림", 15F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(395, 7);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 30);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("굴림", 15F);
            this.dateTimePicker2.CalendarMonthBackground = System.Drawing.SystemColors.Menu;
            this.dateTimePicker2.CustomFormat = "yy-MM-dd";
            this.dateTimePicker2.Font = new System.Drawing.Font("굴림", 15F);
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(606, 7);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(163, 30);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.comboBox1.Font = new System.Drawing.Font("굴림", 15F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.IntegralHeight = false;
            this.comboBox1.Items.AddRange(new object[] {
            "",
            "만두피",
            "양파",
            "부추",
            "양배추",
            "대파",
            "돼지고기",
            "간장",
            "설탕",
            "후추",
            "소금",
            "마늘",
            "두부",
            "당면",
            "김치",
            "갈비양념",
            "호박",
            "고기만두",
            "갈비만두",
            "김치만두"});
            this.comboBox1.Location = new System.Drawing.Point(113, 9);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(163, 28);
            this.comboBox1.TabIndex = 5;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("굴림", 14F);
            this.button3.Location = new System.Drawing.Point(665, 522);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(104, 38);
            this.button3.TabIndex = 7;
            this.button3.Text = "초기화";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.ST_DT_Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(935, 58);
            this.panel1.TabIndex = 55;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(931, 2);
            this.label6.TabIndex = 66;
            this.label6.Text = "label6";
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(2, 58);
            this.label3.TabIndex = 65;
            this.label3.Text = "label3";
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Location = new System.Drawing.Point(933, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(2, 58);
            this.label1.TabIndex = 62;
            this.label1.Text = "label1";
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
            this.iconPictureBox1.TabIndex = 53;
            this.iconPictureBox1.TabStop = false;
            // 
            // ST_DT_Label1
            // 
            this.ST_DT_Label1.Font = new System.Drawing.Font("나눔고딕코딩", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_DT_Label1.ForeColor = System.Drawing.Color.White;
            this.ST_DT_Label1.Location = new System.Drawing.Point(312, 9);
            this.ST_DT_Label1.Name = "ST_DT_Label1";
            this.ST_DT_Label1.Size = new System.Drawing.Size(312, 41);
            this.ST_DT_Label1.TabIndex = 32;
            this.ST_DT_Label1.Text = "재고 목록 상세";
            this.ST_DT_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.ST_DT_View);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ST_DT);
            this.panel2.Controls.Add(this.ST_DT_DATE);
            this.panel2.Controls.Add(this.dateTimePicker2);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.dateTimePicker1);
            this.panel2.Location = new System.Drawing.Point(-1, 58);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(935, 46);
            this.panel2.TabIndex = 56;
            // 
            // ST_DT_View
            // 
            this.ST_DT_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ST_DT_View.FlatAppearance.BorderSize = 0;
            this.ST_DT_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_DT_View.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_DT_View.ForeColor = System.Drawing.Color.White;
            this.ST_DT_View.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ST_DT_View.IconColor = System.Drawing.Color.White;
            this.ST_DT_View.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ST_DT_View.IconSize = 30;
            this.ST_DT_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ST_DT_View.Location = new System.Drawing.Point(817, 5);
            this.ST_DT_View.Name = "ST_DT_View";
            this.ST_DT_View.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ST_DT_View.Size = new System.Drawing.Size(106, 36);
            this.ST_DT_View.TabIndex = 57;
            this.ST_DT_View.Tag = "Button4";
            this.ST_DT_View.Text = "   조회";
            this.ST_DT_View.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ST_DT_View.UseVisualStyleBackColor = false;
            this.ST_DT_View.Click += new System.EventHandler(this.ST_DT_View_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(564, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 42);
            this.label2.TabIndex = 49;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_DT
            // 
            this.ST_DT.BackColor = System.Drawing.SystemColors.Menu;
            this.ST_DT.Dock = System.Windows.Forms.DockStyle.Left;
            this.ST_DT.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_DT.Location = new System.Drawing.Point(0, 0);
            this.ST_DT.Name = "ST_DT";
            this.ST_DT.Size = new System.Drawing.Size(107, 44);
            this.ST_DT.TabIndex = 40;
            this.ST_DT.Text = "품목";
            this.ST_DT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_DT_DATE
            // 
            this.ST_DT_DATE.BackColor = System.Drawing.SystemColors.Menu;
            this.ST_DT_DATE.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_DT_DATE.Location = new System.Drawing.Point(282, 0);
            this.ST_DT_DATE.Name = "ST_DT_DATE";
            this.ST_DT_DATE.Size = new System.Drawing.Size(107, 44);
            this.ST_DT_DATE.TabIndex = 39;
            this.ST_DT_DATE.Text = "기간";
            this.ST_DT_DATE.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(38, 143);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(854, 350);
            this.dataGridView1.TabIndex = 59;
            // 
            // ST_Re_Exit
            // 
            this.ST_Re_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ST_Re_Exit.FlatAppearance.BorderSize = 0;
            this.ST_Re_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_Re_Exit.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_Re_Exit.ForeColor = System.Drawing.Color.White;
            this.ST_Re_Exit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.ST_Re_Exit.IconColor = System.Drawing.Color.White;
            this.ST_Re_Exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ST_Re_Exit.IconSize = 30;
            this.ST_Re_Exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ST_Re_Exit.Location = new System.Drawing.Point(419, 524);
            this.ST_Re_Exit.Name = "ST_Re_Exit";
            this.ST_Re_Exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ST_Re_Exit.Size = new System.Drawing.Size(103, 36);
            this.ST_Re_Exit.TabIndex = 60;
            this.ST_Re_Exit.Tag = "Button4";
            this.ST_Re_Exit.Text = " 닫기";
            this.ST_Re_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ST_Re_Exit.UseVisualStyleBackColor = false;
            this.ST_Re_Exit.Click += new System.EventHandler(this.ST_Re_Exit_Click);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(933, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 537);
            this.label7.TabIndex = 61;
            this.label7.Text = "label7";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 593);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(933, 2);
            this.label5.TabIndex = 63;
            this.label5.Text = "label5";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 535);
            this.label8.TabIndex = 64;
            this.label8.Text = "label8";
            // 
            // Stock_ViewDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(935, 595);
            this.ControlBox = false;
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ST_Re_Exit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button3);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock_ViewDetail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.Stock_ViewDetail_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label ST_DT_Label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label ST_DT;
        private System.Windows.Forms.Label ST_DT_DATE;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton ST_DT_View;
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton ST_Re_Exit;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
    }
}
namespace MES
{
    partial class Stock_Receiving
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ST_Rec_Label = new System.Windows.Forms.Label();
            this.ST_Rec_OK = new FontAwesome.Sharp.IconButton();
            this.ST_Re_Exit = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("맑은 고딕", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(153, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(119, 35);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("굴림", 16F);
            this.comboBox1.FormattingEnabled = true;
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
            "호박"});
            this.comboBox1.Location = new System.Drawing.Point(12, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 29);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(30, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "재고명";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(180, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "수량";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(384, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "입고날짜";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "yy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("굴림", 16F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(349, 110);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 32);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 18F);
            this.label4.Location = new System.Drawing.Point(295, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kg";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.ST_Rec_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(676, 58);
            this.panel1.TabIndex = 54;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 58);
            this.iconPictureBox1.TabIndex = 53;
            this.iconPictureBox1.TabStop = false;
            // 
            // ST_Rec_Label
            // 
            this.ST_Rec_Label.Font = new System.Drawing.Font("나눔고딕코딩", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_Rec_Label.ForeColor = System.Drawing.Color.White;
            this.ST_Rec_Label.Location = new System.Drawing.Point(162, 10);
            this.ST_Rec_Label.Name = "ST_Rec_Label";
            this.ST_Rec_Label.Size = new System.Drawing.Size(169, 41);
            this.ST_Rec_Label.TabIndex = 32;
            this.ST_Rec_Label.Text = "지시서 등록";
            this.ST_Rec_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_Rec_OK
            // 
            this.ST_Rec_OK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ST_Rec_OK.FlatAppearance.BorderSize = 0;
            this.ST_Rec_OK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_Rec_OK.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_Rec_OK.ForeColor = System.Drawing.Color.White;
            this.ST_Rec_OK.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.ST_Rec_OK.IconColor = System.Drawing.Color.White;
            this.ST_Rec_OK.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ST_Rec_OK.IconSize = 30;
            this.ST_Rec_OK.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ST_Rec_OK.Location = new System.Drawing.Point(104, 254);
            this.ST_Rec_OK.Name = "ST_Rec_OK";
            this.ST_Rec_OK.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ST_Rec_OK.Size = new System.Drawing.Size(103, 36);
            this.ST_Rec_OK.TabIndex = 55;
            this.ST_Rec_OK.Tag = "Button4";
            this.ST_Rec_OK.Text = "  확인";
            this.ST_Rec_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ST_Rec_OK.UseVisualStyleBackColor = false;
            this.ST_Rec_OK.Click += new System.EventHandler(this.ST_Rec_OK_Click);
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
            this.ST_Re_Exit.Location = new System.Drawing.Point(349, 254);
            this.ST_Re_Exit.Name = "ST_Re_Exit";
            this.ST_Re_Exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ST_Re_Exit.Size = new System.Drawing.Size(103, 36);
            this.ST_Re_Exit.TabIndex = 56;
            this.ST_Re_Exit.Tag = "Button4";
            this.ST_Re_Exit.Text = " 닫기";
            this.ST_Re_Exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ST_Re_Exit.UseVisualStyleBackColor = false;
            this.ST_Re_Exit.Click += new System.EventHandler(this.ST_Re_Exit_Click);
            // 
            // Stock_Receiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(676, 353);
            this.Controls.Add(this.ST_Re_Exit);
            this.Controls.Add(this.ST_Rec_OK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Name = "Stock_Receiving";
            this.Text = "Stock_Receiving";
            this.Load += new System.EventHandler(this.Stock_Receiving_Load_1);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label ST_Rec_Label;
        private FontAwesome.Sharp.IconButton ST_Rec_OK;
        private FontAwesome.Sharp.IconButton ST_Re_Exit;
    }
}
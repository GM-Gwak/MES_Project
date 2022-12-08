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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.ST_Rec_Label = new System.Windows.Forms.Label();
            this.ST_Rec_OK = new FontAwesome.Sharp.IconButton();
            this.ST_Re_Exit = new FontAwesome.Sharp.IconButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.textBox1.Location = new System.Drawing.Point(142, 171);
            this.textBox1.MaxLength = 5;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(241, 30);
            this.textBox1.TabIndex = 1;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("굴림", 15F);
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
            this.comboBox1.Location = new System.Drawing.Point(142, 102);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(241, 28);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(49, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "제품명";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(73, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "수량";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(49, 245);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "입고일";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.dateTimePicker1.CustomFormat = "yy-MM-dd";
            this.dateTimePicker1.Font = new System.Drawing.Font("굴림", 15F);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(142, 242);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(241, 30);
            this.dateTimePicker1.TabIndex = 6;
            this.dateTimePicker1.Value = new System.DateTime(2022, 12, 1, 0, 0, 0, 0);
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dateTimePicker1_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.ST_Rec_Label);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 58);
            this.panel1.TabIndex = 54;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Black;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Location = new System.Drawing.Point(0, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(2, 56);
            this.label10.TabIndex = 61;
            this.label10.Text = "label10";
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Black;
            this.label9.Dock = System.Windows.Forms.DockStyle.Right;
            this.label9.Location = new System.Drawing.Point(488, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(2, 56);
            this.label9.TabIndex = 60;
            this.label9.Text = "label9";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Black;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(490, 2);
            this.label6.TabIndex = 58;
            this.label6.Text = "label6";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(2, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 58);
            this.iconPictureBox1.TabIndex = 53;
            this.iconPictureBox1.TabStop = false;
            // 
            // ST_Rec_Label
            // 
            this.ST_Rec_Label.Font = new System.Drawing.Font("나눔고딕코딩", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_Rec_Label.ForeColor = System.Drawing.Color.White;
            this.ST_Rec_Label.Location = new System.Drawing.Point(167, 10);
            this.ST_Rec_Label.Name = "ST_Rec_Label";
            this.ST_Rec_Label.Size = new System.Drawing.Size(169, 41);
            this.ST_Rec_Label.TabIndex = 32;
            this.ST_Rec_Label.Text = "입고 등록";
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
            this.ST_Rec_OK.Location = new System.Drawing.Point(77, 302);
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
            this.ST_Re_Exit.Location = new System.Drawing.Point(309, 302);
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
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Black;
            this.label5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label5.Location = new System.Drawing.Point(0, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(490, 2);
            this.label5.TabIndex = 57;
            this.label5.Text = "label5";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Black;
            this.label7.Dock = System.Windows.Forms.DockStyle.Right;
            this.label7.Location = new System.Drawing.Point(488, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(2, 297);
            this.label7.TabIndex = 59;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Black;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Location = new System.Drawing.Point(0, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(2, 297);
            this.label8.TabIndex = 60;
            this.label8.Text = "label8";
            // 
            // Stock_Receiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 357);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ST_Re_Exit);
            this.Controls.Add(this.ST_Rec_OK);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Stock_Receiving";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label ST_Rec_Label;
        private FontAwesome.Sharp.IconButton ST_Rec_OK;
        private FontAwesome.Sharp.IconButton ST_Re_Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
    }
}
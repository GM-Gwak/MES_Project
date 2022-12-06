namespace MES.Workorder_Form
{
    partial class WorkOrder_Create
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
            this.PD = new System.Windows.Forms.ComboBox();
            this.EA = new System.Windows.Forms.TextBox();
            this.EA_N = new System.Windows.Forms.Label();
            this.PD_N = new System.Windows.Forms.Label();
            this.ok = new FontAwesome.Sharp.IconButton();
            this.exit = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.WO_CT_Label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PD
            // 
            this.PD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PD.Font = new System.Drawing.Font("굴림", 15F);
            this.PD.FormattingEnabled = true;
            this.PD.Items.AddRange(new object[] {
            "pme01",
            "pki01",
            "pri01"});
            this.PD.Location = new System.Drawing.Point(142, 102);
            this.PD.Name = "PD";
            this.PD.Size = new System.Drawing.Size(241, 28);
            this.PD.TabIndex = 30;
            // 
            // EA
            // 
            this.EA.Font = new System.Drawing.Font("굴림", 15F);
            this.EA.Location = new System.Drawing.Point(142, 172);
            this.EA.MaxLength = 5;
            this.EA.Multiline = true;
            this.EA.Name = "EA";
            this.EA.Size = new System.Drawing.Size(241, 28);
            this.EA.TabIndex = 29;
            this.EA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // EA_N
            // 
            this.EA_N.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.EA_N.Location = new System.Drawing.Point(73, 172);
            this.EA_N.Name = "EA_N";
            this.EA_N.Size = new System.Drawing.Size(63, 26);
            this.EA_N.TabIndex = 28;
            this.EA_N.Text = "수량";
            this.EA_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PD_N
            // 
            this.PD_N.Font = new System.Drawing.Font("나눔고딕코딩", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.PD_N.Location = new System.Drawing.Point(73, 102);
            this.PD_N.Name = "PD_N";
            this.PD_N.Size = new System.Drawing.Size(63, 26);
            this.PD_N.TabIndex = 27;
            this.PD_N.Text = "품목";
            this.PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ok
            // 
            this.ok.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ok.FlatAppearance.BorderSize = 0;
            this.ok.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ok.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ok.ForeColor = System.Drawing.Color.White;
            this.ok.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.ok.IconColor = System.Drawing.Color.White;
            this.ok.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ok.IconSize = 30;
            this.ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ok.Location = new System.Drawing.Point(77, 252);
            this.ok.Name = "ok";
            this.ok.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ok.Size = new System.Drawing.Size(103, 36);
            this.ok.TabIndex = 51;
            this.ok.Tag = "Button4";
            this.ok.Text = "  확인";
            this.ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ok.UseVisualStyleBackColor = false;
            this.ok.Click += new System.EventHandler(this.ok_Click_1);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.exit.ForeColor = System.Drawing.Color.White;
            this.exit.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.exit.IconColor = System.Drawing.Color.White;
            this.exit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit.IconSize = 30;
            this.exit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.exit.Location = new System.Drawing.Point(309, 252);
            this.exit.Name = "exit";
            this.exit.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.exit.Size = new System.Drawing.Size(103, 36);
            this.exit.TabIndex = 52;
            this.exit.Tag = "Button4";
            this.exit.Text = " 닫기";
            this.exit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click_1);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.WO_CT_Label);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 58);
            this.panel1.TabIndex = 53;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
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
            // WO_CT_Label
            // 
            this.WO_CT_Label.Font = new System.Drawing.Font("나눔고딕코딩", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_CT_Label.ForeColor = System.Drawing.Color.White;
            this.WO_CT_Label.Location = new System.Drawing.Point(162, 10);
            this.WO_CT_Label.Name = "WO_CT_Label";
            this.WO_CT_Label.Size = new System.Drawing.Size(169, 41);
            this.WO_CT_Label.TabIndex = 32;
            this.WO_CT_Label.Text = "지시서 등록";
            this.WO_CT_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.WO_CT_Label.MouseDown += new System.Windows.Forms.MouseEventHandler(this.WO_LABEL_MouseDown);
            // 
            // WorkOrder_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(490, 307);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.PD);
            this.Controls.Add(this.EA);
            this.Controls.Add(this.EA_N);
            this.Controls.Add(this.PD_N);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkOrder_Create";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Workorder_Create";
            this.Load += new System.EventHandler(this.Workorder_Create_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PD;
        private System.Windows.Forms.TextBox EA;
        private System.Windows.Forms.Label EA_N;
        private System.Windows.Forms.Label PD_N;
        private FontAwesome.Sharp.IconButton ok;
        private FontAwesome.Sharp.IconButton exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label WO_CT_Label;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}
namespace MES.Workorder_Form
{
    partial class WorkOrder_Detail
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ok = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.WO_LABEL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(59, 116);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(682, 297);
            this.dataGridView1.TabIndex = 2;
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
            this.ok.Location = new System.Drawing.Point(585, 252);
            this.ok.Name = "ok";
            this.ok.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ok.Size = new System.Drawing.Size(103, 36);
            this.ok.TabIndex = 52;
            this.ok.Tag = "Button4";
            this.ok.Text = "  확인";
            this.ok.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ok.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.WO_LABEL);
            this.panel1.Location = new System.Drawing.Point(177, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(490, 58);
            this.panel1.TabIndex = 54;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 58);
            this.iconPictureBox1.TabIndex = 53;
            this.iconPictureBox1.TabStop = false;
            // 
            // WO_LABEL
            // 
            this.WO_LABEL.Font = new System.Drawing.Font("나눔고딕코딩", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_LABEL.Location = new System.Drawing.Point(162, 10);
            this.WO_LABEL.Name = "WO_LABEL";
            this.WO_LABEL.Size = new System.Drawing.Size(169, 41);
            this.WO_LABEL.TabIndex = 32;
            this.WO_LABEL.Text = "지시서 등록";
            this.WO_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkOrder_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ok);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WorkOrder_Detail";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WorkOrder_Detail";
            this.Load += new System.EventHandler(this.WorkOrder_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private FontAwesome.Sharp.IconButton ok;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label WO_LABEL;
    }
}
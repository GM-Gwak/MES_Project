﻿namespace MES.Workorder_Form
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
            this.Wo_detail_close = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.WO_DT_Label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(20, 78);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(756, 297);
            this.dataGridView1.TabIndex = 2;
            // 
            // Wo_detail_close
            // 
            this.Wo_detail_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.Wo_detail_close.FlatAppearance.BorderSize = 0;
            this.Wo_detail_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Wo_detail_close.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Wo_detail_close.ForeColor = System.Drawing.Color.White;
            this.Wo_detail_close.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.Wo_detail_close.IconColor = System.Drawing.Color.White;
            this.Wo_detail_close.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Wo_detail_close.IconSize = 30;
            this.Wo_detail_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Wo_detail_close.Location = new System.Drawing.Point(350, 402);
            this.Wo_detail_close.Name = "Wo_detail_close";
            this.Wo_detail_close.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Wo_detail_close.Size = new System.Drawing.Size(103, 36);
            this.Wo_detail_close.TabIndex = 52;
            this.Wo_detail_close.Tag = "Button4";
            this.Wo_detail_close.Text = "  닫기";
            this.Wo_detail_close.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Wo_detail_close.UseVisualStyleBackColor = false;
            this.Wo_detail_close.Click += new System.EventHandler(this.Wo_detail_close_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.iconPictureBox1);
            this.panel1.Controls.Add(this.WO_DT_Label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 58);
            this.panel1.TabIndex = 54;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 58;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 58);
            this.iconPictureBox1.TabIndex = 53;
            this.iconPictureBox1.TabStop = false;
            // 
            // WO_DT_Label1
            // 
            this.WO_DT_Label1.Font = new System.Drawing.Font("나눔고딕코딩", 21F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_DT_Label1.Location = new System.Drawing.Point(93, 9);
            this.WO_DT_Label1.Name = "WO_DT_Label1";
            this.WO_DT_Label1.Size = new System.Drawing.Size(617, 41);
            this.WO_DT_Label1.TabIndex = 32;
            this.WO_DT_Label1.Text = "wo00001 지시서 상세 정보";
            this.WO_DT_Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WorkOrder_Detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Wo_detail_close);
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
        private FontAwesome.Sharp.IconButton Wo_detail_close;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label WO_DT_Label1;
    }
}
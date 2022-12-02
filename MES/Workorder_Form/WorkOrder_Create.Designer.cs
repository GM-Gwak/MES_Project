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
            this.exit = new System.Windows.Forms.Button();
            this.ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PD
            // 
            this.PD.Font = new System.Drawing.Font("굴림", 15F);
            this.PD.FormattingEnabled = true;
            this.PD.Items.AddRange(new object[] {
            "pme01",
            "pki01",
            "pri01"});
            this.PD.Location = new System.Drawing.Point(167, 56);
            this.PD.Name = "PD";
            this.PD.Size = new System.Drawing.Size(190, 28);
            this.PD.TabIndex = 30;
            // 
            // EA
            // 
            this.EA.Font = new System.Drawing.Font("굴림", 15F);
            this.EA.Location = new System.Drawing.Point(167, 212);
            this.EA.Multiline = true;
            this.EA.Name = "EA";
            this.EA.Size = new System.Drawing.Size(190, 28);
            this.EA.TabIndex = 29;
            // 
            // EA_N
            // 
            this.EA_N.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.EA_N.Location = new System.Drawing.Point(85, 212);
            this.EA_N.Name = "EA_N";
            this.EA_N.Size = new System.Drawing.Size(63, 26);
            this.EA_N.TabIndex = 28;
            this.EA_N.Text = "수량";
            this.EA_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PD_N
            // 
            this.PD_N.Font = new System.Drawing.Font("굴림", 18F, System.Drawing.FontStyle.Bold);
            this.PD_N.Location = new System.Drawing.Point(85, 56);
            this.PD_N.Name = "PD_N";
            this.PD_N.Size = new System.Drawing.Size(63, 26);
            this.PD_N.TabIndex = 27;
            this.PD_N.Text = "품목";
            this.PD_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("굴림", 18F);
            this.exit.Location = new System.Drawing.Point(272, 348);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(188, 49);
            this.exit.TabIndex = 26;
            this.exit.Text = "취소";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // ok
            // 
            this.ok.Font = new System.Drawing.Font("굴림", 18F);
            this.ok.Location = new System.Drawing.Point(24, 348);
            this.ok.Name = "ok";
            this.ok.Size = new System.Drawing.Size(188, 49);
            this.ok.TabIndex = 25;
            this.ok.Text = "확인";
            this.ok.UseVisualStyleBackColor = true;
            this.ok.Click += new System.EventHandler(this.ok_Click);
            // 
            // Workorder_Create
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 450);
            this.Controls.Add(this.PD);
            this.Controls.Add(this.EA);
            this.Controls.Add(this.EA_N);
            this.Controls.Add(this.PD_N);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.ok);
            this.Name = "Workorder_Create";
            this.Text = "Workorder_Create";
            this.Load += new System.EventHandler(this.Workorder_Create_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PD;
        private System.Windows.Forms.TextBox EA;
        private System.Windows.Forms.Label EA_N;
        private System.Windows.Forms.Label PD_N;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.Button ok;
    }
}
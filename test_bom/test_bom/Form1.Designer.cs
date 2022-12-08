namespace test_bom
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.start_1 = new System.Windows.Forms.Button();
            this.end_1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.end_2 = new System.Windows.Forms.Button();
            this.start_2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.end_3 = new System.Windows.Forms.Button();
            this.start_3 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.end_4 = new System.Windows.Forms.Button();
            this.start_4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 30);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(181, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "다음 workorder 가져오기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // start_1
            // 
            this.start_1.Location = new System.Drawing.Point(141, 98);
            this.start_1.Name = "start_1";
            this.start_1.Size = new System.Drawing.Size(155, 30);
            this.start_1.TabIndex = 1;
            this.start_1.Text = "시작";
            this.start_1.UseVisualStyleBackColor = true;
            this.start_1.Click += new System.EventHandler(this.start_1_Click);
            // 
            // end_1
            // 
            this.end_1.Location = new System.Drawing.Point(141, 152);
            this.end_1.Name = "end_1";
            this.end_1.Size = new System.Drawing.Size(155, 23);
            this.end_1.TabIndex = 2;
            this.end_1.Text = "종료";
            this.end_1.UseVisualStyleBackColor = true;
            this.end_1.Click += new System.EventHandler(this.end_1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "작업장 1";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 290);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "작업장 2";
            // 
            // end_2
            // 
            this.end_2.Location = new System.Drawing.Point(141, 314);
            this.end_2.Name = "end_2";
            this.end_2.Size = new System.Drawing.Size(155, 23);
            this.end_2.TabIndex = 5;
            this.end_2.Text = "종료";
            this.end_2.UseVisualStyleBackColor = true;
            this.end_2.Click += new System.EventHandler(this.end_2_Click);
            // 
            // start_2
            // 
            this.start_2.Location = new System.Drawing.Point(141, 260);
            this.start_2.Name = "start_2";
            this.start_2.Size = new System.Drawing.Size(155, 30);
            this.start_2.TabIndex = 4;
            this.start_2.Text = "시작";
            this.start_2.UseVisualStyleBackColor = true;
            this.start_2.Click += new System.EventHandler(this.start_2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 12);
            this.label3.TabIndex = 9;
            this.label3.Text = "작업장 3";
            // 
            // end_3
            // 
            this.end_3.Location = new System.Drawing.Point(504, 152);
            this.end_3.Name = "end_3";
            this.end_3.Size = new System.Drawing.Size(155, 23);
            this.end_3.TabIndex = 8;
            this.end_3.Text = "종료";
            this.end_3.UseVisualStyleBackColor = true;
            this.end_3.Click += new System.EventHandler(this.end_3_Click);
            // 
            // start_3
            // 
            this.start_3.Location = new System.Drawing.Point(504, 98);
            this.start_3.Name = "start_3";
            this.start_3.Size = new System.Drawing.Size(155, 30);
            this.start_3.TabIndex = 7;
            this.start_3.Text = "시작";
            this.start_3.UseVisualStyleBackColor = true;
            this.start_3.Click += new System.EventHandler(this.start_3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "작업장 4";
            // 
            // end_4
            // 
            this.end_4.Location = new System.Drawing.Point(504, 314);
            this.end_4.Name = "end_4";
            this.end_4.Size = new System.Drawing.Size(155, 23);
            this.end_4.TabIndex = 11;
            this.end_4.Text = "종료";
            this.end_4.UseVisualStyleBackColor = true;
            this.end_4.Click += new System.EventHandler(this.end_4_Click);
            // 
            // start_4
            // 
            this.start_4.Location = new System.Drawing.Point(504, 260);
            this.start_4.Name = "start_4";
            this.start_4.Size = new System.Drawing.Size(155, 30);
            this.start_4.TabIndex = 10;
            this.start_4.Text = "시작";
            this.start_4.UseVisualStyleBackColor = true;
            this.start_4.Click += new System.EventHandler(this.start_4_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(486, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 13;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.end_4);
            this.Controls.Add(this.start_4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.end_3);
            this.Controls.Add(this.start_3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.end_2);
            this.Controls.Add(this.start_2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.end_1);
            this.Controls.Add(this.start_1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button start_1;
        private System.Windows.Forms.Button end_1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button end_2;
        private System.Windows.Forms.Button start_2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button end_3;
        private System.Windows.Forms.Button start_3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button end_4;
        private System.Windows.Forms.Button start_4;
        private System.Windows.Forms.Button button2;
    }
}


namespace MES.seungmin_Forms
{
    partial class faulty
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_faulty_detail = new FontAwesome.Sharp.IconButton();
            this.faulty_search = new FontAwesome.Sharp.IconButton();
            this.WO_LABEL = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.date_1 = new System.Windows.Forms.DateTimePicker();
            this.date_2 = new System.Windows.Forms.DateTimePicker();
            this.WO_DATE_N = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea2.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chart1.Legends.Add(legend2);
            this.chart1.Location = new System.Drawing.Point(49, 141);
            this.chart1.Name = "chart1";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series5.IsValueShownAsLabel = true;
            series5.Legend = "Legend1";
            series5.Name = "고기만두";
            series5.ShadowColor = System.Drawing.Color.White;
            series5.ShadowOffset = 10;
            series6.ChartArea = "ChartArea1";
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            series6.IsValueShownAsLabel = true;
            series6.Legend = "Legend1";
            series6.Name = "김치만두";
            series7.ChartArea = "ChartArea1";
            series7.Color = System.Drawing.Color.Salmon;
            series7.IsValueShownAsLabel = true;
            series7.Legend = "Legend1";
            series7.Name = "갈비만두";
            series8.ChartArea = "ChartArea1";
            series8.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series8.Color = System.Drawing.Color.Blue;
            series8.IsValueShownAsLabel = true;
            series8.Legend = "Legend1";
            series8.Name = "총 합";
            series8.YAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            this.chart1.Series.Add(series5);
            this.chart1.Series.Add(series6);
            this.chart1.Series.Add(series7);
            this.chart1.Series.Add(series8);
            this.chart1.Size = new System.Drawing.Size(1320, 579);
            this.chart1.TabIndex = 34;
            this.chart1.Text = "chart1";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.btn_faulty_detail);
            this.panel2.Controls.Add(this.faulty_search);
            this.panel2.Controls.Add(this.WO_LABEL);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1553, 66);
            this.panel2.TabIndex = 52;
            // 
            // btn_faulty_detail
            // 
            this.btn_faulty_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.btn_faulty_detail.FlatAppearance.BorderSize = 0;
            this.btn_faulty_detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_faulty_detail.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn_faulty_detail.ForeColor = System.Drawing.Color.White;
            this.btn_faulty_detail.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.btn_faulty_detail.IconColor = System.Drawing.Color.White;
            this.btn_faulty_detail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_faulty_detail.IconSize = 30;
            this.btn_faulty_detail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_faulty_detail.Location = new System.Drawing.Point(1091, 18);
            this.btn_faulty_detail.Name = "btn_faulty_detail";
            this.btn_faulty_detail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btn_faulty_detail.Size = new System.Drawing.Size(126, 36);
            this.btn_faulty_detail.TabIndex = 53;
            this.btn_faulty_detail.Tag = "상세보기";
            this.btn_faulty_detail.Text = "상세보기";
            this.btn_faulty_detail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_faulty_detail.UseVisualStyleBackColor = false;
            this.btn_faulty_detail.Click += new System.EventHandler(this.btn_faulty_detail_Click);
            // 
            // faulty_search
            // 
            this.faulty_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.faulty_search.FlatAppearance.BorderSize = 0;
            this.faulty_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.faulty_search.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.faulty_search.ForeColor = System.Drawing.Color.White;
            this.faulty_search.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.faulty_search.IconColor = System.Drawing.Color.White;
            this.faulty_search.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.faulty_search.IconSize = 30;
            this.faulty_search.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.faulty_search.Location = new System.Drawing.Point(1223, 18);
            this.faulty_search.Name = "faulty_search";
            this.faulty_search.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.faulty_search.Size = new System.Drawing.Size(106, 36);
            this.faulty_search.TabIndex = 49;
            this.faulty_search.Tag = "조회";
            this.faulty_search.Text = "조회";
            this.faulty_search.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.faulty_search.UseVisualStyleBackColor = false;
            this.faulty_search.Click += new System.EventHandler(this.faulty_search_Click);
            // 
            // WO_LABEL
            // 
            this.WO_LABEL.Font = new System.Drawing.Font("나눔고딕코딩", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_LABEL.Location = new System.Drawing.Point(80, 11);
            this.WO_LABEL.Name = "WO_LABEL";
            this.WO_LABEL.Size = new System.Drawing.Size(169, 41);
            this.WO_LABEL.TabIndex = 31;
            this.WO_LABEL.Text = "품질관리";
            this.WO_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 66;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 66);
            this.iconPictureBox1.TabIndex = 52;
            this.iconPictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.date_1);
            this.panel1.Controls.Add(this.date_2);
            this.panel1.Controls.Add(this.WO_DATE_N);
            this.panel1.Location = new System.Drawing.Point(-1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1553, 46);
            this.panel1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("굴림", 15F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(280, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 42);
            this.label2.TabIndex = 48;
            this.label2.Text = "-";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // date_1
            // 
            this.date_1.CustomFormat = "";
            this.date_1.Font = new System.Drawing.Font("굴림", 15F);
            this.date_1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_1.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.date_1.Location = new System.Drawing.Point(113, 7);
            this.date_1.Name = "date_1";
            this.date_1.Size = new System.Drawing.Size(161, 30);
            this.date_1.TabIndex = 34;
            // 
            // date_2
            // 
            this.date_2.CustomFormat = "";
            this.date_2.Font = new System.Drawing.Font("굴림", 15F);
            this.date_2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.date_2.ImeMode = System.Windows.Forms.ImeMode.KatakanaHalf;
            this.date_2.Location = new System.Drawing.Point(324, 7);
            this.date_2.Name = "date_2";
            this.date_2.Size = new System.Drawing.Size(161, 30);
            this.date_2.TabIndex = 34;
            // 
            // WO_DATE_N
            // 
            this.WO_DATE_N.BackColor = System.Drawing.SystemColors.Menu;
            this.WO_DATE_N.Dock = System.Windows.Forms.DockStyle.Left;
            this.WO_DATE_N.Font = new System.Drawing.Font("맑은 고딕", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_DATE_N.Location = new System.Drawing.Point(0, 0);
            this.WO_DATE_N.Name = "WO_DATE_N";
            this.WO_DATE_N.Size = new System.Drawing.Size(107, 44);
            this.WO_DATE_N.TabIndex = 41;
            this.WO_DATE_N.Text = "기간";
            this.WO_DATE_N.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // faulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1553, 824);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.chart1);
            this.Name = "faulty";
            this.Text = "faulty";
            this.Load += new System.EventHandler(this.faulty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label WO_LABEL;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker date_1;
        private System.Windows.Forms.DateTimePicker date_2;
        private System.Windows.Forms.Label WO_DATE_N;
        private FontAwesome.Sharp.IconButton faulty_search;
        private FontAwesome.Sharp.IconButton btn_faulty_detail;
    }
}
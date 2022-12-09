namespace MES
{
    partial class StockManagement
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ST_Add = new FontAwesome.Sharp.IconButton();
            this.WO_LABEL = new System.Windows.Forms.Label();
            this.ST_View = new FontAwesome.Sharp.IconButton();
            this.ST_Detail = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(-1, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 1);
            this.panel1.TabIndex = 48;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel2.Controls.Add(this.ST_Add);
            this.panel2.Controls.Add(this.WO_LABEL);
            this.panel2.Controls.Add(this.ST_View);
            this.panel2.Controls.Add(this.ST_Detail);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Location = new System.Drawing.Point(-1, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1356, 66);
            this.panel2.TabIndex = 52;
            // 
            // ST_Add
            // 
            this.ST_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ST_Add.FlatAppearance.BorderSize = 0;
            this.ST_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_Add.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_Add.ForeColor = System.Drawing.Color.White;
            this.ST_Add.IconChar = FontAwesome.Sharp.IconChar.ShoppingBag;
            this.ST_Add.IconColor = System.Drawing.Color.White;
            this.ST_Add.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ST_Add.IconSize = 30;
            this.ST_Add.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ST_Add.Location = new System.Drawing.Point(1073, 16);
            this.ST_Add.Name = "ST_Add";
            this.ST_Add.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ST_Add.Size = new System.Drawing.Size(153, 36);
            this.ST_Add.TabIndex = 2;
            this.ST_Add.Tag = "Button4";
            this.ST_Add.Text = "   입고 관리";
            this.ST_Add.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ST_Add.UseVisualStyleBackColor = false;
            this.ST_Add.Click += new System.EventHandler(this.ST_Add_Click);
            // 
            // WO_LABEL
            // 
            this.WO_LABEL.Font = new System.Drawing.Font("나눔고딕코딩", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.WO_LABEL.Location = new System.Drawing.Point(80, 11);
            this.WO_LABEL.Name = "WO_LABEL";
            this.WO_LABEL.Size = new System.Drawing.Size(169, 41);
            this.WO_LABEL.TabIndex = 31;
            this.WO_LABEL.Text = "재고관리";
            this.WO_LABEL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ST_View
            // 
            this.ST_View.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ST_View.FlatAppearance.BorderSize = 0;
            this.ST_View.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_View.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_View.ForeColor = System.Drawing.Color.White;
            this.ST_View.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.ST_View.IconColor = System.Drawing.Color.White;
            this.ST_View.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ST_View.IconSize = 30;
            this.ST_View.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ST_View.Location = new System.Drawing.Point(1232, 16);
            this.ST_View.Name = "ST_View";
            this.ST_View.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ST_View.Size = new System.Drawing.Size(106, 36);
            this.ST_View.TabIndex = 3;
            this.ST_View.Tag = "Button4";
            this.ST_View.Text = "   조회";
            this.ST_View.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ST_View.UseVisualStyleBackColor = false;
            this.ST_View.Click += new System.EventHandler(this.ST_View_Click);
            // 
            // ST_Detail
            // 
            this.ST_Detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.ST_Detail.FlatAppearance.BorderSize = 0;
            this.ST_Detail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ST_Detail.Font = new System.Drawing.Font("맑은 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ST_Detail.ForeColor = System.Drawing.Color.White;
            this.ST_Detail.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.ST_Detail.IconColor = System.Drawing.Color.White;
            this.ST_Detail.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ST_Detail.IconSize = 30;
            this.ST_Detail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ST_Detail.Location = new System.Drawing.Point(914, 16);
            this.ST_Detail.Name = "ST_Detail";
            this.ST_Detail.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ST_Detail.Size = new System.Drawing.Size(153, 36);
            this.ST_Detail.TabIndex = 1;
            this.ST_Detail.Tag = "Button4";
            this.ST_Detail.Text = "   재고 상세";
            this.ST_Detail.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ST_Detail.UseVisualStyleBackColor = false;
            this.ST_Detail.Click += new System.EventHandler(this.ST_Detail_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.iconPictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.ShoppingCart;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 66;
            this.iconPictureBox1.Location = new System.Drawing.Point(0, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(74, 66);
            this.iconPictureBox1.TabIndex = 52;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(-1, 744);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1356, 1);
            this.label1.TabIndex = 53;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(71)))), ((int)(((byte)(80)))));
            this.dataGridView1.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.dataGridView1.Location = new System.Drawing.Point(17, 87);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1320, 640);
            this.dataGridView1.TabIndex = 54;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // StockManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1354, 824);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "StockManagement";
            this.Text = "StockManagement";
            this.Load += new System.EventHandler(this.StockManagement_Load_1);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton ST_Add;
        private System.Windows.Forms.Label WO_LABEL;
        private FontAwesome.Sharp.IconButton ST_View;
        private FontAwesome.Sharp.IconButton ST_Detail;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


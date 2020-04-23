namespace BTL.Forms
{
    partial class frmthoikhoabieugv
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
            this.cboKyhoc = new System.Windows.Forms.ComboBox();
            this.cboNamhoc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.txtTengiaovien = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cboKyhoc
            // 
            this.cboKyhoc.FormattingEnabled = true;
            this.cboKyhoc.Items.AddRange(new object[] {
            "Kỳ 1",
            "Kỳ 2"});
            this.cboKyhoc.Location = new System.Drawing.Point(40, 93);
            this.cboKyhoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboKyhoc.Name = "cboKyhoc";
            this.cboKyhoc.Size = new System.Drawing.Size(158, 21);
            this.cboKyhoc.TabIndex = 4;
            // 
            // cboNamhoc
            // 
            this.cboNamhoc.FormattingEnabled = true;
            this.cboNamhoc.Items.AddRange(new object[] {
            "2013 - 2014",
            "2014 - 2015",
            "2015 - 2016",
            "2016 - 2017"});
            this.cboNamhoc.Location = new System.Drawing.Point(283, 93);
            this.cboNamhoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboNamhoc.Name = "cboNamhoc";
            this.cboNamhoc.Size = new System.Drawing.Size(158, 21);
            this.cboNamhoc.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 67);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chọn kỳ học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(217, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(299, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Thời khóa biểu giáo viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(541, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nhập tên giáo viên";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(57, 131);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(591, 99);
            this.DataGridView.TabIndex = 11;
            // 
            // txtTengiaovien
            // 
            this.txtTengiaovien.Location = new System.Drawing.Point(516, 95);
            this.txtTengiaovien.Margin = new System.Windows.Forms.Padding(2);
            this.txtTengiaovien.Name = "txtTengiaovien";
            this.txtTengiaovien.Size = new System.Drawing.Size(143, 20);
            this.txtTengiaovien.TabIndex = 12;
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.Image = global::BTL.Properties.Resources.icon_thoát;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(532, 251);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(78, 45);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.Image = global::BTL.Properties.Resources.icon_in;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(393, 251);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(79, 46);
            this.btnIn.TabIndex = 2;
            this.btnIn.Text = "  In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBoqua.Image = global::BTL.Properties.Resources.icon_bỏ_qua___hủy;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(243, 250);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(81, 46);
            this.btnBoqua.TabIndex = 1;
            this.btnBoqua.Text = "Bỏ qua";
            this.btnBoqua.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBaocao.Image = global::BTL.Properties.Resources.icon_Báo_cáo___OK;
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(93, 251);
            this.btnBaocao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(82, 46);
            this.btnBaocao.TabIndex = 0;
            this.btnBaocao.Text = "Báo cáo";
            this.btnBaocao.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(316, 67);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Chọn năm học";
            // 
            // frmthoikhoabieugv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources._17760642_393694617684539_520841252_n;
            this.ClientSize = new System.Drawing.Size(714, 318);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTengiaovien);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboNamhoc);
            this.Controls.Add(this.cboKyhoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnBaocao);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmthoikhoabieugv";
            this.Text = "frmthoikhoabieugv";
            this.Load += new System.EventHandler(this.frmthoikhoabieugv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cboKyhoc;
        private System.Windows.Forms.ComboBox cboNamhoc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.TextBox txtTengiaovien;
        private System.Windows.Forms.Label label5;

        public System.EventHandler label2_Click { get; set; }
    }
}
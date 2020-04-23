namespace BTL.Forms
{
    partial class frmFindGiaovien
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboKhoa = new System.Windows.Forms.ComboBox();
            this.cboChnganh = new System.Windows.Forms.ComboBox();
            this.cboBomon = new System.Windows.Forms.ComboBox();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Khoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(354, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chuyên ngành";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Bộ môn";
            // 
            // cboKhoa
            // 
            this.cboKhoa.FormattingEnabled = true;
            this.cboKhoa.Location = new System.Drawing.Point(80, 103);
            this.cboKhoa.Name = "cboKhoa";
            this.cboKhoa.Size = new System.Drawing.Size(167, 21);
            this.cboKhoa.TabIndex = 5;
            // 
            // cboChnganh
            // 
            this.cboChnganh.FormattingEnabled = true;
            this.cboChnganh.Location = new System.Drawing.Point(436, 54);
            this.cboChnganh.Name = "cboChnganh";
            this.cboChnganh.Size = new System.Drawing.Size(121, 21);
            this.cboChnganh.TabIndex = 6;
            // 
            // cboBomon
            // 
            this.cboBomon.FormattingEnabled = true;
            this.cboBomon.Location = new System.Drawing.Point(436, 100);
            this.cboBomon.Name = "cboBomon";
            this.cboBomon.Size = new System.Drawing.Size(121, 21);
            this.cboBomon.TabIndex = 7;
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(80, 55);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(167, 20);
            this.txtHoten.TabIndex = 8;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(53, 142);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(504, 109);
            this.DataGridView.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(166, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(289, 31);
            this.label5.TabIndex = 13;
            this.label5.Text = "TÌM KIẾM GIÁO VIÊN";
            // 
            // btnDong
            // 
            this.btnDong.Image = global::BTL.Properties.Resources.icon_thoát2;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(422, 267);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 38);
            this.btnDong.TabIndex = 12;
            this.btnDong.Text = "    Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Image = global::BTL.Properties.Resources._17821010_393719717682029_2044862426_n;
            this.btnTimlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimlai.Location = new System.Drawing.Point(263, 267);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(98, 38);
            this.btnTimlai.TabIndex = 11;
            this.btnTimlai.Text = "        Tìm lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::BTL.Properties.Resources._17814025_393717487682252_129849992_n;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(100, 267);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(98, 38);
            this.btnTimkiem.TabIndex = 10;
            this.btnTimkiem.Text = "       Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // frmFindGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources._17760642_393694617684539_520841252_n;
            this.ClientSize = new System.Drawing.Size(634, 317);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txtHoten);
            this.Controls.Add(this.cboBomon);
            this.Controls.Add(this.cboChnganh);
            this.Controls.Add(this.cboKhoa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmFindGiaovien";
            this.Text = "TÌM KIẾM GIÁO VIÊN";
            this.Load += new System.EventHandler(this.frmFindGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboKhoa;
        private System.Windows.Forms.ComboBox cboChnganh;
        private System.Windows.Forms.ComboBox cboBomon;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Label label5;
    }
}
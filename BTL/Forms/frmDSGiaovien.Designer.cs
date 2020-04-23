namespace BTL.Forms
{
    partial class frmDSGiaovien
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
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.cboMachnganh = new System.Windows.Forms.ComboBox();
            this.txtLuongtiet = new System.Windows.Forms.TextBox();
            this.cboMatrinhdo = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cboMaBM = new System.Windows.Forms.ComboBox();
            this.cboMakhoa = new System.Windows.Forms.ComboBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.txtTenGV = new System.Windows.Forms.TextBox();
            this.txtMaGV = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mskNgaysinh = new System.Windows.Forms.MaskedTextBox();
            this.chkGioitinh = new System.Windows.Forms.CheckBox();
            this.label12 = new System.Windows.Forms.Label();
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(36, 235);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(613, 118);
            this.DataGridView.TabIndex = 51;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // cboMachnganh
            // 
            this.cboMachnganh.FormattingEnabled = true;
            this.cboMachnganh.Location = new System.Drawing.Point(501, 177);
            this.cboMachnganh.Name = "cboMachnganh";
            this.cboMachnganh.Size = new System.Drawing.Size(148, 21);
            this.cboMachnganh.TabIndex = 50;
            // 
            // txtLuongtiet
            // 
            this.txtLuongtiet.Location = new System.Drawing.Point(501, 209);
            this.txtLuongtiet.Name = "txtLuongtiet";
            this.txtLuongtiet.Size = new System.Drawing.Size(100, 20);
            this.txtLuongtiet.TabIndex = 49;
            this.txtLuongtiet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLuongtiet_KeyPress);
            // 
            // cboMatrinhdo
            // 
            this.cboMatrinhdo.FormattingEnabled = true;
            this.cboMatrinhdo.Location = new System.Drawing.Point(501, 140);
            this.cboMatrinhdo.Name = "cboMatrinhdo";
            this.cboMatrinhdo.Size = new System.Drawing.Size(148, 21);
            this.cboMatrinhdo.TabIndex = 48;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(403, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Lương tiết";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(390, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(93, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Mã chuyên ngành";
            // 
            // cboMaBM
            // 
            this.cboMaBM.FormattingEnabled = true;
            this.cboMaBM.Location = new System.Drawing.Point(501, 111);
            this.cboMaBM.Name = "cboMaBM";
            this.cboMaBM.Size = new System.Drawing.Size(148, 21);
            this.cboMaBM.TabIndex = 45;
            // 
            // cboMakhoa
            // 
            this.cboMakhoa.FormattingEnabled = true;
            this.cboMakhoa.Location = new System.Drawing.Point(501, 77);
            this.cboMakhoa.Name = "cboMakhoa";
            this.cboMakhoa.Size = new System.Drawing.Size(148, 21);
            this.cboMakhoa.TabIndex = 44;
            this.cboMakhoa.TextChanged += new System.EventHandler(this.cboMakhoa_TextChanged);
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(107, 182);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(100, 20);
            this.txtDiachi.TabIndex = 42;
            // 
            // txtTenGV
            // 
            this.txtTenGV.Location = new System.Drawing.Point(107, 81);
            this.txtTenGV.Name = "txtTenGV";
            this.txtTenGV.Size = new System.Drawing.Size(100, 20);
            this.txtTenGV.TabIndex = 40;
            // 
            // txtMaGV
            // 
            this.txtMaGV.Location = new System.Drawing.Point(107, 53);
            this.txtMaGV.Name = "txtMaGV";
            this.txtMaGV.Size = new System.Drawing.Size(100, 20);
            this.txtMaGV.TabIndex = 39;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(404, 148);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 13);
            this.label9.TabIndex = 38;
            this.label9.Text = "Mã trình độ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(404, 114);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 37;
            this.label8.Text = "Mã bộ môn";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(408, 80);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Mã khoa";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(409, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 13);
            this.label6.TabIndex = 35;
            this.label6.Text = "Điện thoại";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(43, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 34;
            this.label5.Text = "Địa chỉ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 152);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Tên giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã giáo viên";
            // 
            // mskNgaysinh
            // 
            this.mskNgaysinh.Location = new System.Drawing.Point(107, 114);
            this.mskNgaysinh.Mask = "00/00/0000";
            this.mskNgaysinh.Name = "mskNgaysinh";
            this.mskNgaysinh.Size = new System.Drawing.Size(100, 20);
            this.mskNgaysinh.TabIndex = 59;
            this.mskNgaysinh.ValidatingType = typeof(System.DateTime);
            // 
            // chkGioitinh
            // 
            this.chkGioitinh.AutoSize = true;
            this.chkGioitinh.Location = new System.Drawing.Point(107, 152);
            this.chkGioitinh.Name = "chkGioitinh";
            this.chkGioitinh.Size = new System.Drawing.Size(48, 17);
            this.chkGioitinh.TabIndex = 62;
            this.chkGioitinh.Text = "Nam";
            this.chkGioitinh.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(184, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(319, 31);
            this.label12.TabIndex = 63;
            this.label12.Text = "DANH SÁCH GIÁO VIÊN";
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(501, 44);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(100, 20);
            this.mskDienthoai.TabIndex = 64;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::BTL.Properties.Resources.icon_thoát;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(531, 359);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 38);
            this.btnDong.TabIndex = 87;
            this.btnDong.Text = "   Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::BTL.Properties.Resources.icon_bỏ_qua___hủy;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(428, 359);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(97, 38);
            this.btnBoqua.TabIndex = 86;
            this.btnBoqua.Text = "   Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::BTL.Properties.Resources.icon_lưu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(342, 359);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 38);
            this.btnLuu.TabIndex = 85;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BTL.Properties.Resources.icon_sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(247, 359);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 38);
            this.btnSua.TabIndex = 84;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTL.Properties.Resources.icon_xóa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(141, 359);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 83;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Image = global::BTL.Properties.Resources.icon_thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(43, 359);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 38);
            this.btnThem.TabIndex = 82;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // frmDSGiaovien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources._17760642_393694617684539_520841252_n;
            this.ClientSize = new System.Drawing.Size(694, 403);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.mskDienthoai);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.chkGioitinh);
            this.Controls.Add(this.mskNgaysinh);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.cboMachnganh);
            this.Controls.Add(this.txtLuongtiet);
            this.Controls.Add(this.cboMatrinhdo);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.cboMaBM);
            this.Controls.Add(this.cboMakhoa);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.txtTenGV);
            this.Controls.Add(this.txtMaGV);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDSGiaovien";
            this.Text = "GIÁO VIÊN";
            this.Load += new System.EventHandler(this.frmDMGiaovien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ComboBox cboMachnganh;
        private System.Windows.Forms.TextBox txtLuongtiet;
        private System.Windows.Forms.ComboBox cboMatrinhdo;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboMaBM;
        private System.Windows.Forms.ComboBox cboMakhoa;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.TextBox txtTenGV;
        private System.Windows.Forms.TextBox txtMaGV;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox mskNgaysinh;
        private System.Windows.Forms.CheckBox chkGioitinh;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}
namespace BTL.Forms
{
    partial class frmDSBomon
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
            this.mskDienthoai = new System.Windows.Forms.MaskedTextBox();
            this.txtMaBM = new System.Windows.Forms.TextBox();
            this.txtTenBM = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lblMaBM = new System.Windows.Forms.Label();
            this.lblTenBM = new System.Windows.Forms.Label();
            this.lblMakhoa = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.cboMakhoa = new System.Windows.Forms.ComboBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mskDienthoai
            // 
            this.mskDienthoai.Location = new System.Drawing.Point(428, 109);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(127, 20);
            this.mskDienthoai.TabIndex = 100;
            // 
            // txtMaBM
            // 
            this.txtMaBM.Location = new System.Drawing.Point(125, 69);
            this.txtMaBM.Name = "txtMaBM";
            this.txtMaBM.Size = new System.Drawing.Size(77, 20);
            this.txtMaBM.TabIndex = 99;
            // 
            // txtTenBM
            // 
            this.txtTenBM.Location = new System.Drawing.Point(125, 106);
            this.txtTenBM.Name = "txtTenBM";
            this.txtTenBM.Size = new System.Drawing.Size(139, 20);
            this.txtTenBM.TabIndex = 98;
            // 
            // txtDiachi
            // 
            this.txtDiachi.Location = new System.Drawing.Point(428, 69);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(127, 20);
            this.txtDiachi.TabIndex = 96;
            // 
            // lblMaBM
            // 
            this.lblMaBM.AutoSize = true;
            this.lblMaBM.Location = new System.Drawing.Point(53, 69);
            this.lblMaBM.Name = "lblMaBM";
            this.lblMaBM.Size = new System.Drawing.Size(63, 13);
            this.lblMaBM.TabIndex = 95;
            this.lblMaBM.Text = "Mã bộ môn ";
            // 
            // lblTenBM
            // 
            this.lblTenBM.AutoSize = true;
            this.lblTenBM.Location = new System.Drawing.Point(49, 109);
            this.lblTenBM.Name = "lblTenBM";
            this.lblTenBM.Size = new System.Drawing.Size(67, 13);
            this.lblTenBM.TabIndex = 94;
            this.lblTenBM.Text = "Tên bộ môn ";
            // 
            // lblMakhoa
            // 
            this.lblMakhoa.AutoSize = true;
            this.lblMakhoa.Location = new System.Drawing.Point(53, 147);
            this.lblMakhoa.Name = "lblMakhoa";
            this.lblMakhoa.Size = new System.Drawing.Size(52, 13);
            this.lblMakhoa.TabIndex = 93;
            this.lblMakhoa.Text = "Mã khoa ";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(360, 76);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(43, 13);
            this.lblDiachi.TabIndex = 92;
            this.lblDiachi.Text = "Địa chỉ ";
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Location = new System.Drawing.Point(342, 109);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(58, 13);
            this.lblDienthoai.TabIndex = 91;
            this.lblDienthoai.Text = "Điện thoại:";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(30, 182);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(616, 130);
            this.DataGridView.TabIndex = 84;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // cboMakhoa
            // 
            this.cboMakhoa.FormattingEnabled = true;
            this.cboMakhoa.Location = new System.Drawing.Point(125, 144);
            this.cboMakhoa.Name = "cboMakhoa";
            this.cboMakhoa.Size = new System.Drawing.Size(143, 21);
            this.cboMakhoa.TabIndex = 101;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::BTL.Properties.Resources.icon_thoát;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(538, 330);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 38);
            this.btnDong.TabIndex = 107;
            this.btnDong.Text = "   Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::BTL.Properties.Resources.icon_bỏ_qua___hủy;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(435, 330);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(97, 38);
            this.btnBoqua.TabIndex = 106;
            this.btnBoqua.Text = "   Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::BTL.Properties.Resources.icon_lưu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(349, 330);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 38);
            this.btnLuu.TabIndex = 105;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BTL.Properties.Resources.icon_sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(254, 330);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 38);
            this.btnSua.TabIndex = 104;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTL.Properties.Resources.icon_xóa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(148, 330);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 103;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Image = global::BTL.Properties.Resources.icon_thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(50, 330);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 38);
            this.btnThem.TabIndex = 102;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 31);
            this.label1.TabIndex = 108;
            this.label1.Text = "DANH SÁCH BỘ MÔN";
            // 
            // frmDSBomon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources._17760642_393694617684539_520841252_n;
            this.ClientSize = new System.Drawing.Size(679, 380);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.cboMakhoa);
            this.Controls.Add(this.mskDienthoai);
            this.Controls.Add(this.txtMaBM);
            this.Controls.Add(this.txtTenBM);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.lblMaBM);
            this.Controls.Add(this.lblTenBM);
            this.Controls.Add(this.lblMakhoa);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblDienthoai);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmDSBomon";
            this.Text = "BỘ MÔN";
            this.Load += new System.EventHandler(this.frmDSMonhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.TextBox txtMaBM;
        private System.Windows.Forms.TextBox txtTenBM;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lblMaBM;
        private System.Windows.Forms.Label lblTenBM;
        private System.Windows.Forms.Label lblMakhoa;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.ComboBox cboMakhoa;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label1;
    }
}
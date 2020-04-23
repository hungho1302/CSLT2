namespace BTL.Forms
{
    partial class frmDSKhoa
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
            this.txtMakhoa = new System.Windows.Forms.TextBox();
            this.txtTenkhoa = new System.Windows.Forms.TextBox();
            this.txtDiachi = new System.Windows.Forms.TextBox();
            this.lblMakhoa = new System.Windows.Forms.Label();
            this.lblTenkhoa = new System.Windows.Forms.Label();
            this.lblDiachi = new System.Windows.Forms.Label();
            this.lblDienthoai = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
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
            this.mskDienthoai.Location = new System.Drawing.Point(448, 111);
            this.mskDienthoai.Mask = "(999) 000-0000";
            this.mskDienthoai.Name = "mskDienthoai";
            this.mskDienthoai.Size = new System.Drawing.Size(100, 20);
            this.mskDienthoai.TabIndex = 89;
            // 
            // txtMakhoa
            // 
            this.txtMakhoa.Location = new System.Drawing.Point(143, 68);
            this.txtMakhoa.Name = "txtMakhoa";
            this.txtMakhoa.Size = new System.Drawing.Size(78, 20);
            this.txtMakhoa.TabIndex = 88;
            // 
            // txtTenkhoa
            // 
            this.txtTenkhoa.Location = new System.Drawing.Point(143, 107);
            this.txtTenkhoa.Name = "txtTenkhoa";
            this.txtTenkhoa.Size = new System.Drawing.Size(151, 20);
            this.txtTenkhoa.TabIndex = 87;
            // 
            // txtDiachi
            // 
            this.txtDiachi.BackColor = System.Drawing.SystemColors.HotTrack;
            this.txtDiachi.Location = new System.Drawing.Point(446, 71);
            this.txtDiachi.Name = "txtDiachi";
            this.txtDiachi.Size = new System.Drawing.Size(100, 20);
            this.txtDiachi.TabIndex = 86;
            // 
            // lblMakhoa
            // 
            this.lblMakhoa.AutoSize = true;
            this.lblMakhoa.Location = new System.Drawing.Point(74, 71);
            this.lblMakhoa.Name = "lblMakhoa";
            this.lblMakhoa.Size = new System.Drawing.Size(55, 13);
            this.lblMakhoa.TabIndex = 85;
            this.lblMakhoa.Text = "Mã khoa :";
            // 
            // lblTenkhoa
            // 
            this.lblTenkhoa.AutoSize = true;
            this.lblTenkhoa.Location = new System.Drawing.Point(70, 114);
            this.lblTenkhoa.Name = "lblTenkhoa";
            this.lblTenkhoa.Size = new System.Drawing.Size(59, 13);
            this.lblTenkhoa.TabIndex = 84;
            this.lblTenkhoa.Text = "Tên khoa :";
            // 
            // lblDiachi
            // 
            this.lblDiachi.AutoSize = true;
            this.lblDiachi.Location = new System.Drawing.Point(387, 71);
            this.lblDiachi.Name = "lblDiachi";
            this.lblDiachi.Size = new System.Drawing.Size(46, 13);
            this.lblDiachi.TabIndex = 83;
            this.lblDiachi.Text = "Địa chỉ :";
            // 
            // lblDienthoai
            // 
            this.lblDienthoai.AutoSize = true;
            this.lblDienthoai.Location = new System.Drawing.Point(387, 114);
            this.lblDienthoai.Name = "lblDienthoai";
            this.lblDienthoai.Size = new System.Drawing.Size(61, 13);
            this.lblDienthoai.TabIndex = 82;
            this.lblDienthoai.Text = "Điện thoại :";
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(35, 147);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(629, 145);
            this.DataGridView.TabIndex = 75;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // btnDong
            // 
            this.btnDong.Image = global::BTL.Properties.Resources.icon_thoát;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(548, 311);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 38);
            this.btnDong.TabIndex = 81;
            this.btnDong.Text = "   Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::BTL.Properties.Resources.icon_bỏ_qua___hủy;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(445, 311);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(97, 38);
            this.btnBoqua.TabIndex = 80;
            this.btnBoqua.Text = "   Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::BTL.Properties.Resources.icon_lưu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(359, 311);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 38);
            this.btnLuu.TabIndex = 79;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BTL.Properties.Resources.icon_sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(264, 311);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 38);
            this.btnSua.TabIndex = 78;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTL.Properties.Resources.icon_xóa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(158, 311);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 77;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Image = global::BTL.Properties.Resources.icon_thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(60, 311);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 38);
            this.btnThem.TabIndex = 76;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(223, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(256, 31);
            this.label1.TabIndex = 90;
            this.label1.Text = "DANH SÁCH KHOA";
            // 
            // frmDSKhoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources._17760642_393694617684539_520841252_n;
            this.ClientSize = new System.Drawing.Size(702, 369);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mskDienthoai);
            this.Controls.Add(this.txtMakhoa);
            this.Controls.Add(this.txtTenkhoa);
            this.Controls.Add(this.txtDiachi);
            this.Controls.Add(this.lblMakhoa);
            this.Controls.Add(this.lblTenkhoa);
            this.Controls.Add(this.lblDiachi);
            this.Controls.Add(this.lblDienthoai);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.DataGridView);
            this.Name = "frmDSKhoa";
            this.Text = "KHOA";
            this.Load += new System.EventHandler(this.frmDSKhoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mskDienthoai;
        private System.Windows.Forms.TextBox txtMakhoa;
        private System.Windows.Forms.TextBox txtTenkhoa;
        private System.Windows.Forms.TextBox txtDiachi;
        private System.Windows.Forms.Label lblMakhoa;
        private System.Windows.Forms.Label lblTenkhoa;
        private System.Windows.Forms.Label lblDiachi;
        private System.Windows.Forms.Label lblDienthoai;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label1;
    }
}
namespace BTL.Forms
{
    partial class frmDSTrinhdo
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
            this.txtMatrinhdo = new System.Windows.Forms.TextBox();
            this.txtTentrinhdo = new System.Windows.Forms.TextBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã trình độ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên trình độ";
            // 
            // txtMatrinhdo
            // 
            this.txtMatrinhdo.Location = new System.Drawing.Point(140, 53);
            this.txtMatrinhdo.Name = "txtMatrinhdo";
            this.txtMatrinhdo.Size = new System.Drawing.Size(100, 20);
            this.txtMatrinhdo.TabIndex = 2;
            // 
            // txtTentrinhdo
            // 
            this.txtTentrinhdo.Location = new System.Drawing.Point(485, 56);
            this.txtTentrinhdo.Name = "txtTentrinhdo";
            this.txtTentrinhdo.Size = new System.Drawing.Size(100, 20);
            this.txtTentrinhdo.TabIndex = 3;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(87, 93);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(469, 138);
            this.DataGridView.TabIndex = 4;
            this.DataGridView.Click += new System.EventHandler(this.DataGridView_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(177, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(312, 31);
            this.label3.TabIndex = 64;
            this.label3.Text = "DANH SÁCH TRÌNH ĐỘ";
            // 
            // btnDong
            // 
            this.btnDong.Image = global::BTL.Properties.Resources.icon_thoát;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(525, 255);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(91, 38);
            this.btnDong.TabIndex = 113;
            this.btnDong.Text = "   Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click_1);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::BTL.Properties.Resources.icon_bỏ_qua___hủy;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(422, 255);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(97, 38);
            this.btnBoqua.TabIndex = 112;
            this.btnBoqua.Text = "   Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click_1);
            // 
            // btnLuu
            // 
            this.btnLuu.Image = global::BTL.Properties.Resources.icon_lưu;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(336, 255);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(80, 38);
            this.btnLuu.TabIndex = 111;
            this.btnLuu.Text = "   Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click_1);
            // 
            // btnSua
            // 
            this.btnSua.Image = global::BTL.Properties.Resources.icon_sửa;
            this.btnSua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSua.Location = new System.Drawing.Point(241, 255);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(89, 38);
            this.btnSua.TabIndex = 110;
            this.btnSua.Text = "   Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click_1);
            // 
            // btnXoa
            // 
            this.btnXoa.Image = global::BTL.Properties.Resources.icon_xóa;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(135, 255);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 38);
            this.btnXoa.TabIndex = 109;
            this.btnXoa.Text = "    Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click_1);
            // 
            // btnThem
            // 
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnThem.Image = global::BTL.Properties.Resources.icon_thêm;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(37, 255);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(92, 38);
            this.btnThem.TabIndex = 108;
            this.btnThem.Text = "     Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click_1);
            // 
            // frmDSTrinhdo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources._17760642_393694617684539_520841252_n;
            this.ClientSize = new System.Drawing.Size(669, 305);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.txtTentrinhdo);
            this.Controls.Add(this.txtMatrinhdo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDSTrinhdo";
            this.Text = "TRÌNH ĐỘ";
            this.Load += new System.EventHandler(this.frmDSTrinhdo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMatrinhdo;
        private System.Windows.Forms.TextBox txtTentrinhdo;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
    }
}
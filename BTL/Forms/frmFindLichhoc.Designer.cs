namespace BTL.Forms
{
    partial class frmFindLichhoc
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
            this.lblCaday = new System.Windows.Forms.Label();
            this.lblLop = new System.Windows.Forms.Label();
            this.lblGiaovien = new System.Windows.Forms.Label();
            this.cboCaday = new System.Windows.Forms.ComboBox();
            this.cboLop = new System.Windows.Forms.ComboBox();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGiaovien = new System.Windows.Forms.TextBox();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTimlai = new System.Windows.Forms.Button();
            this.btnTimkiem = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaday
            // 
            this.lblCaday.AutoSize = true;
            this.lblCaday.Location = new System.Drawing.Point(14, 84);
            this.lblCaday.Name = "lblCaday";
            this.lblCaday.Size = new System.Drawing.Size(40, 13);
            this.lblCaday.TabIndex = 0;
            this.lblCaday.Text = "Ca dậy";
            // 
            // lblLop
            // 
            this.lblLop.AutoSize = true;
            this.lblLop.Location = new System.Drawing.Point(250, 84);
            this.lblLop.Name = "lblLop";
            this.lblLop.Size = new System.Drawing.Size(25, 13);
            this.lblLop.TabIndex = 1;
            this.lblLop.Text = "Lớp";
            // 
            // lblGiaovien
            // 
            this.lblGiaovien.AutoSize = true;
            this.lblGiaovien.Location = new System.Drawing.Point(462, 84);
            this.lblGiaovien.Name = "lblGiaovien";
            this.lblGiaovien.Size = new System.Drawing.Size(52, 13);
            this.lblGiaovien.TabIndex = 2;
            this.lblGiaovien.Text = "Giáo viên";
            // 
            // cboCaday
            // 
            this.cboCaday.FormattingEnabled = true;
            this.cboCaday.Items.AddRange(new object[] {
            "Ca 1",
            "Ca 2",
            "Ca 3",
            "Ca 4"});
            this.cboCaday.Location = new System.Drawing.Point(77, 81);
            this.cboCaday.Name = "cboCaday";
            this.cboCaday.Size = new System.Drawing.Size(121, 21);
            this.cboCaday.TabIndex = 3;
            // 
            // cboLop
            // 
            this.cboLop.FormattingEnabled = true;
            this.cboLop.Location = new System.Drawing.Point(294, 81);
            this.cboLop.Name = "cboLop";
            this.cboLop.Size = new System.Drawing.Size(121, 21);
            this.cboLop.TabIndex = 4;
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(92, 141);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.Size = new System.Drawing.Size(506, 103);
            this.DataGridView.TabIndex = 64;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(214, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 31);
            this.label1.TabIndex = 65;
            this.label1.Text = "TÌM KIẾM LỊCH HỌC";
            // 
            // txtGiaovien
            // 
            this.txtGiaovien.Location = new System.Drawing.Point(540, 84);
            this.txtGiaovien.Name = "txtGiaovien";
            this.txtGiaovien.Size = new System.Drawing.Size(116, 20);
            this.txtGiaovien.TabIndex = 66;
            // 
            // btnDong
            // 
            this.btnDong.Image = global::BTL.Properties.Resources.icon_thoát;
            this.btnDong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDong.Location = new System.Drawing.Point(443, 270);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(99, 37);
            this.btnDong.TabIndex = 63;
            this.btnDong.Text = " Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnTimlai
            // 
            this.btnTimlai.Image = global::BTL.Properties.Resources._17821010_393719717682029_2044862426_n;
            this.btnTimlai.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimlai.Location = new System.Drawing.Point(294, 270);
            this.btnTimlai.Name = "btnTimlai";
            this.btnTimlai.Size = new System.Drawing.Size(93, 37);
            this.btnTimlai.TabIndex = 59;
            this.btnTimlai.Text = "         Tìm lại";
            this.btnTimlai.UseVisualStyleBackColor = true;
            this.btnTimlai.Click += new System.EventHandler(this.btnTimlai_Click);
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Image = global::BTL.Properties.Resources._17814025_393717487682252_129849992_n;
            this.btnTimkiem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTimkiem.Location = new System.Drawing.Point(146, 270);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(95, 37);
            this.btnTimkiem.TabIndex = 58;
            this.btnTimkiem.Text = "         Tìm kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // frmFindLichhoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources._17760642_393694617684539_520841252_n;
            this.ClientSize = new System.Drawing.Size(712, 329);
            this.Controls.Add(this.txtGiaovien);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTimlai);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.cboLop);
            this.Controls.Add(this.cboCaday);
            this.Controls.Add(this.lblGiaovien);
            this.Controls.Add(this.lblLop);
            this.Controls.Add(this.lblCaday);
            this.Name = "frmFindLichhoc";
            this.Text = "TÌM KIẾM LỊCH HỌC";
            this.Load += new System.EventHandler(this.frmFindLichhoc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCaday;
        private System.Windows.Forms.Label lblLop;
        private System.Windows.Forms.Label lblGiaovien;
        private System.Windows.Forms.ComboBox cboCaday;
        private System.Windows.Forms.ComboBox cboLop;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTimlai;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGiaovien;
    }
}
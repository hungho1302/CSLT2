namespace BTL.Forms
{
    partial class frmBCtiendaytienthi
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboKyhoc = new System.Windows.Forms.ComboBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnBoqua = new System.Windows.Forms.Button();
            this.btnBaocao = new System.Windows.Forms.Button();
            this.txtGiaovien = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridView
            // 
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Location = new System.Drawing.Point(35, 129);
            this.DataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowTemplate.Height = 24;
            this.DataGridView.Size = new System.Drawing.Size(539, 99);
            this.DataGridView.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 53);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Chọn giáo viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(103, 9);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(375, 31);
            this.label3.TabIndex = 20;
            this.label3.Text = "Tiền dạy - tiền thi của giáo viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 93);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Chọn kỳ học";
            // 
            // cboKyhoc
            // 
            this.cboKyhoc.FormattingEnabled = true;
            this.cboKyhoc.Items.AddRange(new object[] {
            "Kỳ 1",
            "Kỳ 2"});
            this.cboKyhoc.Location = new System.Drawing.Point(107, 90);
            this.cboKyhoc.Margin = new System.Windows.Forms.Padding(2);
            this.cboKyhoc.Name = "cboKyhoc";
            this.cboKyhoc.Size = new System.Drawing.Size(158, 21);
            this.cboKyhoc.TabIndex = 16;
            // 
            // btnThoat
            // 
            this.btnThoat.Image = global::BTL.Properties.Resources.icon_thoát;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(443, 239);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(91, 34);
            this.btnThoat.TabIndex = 15;
            this.btnThoat.Text = "   Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnIn
            // 
            this.btnIn.Image = global::BTL.Properties.Resources.icon_in;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(329, 239);
            this.btnIn.Margin = new System.Windows.Forms.Padding(2);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(73, 34);
            this.btnIn.TabIndex = 14;
            this.btnIn.Text = "   In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnBoqua
            // 
            this.btnBoqua.Image = global::BTL.Properties.Resources.icon_bỏ_qua___hủy;
            this.btnBoqua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBoqua.Location = new System.Drawing.Point(203, 239);
            this.btnBoqua.Margin = new System.Windows.Forms.Padding(2);
            this.btnBoqua.Name = "btnBoqua";
            this.btnBoqua.Size = new System.Drawing.Size(86, 34);
            this.btnBoqua.TabIndex = 13;
            this.btnBoqua.Text = "      Bỏ qua";
            this.btnBoqua.UseVisualStyleBackColor = true;
            this.btnBoqua.Click += new System.EventHandler(this.btnBoqua_Click);
            // 
            // btnBaocao
            // 
            this.btnBaocao.Image = global::BTL.Properties.Resources.icon_Báo_cáo___OK;
            this.btnBaocao.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBaocao.Location = new System.Drawing.Point(77, 239);
            this.btnBaocao.Margin = new System.Windows.Forms.Padding(2);
            this.btnBaocao.Name = "btnBaocao";
            this.btnBaocao.Size = new System.Drawing.Size(85, 34);
            this.btnBaocao.TabIndex = 12;
            this.btnBaocao.Text = "     Báo cáo";
            this.btnBaocao.UseVisualStyleBackColor = true;
            this.btnBaocao.Click += new System.EventHandler(this.btnBaocao_Click);
            // 
            // txtGiaovien
            // 
            this.txtGiaovien.Location = new System.Drawing.Point(109, 53);
            this.txtGiaovien.Name = "txtGiaovien";
            this.txtGiaovien.Size = new System.Drawing.Size(156, 20);
            this.txtGiaovien.TabIndex = 24;
            // 
            // frmBCtiendaytienthi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::BTL.Properties.Resources._17760642_393694617684539_520841252_n;
            this.ClientSize = new System.Drawing.Size(585, 289);
            this.Controls.Add(this.txtGiaovien);
            this.Controls.Add(this.DataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboKyhoc);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnBoqua);
            this.Controls.Add(this.btnBaocao);
            this.Name = "frmBCtiendaytienthi";
            this.Text = "TIỀN DẠY - TIỀN THI";
            this.Load += new System.EventHandler(this.frmBCtiendaytienthi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DataGridView;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboKyhoc;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnBoqua;
        private System.Windows.Forms.Button btnBaocao;
        private System.Windows.Forms.TextBox txtGiaovien;
    }
}
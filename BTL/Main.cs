using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace BTL
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Class.Functions.Connect();
        }    

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Class.Functions.Disconnect();
            Application.Exit();
        }
       

        private void mnuKhoa_Click(object sender, EventArgs e)
        {
            Forms.frmDSKhoa f = new Forms.frmDSKhoa();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuBomon_Click(object sender, EventArgs e)
        {
            Forms.frmDSBomon f = new Forms.frmDSBomon();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuMonhoc_Click(object sender, EventArgs e)
        {
            Forms.frmDSMonhoc f = new Forms.frmDSMonhoc();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuLophoc_Click(object sender, EventArgs e)
        {
            Forms.frmDSLophoc f = new Forms.frmDSLophoc();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuTrinhdo_Click(object sender, EventArgs e)
        {
            Forms.frmDSTrinhdo f = new Forms.frmDSTrinhdo();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuChuyennganh_Click(object sender, EventArgs e)
        {
            Forms.frmDSChuyennganh f = new Forms.frmDSChuyennganh();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuGiaovien_Click(object sender, EventArgs e)
        {
            Forms.frmDSGiaovien f = new Forms.frmDSGiaovien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuGVMD_Click(object sender, EventArgs e)
        {
            Forms.frmDSGVMD f = new Forms.frmDSGVMD();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuLichday_Click(object sender, EventArgs e)
        {
            Forms.frmDSLichday f = new Forms.frmDSLichday();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuBCLichhocchuaketthuc_Click(object sender, EventArgs e)
        {
            Forms.frmLichhocchuaketthuc f = new Forms.frmLichhocchuaketthuc();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuBCThoikhoabieugiaovien_Click(object sender, EventArgs e)
        {
            Forms.frmthoikhoabieugv f = new Forms.frmthoikhoabieugv();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuFindGiaovien_Click(object sender, EventArgs e)
        {
            Forms.frmFindGiaovien f = new Forms.frmFindGiaovien();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuFindLichday_Click(object sender, EventArgs e)
        {
            Forms.frmFindLichhoc f = new Forms.frmFindLichhoc();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

        private void mnuTienthitienday_Click(object sender, EventArgs e)
        {
            Forms.frmBCtiendaytienthi f = new Forms.frmBCtiendaytienthi();
            f.StartPosition = FormStartPosition.CenterScreen;
            f.Show();
        }

       
     
       

       
        

    }
}

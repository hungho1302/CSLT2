using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL.Class;

namespace BTL.Forms
{
    public partial class frmFindGiaovien : Form
    {
        public frmFindGiaovien()
        {
            InitializeComponent();
        }
        DataTable tblFGV;
        private void frmFindGiaovien_Load(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;
            Functions.FillCombo("select Makhoa, tenkhoa from tblKhoa", cboKhoa, "Makhoa", "Tenkhoa");
            cboKhoa.SelectedIndex = -1;
            Functions.FillCombo("select Machnganh, tenchnganh from tblChuyennganh", cboChnganh, "Machnganh", "Tenchnganh");
            cboKhoa.SelectedIndex = -1;
            Functions.FillCombo("select MaBM, TenBM from tblBomon", cboBomon, "MaBM", "TenBM");
            cboKhoa.SelectedIndex = -1;
            ResetValues();

        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            txtHoten.Focus();
            cboKhoa.Text = "";
            cboChnganh.Text = "";
            cboBomon.Text = "";
            txtHoten.Text = "";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((txtHoten.Text == "") && (cboKhoa.Text == "") && (cboChnganh.Text == "") && (cboBomon.Text == ""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT TenGV,Tenkhoa,Tenchnganh,TenBM FROM tblGiaovien gv inner join tblKhoa k on gv.Makhoa=k.Makhoa inner join tblBomon bm on gv.MaBM=bm.MaBM inner join tblChuyennganh cn on gv.Machnganh=cn.Machnganh WHERE 1=1";
            if (txtHoten.Text != "")
                sql = sql + " AND TenGV Like N'%" + txtHoten.Text + "%'";
            if (cboKhoa.Text != "")
                sql = sql + " AND Tenkhoa Like N'%" + cboKhoa.Text + "%'";
            if (cboChnganh.Text != "")
                sql = sql + " AND Tenchnganh Like N'%" + cboChnganh.Text + "%'";
            if (cboBomon.Text != "")
                sql = sql + " AND TenBM Like N'%" + cboBomon.Text + "%'";
            tblFGV = Functions.GetDataToTable(sql);
            if (tblFGV.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }
            else
                MessageBox.Show("Có " + tblFGV.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblFGV;
            Load_DataGridView();

        }

        private void btnTimlai_Click(object sender, EventArgs e)
        {
            ResetValues();
            DataGridView.DataSource = null;

        }
        private void Load_DataGridView()
        {
            DataGridView.Columns[0].HeaderText = "Họ tên";
            DataGridView.Columns[1].HeaderText = "Khoa";
            DataGridView.Columns[2].HeaderText = "Chuyên ngành";
            DataGridView.Columns[3].HeaderText = "Bộ môn";
            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

       

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

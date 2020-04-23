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
    public partial class frmDSChuyennganh : Form
    {
        DataTable tblCN;
        public frmDSChuyennganh()
        {
            InitializeComponent();
        }

        private void frmDSChuyennganh_Load(object sender, EventArgs e)
        {
            txtMachnganh.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Machnganh, Tenchnganh FROM tblChuyennganh";
            tblCN = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblCN;
            DataGridView.Columns[0].HeaderText = "Mã chuyên ngành";
            DataGridView.Columns[1].HeaderText = "Tên chuyên ngành";
            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 250;
            DataGridView.AllowUserToAddRows = false;
                DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {

            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMachnganh.Focus();
                return;
            }
            if (tblCN.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,  MessageBoxIcon.Information);
                return;
            }
            txtMachnganh.Text = DataGridView.CurrentRow.Cells["Machnganh"].Value.ToString();
            txtTenchnganh.Text = DataGridView.CurrentRow.Cells["Tenchnganh"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void ResetValues()
        {
            txtMachnganh.Text = "";
            txtTenchnganh.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMachnganh.Enabled = true;
            txtMachnganh.Focus();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMachnganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachnganh.Focus();
                return;
            }
            if (txtTenchnganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenchnganh.Focus();
                return;
            }
            sql = "SELECT Machnganh FROM tblChuyennganh WHERE Machnganh=N'" + txtMachnganh.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã chuyên ngành này đã có, bạn phải nhập mã khác", "Thôngbáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMachnganh.Focus();
                txtMachnganh.Text = "";
                return;
            }
            sql = "INSERT INTO tblChuyennganh(Machnganh,Tenchnganh) VALUES(N'" + txtMachnganh.Text + "',N'" + txtTenchnganh.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMachnganh.Enabled = false;
        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachnganh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenchnganh.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenchnganh.Focus();
                return;
            }
            sql = "UPDATE tblChuyennganh SET Tenchnganh=N'" + txtTenchnganh.Text.ToString() + "' WHERE Machnganh=N'" + txtMachnganh.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblCN.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMachnganh.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",
MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblChuyennganh WHERE Machnganh=N'" + txtMachnganh.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMachnganh.Enabled = false;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmDSMonhoc : Form
    {
        DataTable tblMH;
        public frmDSMonhoc()
        {
            InitializeComponent();
        }

        private void frmDSMonhoc_Load(object sender, EventArgs e)
        {
            txtMamonhoc.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Functions.FillCombo("SELECT Makhoa, Tenkhoa FROM tblKhoa", cboMakhoa, "Makhoa", "Tenkhoa");
            cboMakhoa.SelectedIndex = -1;
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblMonhoc";
            tblMH = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblMH;
            DataGridView.Columns[0].HeaderText = "Mã môn học";
            DataGridView.Columns[1].HeaderText = "Tên môn học";
            DataGridView.Columns[2].HeaderText = "Số tiết";
            DataGridView.Columns[3].HeaderText = "Khoa";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 200;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMamonhoc.Text = "";
            txtTenmonhoc.Text = "";
            cboMakhoa.Text = "";
            txtSotiet.Text = "";
            txtMamonhoc.Focus();
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMamonhoc.Focus();
                return;
            }
            if (tblMH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMamonhoc.Text = DataGridView.CurrentRow.Cells["Mamon"].Value.ToString();
            txtTenmonhoc.Text = DataGridView.CurrentRow.Cells["Tenmon"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["Makhoa"].Value.ToString();
            cboMakhoa.Text = Functions.GetFieldValues("SELECT Tenkhoa FROM tblKhoa WHERE Makhoa = N'" + ma + "'");
            txtSotiet.Text = DataGridView.CurrentRow.Cells["Sotiet"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMamonhoc.Enabled = true;
            txtMamonhoc.Focus();
            ResetValues();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMamonhoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamonhoc.Focus();
                return;
            }
            if (txtTenmonhoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenmonhoc.Focus();
                return;
            }
            if (cboMakhoa.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhoa.Focus();
                return;
            }
            if (txtSotiet.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSotiet.Focus();
                return;
            }
            sql = "SELECT Mamon FROM tblMonhoc WHERE Mamon=N'" + txtMamonhoc.Text.Trim().ToString() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã môn học đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMamonhoc.Focus();
                txtMamonhoc.Text = "";
                return;
            }
            sql = "INSERT INTO tblMonhoc(Mamon,Tenmon,Makhoa,Sotiet) VALUES (N'" + txtMamonhoc.Text.Trim().ToString() + "',N'" + txtTenmonhoc.Text.Trim().ToString() + "',N'" + cboMakhoa.SelectedValue.ToString() + "',N'" + txtSotiet.Text.Trim().ToString() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMamonhoc.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMamonhoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenmonhoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenmonhoc.Focus();
                return;
            }
            if (cboMakhoa.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhoa.Focus();
                return;
            }
            if (txtSotiet.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập số tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSotiet.Focus();
                return;
            }
            sql = "UPDATE tblMonhoc SET Tenmon=N'" + txtTenmonhoc.Text.Trim().ToString() + "',Makhoa=N'" + cboMakhoa.SelectedValue.ToString() + "',Sotiet=N'" + txtSotiet.Text.Trim().ToString() + "' WHERE Mamon=N'" + txtMamonhoc.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblMH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMamonhoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblMonhoc WHERE Mamon=N'" + txtMamonhoc.Text + "'";
                Functions.RunSqlDel(sql);
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
            txtMamonhoc.Enabled = false;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSotiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
(e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}

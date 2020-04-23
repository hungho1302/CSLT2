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
    public partial class frmDSLophoc : Form
    {
        DataTable tblLH;
        public frmDSLophoc()
        {
            InitializeComponent();
        }

        private void frmDSLophoc_Load(object sender, EventArgs e)
        {
            txtMalophoc.Enabled = false;
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
            sql = "SELECT * FROM tblLophoc";
            tblLH = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblLH;
            DataGridView.Columns[0].HeaderText = "Mã lớp học";
            DataGridView.Columns[1].HeaderText = "Tên lớp học";
            DataGridView.Columns[2].HeaderText = "Khoa";
            DataGridView.Columns[3].HeaderText = "Sĩ số";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMalophoc.Text = "";
            txtTenlophoc.Text = "";
            cboMakhoa.Text = "";
            txtSiso.Text = "";
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMalophoc.Focus();
                return;
            }
            if (tblLH.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            txtMalophoc.Text = DataGridView.CurrentRow.Cells["Malop"].Value.ToString();
            txtTenlophoc.Text = DataGridView.CurrentRow.Cells["Tenlop"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["Makhoa"].Value.ToString();
            cboMakhoa.Text = Functions.GetFieldValues("SELECT Tenkhoa FROM tblKhoa WHERE Makhoa = N'" + ma + "'");
            txtSiso.Text = DataGridView.CurrentRow.Cells["Siso"].Value.ToString();
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
            txtMalophoc.Enabled = true;
            txtMalophoc.Focus();
            ResetValues();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMalophoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMalophoc.Focus();
                return;
            }
            if (txtTenlophoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenlophoc.Focus();
                return;
            }
            if (cboMakhoa.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhoa.Focus();
                return;
            }
            if (txtSiso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập sĩ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSiso.Focus();
                return;
            }
            sql = "SELECT Malop FROM tblLophoc WHERE Malop=N'" + txtMalophoc.Text.Trim().ToString() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã lớp học đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMalophoc.Focus();
                txtMalophoc.Text = "";
                return;
            }
            sql = "INSERT INTO tblLophoc(Malop,Tenlop,Makhoa,Siso) VALUES (N'" + txtMalophoc.Text.Trim().ToString() + "',N'" + txtTenlophoc.Text.Trim().ToString() + "',N'" + cboMakhoa.SelectedValue.ToString() + "',N'" + txtSiso.Text.Trim().ToString() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMalophoc.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMalophoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenlophoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên lớp học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenlophoc.Focus();
                return;
            }
            if (cboMakhoa.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhoa.Focus();
                return;
            }
            if (txtSiso.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập sĩ số", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSiso.Focus();
                return;
            }
            sql = "UPDATE tblLophoc SET Tenlop=N'" + txtTenlophoc.Text.Trim().ToString() + "',Makhoa=N'" + cboMakhoa.SelectedValue.ToString() + "',Siso=N'" + txtSiso.Text.Trim().ToString() + "' WHERE Malop=N'" + txtMalophoc.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLH.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMalophoc.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblLophoc WHERE Malop=N'" + txtMalophoc.Text + "'";
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
            txtMalophoc.Enabled = false;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void txtSiso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
 (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }
    }
}

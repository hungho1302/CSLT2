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
    public partial class frmDSBomon : Form
    {
        DataTable tblBM;
        public frmDSBomon()
        {
            InitializeComponent();
        }

        private void frmDSMonhoc_Load(object sender, EventArgs e)
        {
            txtMaBM.Enabled = false;
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
            sql = "SELECT * FROM tblBomon";
            tblBM = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblBM;
            DataGridView.Columns[0].HeaderText = "Mã bộ môn";
            DataGridView.Columns[1].HeaderText = "Tên bộ môn";
            DataGridView.Columns[2].HeaderText = "Khoa";
            DataGridView.Columns[3].HeaderText = "Địa chỉ";
            DataGridView.Columns[4].HeaderText = "Điện thoại";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 200;
            DataGridView.Columns[2].Width = 200;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            txtMaBM.Text = "";
            txtTenBM.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
            cboMakhoa.Text = "";
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaBM.Focus();
                return;
            }
            if (tblBM.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            txtMaBM.Text = DataGridView.CurrentRow.Cells["MaBM"].Value.ToString();
            txtTenBM.Text = DataGridView.CurrentRow.Cells["TenBM"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["Makhoa"].Value.ToString();
            cboMakhoa.Text = Functions.GetFieldValues("SELECT Tenkhoa FROM tblKhoa WHERE Makhoa = N'" + ma + "'");
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaBM.Enabled = true;
            txtMaBM.Focus();
            ResetValues();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (txtMaBM.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã bộ môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBM.Focus();
                return;
            }
            if (txtTenBM.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên bộ môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBM.Focus();
                return;
            }
            if (cboMakhoa.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhoa.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }

            sql = "SELECT MaBM FROM tblBomon WHERE MaBM=N'" + txtMaBM.Text.Trim().ToString() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã bộ môn này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaBM.Focus();
                txtMaBM.Text = "";
                return;
            }
            sql = "INSERT INTO tblBomon(MaBM,TenBM,Makhoa,Diachi,Dienthoai) VALUES (N'" + txtMaBM.Text.Trim().ToString() + "',N'" + txtTenBM.Text.Trim().ToString() + "',N'" + cboMakhoa.SelectedValue.ToString() + "',N'" + txtDiachi.Text.Trim().ToString() + "',N'" + mskDienthoai.Text.ToString() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaBM.Enabled = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblBM.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBM.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblBomon WHERE MaBM=N'" + txtMaBM.Text + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblBM.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaBM.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenBM.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên bộ môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenBM.Focus();
                return;
            }
            if (cboMakhoa.Text == "")
            {
                MessageBox.Show("Bạn phải chưa chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhoa.Focus();
                return;
            }

            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }

            sql = "UPDATE tblBomon SET  TenBM=N'" + txtTenBM.Text.Trim().ToString()
                  + "',Makhoa=N'" + cboMakhoa.SelectedValue.ToString() + "',Diachi=N'" + txtDiachi.Text.Trim().ToString() + "',Dienthoai=N'" +
                mskDienthoai.Text.ToString() + "' WHERE MaBM=N'" + txtMaBM.Text + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnBoqua_Click_1(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMaBM.Enabled = false;
        }

        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}

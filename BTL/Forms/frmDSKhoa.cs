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
    public partial class frmDSKhoa : Form
    {
        DataTable tblK;
        public frmDSKhoa()
        {
            InitializeComponent();
        }

        private void frmDSKhoa_Load(object sender, EventArgs e)
        {
            txtMakhoa.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;

            Load_DataGridView();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Makhoa, Tenkhoa, Diachi, Dienthoai FROM tblKhoa";
            tblK = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblK;
            DataGridView.Columns[0].HeaderText = "Mã khoa";
            DataGridView.Columns[1].HeaderText = "Tên khoa";
            DataGridView.Columns[2].HeaderText = "Địa chỉ";
            DataGridView.Columns[3].HeaderText = "Điện thoại";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 300;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMakhoa.Focus();
                return;
            }
            if (tblK.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            txtMakhoa.Text = DataGridView.CurrentRow.Cells["Makhoa"].Value.ToString();
            txtTenkhoa.Text = DataGridView.CurrentRow.Cells["Tenkhoa"].Value.ToString();
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
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
            ResetValues();
            txtMakhoa.Enabled = true;
            txtMakhoa.Focus();
        }
        private void ResetValues()
        {
            txtMakhoa.Text = "";
            txtTenkhoa.Text = "";
            txtDiachi.Text = "";
            mskDienthoai.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtMakhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã khoa", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtMakhoa.Focus();
                return;
            }
            if (txtTenkhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khoa", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhoa.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }

            sql = "SELECT Makhoa FROM tblKhoa WHERE Makhoa=N'" + txtMakhoa.Text.Trim().ToString() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã khoa này đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMakhoa.Focus();
                txtMakhoa.Text = "";
                return;
            }
            sql = "INSERT INTO tblKhoa(Makhoa,Tenkhoa,Diachi,Dienthoai) VALUES (N'" +txtMakhoa.Text.Trim() + "',N'" + txtTenkhoa.Text.Trim() + "',N'" +txtDiachi.Text.Trim() + "','" + mskDienthoai.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMakhoa.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblK.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMakhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenkhoa.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên khoa", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenkhoa.Focus();
                return;
            }
            if (txtDiachi.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập địa chỉ", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtDiachi.Focus();
                return;
            }
            if (mskDienthoai.Text == "(   )     -")
            {
                MessageBox.Show("Bạn phải nhập điện thoại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskDienthoai.Focus();
                return;
            }
            sql = "UPDATE tblKhoa SET  Tenkhoa=N'" + txtTenkhoa.Text.Trim().ToString()
                  + "',Diachi=N'" + txtDiachi.Text.Trim().ToString() + "',Dienthoai='" +
                mskDienthoai.Text.ToString() + "' WHERE Makhoa=N'" + txtMakhoa.Text + "'";

            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblK.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }
            if (txtMakhoa.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo",MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblKhoa WHERE Makhoa=N'" + txtMakhoa.Text + "'";
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
            txtMakhoa.Enabled = false;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmDSTrinhdo : Form
    {
        DataTable tblTD;
        public frmDSTrinhdo()
        {
            InitializeComponent();
        }

        private void frmDSTrinhdo_Load(object sender, EventArgs e)
        {
            txtMatrinhdo.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();

        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT Matrinhdo, Tentrinhdo FROM tblTrinhdo";
            tblTD = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblTD;
            DataGridView.Columns[0].HeaderText = "Mã trình độ";
            DataGridView.Columns[1].HeaderText = "Tên trình độ";
            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 300;
            // Không cho phép thêm mới dữ liệu trực tiếp trên lưới
            DataGridView.AllowUserToAddRows = false;
            // Không cho phép sửa dữ liệu trực tiếp trên lưới
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",
        MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMatrinhdo.Focus();
                return;
            }
            if (tblTD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK,  MessageBoxIcon.Information);
                return;
            }
            txtMatrinhdo.Text = DataGridView.CurrentRow.Cells["Matrinhdo"].Value.ToString();
            txtTentrinhdo.Text = DataGridView.CurrentRow.Cells["Tentrinhdo"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;

        }

        private void ResetValues()
        {
            txtMatrinhdo.Text = "";
            txtTentrinhdo.Text = "";
        }
        private void btnThem_Click_1(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            ResetValues();
            txtMatrinhdo.Enabled = true;
            txtMatrinhdo.Focus();
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (txtMatrinhdo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatrinhdo.Focus();
                return;
            }
            if (txtTentrinhdo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTentrinhdo.Focus();
                return;
            }
            sql = "SELECT Matrinhdo FROM tblTrinhdo WHERE Matrinhdo=N'" + txtMatrinhdo.Text.Trim() + "'";
            if (Class.Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã trình độ này đã có, bạn phải nhập mã khác", "Thôngbáo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMatrinhdo.Focus();
                txtMatrinhdo.Text = "";
                return;
            }
            sql = "INSERT INTO tblTrinhdo(Matrinhdo,Tentrinhdo) VALUES(N'" + txtMatrinhdo.Text + "',N'" + txtTentrinhdo.Text + "')";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMatrinhdo.Enabled = false;
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblTD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatrinhdo.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTentrinhdo.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTentrinhdo.Focus();
                return;
            }
            sql = "UPDATE tblTrinhdo SET Tentrinhdo=N'" + txtTentrinhdo.Text.ToString() + "' WHERE Matrinhdo=N'" + txtMatrinhdo.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            string sql;
            if (tblTD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMatrinhdo.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblTrinhdo WHERE Matrinhdo=N'" + txtMatrinhdo.Text + "'";
                Class.Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }
        }

        private void btnBoqua_Click_1(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnThem.Enabled = true;
            btnXoa.Enabled = true;
            btnSua.Enabled = true;
            btnLuu.Enabled = false;
            txtMatrinhdo.Enabled = false;
        }
        private void btnDong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

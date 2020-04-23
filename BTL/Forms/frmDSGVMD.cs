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
    public partial class frmDSGVMD : Form
    {
        DataTable tblGVMD;
        public frmDSGVMD()
        {
            InitializeComponent();
        }

        private void frmDSGVMD_Load(object sender, EventArgs e)
        {
            cboMamon.Enabled = false;
            cboGiaovien.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Functions.FillCombo("SELECT MaGV, TenGV FROM tblGiaovien", cboGiaovien, "MaGV", "TenGV");
            cboGiaovien.SelectedIndex = -1;
            ResetValues();
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblGiaovienMonday";
            tblGVMD = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblGVMD;
            DataGridView.Columns[0].HeaderText = "Giáo viên";
            DataGridView.Columns[1].HeaderText = "Môn học";
            DataGridView.Columns[2].HeaderText = "Ghi chú";
            DataGridView.Columns[0].Width = 150;
            DataGridView.Columns[1].Width = 150;
            DataGridView.Columns[2].Width = 150;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void ResetValues()
        {
            cboGiaovien.Text = "";
            cboMamon.Text = "";
            txtGhichu.Text = "";
        }

        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cboGiaovien.Focus();
                return;
            }
            if (tblGVMD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ma = DataGridView.CurrentRow.Cells["MaGV"].Value.ToString();
            cboGiaovien.Text = Functions.GetFieldValues("SELECT TenGV FROM tblGiaovien WHERE MaGV = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["Mamon"].Value.ToString();
            cboMamon.Text = Functions.GetFieldValues("SELECT Tenmon FROM tblMonhoc WHERE  Mamon= N'" + ma + "'");
            txtGhichu.Text = DataGridView.CurrentRow.Cells["Ghichu"].Value.ToString();
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
            cboGiaovien.Enabled = true;
            cboMamon.Enabled = true;
            cboGiaovien.Focus();
            ResetValues();
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboGiaovien.Text == "")
            {
                MessageBox.Show("Bạn phải chọn giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGiaovien.Focus();
                return;
            }
            if (cboMamon.Text == "")
            {
                MessageBox.Show("Bạn phải chọn môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMamon.Focus();
                return;
            }
            sql = "SELECT MaGV, Mamon FROM tblGiaovienMonday WHERE MaGV=N'" + cboGiaovien.SelectedValue + "' and Mamon=N'" + cboMamon.SelectedValue + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã giáo viên và mã môn học này đã có, bạn phải chọn mã giáo viên hoặc mã môn khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboGiaovien.Focus();
                cboGiaovien.Text = "";
                cboMamon.Text = "";
                return;
            }
            sql = "INSERT INTO tblGiaovienMonday(MaGV,Mamon,Ghichu) VALUES (N'" + cboGiaovien.SelectedValue.ToString() + "',N'" + cboMamon.SelectedValue.ToString() + "',N'" + txtGhichu.Text.ToString() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            cboGiaovien.Enabled = false;
            cboMamon.Enabled = false;

        }
        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblGVMD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboGiaovien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            sql = "UPDATE tblGiaovienMonday SET Ghichu=N'" + txtGhichu.Text.Trim().ToString() + "' WHERE MaGV=N'" + cboGiaovien.SelectedValue + "' and Mamon=N'" + cboMamon.SelectedValue + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblGVMD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboGiaovien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblGiaovienMonday WHERE MaGV=N'" + cboGiaovien.SelectedValue + "' and Mamon='" + cboMamon.SelectedValue + "'";
                Functions.RunSqlDel(sql);
                Load_DataGridView();
                ResetValues();
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Trong bảng Giáo viên - môn dậy: mã môn chỉ hiển thị ds các môn học tương ứng với khoa của GV.
        private void cboGiaovien_TextChanged(object sender, EventArgs e)
        {
            if (cboGiaovien.Text != "")
            {
                Functions.FillCombo("SELECT mh.Mamon, mh.Tenmon FROM tblKhoa k inner join tblMonhoc mh on k.Makhoa=mh.Makhoa inner join tblGiaovien gv on gv.Makhoa=k.Makhoa where MaGV='" + cboGiaovien.SelectedValue + "'", cboMamon, "Mamon", "Tenmon");
                cboMamon.SelectedIndex = -1;
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
            cboGiaovien.Enabled = false;
            cboMamon.Enabled = false;

        }

       
      
    }
}

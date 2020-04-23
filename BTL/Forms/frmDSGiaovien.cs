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
    public partial class frmDSGiaovien : Form
    {
        DataTable tblGV;

        public frmDSGiaovien()
        {
            InitializeComponent();
        }

        private void frmDMGiaovien_Load(object sender, EventArgs e)
        {
            txtMaGV.Enabled = false;
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Functions.FillCombo("SELECT Makhoa, Tenkhoa FROM tblKhoa",cboMakhoa, "Makhoa", "Tenkhoa");
            cboMakhoa.SelectedIndex = -1;
            Functions.FillCombo("SELECT Matrinhdo, Tentrinhdo FROM tblTrinhdo", cboMatrinhdo, "Matrinhdo", "Tentrinhdo");
            cboMatrinhdo.SelectedIndex = -1;
            Functions.FillCombo("SELECT Machnganh, Tenchnganh FROM tblChuyennganh", cboMachnganh, "Machnganh", "Tenchnganh");
            cboMachnganh.SelectedIndex = -1;
            ResetValues();
        }
       
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblGiaovien";
            tblGV = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblGV;
            DataGridView.Columns[0].HeaderText = "Mã giáo viên";
            DataGridView.Columns[1].HeaderText = "Tên giáo viên";
            DataGridView.Columns[2].HeaderText = "Ngày sinh";
            DataGridView.Columns[3].HeaderText = "Giới tính";
            DataGridView.Columns[4].HeaderText = "Địa chỉ";
            DataGridView.Columns[5].HeaderText = "Điện thoại";
            DataGridView.Columns[6].HeaderText = "Khoa";
            DataGridView.Columns[7].HeaderText = "Bộ môn";
            DataGridView.Columns[8].HeaderText = "Trình độ";
            DataGridView.Columns[9].HeaderText = "Chuyên ngành";
            DataGridView.Columns[10].HeaderText = "Lương tiết";
            DataGridView.Columns[0].Width = 100;
            DataGridView.Columns[1].Width = 100;
            DataGridView.Columns[2].Width = 100;
            DataGridView.Columns[3].Width = 100;
            DataGridView.Columns[4].Width = 100;
            DataGridView.Columns[5].Width = 100;
            DataGridView.Columns[6].Width = 100;
            DataGridView.Columns[7].Width = 100;
            DataGridView.Columns[8].Width = 100;
            DataGridView.Columns[9].Width = 100;
            DataGridView.Columns[10].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtMaGV.Focus();
                return;
            }
            if (tblGV.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo",MessageBoxButtons.OK,  MessageBoxIcon.Information);
                return;
            }
            txtMaGV.Text = DataGridView.CurrentRow.Cells["MaGV"].Value.ToString();
            txtTenGV.Text = DataGridView.CurrentRow.Cells["TenGV"].Value.ToString();
            mskNgaysinh.Text = DataGridView.CurrentRow.Cells["Ngaysinh"].Value.ToString();
            if (DataGridView.CurrentRow.Cells["Gioitinh"].Value.ToString() == "Nam")
                chkGioitinh.Checked = true;
            else
                chkGioitinh.Checked = false;
            txtDiachi.Text = DataGridView.CurrentRow.Cells["Diachi"].Value.ToString();
            mskDienthoai.Text = DataGridView.CurrentRow.Cells["Dienthoai"].Value.ToString();
            ma = DataGridView.CurrentRow.Cells["Makhoa"].Value.ToString();
            cboMakhoa.Text = Functions.GetFieldValues("SELECT Tenkhoa FROM tblKhoa WHERE Makhoa = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaBM"].Value.ToString();
            cboMaBM.Text = Functions.GetFieldValues("SELECT TenBM FROM tblBomon WHERE MaBM = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["Matrinhdo"].Value.ToString();
            cboMatrinhdo.Text = Functions.GetFieldValues("SELECT Tentrinhdo FROM tblTrinhdo WHERE Matrinhdo = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["Machnganh"].Value.ToString();
            cboMachnganh.Text = Functions.GetFieldValues("SELECT Tenchnganh FROM tblChuyennganh WHERE Machnganh = N'" + ma + "'");
            txtLuongtiet.Text = DataGridView.CurrentRow.Cells["Luongtiet"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            txtMaGV.Text = "";
            txtTenGV.Text = "";
            txtDiachi.Text = "";
            chkGioitinh.Checked = false;
            mskNgaysinh.Text = "";
            mskDienthoai.Text = "";
            cboMakhoa.Text = "";
            cboMaBM.Text = "";
            cboMatrinhdo.Text = "";
            cboMachnganh.Text = "";
            txtLuongtiet.Text = "";
        }
        private void txtLuongtiet_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar >= '0') && (e.KeyChar <= '9')) || (e.KeyChar == '-') ||
 (e.KeyChar == '.') || (Convert.ToInt32(e.KeyChar) == 8) || (Convert.ToInt32(e.KeyChar) == 13))
                e.Handled = false;
            else
                e.Handled = true;
        }

        //Khi nhập thông tin giáo viên, mã bộ môn chỉ hiển thị danh sách các bộ môn của khoa tương ứng
        private void cboMakhoa_TextChanged(object sender, EventArgs e)
        {
            if (cboMakhoa.Text != "")
            {
                Functions.FillCombo("SELECT MaBM, TenBM, Makhoa FROM tblBomon where Makhoa='" + cboMakhoa.SelectedValue + "'", cboMaBM, "MaBM", "TenBM");
                cboMaBM.SelectedIndex = -1;
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            txtMaGV.Enabled = true;
            txtMaGV.Focus();
            ResetValues();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (txtMaGV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập mã giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGV.Focus();
                return;
            }
            if (txtTenGV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGV.Focus();
                return;
            }
           

            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
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
            if (cboMakhoa.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhoa.Focus();
                return;
            }
            if (cboMaBM.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bộ môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBM.Focus();
                return;
            }
            if (cboMatrinhdo.Text == "")
            {
                MessageBox.Show("Bạn phải chọn trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMatrinhdo.Focus();
                return;
            }
            if (cboMachnganh.Text == "")
            {
                MessageBox.Show("Bạn phải chọn chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachnganh.Focus();
                return;
            }
            if (txtLuongtiet.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lương của 1 tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongtiet.Focus();
                return;
            }

            sql = "SELECT MaGV FROM tblGiaovien WHERE MaGV=N'" + txtMaGV.Text.Trim() + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Mã giáo viên đã có, bạn phải nhập mã khác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMaGV.Focus();
                txtMaGV.Text = "";
                return;
            }
            sql = "INSERT INTO tblGiaovien(MaGV,TenGV,Ngaysinh,Gioitinh,Diachi,Dienthoai,Makhoa,MaBM,Matrinhdo,Machnganh,Luongtiet) VALUES(N'"
                + txtMaGV.Text.Trim().ToString() + "',N'"
                + txtTenGV.Text.Trim().ToString() + "','"
                + Functions.ConvertDateTime(mskNgaysinh.Text) + "',N'"
                + gt + "',N'"
                + txtDiachi.Text.Trim().ToString() + "',N'"
                + mskDienthoai.Text.Trim().ToString() + "',N'"
                + cboMakhoa.SelectedValue.ToString() + "',N'"
                + cboMaBM.SelectedValue.ToString() + "',N'"
                + cboMatrinhdo.SelectedValue.ToString() + "',N'"
                + cboMachnganh.SelectedValue.ToString() + "',N'"
                + txtLuongtiet.Text.ToString() + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            txtMaGV.Enabled = false;

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, gt;
            if (tblGV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtTenGV.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập tên giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenGV.Focus();
                return;
            }
           
            if (mskNgaysinh.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Focus();
                return;
            }
            if (!Functions.IsDate(mskNgaysinh.Text))
            {
                MessageBox.Show("Bạn phải nhập lại ngày sinh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskNgaysinh.Text = "";
                mskNgaysinh.Focus();
                return;
            }
            if (chkGioitinh.Checked == true)
                gt = "Nam";
            else
                gt = "Nữ";
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
            if (cboMakhoa.Text == "")
            {
                MessageBox.Show("Bạn phải chọn khoa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMakhoa.Focus();
                return;
            }
            if (cboMaBM.Text == "")
            {
                MessageBox.Show("Bạn phải chọn bộ môn", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMaBM.Focus();
                return;
            }
            if (cboMatrinhdo.Text == "")
            {
                MessageBox.Show("Bạn phải chọn trình độ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMatrinhdo.Focus();
                return;
            }
            if (cboMachnganh.Text == "")
            {
                MessageBox.Show("Bạn phải chọn chuyên ngành", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMachnganh.Focus();
                return;
            }
            if (txtLuongtiet.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải nhập lương của 1 tiết", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtLuongtiet.Focus();
                return;
            }
            sql = "UPDATE tblGiaovien SET TenGV=N'"
                + txtTenGV.Text.Trim().ToString() + "',Ngaysinh='"
                + Functions.ConvertDateTime(mskNgaysinh.Text) + "',Gioitinh=N'"
                + gt + "',Diachi=N'"
                + txtDiachi.Text.Trim().ToString() + "',Dienthoai=N'"
                + mskDienthoai.Text.ToString() + "',Makhoa=N'"
                + cboMakhoa.SelectedValue.ToString() + "',MaBM=N'"
                + cboMaBM.SelectedValue.ToString() + "',Matrinhdo=N'"
                + cboMatrinhdo.SelectedValue.ToString() + "', Machnganh=N'"
                + cboMachnganh.SelectedValue.ToString() + "',Luongtiet='"
                + txtLuongtiet.Text.Trim().ToString() + "' where MaGV=N'" + txtMaGV.Text + "'";
            Class.Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblGV.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtMaGV.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblGiaovien WHERE MaGV=N'" + txtMaGV.Text + "'";
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
            txtMaGV.Enabled = false;
        }
        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class frmDSLichday : Form
    {
        DataTable tblLD;
        public frmDSLichday()
        {
            InitializeComponent();
        }

        private void frmDSLichday_Load(object sender, EventArgs e)
        {
            btnLuu.Enabled = false;
            btnBoqua.Enabled = false;
            Load_DataGridView();
            Functions.FillCombo("SELECT Malop, Tenlop FROM tblLophoc", cboMalop, "Malop", "Tenlop");
            cboMalop.SelectedIndex = -1;
            cboMalop.Enabled = false;
            cboMamon.Enabled = false;
            cboMagiaovien.Enabled = false;
            ResetValues();
        }

        //Trong bảng Lịch dậy: mã môn chỉ hiển thị ds các môn học tương ứng với khoa của mã lớp
        private void cboMalop_TextChanged(object sender, EventArgs e)
        {
            if (cboMalop.Text != "")
            {
                Functions.FillCombo("SELECT mh.Mamon, mh.Tenmon, lh.Malop FROM tblKhoa k inner join tblLophoc lh on k.Makhoa=lh.Makhoa inner join tblMonhoc mh on mh.Makhoa=k.Makhoa where Malop='" + cboMalop.SelectedValue + "'", cboMamon, "Mamon", "Tenmon");
                cboMamon.SelectedIndex = -1;
            }
        }

        //Trong bảng Lịch dậy: mã giáo viên chỉ hiển thị ds các giáo viên dậy được môn học tương ứng
        private void cboMamon_TextChanged(object sender, EventArgs e)
        {

            if (cboMamon.Text != "")
            {
                Functions.FillCombo("SELECT gv.MaGV,gv.TenGV, mh.Mamon FROM tblKhoa k inner join tblGiaovien gv on k.Makhoa=gv.Makhoa inner join tblMonhoc mh on mh.Makhoa=k.Makhoa where Mamon='" + cboMamon.SelectedValue + "'", cboMagiaovien, "MaGV", "TenGV");
                cboMagiaovien.SelectedIndex = -1;
            }
        }
        private void Load_DataGridView()
        {
            string sql;
            sql = "SELECT * FROM tblLichday";
            tblLD = Class.Functions.GetDataToTable(sql);
            DataGridView.DataSource = tblLD;
            DataGridView.Columns[0].HeaderText = "Lớp";
            DataGridView.Columns[1].HeaderText = "Môn học";
            DataGridView.Columns[2].HeaderText = "Giáo viên";
            DataGridView.Columns[3].HeaderText = "Kì học";
            DataGridView.Columns[4].HeaderText = "Năm học";
            DataGridView.Columns[5].HeaderText = "T.gian B.đầu";
            DataGridView.Columns[6].HeaderText = "T.gian K.thúc";
            DataGridView.Columns[7].HeaderText = "Thứ dậy 1";
            DataGridView.Columns[8].HeaderText = "Ca dậy 1";
            DataGridView.Columns[9].HeaderText = "Thứ dậy 2";
            DataGridView.Columns[10].HeaderText = "Ca dậy 2";
            DataGridView.Columns[11].HeaderText = "Tiền thi";
            DataGridView.Columns[12].HeaderText = "Tiền dậy";
            DataGridView.Columns[13].HeaderText = "Ghi chú";
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
            DataGridView.Columns[11].Width = 100;
            DataGridView.Columns[12].Width = 100;
            DataGridView.Columns[13].Width = 100;
            DataGridView.AllowUserToAddRows = false;
            DataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;
        }
        private void DataGridView_Click(object sender, EventArgs e)
        {
            string ma;
            if (btnThem.Enabled == false)
            {
                MessageBox.Show("Đang ở chế độ thêm mới!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (tblLD.Rows.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            ma = DataGridView.CurrentRow.Cells["Malop"].Value.ToString();
            cboMalop.Text = Functions.GetFieldValues("SELECT Tenlop FROM tblLophoc WHERE Malop = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["Mamon"].Value.ToString();
            cboMamon.Text = Functions.GetFieldValues("SELECT Tenmon FROM tblMonhoc WHERE Mamon = N'" + ma + "'");
            ma = DataGridView.CurrentRow.Cells["MaGV"].Value.ToString();
            cboMagiaovien.Text = Functions.GetFieldValues("SELECT TenGV FROM tblGiaovien WHERE MaGV = N'" + ma + "'");
            cboKihoc.Text = DataGridView.CurrentRow.Cells["Kihoc"].Value.ToString();
            txtNamhoc.Text = DataGridView.CurrentRow.Cells["Namhoc"].Value.ToString();
            mskTGBD.Text = DataGridView.CurrentRow.Cells["ThoigianBD"].Value.ToString();
            mskTGKT.Text = DataGridView.CurrentRow.Cells["ThoigianKT"].Value.ToString();
            cboThuday1.Text = DataGridView.CurrentRow.Cells["Thuday1"].Value.ToString();
            cboCaday1.Text = DataGridView.CurrentRow.Cells["Caday1"].Value.ToString();
            cboThuday2.Text = DataGridView.CurrentRow.Cells["Thuday2"].Value.ToString();
            cboCaday2.Text = DataGridView.CurrentRow.Cells["Caday2"].Value.ToString();
            txtTienthi.Text = DataGridView.CurrentRow.Cells["Tienthi"].Value.ToString();
            txtTienday.Text = DataGridView.CurrentRow.Cells["Tienday"].Value.ToString();
            txtGhichu.Text = DataGridView.CurrentRow.Cells["Ghichu"].Value.ToString();
            btnSua.Enabled = true;
            btnXoa.Enabled = true;
            btnBoqua.Enabled = true;
        }
        private void ResetValues()
        {
            cboMalop.Text = "";
            cboMamon.Text = "";
            cboMagiaovien.Text = "";
            cboKihoc.Text = "";
            txtNamhoc.Text = "";
            mskTGBD.Text = "";
            mskTGKT.Text = "";
            cboThuday1.Text = "";
            cboCaday1.Text = "";
            cboThuday2.Text = "";
            cboCaday2.Text = "";
            txtTienthi.Text = "0";
            txtTienday.Text = "0";
            txtGhichu.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            btnSua.Enabled = false;
            btnXoa.Enabled = false;
            btnBoqua.Enabled = true;
            btnLuu.Enabled = true;
            btnThem.Enabled = false;
            cboMalop.Enabled = true;
            cboMamon.Enabled = true;
            cboMagiaovien.Enabled = true;
            ResetValues();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql;
            if (cboMalop.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã lớp", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMalop.Focus();
                return;
            }
            if (cboMamon.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn mã môn học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMamon.Focus();
                return;
            }
            if (cboMagiaovien.Text == "")
            {
                MessageBox.Show("Bạn phải chọn mã giáo viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboMagiaovien.Focus();
                return;
            }

            if (txtNamhoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamhoc.Focus();
                return;
            }
            if (cboKihoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn kì học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKihoc.Focus();
                return;

            }
            if (mskTGBD.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập thời gian bắt đầu học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTGBD.Focus();
                return;
            }
            if (!Functions.IsDate(mskTGBD.Text))
            {
                MessageBox.Show("Bạn phải nhập lại thời gian bắt đầu học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTGBD.Text = "";
                mskTGBD.Focus();
                return;
            }
            if (mskTGKT.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập thời gian kết thúc học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTGKT.Focus();
                return;
            }
            if (!Functions.IsDate(mskTGKT.Text))
            {
                MessageBox.Show("Bạn phải nhập lại thời gian kết thúc học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTGKT.Text = "";
                mskTGKT.Focus();
                return;
            }
            if (cboThuday1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn thứ dậy 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThuday1.Focus();
                return;
            }
            if (cboCaday1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ca dậy 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCaday1.Focus();
                return;
            }
            if (cboThuday2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn thứ dậy 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThuday2.Focus();
                return;
            }
            if (cboCaday2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ca dậy 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCaday2.Focus();
                return;
            }
            string ss = Functions.GetFieldValues("select Siso from tblLophoc where Malop='" + cboMalop.SelectedValue + "'");
            Double ss1 = Convert.ToDouble(ss);

            //Tính tiền thi
            Double tienthi = 5000 * ss1;

            string lt = Functions.GetFieldValues("select Luongtiet from tblGiaovien where MaGV='" + cboMagiaovien.SelectedValue + "'");
            string st = Functions.GetFieldValues("select Sotiet from tblMonhoc where Mamon='" + cboMamon.SelectedValue + "'");
            Double lt1 = Convert.ToDouble(lt);
            Double st1 = Convert.ToDouble(st);

            //Tính tiền dậy
            double tienday;
            if (ss1 <= 60)
            {
                tienday = st1 * lt1;
            }
            else if (ss1 >= 61 && ss1 <= 80)
            {
                tienday = st1 * lt1 * 1.3;
            }
            else
            {
                tienday = st1 * lt1 * 2;
            }

            //Trong bảng Lịch dậy kiểm tra một lớp và một giáo viên không thể trùng lịch học và lịch dậy
            //Kiểm tra xem vào năm học đc chọn, kì học đc chọn, thứ và ca học đc chọn thì lớp đc chọn đã có lịch học chưa, hoặc giáo viên đc chọn đã có giờ dạy vào ca đó chưa
            sql = "select thuday1,caday1 from tblLichday where ((thuday1=N'"
                + cboThuday1.Text + "' and caday1=N'"
                + cboCaday1.Text + "') or (thuday2=N'" 
                + cboThuday1.Text + "' and caday2=N'" 
                + cboCaday1.Text + "')) and (malop='"
                + cboMalop.SelectedValue + "' or maGV=N'" + cboMagiaovien.SelectedValue + "') and Kihoc=N'"
                + cboKihoc.Text + "' and Namhoc='"
                + txtNamhoc.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Đã có lớp học trong thời gian này, bạn hãy chọn lại thứ dậy 1 hoặc ca dậy 1 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Kiểm tra xem vào năm học đc chọn, kì học đc chọn, thứ và ca học đc chọn thì lớp đc chọn đã có lịch học chưa, hoặc giáo viên đc chọn đã có giờ dạy vào ca đó chưa
            sql = "select thuday2,caday2 from tblLichday where ((thuday1=N'"
               + cboThuday2.Text + "' and caday1=N'"
               + cboCaday2.Text + "') or (thuday2=N'"
               + cboThuday2.Text + "' and caday2=N'"
               + cboCaday2.Text + "')) and (malop='"
               + cboMalop.SelectedValue + "' or maGV=N'" + cboMagiaovien.SelectedValue + "') and Kihoc=N'"
               + cboKihoc.Text + "' and Namhoc='"
               + txtNamhoc.Text + "'";
            if (Functions.CheckKey(sql))
            {
                MessageBox.Show("Đã có lớp học trong thời gian này, bạn hãy chọn lại thứ dậy 2 hoặc ca dậy 2 ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            string td1, cd1, td2, cd2;
            td1 = cboThuday1.Text;
            cd1 = cboCaday1.Text;
            td2 = cboThuday2.Text;
            cd2 = cboCaday2.Text;
            if (td1 == td2)
            {
                if (cd1 == cd2)
                {
                    MessageBox.Show("Hai buổi học của lớp bạn chọn trùng nhau, hãy thay đổi lại thời gian 1 trong 2 buổi học", "Thông báo");
                    return;
                }
            }

            sql = "insert into tbllichday(Malop,Mamon,MaGV,Kihoc,Namhoc,ThoigianBD,ThoigianKT,Thuday1,Caday1,Thuday2,Caday2,Tienthi,Tienday,Ghichu) values('"
                + cboMalop.SelectedValue + "','"
                + cboMamon.SelectedValue + "','"
                + cboMagiaovien.SelectedValue + "','"
                + cboKihoc.Text + "','"
                + txtNamhoc.Text + "','"
                + Class.Functions.ConvertDateTime(mskTGBD.Text) + "','"
                + Class.Functions.ConvertDateTime(mskTGKT.Text) + "',N'"
                + cboThuday1.Text + "',N'" + cboCaday1.Text + "',N'" + cboThuday2.Text + "',N'" + cboCaday2.Text + "','" + tienday.ToString() + "','" + tienthi.ToString() + "',N'" + txtGhichu.Text + "')";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnXoa.Enabled = true;
            btnThem.Enabled = true;
            btnSua.Enabled = true;
            btnBoqua.Enabled = false;
            btnLuu.Enabled = false;
            cboMalop.Enabled = false;
            cboMamon.Enabled = false;
            cboMagiaovien.Enabled = false;

        }       

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql, td1, cd1, td2, cd2;
            if (tblLD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMalop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (txtNamhoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn năm học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNamhoc.Focus();
                return;
            }
            if (cboKihoc.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn kì học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboKihoc.Focus();
                return;
            }
            if (mskTGBD.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập thời gian bắt đầu học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTGBD.Focus();
                return;
            }
            if (!Functions.IsDate(mskTGBD.Text))
            {
                MessageBox.Show("Bạn phải nhập lại thời gian bắt đầu học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTGBD.Text = "";
                mskTGBD.Focus();
                return;
            }
            if (mskTGKT.Text == "  /  /")
            {
                MessageBox.Show("Bạn phải nhập thời gian kết thúc học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTGKT.Focus();
                return;
            }
            if (!Functions.IsDate(mskTGKT.Text))
            {
                MessageBox.Show("Bạn phải nhập lại thời gian kết thúc học", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                mskTGKT.Text = "";
                mskTGKT.Focus();
                return;
            }
            if (cboThuday1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn thứ dậy 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThuday1.Focus();
                return;
            }
            if (cboCaday1.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ca dậy 1", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCaday1.Focus();
                return;
            }
            if (cboThuday2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn thứ dậy 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboThuday2.Focus();
                return;
            }
            if (cboCaday2.Text.Trim().Length == 0)
            {
                MessageBox.Show("Bạn phải chọn ca dậy 2", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboCaday2.Focus();
                return;
            }         

            td1 = cboThuday1.Text;
            cd1 = cboCaday1.Text;
            td2 = cboThuday2.Text;
            cd2 = cboCaday2.Text;
            if (td1 == td2)
            {
                if (cd1 == cd2)
                {
                    MessageBox.Show("Hai buổi học của lớp bạn chọn trùng nhau, hãy thay đổi lại thời gian 1 trong 2 buổi học", "Thông báo");
                    return;
                }
            }
            sql = "UPDATE tblLichday SET Kihoc='"
                + cboKihoc.Text.ToString() + "',Namhoc='"
                + txtNamhoc.Text.ToString() + "', ThoigianBD='"
                + Functions.ConvertDateTime(mskTGBD.Text) + "',ThoigianKT='"
                + Functions.ConvertDateTime(mskTGKT.Text) + "',Thuday1=N'"
                + cboThuday1.Text.ToString() + "',Caday1=N'"
                + cboCaday1.Text.ToString() + "',Thuday2=N'"
                + cboThuday2.Text.ToString() + "',Caday2=N'"
                + cboCaday2.Text.ToString() + "',Tienthi='"
                + txtTienthi.Text + "',Tienday='"
                + txtTienday.Text + "',Ghichu=N'"
                + txtGhichu.Text.Trim().ToString() + "' where Malop='" + cboMalop.SelectedValue + "' and Mamon='" + cboMamon.SelectedValue + "' and MaGV='" + cboMagiaovien.SelectedValue + "'";
            Functions.RunSql(sql);
            Load_DataGridView();
            ResetValues();
            btnBoqua.Enabled = false;

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql;
            if (tblLD.Rows.Count == 0)
            {
                MessageBox.Show("Không còn dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (cboMalop.Text == "" && cboMamon.Text == "" && cboMagiaovien.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn bản ghi nào", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                sql = "DELETE tblLichday WHERE Malop=N'" + cboMalop.SelectedValue + "' and Mamon=N'" + cboMamon.SelectedValue + "' and MaGV=N'" + cboMagiaovien.SelectedValue + "'";
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
            cboMalop.Enabled = false;
            cboMamon.Enabled = false;
            cboMagiaovien.Enabled = false;

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}

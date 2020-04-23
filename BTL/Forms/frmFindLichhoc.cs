using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using BTL.Class;


namespace BTL.Forms
{
    public partial class frmFindLichhoc : Form
    {
        public frmFindLichhoc()
        {
            InitializeComponent();
        }
        DataTable tblFLH;
        private void frmFindLichhoc_Load(object sender, EventArgs e)
        {
           
            DataGridView.DataSource = null;
            Functions.FillCombo("SELECT DISTINCT Malop, Tenlop FROM tblLophoc", cboLop, "Malop", "Tenlop");
            cboLop.SelectedIndex = -1;
            ResetValues();
        }
        private void ResetValues()
        {
            foreach (Control Ctl in this.Controls)
                if (Ctl is TextBox)
                    Ctl.Text = "";
            cboCaday.Focus();
            cboLop.Text = "";
            cboCaday.Text = "";
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string sql;
            if ((cboCaday.Text == "") && (cboLop.Text == "") && (txtGiaovien.Text == "") )
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT Tenlop,TenGV,thuday1,caday1,thuday2,caday2 FROM tblLichday ld inner join tblGiaovien gv on gv.MaGV=ld.MaGV inner join tblLophoc lh on ld.Malop=lh.Malop WHERE 1=1";
            if(cboCaday.Text != "")
                sql = sql + " AND ((caday1 = '" + cboCaday.Text + "') or (caday2 = '" + cboCaday.Text + "')) ";                     
            if (cboLop.Text != "")
                sql = sql + " AND (Tenlop = '" + cboLop.Text + "')";
            if (txtGiaovien.Text != "")
                sql = sql + " AND TenGV like N%" + txtGiaovien.Text + "%'";
            tblFLH = Functions.GetDataToTable(sql);
            if (tblFLH.Rows.Count == 0)
            {
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                ResetValues();
            }

            else
                MessageBox.Show("Có " + tblFLH.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblFLH;
        }
            private void btnTimlai_Click(object sender, EventArgs e)
            {
                ResetValues();
                DataGridView.DataSource = null;

            }
            

            private void btnDong_Click(object sender, EventArgs e)
            {
                this.Close();
            }

        


        
    }
}

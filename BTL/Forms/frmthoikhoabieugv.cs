using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using BTL.Class;
using System.Windows.Forms;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;

namespace BTL.Forms
{
    public partial class frmthoikhoabieugv : Form
      
    {
        DataTable tblLD;
        public frmthoikhoabieugv()
        {
            InitializeComponent();
        }
        private void frmthoikhoabieugv_Load(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT DISTINCT kihoc FROM tbllichday", cboKyhoc, "kihoc", "kihoc");
            cboKyhoc.SelectedIndex = -1;
            Functions.FillCombo("SELECT DISTINCT Namhoc FROM tbllichday", cboNamhoc, "namhoc", "namhoc");
            cboNamhoc.SelectedIndex = -1;
            ResetValues();
            btnIn.Enabled = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnBaocao.Enabled = true;
            btnThoat.Enabled = true;
            btnIn.Enabled = false;
                     
        }
        private void ResetValues()
        {
             cboKyhoc.Text= "";
            cboNamhoc.Text = "";
            txtTengiaovien.Text = "";
           
        }
        private void btnBaocao_Click(object sender, EventArgs e)
        {
            btnIn.Enabled = true;
            string sql;
            if ((cboKyhoc.Text == "") && (cboNamhoc.Text == "") && (txtTengiaovien.Text ==
""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT ld.* FROM tblLichday ld inner join tblGiaovien gv on ld.MaGV=gv.MaGV WHERE 1=1";
            if (cboKyhoc.Text != "")
                sql = sql + " AND Kihoc Like N'%" + cboKyhoc.Text + "%'";
            if (cboNamhoc.Text != "")
                sql = sql + " AND Namhoc Like N'%" + cboNamhoc.Text + "%'";
            if (txtTengiaovien.Text != "")
                sql = sql + " AND TenGV Like N'%" + txtTengiaovien.Text + "%'";
            tblLD = Functions.GetDataToTable(sql);
            if (tblLD.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",
MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblLD.Rows.Count + " bản ghi thỏa mãn điều kiện!!!",
"Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            DataGridView.DataSource = tblLD;
        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange; 
            string sql;
            int hang=0, cot=0;
            DataTable tblLichday;
            exBook = exApp.Workbooks.Add(COMExcel.XlWBATemplate.xlWBATWorksheet);
            exSheet = exBook.Worksheets[1];
            // Định dạng chung
            exRange = exSheet.Cells[1, 1];
            exRange.Range["A1:B3"].Font.Size = 10;
            exRange.Range["A1:B3"].Font.Name = "Times new roman";
            exRange.Range["A1:B3"].Font.Bold = true;
            exRange.Range["A1:B3"].Font.ColorIndex = 5; //Màu xanh da trời
            exRange.Range["A1:A1"].ColumnWidth = 7;
            exRange.Range["B1:B1"].ColumnWidth = 15;
            exRange.Range["A1:B1"].MergeCells = true;
            exRange.Range["A1:B1"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A1:B1"].Value = "Học Viện Ngân Hàng";
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Khoa HTTTQL";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: (04)37562222";
           

            exRange.Range["A4:E4"].Font.Size = 16;
            exRange.Range["A4:E4"].Font.Name = "Times new roman";
            exRange.Range["A4:E4"].Font.Bold = true;
            exRange.Range["A4:E4"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["A4:E4"].MergeCells = true;
            exRange.Range["A4:E4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A4:E4"].Value = "Thời khóa biểu giáo viên";

            //Lấy thông tin
            sql = "SELECT ld.* FROM tblLichday ld inner join tblGiaovien gv on ld.MaGV=gv.MaGV WHERE 1=1";
            if (cboKyhoc.Text != "")
                sql = sql + " AND Kihoc Like N'%" + cboKyhoc.Text + "%'";
            if (cboNamhoc.Text != "")
                sql = sql + " AND Namhoc Like N'%" + cboNamhoc.Text + "%'";
            if (txtTengiaovien.Text != "")
                sql = sql + " AND TenGV Like N'%" + txtTengiaovien.Text + "%'";

            tblLichday = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A7:N11"].Font.Bold = true;
            exRange.Range["A7:N11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:F7"].ColumnWidth = 12;
            exRange.Range["A7:A7"].Value = "STT";
            exRange.Range["B7:B7"].Value = "Mã lớp";
            exRange.Range["C7:C7"].Value = "Mã môn";
            exRange.Range["D7:D7"].Value = "Mã giáo viên";
            exRange.Range["E7:E7"].Value = "Kỳ học";
            exRange.Range["F7:F7"].Value = "Năm học";
            exRange.Range["G7:G7"].Value = "TGBT"; 
            exRange.Range["H7:H7"].Value = "TGKT";
            exRange.Range["I7:I7"].Value = "Thuday1";
            exRange.Range["J7:J7"].Value = "Caday1";
            exRange.Range["K7:K7"].Value = "Thuday2";
            exRange.Range["L7:L7"].Value = "Caday2";
            exRange.Range["M7:M7"].Value = "Tiền thi";
            exRange.Range["N7:N7"].Value = "Tiền dạy";
            for (hang = 0 ; hang <= tblLichday.Rows.Count - 1; hang ++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 8
                exSheet.Cells[1][hang + 8] = hang + 1;
                for (cot = 0 ; cot <= tblLichday.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 8
              exSheet.Cells[cot + 2][hang + 8]= tblLichday.Rows[hang][cot].ToString();
            }
            exApp.Visible = true;

        }
    }
}

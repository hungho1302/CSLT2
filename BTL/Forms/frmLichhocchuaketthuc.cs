using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BTL.Class;
using System.Data.SqlClient;
using COMExcel = Microsoft.Office.Interop.Excel;


namespace BTL.Forms
{
    public partial class frmLichhocchuaketthuc : Form
    {
        DataTable tblLichday;
        public frmLichhocchuaketthuc()
        {
            InitializeComponent();
        }
        private void frmLichhocchuaketthuc_Load(object sender, EventArgs e)
        {
            btnBaocao.Enabled = true;
            btnIn.Enabled = false;
            btnThoat.Enabled = true;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnBaocao_Click(object sender, EventArgs e)
        {
            btnIn.Enabled = true;
            string sql;
            sql = "SELECT Malop, Mamon, MaGV, Kihoc, Namhoc FROM tblLichday WHERE 1=1 and ThoigianKT > '" +DateTime.Now+"'";
            tblLichday = Functions.GetDataToTable(sql);
            if (tblLichday.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblLichday.Rows.Count + " bản ghi thỏa mãn điều kiện!!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblLichday;
        }

       

        private void btnIn_Click(object sender, EventArgs e)
        {
            // Khởi động chương trình Excel
            COMExcel.Application exApp = new COMExcel.Application();
            COMExcel.Workbook exBook; //Trong 1 chương trình Excel có nhiều Workbook
            COMExcel.Worksheet exSheet; //Trong 1 Workbook có nhiều Worksheet
            COMExcel.Range exRange;
            string sql;
            int hang = 0, cot = 0;
            DataTable tblLichhoc;
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
            exRange.Range["A2:B2"].MergeCells = true;
            exRange.Range["A2:B2"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A2:B2"].Value = "Học viện Ngân Hàng";
            exRange.Range["A3:B3"].MergeCells = true;
            exRange.Range["A3:B3"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A3:B3"].Value = "Điện thoại: 0981230262";
            exRange.Range["A4:E4"].Font.Size = 16;
            exRange.Range["A4:E4"].Font.Name = "Times new roman";
            exRange.Range["A4:E4"].Font.Bold = true;
            exRange.Range["A4:E4"].Font.ColorIndex = 3; //Màu đỏ
            exRange.Range["A4:E4"].MergeCells = true;
            exRange.Range["A4:E4"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["A4:E4"].Value = "Báo cáo lịch dạy chưa kết thúc";

            //Lấy thông tin các mặt hàng
            sql = "SELECT Malop, Mamon, MaGV, Kihoc, Namhoc FROM tblLichday WHERE 1=1 and ThoigianKT > '" + DateTime.Now + "'";
       
            tblLichhoc = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A7:L11"].Font.Bold = true;
            exRange.Range["A7:L11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:F7"].ColumnWidth = 12;
            exRange.Range["A7:A7"].Value = "STT";
            exRange.Range["B7:B7"].Value = "Lớp";
            exRange.Range["C7:C7"].Value = "Môn học";
            exRange.Range["D7:D7"].Value = "Giáo viên";
            exRange.Range["E7:E7"].Value = "Kỳ học";
            exRange.Range["F7:F7"].Value = "Năm học";
            
            for (hang = 0; hang <= tblLichhoc.Rows.Count - 1; hang++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 8
                exSheet.Cells[1][hang + 8] = hang + 1;
                for (cot = 0; cot <= tblLichhoc.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 8
                    exSheet.Cells[cot + 2][hang + 8] = tblLichhoc.Rows[hang][cot].ToString();
            }
            exApp.Visible = true;
        }

    }
}

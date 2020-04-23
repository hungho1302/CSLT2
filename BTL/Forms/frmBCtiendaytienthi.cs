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
    public partial class frmBCtiendaytienthi : Form
    {
        public frmBCtiendaytienthi()
        {
            InitializeComponent();
        }
        private void frmBCtiendaytienthi_Load(object sender, EventArgs e)
        {
            Functions.FillCombo("SELECT DISTINCT kihoc FROM tbllichday", cboKyhoc, "kihoc", "kihoc");
            cboKyhoc.SelectedIndex = -1;
            ResetValues();
            btnIn.Enabled = false;
        }
        
        private void ResetValues()
        {
            cboKyhoc.Text = "";
            txtGiaovien.Text = "";
        }

        private void btnBaocao_Click(object sender, EventArgs e)
        {
             btnIn.Enabled = true;
            string sql;
            if ((cboKyhoc.Text == "") && (txtGiaovien.Text ==""))
            {
                MessageBox.Show("Hãy nhập một điều kiện tìm kiếm!!!", "Yêu cầu ...",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sql = "SELECT Malop, Mamon, TenGV, Kihoc, Namhoc, ThoigianBD, ThoigianKT, Tienday, Tienthi FROM tblLichday ld inner join tblGiaovien gv on ld.MaGV=gv.MaGV WHERE 1=1 ";
            if (cboKyhoc.Text != "")
                sql = sql + " AND  (Kihoc = '" + cboKyhoc.Text + "')";
            if (txtGiaovien.Text != "")
                sql = sql + " AND TenGV Like N'%" + txtGiaovien.Text + "%'";
            tblLichday = Functions.GetDataToTable(sql);
            if (tblLichday.Rows.Count == 0)
                MessageBox.Show("Không có bản ghi thỏa mãn điều kiện!!!", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Có " + tblLichday.Rows.Count + " bản ghi thỏa mãn điều kiện!!!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DataGridView.DataSource = tblLichday;
            btnBoqua.Enabled = true;
        }

        private void btnBoqua_Click(object sender, EventArgs e)
        {
            ResetValues();
            btnBoqua.Enabled = false;
            btnBaocao.Enabled = true;
            btnThoat.Enabled = true;
            btnIn.Enabled = false;
            DataGridView.DataSource = null;
            
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
            DataTable  tblThongtinHang;
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
            exRange.Range["A4:E4"].Value = "Báo cáo tiền dạy- tiền thi của giáo viên";
            
            //Lấy thông tin các mặt hàng
            sql = "SELECT Malop, Mamon, TenGV, Kihoc, Namhoc, ThoigianBD, ThoigianKT, Tienday, Tienthi FROM  tblLichday ld inner join tblGiaovien gv on ld.MaGV=gv.MaGV WHERE 1=1 ";
            if (cboKyhoc.Text != "")
                sql = sql + " AND  (Kihoc = '" + cboKyhoc.SelectedValue + "')";
            if (txtGiaovien.Text != "")
                sql = sql + " AND  (TenGV = '" + txtGiaovien.Text + "')";
            tblThongtinHang = Functions.GetDataToTable(sql);
            //Tạo dòng tiêu đề bảng
            exRange.Range["A7:L11"].Font.Bold = true;
            exRange.Range["A7:L11"].HorizontalAlignment = COMExcel.XlHAlign.xlHAlignCenter;
            exRange.Range["C7:F7"].ColumnWidth = 12;
            exRange.Range["A7:A7"].Value = "STT";
            exRange.Range["B7:B7"].Value = "Lớp";
            exRange.Range["C7:C7"].Value = "Môn";
            exRange.Range["D7:D7"].Value = "Giáo viên";
            exRange.Range["E7:E7"].Value = "Kỳ học";
            exRange.Range["F7:F7"].Value = "Năm học";
            exRange.Range["G7:G7"].Value = "TGBT"; 
            exRange.Range["H7:H7"].Value = "TGKT";
            exRange.Range["I7:I7"].Value = "Tienday";
            exRange.Range["J7:J7"].Value = "Tienthi";
            for (hang = 0 ; hang <= tblThongtinHang.Rows.Count - 1; hang ++)
            {
                //Điền số thứ tự vào cột 1 từ dòng 8
                exSheet.Cells[1][hang + 8] = hang + 1;
                for (cot = 0 ; cot <= tblThongtinHang.Columns.Count - 1; cot++)
                    //Điền thông tin hàng từ cột thứ 2, dòng 8
              exSheet.Cells[cot + 2][hang + 8]= tblThongtinHang.Rows[hang][cot].ToString();
            }
            exApp.Visible = true;

        }
        DataTable tblLichday;
       
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }     
    }
}

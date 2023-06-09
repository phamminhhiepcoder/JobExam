﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaoCaoThongKeDAL
    {
        public GetSQLConnection getSQLConnection = new GetSQLConnection();

        public static bool baoCaoThongKeSV(string content, System.Data.DataTable dataTable)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                string sheetName = content;
                string title = "Quản Lý " + content;

                oSheet.Name = sheetName;

                // Tạo phần Tiêu đề
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã sinh viên";

                cl1.ColumnWidth = 12;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Tên sinh viên";

                cl2.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Địa chỉ";
                cl3.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Email";

                cl4.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Số điện thoại";

                cl5.ColumnWidth = 23.71;
                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Tên lớp";

                cl6.ColumnWidth = 23.71;

                

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền
                int size = dataTable.Columns.Count;

                rowHead.Interior.ColorIndex = 6;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mảng theo datatable

                string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    DataRow dataRow = dataTable.Rows[row];

                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        arr[row, col] = dataRow[col].ToString();
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dataTable.Rows.Count - 1;

                int columnEnd = dataTable.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột mã nhân viên

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                //Căn giữa cả bảng 
                oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }

        public static bool baoCaoThongKeDiem(string content, System.Data.DataTable dataTable)
        {
                try
                {
                    Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbooks oBooks;

                    Microsoft.Office.Interop.Excel.Sheets oSheets;

                    Microsoft.Office.Interop.Excel.Workbook oBook;

                    Microsoft.Office.Interop.Excel.Worksheet oSheet;

                    //Tạo mới một Excel WorkBook 

                    oExcel.Visible = true;

                    oExcel.DisplayAlerts = false;

                    oExcel.Application.SheetsInNewWorkbook = 1;

                    oBooks = oExcel.Workbooks;

                    oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                    oSheets = oBook.Worksheets;

                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                    string sheetName = content;
                    string title = "Quản Lý " + content;

                    oSheet.Name = sheetName;

                    // Tạo phần Tiêu đề
                    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "J1");

                    head.MergeCells = true;

                    head.Value2 = title;

                    head.Font.Bold = true;

                    head.Font.Name = "Times New Roman";

                    head.Font.Size = "20";

                    head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo tiêu đề cột 

                    Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                    cl1.Value2 = "Mã sinh viên";

                    cl1.ColumnWidth = 12;

                    Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                    cl2.Value2 = "Tên sinh viên";

                    cl2.ColumnWidth = 31.29;

                    Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                    cl3.Value2 = "Tên lớp";
                    cl3.ColumnWidth = 20.29;

                    Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                    cl4.Value2 = "Tên môn học";

                    cl4.ColumnWidth = 30;

                    Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                    cl5.Value2 = "Điểm miệng";

                    cl5.ColumnWidth = 15.71;

                    Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                    cl6.Value2 = "Điểm 15 phút";

                    cl6.ColumnWidth = 15.71;

                    Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                    cl7.Value2 = "Điểm 45 phút";

                    cl7.ColumnWidth = 24;

                    Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

                    cl8.Value2 = "Điểm giữa kỳ";

                    cl8.ColumnWidth = 18.43;
                    Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

                    cl9.Value2 = "Điểm cuối kỳ";

                    cl9.ColumnWidth = 18.43;
                    
                    Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

                    cl10.Value2 = "Điểm tổng kết";

                    cl10.ColumnWidth = 18.43;
                    
                    

                   

                    Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "J3");

                    rowHead.Font.Bold = true;

                    // Kẻ viền

                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Thiết lập màu nền
                    int size = dataTable.Columns.Count;

                    rowHead.Interior.ColorIndex = 6;

                    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo mảng theo datatable

                    string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

                    //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        DataRow dataRow = dataTable.Rows[row];

                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            arr[row, col] = dataRow[col].ToString();
                        }
                    }

                    //Thiết lập vùng điền dữ liệu

                    int rowStart = 4;

                    int columnStart = 1;

                    int rowEnd = rowStart + dataTable.Rows.Count - 1;

                    int columnEnd = dataTable.Columns.Count;

                    // Ô bắt đầu điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                    // Ô kết thúc điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                    // Lấy về vùng điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                    //Điền dữ liệu vào vùng đã thiết lập

                    range.Value2 = arr;

                    // Kẻ viền

                    range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Căn giữa cột mã nhân viên

                    Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                    Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                    //Căn giữa cả bảng 
                    oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;

            
        }
        public static bool baoCaoThongKeDiemTheoMonHoc(string content, System.Data.DataTable dataTable)
        {
                try
                {
                    Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbooks oBooks;

                    Microsoft.Office.Interop.Excel.Sheets oSheets;

                    Microsoft.Office.Interop.Excel.Workbook oBook;

                    Microsoft.Office.Interop.Excel.Worksheet oSheet;

                    //Tạo mới một Excel WorkBook 

                    oExcel.Visible = true;

                    oExcel.DisplayAlerts = false;

                    oExcel.Application.SheetsInNewWorkbook = 1;

                    oBooks = oExcel.Workbooks;

                    oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                    oSheets = oBook.Worksheets;

                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                    string sheetName = content;
                    string title = "Quản Lý " + content;

                    oSheet.Name = sheetName;

                    // Tạo phần Tiêu đề
                    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "H1");

                    head.MergeCells = true;

                    head.Value2 = title;

                    head.Font.Bold = true;

                    head.Font.Name = "Times New Roman";

                    head.Font.Size = "20";

                    head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo tiêu đề cột 

                    Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                    cl1.Value2 = "ID điểm số";

                    cl1.ColumnWidth = 12;

                    Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                    cl2.Value2 = "ID học sinh";

                    cl2.ColumnWidth = 21.29;

                    Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                    cl3.Value2 = "Tên học sinh";
                    cl3.ColumnWidth = 30.29;

                    Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                    cl4.Value2 = "Tên lớp";

                    cl4.ColumnWidth = 30;

                    Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                    cl5.Value2 = "Tên môn học";

                    cl5.ColumnWidth = 23.71;

                    Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                    cl6.Value2 = "Kì học";

                    cl6.ColumnWidth = 10.71;

                    Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                    cl7.Value2 = "Năm học";

                    cl7.ColumnWidth = 24;

                    Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

                    cl8.Value2 = "Điểm";

                    cl8.ColumnWidth = 8.43;

                   

                    Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "H3");

                    rowHead.Font.Bold = true;

                    // Kẻ viền

                    rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Thiết lập màu nền
                    int size = dataTable.Columns.Count;

                    rowHead.Interior.ColorIndex = 6;

                    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo mảng theo datatable

                    string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

                    //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        DataRow dataRow = dataTable.Rows[row];

                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            arr[row, col] = dataRow[col].ToString();
                        }
                    }

                    //Thiết lập vùng điền dữ liệu

                    int rowStart = 4;

                    int columnStart = 1;

                    int rowEnd = rowStart + dataTable.Rows.Count - 1;

                    int columnEnd = dataTable.Columns.Count;

                    // Ô bắt đầu điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                    // Ô kết thúc điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                    // Lấy về vùng điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                    //Điền dữ liệu vào vùng đã thiết lập

                    range.Value2 = arr;

                    // Kẻ viền

                    range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Căn giữa cột mã nhân viên

                    Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                    Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                    //Căn giữa cả bảng 
                    oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;

            
        }
        public static bool baoCaoThongKeDiemTheoNamHoc(string content, System.Data.DataTable dataTable)
        {
                try
                {
                    Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbooks oBooks;

                    Microsoft.Office.Interop.Excel.Sheets oSheets;

                    Microsoft.Office.Interop.Excel.Workbook oBook;

                    Microsoft.Office.Interop.Excel.Worksheet oSheet;

                    //Tạo mới một Excel WorkBook 

                    oExcel.Visible = true;

                    oExcel.DisplayAlerts = false;

                    oExcel.Application.SheetsInNewWorkbook = 1;

                    oBooks = oExcel.Workbooks;

                    oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                    oSheets = oBook.Worksheets;

                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                    string sheetName = content;
                    string title = "Quản Lý " + content;

                    oSheet.Name = sheetName;

                // Tạo phần Tiêu đề
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "L1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã học sinh";

                cl1.ColumnWidth = 12;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Tên học sinh";

                cl2.ColumnWidth = 21.29;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Niên khoá";
                cl3.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Tên môn học";

                cl4.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Học kì";

                cl5.ColumnWidth = 13.71;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Năm học";

                cl6.ColumnWidth = 20.71;


                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                cl7.Value2 = "Điểm miệng";

                cl7.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

                cl8.Value2 = "Điểm 15 phút";

                cl8.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

                cl9.Value2 = "Điểm 45 phút";

                cl9.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

                cl10.Value2 = "Điểm giữa kì";

                cl10.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

                cl11.Value2 = "Điểm cuối kì";

                cl11.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");

                cl12.Value2 = "Điểm tổng kết";

                cl12.ColumnWidth = 18.43;



                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "L3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Thiết lập màu nền
                    int size = dataTable.Columns.Count;

                    rowHead.Interior.ColorIndex = 6;

                    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo mảng theo datatable

                    string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

                    //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        DataRow dataRow = dataTable.Rows[row];

                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            arr[row, col] = dataRow[col].ToString();
                        }
                    }

                    //Thiết lập vùng điền dữ liệu

                    int rowStart = 4;

                    int columnStart = 1;

                    int rowEnd = rowStart + dataTable.Rows.Count - 1;

                    int columnEnd = dataTable.Columns.Count;

                    // Ô bắt đầu điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                    // Ô kết thúc điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                    // Lấy về vùng điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                    //Điền dữ liệu vào vùng đã thiết lập

                    range.Value2 = arr;

                    // Kẻ viền

                    range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Căn giữa cột mã nhân viên

                    Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                    Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                    //Căn giữa cả bảng 
                    oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;

            
        }
        public static bool baoCaoThongKeDiemTheoNamHocVaKiHoc(string content, System.Data.DataTable dataTable)
        {
                try
                {
                    Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                    Microsoft.Office.Interop.Excel.Workbooks oBooks;

                    Microsoft.Office.Interop.Excel.Sheets oSheets;

                    Microsoft.Office.Interop.Excel.Workbook oBook;

                    Microsoft.Office.Interop.Excel.Worksheet oSheet;

                    //Tạo mới một Excel WorkBook 

                    oExcel.Visible = true;

                    oExcel.DisplayAlerts = false;

                    oExcel.Application.SheetsInNewWorkbook = 1;

                    oBooks = oExcel.Workbooks;

                    oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                    oSheets = oBook.Worksheets;

                    oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                    string sheetName = content;
                    string title = "Quản Lý " + content;

                    oSheet.Name = sheetName;

                    // Tạo phần Tiêu đề
                    Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "L1");

                    head.MergeCells = true;

                    head.Value2 = title;

                    head.Font.Bold = true;

                    head.Font.Name = "Times New Roman";

                    head.Font.Size = "20";

                    head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã học sinh";

                cl1.ColumnWidth = 12;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Tên học sinh";

                cl2.ColumnWidth = 21.29;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Niên khoá";
                cl3.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Tên môn học";

                cl4.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Học kì";

                cl5.ColumnWidth = 13.71;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Năm học";

                cl6.ColumnWidth = 20.71;


                Microsoft.Office.Interop.Excel.Range cl7 = oSheet.get_Range("G3", "G3");

                cl7.Value2 = "Điểm miệng";

                cl7.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl8 = oSheet.get_Range("H3", "H3");

                cl8.Value2 = "Điểm 15 phút";

                cl8.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl9 = oSheet.get_Range("I3", "I3");

                cl9.Value2 = "Điểm 45 phút";

                cl9.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl10 = oSheet.get_Range("J3", "J3");

                cl10.Value2 = "Điểm giữa kì";

                cl10.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl11 = oSheet.get_Range("K3", "K3");

                cl11.Value2 = "Điểm cuối kì";

                cl11.ColumnWidth = 18.43;

                Microsoft.Office.Interop.Excel.Range cl12 = oSheet.get_Range("L3", "L3");

                cl12.Value2 = "Điểm tổng kết";

                cl12.ColumnWidth = 18.43;



                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "L3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Thiết lập màu nền
                    int size = dataTable.Columns.Count;

                    rowHead.Interior.ColorIndex = 6;

                    rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                    // Tạo mảng theo datatable

                    string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

                    //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                    for (int row = 0; row < dataTable.Rows.Count; row++)
                    {
                        DataRow dataRow = dataTable.Rows[row];

                        for (int col = 0; col < dataTable.Columns.Count; col++)
                        {
                            arr[row, col] = dataRow[col].ToString();
                        }
                    }

                    //Thiết lập vùng điền dữ liệu

                    int rowStart = 4;

                    int columnStart = 1;

                    int rowEnd = rowStart + dataTable.Rows.Count - 1;

                    int columnEnd = dataTable.Columns.Count;

                    // Ô bắt đầu điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                    // Ô kết thúc điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                    // Lấy về vùng điền dữ liệu

                    Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                    //Điền dữ liệu vào vùng đã thiết lập

                    range.Value2 = arr;

                    // Kẻ viền

                    range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                    // Căn giữa cột mã nhân viên

                    Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                    Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                    //Căn giữa cả bảng 
                    oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                }
                catch (Exception ex)
                {
                    return false;
                }

                return true;

            
        }
        public static bool baoCaoThongKeHocBaTheoLop(string content, System.Data.DataTable dataTable)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                string sheetName = content;
                string title = "Quản Lý " + content;

                oSheet.Name = sheetName;

                // Tạo phần Tiêu đề
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã học sinh";

                cl1.ColumnWidth = 12;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Tên học sinh";

                cl2.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Địa chỉ";
                cl3.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Email";

                cl4.ColumnWidth = 14;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Số điện thoại";

                cl5.ColumnWidth = 23.71;


                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Tên lớp";

                cl6.ColumnWidth = 23.71;

               



                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền
                int size = dataTable.Columns.Count;

                rowHead.Interior.ColorIndex = 6;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mảng theo datatable

                string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    DataRow dataRow = dataTable.Rows[row];

                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        arr[row, col] = dataRow[col].ToString();
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dataTable.Rows.Count - 1;

                int columnEnd = dataTable.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột mã nhân viên

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                //Căn giữa cả bảng 
                oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;

        }
        public static bool baoCaoThongKeSVTheoNam(string content, System.Data.DataTable dataTable)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                string sheetName = content;
                string title = "Quản Lý " + content;

                oSheet.Name = sheetName;

                // Tạo phần Tiêu đề
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã học sinh";

                cl1.ColumnWidth = 12;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Tên học sinh";

                cl2.ColumnWidth = 21.29;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Địa chỉ";
                cl3.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Email";

                cl4.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Số điện thoại";

                cl5.ColumnWidth = 23.71;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Niên khoá";

                cl6.ColumnWidth = 10.71;

                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền
                int size = dataTable.Columns.Count;

                rowHead.Interior.ColorIndex = 6;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mảng theo datatable

                string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    DataRow dataRow = dataTable.Rows[row];

                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        arr[row, col] = dataRow[col].ToString();
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dataTable.Rows.Count - 1;

                int columnEnd = dataTable.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột mã nhân viên

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                //Căn giữa cả bảng 
                oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public static bool baoCaoThongKeTaiKhoanGV(string content, System.Data.DataTable dataTable)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                string sheetName = content;
                string title = "Quản Lý " + content;

                oSheet.Name = sheetName;

                // Tạo phần Tiêu đề
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "F1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã giảng viên";

                cl1.ColumnWidth = 12;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Tên giảng viên";

                cl2.ColumnWidth = 21.29;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Mã tài khoản";
                cl3.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Tên tài khoản";
                cl4.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Mật khẩu";

                cl5.ColumnWidth = 30;

                Microsoft.Office.Interop.Excel.Range cl6 = oSheet.get_Range("F3", "F3");

                cl6.Value2 = "Tên quyền";

                cl6.ColumnWidth = 23.71;



                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "F3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền
                int size = dataTable.Columns.Count;

                rowHead.Interior.ColorIndex = 6;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mảng theo datatable

                string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    DataRow dataRow = dataTable.Rows[row];

                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        arr[row, col] = dataRow[col].ToString();
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dataTable.Rows.Count - 1;

                int columnEnd = dataTable.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột mã nhân viên

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                //Căn giữa cả bảng 
                oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }
        public static bool baoCaoThongKeTaiKhoanSV(string content, System.Data.DataTable dataTable)
        {
            try
            {
                Microsoft.Office.Interop.Excel.Application oExcel = new Microsoft.Office.Interop.Excel.Application();

                Microsoft.Office.Interop.Excel.Workbooks oBooks;

                Microsoft.Office.Interop.Excel.Sheets oSheets;

                Microsoft.Office.Interop.Excel.Workbook oBook;

                Microsoft.Office.Interop.Excel.Worksheet oSheet;

                //Tạo mới một Excel WorkBook 

                oExcel.Visible = true;

                oExcel.DisplayAlerts = false;

                oExcel.Application.SheetsInNewWorkbook = 1;

                oBooks = oExcel.Workbooks;

                oBook = (Microsoft.Office.Interop.Excel.Workbook)(oExcel.Workbooks.Add(Type.Missing));

                oSheets = oBook.Worksheets;

                oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oSheets.get_Item(1);

                string sheetName = content;
                string title = "Quản Lý " + content;

                oSheet.Name = sheetName;

                // Tạo phần Tiêu đề
                Microsoft.Office.Interop.Excel.Range head = oSheet.get_Range("A1", "E1");

                head.MergeCells = true;

                head.Value2 = title;

                head.Font.Bold = true;

                head.Font.Name = "Times New Roman";

                head.Font.Size = "20";

                head.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo tiêu đề cột 

                Microsoft.Office.Interop.Excel.Range cl1 = oSheet.get_Range("A3", "A3");

                cl1.Value2 = "Mã sinh viên";

                cl1.ColumnWidth = 12;

                Microsoft.Office.Interop.Excel.Range cl2 = oSheet.get_Range("B3", "B3");

                cl2.Value2 = "Tên sinh viên";

                cl2.ColumnWidth = 21.29;

                Microsoft.Office.Interop.Excel.Range cl3 = oSheet.get_Range("C3", "C3");

                cl3.Value2 = "Mã tài khoản";
                cl3.ColumnWidth = 30.29;
                
                Microsoft.Office.Interop.Excel.Range cl4 = oSheet.get_Range("D3", "D3");

                cl4.Value2 = "Tên tài khoản";
                cl4.ColumnWidth = 30.29;

                Microsoft.Office.Interop.Excel.Range cl5 = oSheet.get_Range("E3", "E3");

                cl5.Value2 = "Mật khẩu";

                cl5.ColumnWidth = 30;


                Microsoft.Office.Interop.Excel.Range rowHead = oSheet.get_Range("A3", "E3");

                rowHead.Font.Bold = true;

                // Kẻ viền

                rowHead.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Thiết lập màu nền
                int size = dataTable.Columns.Count;

                rowHead.Interior.ColorIndex = 6;

                rowHead.HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                // Tạo mảng theo datatable

                string[,] arr = new string[dataTable.Rows.Count, dataTable.Columns.Count];

                //Chuyển dữ liệu từ DataTable vào mảng đối tượng

                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    DataRow dataRow = dataTable.Rows[row];

                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        arr[row, col] = dataRow[col].ToString();
                    }
                }

                //Thiết lập vùng điền dữ liệu

                int rowStart = 4;

                int columnStart = 1;

                int rowEnd = rowStart + dataTable.Rows.Count - 1;

                int columnEnd = dataTable.Columns.Count;

                // Ô bắt đầu điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c1 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowStart, columnStart];

                // Ô kết thúc điền dữ liệu

                Microsoft.Office.Interop.Excel.Range c2 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnEnd];

                // Lấy về vùng điền dữ liệu

                Microsoft.Office.Interop.Excel.Range range = oSheet.get_Range(c1, c2);

                //Điền dữ liệu vào vùng đã thiết lập

                range.Value2 = arr;

                // Kẻ viền

                range.Borders.LineStyle = Microsoft.Office.Interop.Excel.Constants.xlSolid;

                // Căn giữa cột mã nhân viên

                Microsoft.Office.Interop.Excel.Range c3 = (Microsoft.Office.Interop.Excel.Range)oSheet.Cells[rowEnd, columnStart];

                Microsoft.Office.Interop.Excel.Range c4 = oSheet.get_Range(c1, c3);

                //Căn giữa cả bảng 
                oSheet.get_Range(c1, c2).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
            }
            catch (Exception ex)
            {
                return false;
            }

            return true;
        }

    }
}

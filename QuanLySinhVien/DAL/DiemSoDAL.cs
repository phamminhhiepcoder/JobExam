using DTO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DiemSoDAL
    {
        public static DataTable layDiemSo()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select SinhVien.MaSV, TenSV, TenLop, TenMonHoc, DiemMieng, Diem15, Diem45, DiemGiuaKy, DiemCuoiKy, DiemTongKet " +
                "from SinhVien " +
                "inner join ChiTietDiem on ChiTietDiem.MaSV = SinhVien.MaSV " +
                "inner join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
                "left join Lop on Lop.MaLop = SinhVien.MaLop " +
                "inner join MonHoc on MonHoc.MaMonHoc = ChiTietDiem.MaMonHoc", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }
        public static bool themDiemSo(Diem diemSo, ChiTietDiem chiTietDiem) {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand check = new SqlCommand("select case when exists( " +
                "select *  " +
                "from ChiTietDiem inner join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
                "where Diem.MaMonHoc = " + diemSo.maMonHoc + " and MaGV = " + chiTietDiem.maGV + " and MaSV = " + chiTietDiem.maSV + ") " +
                "then 1 else 0 end", connection);
            int checkID = Convert.ToInt32(check.ExecuteScalar());
            if (checkID == 0)
            {
                SqlCommand insert1 = new SqlCommand("insert into Diem(MaMonHoc, DiemMieng, Diem15, Diem45, DiemGiuaKy, DiemCuoiKy, DiemTongKet) values(" + diemSo.maMonHoc + ", " + diemSo.diemMieng + ", " + diemSo.diem15 +
               ", " + diemSo.diem45 + ", " + diemSo.diemGiuaKi + ", " + diemSo.diemCuoiKi + ", " + diemSo.diemTongKet + ") ", connection);
                insert1.ExecuteNonQuery();
                SqlCommand check2 = new SqlCommand("select scope_identity()", connection);
                int id = Convert.ToInt32(check2.ExecuteScalar());
                SqlCommand insert2 = new SqlCommand("insert into ChiTietDiem(MaMonHoc, MaDiem, MaGV, MaSV) values (" + chiTietDiem.maMonHoc + ", " + id + ", " + chiTietDiem.maGV + ", " + chiTietDiem.maSV + ")", connection);
                insert2.ExecuteNonQuery();
                return true;
            }
            else return false;
        }
        
        public static bool capNhatDiemSo(ChiTietDiem chiTietDiem, Diem diemSo) {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand check = new SqlCommand("select case when exists( " +
               "select *  " +
               "from ChiTietDiem inner join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
               "where Diem.MaMonHoc = " + diemSo.maMonHoc + " and MaGV = " + chiTietDiem.maGV + " and MaSV = " + chiTietDiem.maSV + ") " +
               "then 1 else 0 end", connection);
            int checkID = Convert.ToInt32(check.ExecuteScalar());
            if (checkID == 1)
            {
                SqlCommand command2 = new SqlCommand("update Diem " +
                    "set DiemMieng = " + diemSo.diemMieng + ", " +
                    "Diem15 = " + diemSo.diem15 + ", " +
                    "Diem45 = " + diemSo.diem45 + ", " +
                    "DiemGiuaKy = " + diemSo.diemGiuaKi + ", " +
                    "DiemCuoiKy = " + diemSo.diemCuoiKi + ", " +
                    "DiemTongKet = " + diemSo.diemTongKet + 
                    " from ChiTietDiem " +
                    "left join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
                    "left join SinhVien on SinhVien.MaSV = ChiTietDiem.MaSV " +
                    "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                    "where SinhVien.MaSV = " + chiTietDiem.maSV + " and TenMonHoc = N'" + MonHocDAL.layTenTheoMa(chiTietDiem.maMonHoc) + "'", connection);
                command2.ExecuteNonQuery();
                return true;
            }
            else return false;
        }


        public static bool xoaDiemSo(ChiTietDiem chiTietDiem, Diem diemSo) {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
           
           
                SqlCommand command1 = new SqlCommand("delete ChiTietDiem " +
                    "from ChiTietDiem " +
                    "left join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
                    "left join SinhVien on SinhVien.MaSV = ChiTietDiem.MaSV " +
                    "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                    "where SinhVien.MaSV = " + chiTietDiem.maSV + " and TenMonHoc = N'" + MonHocDAL.layTenTheoMa(chiTietDiem.maMonHoc) + "'", connection);
                command1.ExecuteNonQuery();
                
                return true;
          
        }
        public static bool baoCaoThongKeDiem()
        {
            return BaoCaoThongKeDAL.baoCaoThongKeDiem("Điểm Số", layDiemSo());
        }
    }
}

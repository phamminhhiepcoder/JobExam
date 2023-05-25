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
        
        
      
        public static DataTable layDiemSoTheoLop(string tenLop)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select HocSinh.MaHS, TenHS, TenMonHoc, DiemMieng, Diem15, Diem45, DiemGiuaKy, DiemCuoiKy, DiemTongKet " +
                "from HocSinh " +
                "left join ChiTietDiem on ChiTietDiem.MaHS = HocSinh.MaHS " +
                "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                "left join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
                "where TenLop = N'" + tenLop + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable layDiemSoTheoTenHS(string tenHS)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select HocSinh.MaHS, TenHS, TenNienKhoa, TenMonHoc, ChiTietDiem.MaHK, TenNam, DiemMieng, Diem15, Diem45, DiemGiuaKy, DiemCuoiKy, DiemTongKet " +
                "from HocSinh " +
                "left join ChiTietDiem on ChiTietDiem.MaHS = HocSinh.MaHS " +
                "left join NienKhoa on HocSinh.MaNienKhoa = NienKhoa.MaNienKhoa " +
                "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                "left join Nam on Nam.MaNam = ChiTietDiem.MaNam " +
                "left join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
                "where TenHS = N'" + tenHS + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable layDiemSoTheoTenHSVaMaHS(string tenHS, int maHS)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select HocSinh.MaHS, TenHS, TenMonHoc, DiemMieng, Diem15, Diem45, DiemGiuaKy, DiemCuoiKy, DiemTongKet " +
                "from HocSinh " +
                "left join ChiTietDiem on ChiTietDiem.MaHS = HocSinh.MaHS " +
                "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                "left join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
                "where TenHS = N'" + tenHS + "' and HocSinh.MaHS = " + maHS, connection);
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
                "where Diem.MaMonHoc = " + diemSo.maMonHoc + " and MaGV = " + chiTietDiem.maGV + " and MaHS = " + chiTietDiem.maHS + ") " +
                "then 1 else 0 end", connection);
            int checkID = Convert.ToInt32(check.ExecuteScalar());
            if (checkID == 0)
            {
                SqlCommand insert1 = new SqlCommand("insert into Diem(MaMonHoc, DiemMieng, Diem15, Diem45, DiemGiuaKy, DiemCuoiKy, DiemTongKet) values(" + diemSo.maMonHoc + ", " + diemSo.diemMieng + ", " + diemSo.diem15 +
               ", " + diemSo.diem45 + ", " + diemSo.diemGiuaKi + ", " + diemSo.diemCuoiKi + ", " + diemSo.diemTongKet + ") ", connection);
                insert1.ExecuteNonQuery();
                SqlCommand check2 = new SqlCommand("select scope_identity()", connection);
                int id = Convert.ToInt32(check2.ExecuteScalar());
                SqlCommand insert2 = new SqlCommand("insert into ChiTietDiem(MaMonHoc, MaDiem, MaGV, MaHS) values (" + chiTietDiem.maMonHoc + ", " + id + ", " + chiTietDiem.maGV + ", " + chiTietDiem.maHS + ")", connection);
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
               "where Diem.MaMonHoc = " + diemSo.maMonHoc + " and MaGV = " + chiTietDiem.maGV + " and MaHS = " + chiTietDiem.maHS + ") " +
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
                    "left join HocSinh on HocSinh.MaHS = ChiTietDiem.MaHS " +
                    "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                    "where HocSinh.MaHS = " + chiTietDiem.maHS + " and TenMonHoc = N'" + MonHocDAL.layTenTheoMa(chiTietDiem.maMonHoc) + "'", connection);
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
                    "left join HocSinh on HocSinh.MaHS = ChiTietDiem.MaHS " +
                    "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                    "where HocSinh.MaHS = " + chiTietDiem.maHS + " and TenMonHoc = N'" + MonHocDAL.layTenTheoMa(chiTietDiem.maMonHoc) + "'", connection);
                command1.ExecuteNonQuery();
                
                return true;
          
        }

        public static bool baoCaoThongKeDiemTheoLop(string tenLop)
        {
            return BaoCaoThongKeDAL.baoCaoThongKeDiemTheoLop("Lớp " + tenLop, layDiemSoTheoLop(tenLop));
        }
    }
}

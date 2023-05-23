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
        public static DataTable layThongTinDiemSoCuaLop(string tenLop)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select DiemSo.idDS, HocSinh.idHS, TenHS, TenLop, TenMonHoc, KyHoc, NamHoc, Diem " +
                "from DiemSo " +
                "left join HocSinh on DiemSo.idHS = HocSinh.idHS " +
                "left join Lop on Lop.idLop = HocSinh.idLop " +
                "left join MonHoc on MonHoc.idMH = DiemSo.idMH " +
                "where TenLop = N'" + tenLop + "' " +
                "order by NamHoc desc, KyHoc desc", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }
        public static DataTable layThongTinDiemSoCuaMonHoc(string monHoc)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select DiemSo.idDS, HocSinh.idHS, TenHS, TenLop, TenMonHoc, KyHoc, NamHoc, Diem " +
                "from DiemSo " +
                "left join HocSinh on DiemSo.idHS = HocSinh.idHS " +
                "left join Lop on Lop.idLop = HocSinh.idLop " +
                "left join MonHoc on MonHoc.idMH = DiemSo.idMH " +
                "where TenMonHoc = N'" + monHoc + "' " +
                "order by NamHoc desc, KyHoc desc", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable layDiemSoTheoNamHoc(string nam)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select distinct HocSinh.MaHS, TenHS, TenNienKhoa, TenMonHoc, ChiTietDiem.MaHK, TenNam, DiemMieng, Diem15, Diem45, DiemGiuaKy, DiemCuoiKy, DiemTongKet " +
                "from HocSinh " +
                "left join ChiTietDiem on ChiTietDiem.MaHS = HocSinh.MaHS " +
                "left join NienKhoa on HocSinh.MaNienKhoa = NienKhoa.MaNienKhoa " +
                "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                "left join Nam on Nam.MaNam = ChiTietDiem.MaNam " +
                "left join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
                "where TenNam = '" + nam + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable layDiemSoTheoNamHocVaKiHoc(string nam, int ki)
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
                "where TenNam = '" + nam + "' and ChiTietDiem.MaHK = " + ki, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        } 
      
        public static DataTable layDiemSoTheoNamKiVaLop(string nam, int ki, string tenLop)
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select HocSinh.MaHS, TenHS, TenNienKhoa, TenMonHoc, Lop.MaHK, TenNam, DiemMieng, Diem15, Diem45, DiemGiuaKy, DiemCuoiKy, DiemTongKet " +
                "from HocSinh " +
                "left join ChiTietDiem on ChiTietDiem.MaHS = HocSinh.MaHS " +
                "left join NienKhoa on HocSinh.MaNienKhoa = NienKhoa.MaNienKhoa " +
                "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                "left join Nam on Nam.MaNam = ChiTietDiem.MaNam " +
                "left join Diem on Diem.MaDiem = ChiTietDiem.MaDiem " +
                "where TenNam = '" + nam + "' and ChiTietDiem.MaHK = " + ki + " and TenLop = N'" + tenLop + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable layDiemSoTheoNamKiVaTenHS(string nam, int ki, string tenHS)
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
                "where TenNam = '" + nam + "' and ChiTietDiem.MaHK = " + ki + " and TenHS = N'" + tenHS + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);

            return dataTable;
        }
        public static DataTable layDiemSoTheoNamKiTenHSVaMaHS(string nam, int ki, string tenHS, int maHS)
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
                "where TenNam = '" + nam + "' and ChiTietDiem.MaHK = " + ki + " and TenHS = N'" + tenHS + "' and HocSinh.MaHS = " + maHS, connection);
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
                "where Diem.MaMonHoc = " + diemSo.maMonHoc + " and MaGV = " + chiTietDiem.maGV + " and MaHS = " + chiTietDiem.maHS + " and MaNam = " + chiTietDiem.maNam + ") " +
                "then 1 else 0 end", connection);
            int checkID = Convert.ToInt32(check.ExecuteScalar());
            if (checkID == 0)
            {
                SqlCommand insert1 = new SqlCommand("insert into Diem(MaMonHoc, DiemMieng, Diem15, Diem45, DiemGiuaKy, DiemCuoiKy, DiemTongKet) values(" + diemSo.maMonHoc + ", " + diemSo.diemMieng + ", " + diemSo.diem15 +
               ", " + diemSo.diem45 + ", " + diemSo.diemGiuaKi + ", " + diemSo.diemCuoiKi + ", " + diemSo.diemTongKet + ") ", connection);
                insert1.ExecuteNonQuery();
                SqlCommand check2 = new SqlCommand("select scope_identity()", connection);
                int id = Convert.ToInt32(check2.ExecuteScalar());
                SqlCommand insert2 = new SqlCommand("insert into ChiTietDiem(MaMonHoc, MaDiem, MaGV, MaHS, MaHK, MaNam) values (" + chiTietDiem.maMonHoc + ", " + id + ", " + chiTietDiem.maGV + ", " + chiTietDiem.maHS + ", " + chiTietDiem.maHK + ", " + chiTietDiem.maNam + ")", connection);
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
               "where Diem.MaMonHoc = " + diemSo.maMonHoc + " and MaGV = " + chiTietDiem.maGV + " and MaHS = " + chiTietDiem.maHS + " and MaNam = " + chiTietDiem.maNam + ") " +
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
                    "left join NienKhoa on HocSinh.MaNienKhoa = NienKhoa.MaNienKhoa " +
                    "left join HocSinh_Lop on HocSinh_Lop.MaHS = HocSinh.MaHS " +
                    "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                    "left join Nam on ChiTietDiem.MaNam = Nam.MaNam " +
                    "left join HocKi on HocKi.MaHK = ChiTietDiem.MaHK " +
                    "where HocSinh.MaHS = " + chiTietDiem.maHS + " and TenMonHoc = N'" + MonHocDAL.layTenTheoMa(chiTietDiem.maMonHoc) + "' and TenNam = '" + NamDAL.layTenTheoMa(chiTietDiem.maNam) + "' and HocKi.MaHK = " + chiTietDiem.maHK, connection);
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
                    "left join NienKhoa on HocSinh.MaNienKhoa = NienKhoa.MaNienKhoa " +
                    "left join HocSinh_Lop on HocSinh_Lop.MaHS = HocSinh.MaHS " +
                    "left join MonHoc on ChiTietDiem.MaMonHoc = MonHoc.MaMonHoc " +
                    "left join Nam on ChiTietDiem.MaNam = Nam.MaNam " +
                    "left join HocKi on HocKi.MaHK = ChiTietDiem.MaHK " +
                    "where HocSinh.MaHS = " + chiTietDiem.maHS + " and TenMonHoc = N'" + MonHocDAL.layTenTheoMa(chiTietDiem.maMonHoc) + "' and TenNam = '" + NamDAL.layTenTheoMa(chiTietDiem.maNam) + "' and HocKi.MaHK = " + chiTietDiem.maHK, connection);
                command1.ExecuteNonQuery();
                
                return true;
          
        }

        public static bool baoCaoThongKeDiemTheoLop(string tenLop)
        {
            return BaoCaoThongKeDAL.baoCaoThongKeDiemTheoLop("Lớp " + tenLop, layThongTinDiemSoCuaLop(tenLop));
        }
        public static bool baoCaoThongKeDiemTheoMon(string monHoc)
        {
            return BaoCaoThongKeDAL.baoCaoThongKeDiemTheoMonHoc("Môn " + monHoc, layThongTinDiemSoCuaMonHoc(monHoc));
        } 
        public static bool baoCaoThongKeDiemTheoNamHoc(string namHoc)
        {
            return BaoCaoThongKeDAL.baoCaoThongKeDiemTheoNamHoc("Năm Học " + namHoc, layDiemSoTheoNamHoc(namHoc));
        }
        public static bool baoCaoThongKeDiemTheoNamHocVaKiHoc(string namHoc, int ki)
        {
            return BaoCaoThongKeDAL.baoCaoThongKeDiemTheoNamHocVaKiHoc("Năm " + namHoc + " Kì " + ki, layDiemSoTheoNamHocVaKiHoc(namHoc, ki));
        }
        public static List<string> layTenNamHoc()
        {
            List<string> list = new List<string>(); 
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select distinct NamHoc from DiemSo", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            reader.Close();
            command.ExecuteNonQuery();
            return list;
        }

    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SinhVienDAL
    {
        public static SinhVien layThongTinSV(int maTaiKhoan)
        {
            SinhVien SinhVien = new SinhVien();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select MaSV, TenSV, DiaChi, Email, Sdt from SinhVien where MaTaiKhoan = " + maTaiKhoan, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                SinhVien.maSV = (int)reader.GetValue(0);
                SinhVien.tenSV = (string)reader.GetValue(1);
                SinhVien.diaChi = (string)reader.GetValue(2);
                SinhVien.email = (string)reader.GetValue(3);
                SinhVien.sdt = (string)reader.GetValue(4);
                SinhVien.maTaiKhoan = maTaiKhoan;
            }

            return SinhVien;
        }
        public static SinhVien layThongTinSVTheoMa(int ma)
        {
            SinhVien SinhVien = new SinhVien();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select MaSV, TenSV, DiaChi, Email, Sdt from SinhVien where MaSV = " + ma, connection);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                SinhVien.maSV = (int)reader.GetValue(0);
                SinhVien.tenSV = (string)reader.GetValue(1);
                SinhVien.diaChi = (string)reader.GetValue(2);
                SinhVien.email = (string)reader.GetValue(3);
                SinhVien.sdt = (string)reader.GetValue(4);
            }
            return SinhVien;
        }



        public static List<string> layTenLop()
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            List<string> list = new List<string>();
            SqlCommand sqlCommand = new SqlCommand("select TenLop from Lop inner join SinhVien on SinhVien.idLop = Lop.idLop", connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }

        public static bool themSV(SinhVien SinhVien)
        {

            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("insert into SinhVien(TenSV, DiaChi, Email, Sdt) values (N'" + SinhVien.tenSV + "', N'" + SinhVien.diaChi + "', '" + SinhVien.email + "', '" + SinhVien.sdt + "')", connection);
            command.ExecuteNonQuery();
            return true;

        }
        public static bool capNhatSV(SinhVien SinhVien)
        {

            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("update SinhVien set TenSV = N'" + SinhVien.tenSV + "', DiaChi = N'" + SinhVien.diaChi + "', Email = '" + SinhVien.email + "', Sdt = '" + SinhVien.sdt + "' where MaSV = " + SinhVien.maSV, connection);
            command.ExecuteNonQuery();
            return true;

        }
        public static bool xoaSV(SinhVien SinhVien)
        {

            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand delete1 = new SqlCommand("delete ChiTietDiem\r\nfrom ChiTietDiem\r\ninner join SinhVien on ChiTietDiem.MaSV = SinhVien.MaSV where SinhVien.MaSV = " + SinhVien.maSV, connection);
            delete1.ExecuteNonQuery();
            SqlCommand delete2 = new SqlCommand("delete SinhVien_Lop\r\nfrom SinhVien_Lop\r\ninner join SinhVien on SinhVien_Lop.MaSV = SinhVien.MaSV where SinhVien.MaSV = " + SinhVien.maSV, connection);
            delete2.ExecuteNonQuery();
            SqlCommand command = new SqlCommand("delete SinhVien where SinhVien.MaSV = " + SinhVien.maSV, connection);
            command.ExecuteNonQuery();
            return true;

        }
        public static SinhVien layThongTinCoBan(int ma)
        {
            SinhVien SinhVien = new SinhVien();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select TenSV from SinhVien where MaSV = " + ma, connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                SinhVien.maSV = ma;
                SinhVien.tenSV = reader.GetString(0);
            }
            return SinhVien;
        }

        public static DataTable layDanSVachSVTheoNienKhoa(string nienKhoa)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand("select MaSV, TenSV, DiaChi, Email, Sdt " +
                "from SinhVien " +
                "where TenNienKhoa = '" + nienKhoa + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable layDanhSachSVTheoNam(string nam)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            DataTable dt = new DataTable();

            SqlCommand command = new SqlCommand("select SinhVien.MaSV, TenSV, DiaChi, Email, Sdt, TenNienKhoa " +
                "from SinhVien " +
                "inner join SinhVien_Lop on SinhVien_Lop.MaSV = SinhVien.MaSV " +
                "inner join NienKhoa on NienKhoa.MaNienKhoa = SinhVien.MaNienKhoa " +
                "inner join Nam on SinhVien_Lop.MaNam = Nam.MaNam " +
                "where TenNam = '" + nam + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }


        public static List<string> laySVTheoNamVaKi(string nam, int ki)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            List<string> list = new List<string>();
            SqlCommand sqlCommand = new SqlCommand("select distinct TenSV " +
                "from SinhVien " +
                "inner join SinhVien_Lop on SinhVien.MaSV = SinhVien_Lop.MaSV " +
                "inner join HocKi on SinhVien_Lop.MaHK = HocKi.MaHK " +
                "inner join Nam on Nam.MaNam = SinhVien_Lop.MaNam " +
                "where TenNam = '" + nam + "' and HocKi.MaHK = " + ki, connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }
        public static string layTenTheoMa(int ma)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select TenSV from SinhVien where MaSV = " + ma, connection);
            string ten = (string)command.ExecuteScalar();
            return ten;
        }

        public static bool bctkSinhVienTheoNam(string nam)
        {
            return BaoCaoThongKeDAL.baoCaoThongKeSVTheoNam(" Sinh Viên Theo Năm " + nam, layDanhSachSVTheoNam(nam));
        }
       
    }
}

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
        public static DataTable layThongTinCacSV()
        {
            DataTable dt = new DataTable();
            SinhVien SinhVien = new SinhVien();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select SinhVien.MaSV, TenSV, DiaChi, Email, Sdt, TenLop from SinhVien " +
                                                "left join Lop on SinhVien.MaLop = Lop.MaLop", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }
        public static DataTable layThongTinCacSVTheoLop(string tenLop)
        {
            DataTable dt = new DataTable();
            SinhVien SinhVien = new SinhVien();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select SinhVien.MaSV, TenSV, DiaChi, Email, Sdt, TenLop from SinhVien " +
                                                "left join Lop on SinhVien.MaLop = Lop.MaLop " +
                                                "where TenLop = N'" + tenLop + "'", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dt);
            return dt;
        }

        public static bool baoCaoThongKeSV()
        {
            return BaoCaoThongKeDAL.baoCaoThongKeSV("Sinh Viên", layThongTinCacSV());
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



        public static List<int> layMaHSTheoTen(string ten)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            List<int> list = new List<int>();
            SqlCommand sqlCommand = new SqlCommand("select MaSV from SinhVien where TenSV = N'" + ten + "'", connection);
            SqlDataReader reader = sqlCommand.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetInt32(0));
            }
            return list;
        }

        public static bool themSV(SinhVien SinhVien)
        {

            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("insert into SinhVien(TenSV, DiaChi, Email, Sdt, MaLop) values (N'" + SinhVien.tenSV + "', N'" + SinhVien.diaChi + "', '" + SinhVien.email + "', '" + SinhVien.sdt + "', " + SinhVien.maLop + ")", connection);
            command.ExecuteNonQuery();
            return true;

        }
        public static bool capNhatSV(SinhVien SinhVien)
        {

            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("update SinhVien set TenSV = N'" + SinhVien.tenSV + "', DiaChi = N'" + SinhVien.diaChi + "', Email = '" + SinhVien.email + "', Sdt = '" + SinhVien.sdt + "', MaLop = " + SinhVien.maLop + " where MaSV = " + SinhVien.maSV, connection);
            command.ExecuteNonQuery();
            return true;

        }
        public static bool xoaSV(SinhVien SinhVien)
        {

            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand delete1 = new SqlCommand("delete ChiTietDiem\r\nfrom ChiTietDiem\r\ninner join SinhVien on ChiTietDiem.MaSV = SinhVien.MaSV where SinhVien.MaSV = " + SinhVien.maSV, connection);
            delete1.ExecuteNonQuery();
            SqlCommand command = new SqlCommand("delete SinhVien where SinhVien.MaSV = " + SinhVien.maSV, connection);
            command.ExecuteNonQuery();
            return true;

        }

        public static string layTenTheoMa(int ma)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select TenSV from SinhVien where MaSV = " + ma, connection);
            string ten = (string)command.ExecuteScalar();
            return ten;
        }

       
    }
}

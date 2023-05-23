using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class GiangVienDAL
    {
        public static GiangVien layThongTinGV(int maTaiKhoan)
        {
            GiangVien giangVien = new GiangVien();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select MaGV, TenGV, Email, Sdt from GiangVien where MaTaiKhoan = " + maTaiKhoan, connection);
            SqlDataReader reader = command.ExecuteReader(); 

            while (reader.Read())
            {
                giangVien.maGV = (int)reader.GetValue(0);
                giangVien.tenGV = (string)reader.GetValue(1);
                giangVien.email = (string)reader.GetValue(2);
                giangVien.sdt = (string)reader.GetValue(3);
                giangVien.maTaiKhoan = maTaiKhoan;
            }

            return giangVien;
        }
    }
}

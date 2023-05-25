using DTO;
using System;
using System.Collections.Generic;
using System.Data;
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

        public static DataTable layCacGV()
        {
            DataTable dataTable = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select MaGV, TenGV, Email, Sdt from GiangVien", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }
        public static bool themGV(GiangVien gv)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand checkCmd = new SqlCommand("select case when exists(select * from GiangVien where TenGV = N'" + gv.tenGV + "' and Email = '" + gv.email + "' and Sdt = '" + gv.sdt + "') then 1 else 0 end", connection);
            int check = Convert.ToInt32(checkCmd.ExecuteScalar());
            if (check == 1) return false;
            else
            {
                SqlCommand command = new SqlCommand("insert into GiangVien(TenGV, Email, Sdt) values(N'" + gv.tenGV + "', '" + gv.email + "', '" + gv.sdt + "')", connection);
                command.ExecuteNonQuery();
                return true;
            }
        }
        public static bool suaGV(GiangVien gv)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("update GiangVien set TenGV = N'" + gv.tenGV + "', Email = '" + gv.email + "', Sdt = '" + gv.sdt + "' where MaGV = " + gv.maGV, connection);
            command.ExecuteNonQuery();
            return true;
        }
        public static bool xoaGV(GiangVien gv)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command1 = new SqlCommand("delete ChiTietDiem where MaGV = " + gv.maGV, connection);
            command1.ExecuteNonQuery();
            SqlCommand command2 = new SqlCommand("delete GiangVien where MaGV = " + gv.maGV, connection);
            command2.ExecuteNonQuery();
            return true;
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace DAL
{
    public class MonHocDAL
    {
        public static DataTable layThongTinMonHoc()
        {
            try
            {
                SqlConnection connection = GetSQLConnection.getConnection();
                DataTable dataTable = new DataTable();


                SqlCommand command = new SqlCommand("select * from MonHoc", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);

                adapter.Fill(dataTable);

                return dataTable;
            }catch (Exception ex)
            {
                return null;
            }
        }
      
        public static bool themMonHoc(string tenMonHoc)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand commandCheck = new SqlCommand("select case when exists(select * from MonHoc where TenMonHoc = N'" + tenMonHoc + "') then 1 else 0 end", connection);
            int check = Convert.ToInt32(commandCheck.ExecuteScalar());
            if(check == 1)
            {
                return false;
            }
            else
            {
                SqlCommand insert = new SqlCommand("insert into MonHoc(TenMonHoc) values(N'" + tenMonHoc + "')", connection);
                insert.ExecuteNonQuery();
                return true;
            }
        }
        public static bool capNhatMonHoc(MonHoc monHoc, string tenMonHoc)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand commandCheck = new SqlCommand("select case when exists(select * from MonHoc where TenMonHoc = N'" + monHoc.tenMonHoc + "') then 1 else 0 end", connection);
            int check = Convert.ToInt32(commandCheck.ExecuteScalar());
            if (check == 1)
            {
                SqlCommand update = new SqlCommand("update MonHoc set TenMonHoc = N'" + tenMonHoc + "' where MaMonHoc = " + monHoc.maMonHoc, connection);
                update.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool xoaMonHoc(string tenMonHoc)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand commandCheck = new SqlCommand("select case when exists(select * from MonHoc where TenMonHoc = N'" + tenMonHoc + "') then 1 else 0 end", connection);
            int check = Convert.ToInt32(commandCheck.ExecuteScalar());
            if (check == 1)
            {
                SqlCommand delete1 = new SqlCommand("delete Diem from Diem inner join ChiTietDiem on ChiTietDiem.MaDiem = Diem.MaDiem and ChiTietDiem.MaMonHoc = Diem.MaMonHoc " +
                   "inner join MonHoc on Diem.MaMonHoc = MonHoc.MaMonHoc " +
                   "where TenMonHoc = N'" + tenMonHoc + "'", connection);
                delete1.ExecuteNonQuery();
                SqlCommand delete2 = new SqlCommand("delete MonHoc where TenMonHoc = N'" + tenMonHoc + "'", connection);
                delete2.ExecuteNonQuery();
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<string> layTenCacMonHoc()
        {
            List<string> list = new List<string>();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select TenMonHoc from MonHoc", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }
        public static int layMaTheoTen(string ten)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select MaMonHoc from MonHoc where TenMonHoc = N'" + ten + "'", connection);
            int n = Convert.ToInt32(command.ExecuteScalar());
            return n;
        } 
        public static string layTenTheoMa(int ma)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select TenMonHoc from MonHoc where MaMonHoc = " + ma + "", connection);
           string n = (string)command.ExecuteScalar();
            return n;
        }
    }
}

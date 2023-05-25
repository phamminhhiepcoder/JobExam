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
    public class LopDAL
    {
        public static DataTable layThongTinLop()
        {
            try
            {
                SqlConnection connection = GetSQLConnection.getConnection();
                connection.Open();
                DataTable dataTable = new DataTable();
                string query = "select * from Lop " +
                               "order by idLop";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static int layMaLop(string tenLop)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select MaLop from Lop where TenLop = N'" + tenLop + "'", connection);
            int id = Convert.ToInt32(command.ExecuteScalar());
            return id;
        }
        public static string layTenLop(int maSV, string tenSV)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select TenLop " +
                "from SinhVien " +
                "inner join Lop on SinhVien_Lop.MaLop = Lop.MaLop " +
                "where SinhVien.MaSV = " + maSV + " and TenHS = N'" + tenSV + "'", connection);
            string tenLop = (string)command.ExecuteScalar();
            return tenLop;
        }
        public static List<string> getAllTenLop()
        {
            List<string> list = new List<string>();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select TenLop from Lop", connection);
            SqlDataReader reader = command.ExecuteReader();

            while(reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }
        public static bool themThongTinLop(string tenLop)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand commandCheck = new SqlCommand("select case when exists(select * from Lop where TenLop = N'" + tenLop + "') then 1 else 0 end", connection);
            int check = Convert.ToInt32(commandCheck.ExecuteScalar());
            if (check == 1) return false;
            else
            {
                SqlCommand command = new SqlCommand("insert into Lop(TenLop) values (N'" + tenLop + "')", connection);
                command.ExecuteNonQuery();
                return true;
            }
        }
        public static bool capNhatThongTinLop(Lop lop, string tenLop)
        {
                SqlConnection connection = GetSQLConnection.getConnection();
                connection.Open();
               
                
                    SqlCommand command = new SqlCommand("update Lop set TenLop = N'" + tenLop + "' where TenLop = N'" + lop.tenLop + "'", connection);
                    command.ExecuteNonQuery();
                    return true;
                
        }
        public static bool xoaThongTinLop(string tenLop)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand commandCheck = new SqlCommand("select case when exists(select * from Lop where TenLop = N'" + tenLop + "') then 1 else 0 end", connection);
            int check = Convert.ToInt32(commandCheck.ExecuteScalar());
            if (check == 0) return false;
            else
            {
                SqlCommand command = new SqlCommand("delete Lop where TenLop = N'" + tenLop + "'", connection);
                command.ExecuteNonQuery();
                return true;
            }
        }
        
        
    }
}
        


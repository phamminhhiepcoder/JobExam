using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NamDAL
    {
        public static List<string> layNam()
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            List<string> list = new List<string>();
            SqlCommand cmd = new SqlCommand("select TenNam from Nam", connection);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }

        public static int layMaTheoTen(string tenNam)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select MaNam from Nam where TenNam = '" + tenNam + "'", connection);
            int check = Convert.ToInt32(cmd.ExecuteScalar());
            return check;
        } 
        public static string layTenTheoMa(int ma)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand cmd = new SqlCommand("select TenNam from Nam where MaNam = " + ma, connection);
            string check = (string)cmd.ExecuteScalar();
            return check;
        }
    }
}

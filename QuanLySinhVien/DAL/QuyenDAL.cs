using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuyenDAL
    {
        public static string layTenQuyen(int maQuyen)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select TenQuyen from Quyen where MaQuyen = " + maQuyen, connection);
            string check = (string)command.ExecuteScalar();
            return check;
        } 
        public static int layMaQuyen(string tenQuyen)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select MaQuyen from Quyen where TenQuyen = N'" + tenQuyen + "'", connection);
            int check = Convert.ToInt32(command.ExecuteScalar());
            return check;
        }
    }
}

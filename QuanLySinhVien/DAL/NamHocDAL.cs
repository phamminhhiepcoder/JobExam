using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NamHocDAL
    {
        public static int layMaNam(string tenNam)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select MaNam from Nam where TenNam = '" + tenNam + "'", connection);
            int ma = (int)command.ExecuteScalar();
            return ma;
        }

        public static DataTable layCacNam()
        {
            DataTable table = new DataTable();
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select TenNam from Nam", connection);
            
            return table;
        }
    }
}

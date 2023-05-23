using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DAL
{
    public class GetSQLConnection
    {
        public static SqlConnection getConnection()
        {
            string str = "Data Source=WIN-4CJCU58BMKJ\\SQLEXPRESS;Initial Catalog=QuanLySinhVien;Integrated Security=True";
            try
            {
                SqlConnection connection = new SqlConnection(str);
                return connection;
            }catch(Exception ex)
            {
                return null;
            }
        }

    }
}

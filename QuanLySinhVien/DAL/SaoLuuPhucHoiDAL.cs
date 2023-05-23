using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SaoLuuPhucHoiDAL
    {
        public static bool saoLuuDuLieu()
        {
            string backupPath = "C:\\Backup"; 
            string databaseName = "QLHB"; 

            using (SqlConnection connection = GetSQLConnection.getConnection())
            {
                connection.Open();

                string backupQuery = $"BACKUP DATABASE {databaseName} TO DISK = '{backupPath}'";

                using (SqlCommand command = new SqlCommand(backupQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
        public static bool phucHoiDuLieu()
        {
            string restorePath = "C:\\Backup"; 
            string databaseName = "QLHB"; 

            using (SqlConnection connection = GetSQLConnection.getConnection())
            {
                connection.Open();

                string restoreQuery = $"RESTORE DATABASE {databaseName} FROM DISK = '{restorePath}'";

                using (SqlCommand command = new SqlCommand(restoreQuery, connection))
                {
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}

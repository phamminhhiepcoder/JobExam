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
        public static string layTenLop(int maHS, string tenHS, string tenNienKhoa, string tenNam, int maHK)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select TenLop " +
                "from HocSinh " +
                "inner join HocSinh_Lop on HocSinh_Lop.MaHS = HocSinh.MaHS " +
                "inner join Lop on HocSinh_Lop.MaLop = Lop.MaLop " +
                "inner join NienKhoa on HocSinh.MaNienKhoa = NienKhoa.MaNienKhoa " +
                "inner join Nam on HocSinh_Lop.MaNam = Nam.MaNam " +
                "where HocSinh.MaHS = " + maHS + " and TenHS = N'" + tenHS + "' and TenNienKhoa = '" + tenNienKhoa + "' and TenNam = '" + tenNam + "' and HocSinh_Lop.MaHK = " +  maHK, connection);
            string tenLop = (string)command.ExecuteScalar();
            return tenLop;
        }

        public static string layTenLopTheoMaHSNamVaKi(int maHS, int maNam, int maHK)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select TenLop " +
                "from HocSinh " +
                "inner join HocSinh_Lop on HocSinh.MaHS = HocSinh_Lop.MaHS " +
                "inner join Lop on Lop.MaLop = HocSinh_Lop.MaLop " +
                "where HocSinh.MaHS = " + maHS + " and HocSinh_Lop.MaNam = " + maNam + " and HocSinh_Lop.MaHK = "  + maHK, connection);
            string tenLop = (string)command.ExecuteScalar();
            return tenLop;
        }
        public static DataTable layThongTin1Lop(string tenLop)
        {
            try
            {
                SqlConnection connection = GetSQLConnection.getConnection();
                connection.Open();
                DataTable dataTable = new DataTable();
                
                SqlCommand command = new SqlCommand("select HocSinh.idHS, TenHS, TenMonHoc, KyHoc, NamHoc, Diem " +
                    "from HocSinh " +
                    "inner join DiemSo on HocSinh.idHS = DiemSo.idHS " +
                    "inner join MonHoc on MonHoc.idMH = DiemSo.idMH " +
                    "inner join Lop on HocSinh.idLop = Lop.idLop " +
                    "where TenLop = N'" + tenLop +"'", connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                return dataTable;
            }
            catch (Exception ex)
            {
                return null;
            }
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
        

        public static DataTable layThongTinLopTheoKiVaNam(Lop lop) 
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("select MaLop, TenLop, TenNam, MaHK from Lop inner join Nam on Lop.MaNam = Nam.MaNam where Lop.MaHK = " + lop.maHK + " and Lop.MaNam = " + lop.maNam, connection);
            DataTable table = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);

            return table;
        }
        public static List<string> layTenLopTheoKiVaNam(int ki, string nam) 
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            List<string> list = new List<string>();
            int ma = NamDAL.layMaTheoTen(nam);
            SqlCommand command = new SqlCommand("select TenLop from Lop where MaHK = " + ki + " and MaNam = " + ma, connection);
            SqlDataReader reader = command.ExecuteReader();
            while(reader.Read())
            {
                list.Add(reader.GetString(0));
            }
            return list;
        }

        
    }
}
        


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
    public class TaiKhoanGVDAL
    {
        public static bool checkTaiKhoan(TaiKhoan taiKhoan)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select case when exists (select * from TaiKhoan where TenTaiKhoan = '" + taiKhoan.tenTaiKhoan + "' and MatKhau = '" + taiKhoan.matKhau + "') then 1 else 0 end", connection);
            int check = Convert.ToInt32(command.ExecuteScalar());
            if (check == 1) return true;
            else return false;
        }
        public static int layMaQuyen(TaiKhoan taiKhoan)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select MaQuyen from TaiKhoan where TenTaiKhoan = '" + taiKhoan.tenTaiKhoan + "' and MatKhau = '" + taiKhoan.matKhau + "'", connection);
            int check = Convert.ToInt32(command.ExecuteScalar());
            return check;
        }
        public static int layMaTaiKhoan(TaiKhoan taiKhoan)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("select MaTaiKhoan from TaiKhoan where TenTaiKhoan = '" + taiKhoan.tenTaiKhoan + "' and MatKhau = '" + taiKhoan.matKhau + "'", connection);
            int check = Convert.ToInt32(command.ExecuteScalar());
            return check;
        }
        public static DataTable layDanhSach()
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand("select MaGV, TenGV, GiangVien.MaTaiKhoan, TenTaiKhoan, MatKhau, TenQuyen " +
                "from GiangVien " +
                "left join TaiKhoan on GiangVien.MaTaiKhoan = TaiKhoan.MaTaiKhoan " +
                "left join Quyen on Quyen.MaQuyen = TaiKhoan.MaQuyen", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static bool capNhatTaiKhoan(TaiKhoan taiKhoan, GiangVien GiangVien)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand commandCheck = new SqlCommand("select MaTaiKhoan from TaiKhoan where TenTaiKhoan = '" + taiKhoan.tenTaiKhoan + "' and MatKhau = '" + taiKhoan.matKhau + "'", connection);
            int check = Convert.ToInt32(commandCheck.ExecuteScalar());
            
                SqlCommand insert = new SqlCommand("insert into TaiKhoan(TenTaiKhoan, MatKhau, MaQuyen) values ('" + taiKhoan.tenTaiKhoan + "', '" + taiKhoan.matKhau + "', " + taiKhoan.maQuyen + ")", connection);
                insert.ExecuteNonQuery();

                SqlCommand checkId = new SqlCommand("select scope_identity()", connection);
                int id = Convert.ToInt32(checkId.ExecuteScalar());

                SqlCommand update = new SqlCommand("update GiangVien set MaTaiKhoan = " + id + " where MaGV = " + GiangVien.maGV, connection);
                update.ExecuteNonQuery();
                
                return true;
            
        }
        public static bool xoaTaiKhoan(TaiKhoan taiKhoan, GiangVien GiangVien)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand commandCheck = new SqlCommand("select MaTaiKhoan from TaiKhoan where TenTaiKhoan = '" + taiKhoan.tenTaiKhoan + "' and MatKhau = '" + taiKhoan.matKhau + "'", connection);
            int check = Convert.ToInt32(commandCheck.ExecuteScalar());
            
                SqlCommand update = new SqlCommand("update GiangVien set MaTaiKhoan = null where MaGV = " + GiangVien.maGV, connection);
                update.ExecuteNonQuery();

                SqlCommand command = new SqlCommand("delete TaiKhoan where MaTaiKhoan = " + check, connection);
                command.ExecuteNonQuery();
                return true;
            
        }
        public static bool bctkTaiKhoanGV()
        {
            return BaoCaoThongKeDAL.baoCaoThongKeTaiKhoanGV("Tài Khoản Giảng Viên", layDanhSach());
        }

    }
}

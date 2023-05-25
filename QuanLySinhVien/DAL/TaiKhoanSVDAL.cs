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
    public class TaiKhoanHSDAL
    {
        public static DataTable layDanhSach()
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            DataTable dataTable = new DataTable();
            SqlCommand command = new SqlCommand("select SinhVien.MaSV, TenSV, TaiKhoan.MaTaiKhoan, TenTaiKhoan, MatKhau " +
                "from SinhVien " +
                "left join TaiKhoan on SinhVien.MaTaiKhoan = TaiKhoan.MaTaiKhoan ", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(dataTable);
            return dataTable;
        }

        public static bool capNhatTaiKhoan(TaiKhoan taiKhoan, SinhVien SinhVien)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand commandCheck = new SqlCommand("select MaTaiKhoan from TaiKhoan where TenTaiKhoan = '" + taiKhoan.tenTaiKhoan + "' and MatKhau = '" + taiKhoan.matKhau + "'", connection);
            int check = Convert.ToInt32(commandCheck.ExecuteScalar());

            SqlCommand insert = new SqlCommand("insert into TaiKhoan(TenTaiKhoan, MatKhau, MaQuyen) values ('" + taiKhoan.tenTaiKhoan + "', '" + taiKhoan.matKhau + "', 3)", connection);
            insert.ExecuteNonQuery();

            SqlCommand checkId = new SqlCommand("select scope_identity()", connection);
            int id = Convert.ToInt32(checkId.ExecuteScalar());

            SqlCommand update = new SqlCommand("update SinhVien set MaTaiKhoan = " + id + " where MaSV = " + SinhVien.maSV, connection);
            update.ExecuteNonQuery();

            return true;

        }
        public static bool xoaTaiKhoan(TaiKhoan taiKhoan, SinhVien SinhVien)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            SqlCommand commandCheck = new SqlCommand("select MaTaiKhoan from TaiKhoan where TenTaiKhoan = '" + taiKhoan.tenTaiKhoan + "' and MatKhau = '" + taiKhoan.matKhau + "'", connection);
            int check = Convert.ToInt32(commandCheck.ExecuteScalar());

            SqlCommand update = new SqlCommand("update SinhVien set MaTaiKhoan = null where MaSV = " + SinhVien.maSV, connection);
            update.ExecuteNonQuery();

            SqlCommand command = new SqlCommand("delete TaiKhoan where MaTaiKhoan = " + check, connection);
            command.ExecuteNonQuery();
            return true;

        }
        public static bool bctkTaiKhoanHS()
        {
            return BaoCaoThongKeDAL.baoCaoThongKeTaiKhoanSV(" Tài Khoản Học Sinh", layDanhSach());
        }

    }
}

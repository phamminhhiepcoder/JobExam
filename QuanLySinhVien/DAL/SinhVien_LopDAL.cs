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
    public class SinhVien_LopDAL
    {
        public static DataTable layThongTinSVDuocPhanLop()
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("select SinhVien.MaSV, TenSV, DiaChi, Email, Sdt, TenLop, SinhVien_Lop.MaHK as HocKi, TenNam " +
                "from SinhVien " +
                "inner join SinhVien_Lop on SinhVien_Lop.MaSV = SinhVien.MaSV " +
                "inner join Lop on Lop.MaLop = SinhVien_Lop.MaLop " +
                "inner join Nam on Nam.MaNam = SinhVien_Lop.MaNam " +
                "where Lop.MaLop is not null", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }
        public static bool themSVVaoLop(SinhVien_Lop sinhVien_Lop)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            SqlCommand command = new SqlCommand("insert into SinhVien_Lop values(" + sinhVien_Lop.maSV + ", " + sinhVien_Lop.maLop + ", " + sinhVien_Lop.maHK + ", " + sinhVien_Lop.maNam + ")", connection);
            command.ExecuteNonQuery();
            return true;
        }
        public static DataTable layThongTinSVChuaDuocPhanLop()
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();
            DataTable table = new DataTable();

            SqlCommand command = new SqlCommand("select SinhVien.MaSV, TenSV, DiaChi, Email, Sdt, TenLop, SinhVien_Lop.MaHK as HocKi, TenNam from SinhVien " +
                "left join SinhVien_Lop on SinhVien.MaSV = SinhVien_Lop.MaSV " +
                "left join Lop on Lop.MaLop = SinhVien_Lop.MaLop " +
                "left join Nam on Nam.MaNam = SinhVien_Lop.MaNam " +
                "where Lop.MaLop is null", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            adapter.Fill(table);
            return table;
        }

        public static bool baoCaoThongKeSinhVienPhanLop()
        {
            return BaoCaoThongKeDAL.baoCaoThongKeSinhVienPhanLop("Phân Lớp Sinh Viên", layThongTinSVDuocPhanLop());
        }
        public static List<int> layMaSVTheoKiNamVaTen(string tenSV, int ki, string nam)
        {
            SqlConnection connection = GetSQLConnection.getConnection();
            connection.Open();

            List<int> list = new List<int>();
            SqlCommand command = new SqlCommand("select distinct SinhVien.MaSV " +
                "from SinhVien " +
                "inner join SinhVien_Lop on SinhVien.MaHS = SinhVien_Lop.MaSV " +
                "inner join Nam on HocSinh_Lop.MaNam = Nam.MaNam " +
                "inner join HocKi on HocSinh_Lop.MaHK = HocKi.MaHK " +
                "where HocKi.MaHK = " + ki + " and TenNam = '" + nam + "' and TenSV = N'" + tenSV + "'", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                list.Add(reader.GetInt32(0));
            }
            return list;
        }
    }
}

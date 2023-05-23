using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DiemSoBLL
    {
        public static DataTable layToanBoThongTinDiemSo()
        {
            return DiemSoDAL.layToanBoThongTinDiemSo();
        }

        public static DataTable layThongTinDiemSoCuaLop(string tenLop)
        {
            return DiemSoDAL.layThongTinDiemSoCuaLop(tenLop);
        }
        public static DataTable layThongTinDiemSoCuaMonHoc(string monHoc)
        {
            return DiemSoDAL.layThongTinDiemSoCuaMonHoc(monHoc);
        }public static DataTable layThongTinDiemSoCuaLopVaMonHoc(string tenLop, string monHoc)
        {
            return DiemSoDAL.layThongTinDiemSoCuaLopVaMonHoc(tenLop, monHoc);
        }
        public static bool themDiemSo(DiemSo diemSo)
        {
            return DiemSoDAL.themDiemSo(diemSo);
        }
        public static bool capNhatDiemSo(DiemSo diemSo)
        {
            return DiemSoDAL.capNhatDiemSo(diemSo);
        }public static bool xoaDiemSo(DiemSo diemSo)
        {
            return DiemSoDAL.xoaDiemSo(diemSo);
        }
        public static bool baoCaoThongKeDiemTheoLop(string tenLop)
        {
            return DiemSoDAL.baoCaoThongKeDiemTheoLop(tenLop);
        }
        public static bool baoCaoThongKeDiemTheoMon(string monHoc)
        {
            return DiemSoDAL.baoCaoThongKeDiemTheoMon(monHoc);
        }
        public static bool baoCaoThongKeDiemTheoNamHoc(string namHoc)
        {
            return DiemSoDAL.baoCaoThongKeDiemTheoNamHoc(namHoc);
        }
        public static List<string> layTenNamHoc()
        {
            return DiemSoDAL.layTenNamHoc();
        }
    }
}

using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
namespace BLL
{
    public class LopBLL
    {
        public static DataTable layThongTinLop()
        {
            return LopDAL.layThongTinLop();
        } 
        public static DataTable layThongTin1Lop(string tenLop)
        {
            return LopDAL.layThongTin1Lop(tenLop);
        }
        public static int layID1Lop(string tenLop)
        {
            return LopDAL.layID1Lop(tenLop);
        }
        public static string layTenLop(int id)
        {
            return LopDAL.layTenLop(id);
        }
        public static bool themThongTinLop(string tenLop)
        {
            return LopDAL.themThongTinLop(tenLop);
        }
        public static bool capNhatThongTinLop(Lop lop, string tenLop)
        {
            return LopDAL.capNhatThongTinLop(lop, tenLop);
        }public static bool xoaThongTinLop(string tenLop)
        {
            return LopDAL.xoaThongTinLop(tenLop);
        }
        public static List<string> getAllTenLop()
        {
            return LopDAL.getAllTenLop();
        }
    }
}

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
    public class HocSinhBLL
    {
        public static DataTable layToanBoHS()
        {
            return HocSinhDAL.layToanBoHS();
        }
        public static DataTable layToanBoHSTrongLop(string tenLop)
        {
            return HocSinhDAL.layToanBoHSTrongLop(tenLop);
        }
        public static List<string> layTenLop()
        {
            return HocSinhDAL.layTenLop();
        }
        public static bool themHS(HocSinh hocSinh)
        {
            return HocSinhDAL.themHS(hocSinh);
        }
        public static bool capNhatHS(HocSinh hocSinh)
        {
            return HocSinhDAL.capNhatHS(hocSinh);
        }
        public static bool xoaHS(HocSinh hocSinh)
        {
            return HocSinhDAL.xoaHS(hocSinh);
        }
        public static HocSinh lay1HS(int id)
        {
            return HocSinhDAL.lay1HS(id);
        }

        public static bool baoCaoThongKeHocSinh() {
            return HocSinhDAL.baoCaoThongKeHocSinh();
        }
    }
}

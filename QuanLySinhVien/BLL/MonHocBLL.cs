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
    public class MonHocBLL
    {

        public static DataTable layThongTinMonHoc()
        {
            return MonHocDAL.layThongTinMonHoc();
        }
        public static DataTable layThongTin1MonHoc(string tenMonHoc)
        {
            return MonHocDAL.layThongTin1MonHoc(tenMonHoc);
        }

        public static List<string> layTenCacMonHoc()
        {
            return MonHocDAL.layTenCacMonHoc();
        }
        public static bool themMonHoc(string tenMonHoc)
        {
            return MonHocDAL.themMonHoc(tenMonHoc);
        }
        public static bool capNhatMonHoc(MonHoc monHoc, string tenMonHoc)
        {
            return MonHocDAL.capNhatMonHoc(monHoc, tenMonHoc);
        } 
        public static bool xoaMonHoc(string tenMonHoc)
        {
            return MonHocDAL.xoaMonHoc(tenMonHoc);
        }
        public static int layIdMonHoc(string tenMonHoc)
        {
            return MonHocDAL.layIDMonHoc(tenMonHoc);
        }
    }
}

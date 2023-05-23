using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GiangVien
    {
        public int maGV { get; set; }
        public string tenGV { get; set; }
        public string email { get; set; }
        public string sdt { get; set; }
        public int maTaiKhoan { get; set; }

        public override string ToString()
        {
            return $"MaGV: {maGV} \n TenGV: {tenGV} \n Email: {email} \n sdt: {sdt} \n MaTaiKhoan: {maTaiKhoan}";
        }
    }
}

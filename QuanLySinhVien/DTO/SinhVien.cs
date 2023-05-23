using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SinhVien
    {
        public int maSV {  get; set; }    
        public string tenSV {  get; set; }    
        public string diaChi {  get; set; }    
        public string email {  get; set; }    
        public string sdt {  get; set; }    
        public int maTaiKhoan {  get; set; }

        public override string ToString()
        {
            return $"MaHS: {maSV} \n TenHS: {tenSV} \n DiaChi: {diaChi} \n Email: {email} \n sdt: {sdt} \n MaTaiKhoan: {maTaiKhoan}";

        }
    }
}

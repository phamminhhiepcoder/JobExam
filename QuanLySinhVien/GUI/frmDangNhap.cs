using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmDangNhap : Form
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        public void openFormChucNang()
        {
            Application.Run(new frmChucNang());
        }
        static string tenQuyen = "";
        static SinhVien sinhVien = new SinhVien();
        static GiangVien giangVien = new GiangVien();
        public string layTenQuyen()
        {
            return tenQuyen;
        }
        public static GiangVien layGiangVien()
        {
            return giangVien;
        }public SinhVien layHocSinh()
        {
            return sinhVien;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(txtTenTaiKhoan.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập tên tài khoản!");
            }
            else
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.tenTaiKhoan = txtTenTaiKhoan.Text;
                taiKhoan.matKhau = txtMatKhau.Text;
                if(TaiKhoanGVDAL.checkTaiKhoan(taiKhoan) == true)
                {
                    tenQuyen = QuyenDAL.layTenQuyen(TaiKhoanGVDAL.layMaQuyen(taiKhoan));
                    int maTaiKhoan = TaiKhoanGVDAL.layMaTaiKhoan(taiKhoan);
                    if(tenQuyen == "Sinh viên")
                    {
                        sinhVien = SinhVienDAL.layThongTinSV(maTaiKhoan);
                    }
                    else if(tenQuyen == "Giảng viên")
                    {
                        giangVien = GiangVienDAL.layThongTinGV(maTaiKhoan);   
                    }
                    else if(tenQuyen == "Admin")
                    {
                        giangVien = GiangVienDAL.layThongTinGV(maTaiKhoan);
                    }
                    Thread thread = new Thread(openFormChucNang);
                    thread.Start();
                }
                else
                {
                    MessageBox.Show("Mời nhập lại!");
                }
            }
            
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
           
        }
    }
}

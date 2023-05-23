using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using DAL;
using System.Threading;

namespace GUI
{
    public partial class frmChucNang : Form
    {
        

        public frmChucNang()
        {
            InitializeComponent();
        }
        static string tenQuyen = "";
        static GiangVien giangVien = new GiangVien();
        static SinhVien sinhVien = new SinhVien();

        public static string layTenQuyen() { return tenQuyen; }
        private void frmChucNang_Load(object sender, EventArgs e)
        {
            frmDangNhap dangNhap = new frmDangNhap();

            tenQuyen = dangNhap.layTenQuyen();
            if(tenQuyen == "Học sinh")
            {
                sinhVien = dangNhap.layHocSinh();
                
                btnQuanLyMonHoc.Enabled = false;
                btnQuanLyTaiKhoanSV.Enabled = false;
                btnQuanLyTaiKhoanGV.Enabled = false;
            }
            else if(tenQuyen == "Giáo viên")
            {
                giangVien = frmDangNhap.layGiangVien();
                btnQuanLyTaiKhoanSV.Enabled = false;
                btnQuanLyMonHoc.Enabled = false;
            }
            else if(tenQuyen == "Admin")
            {
                giangVien = frmDangNhap.layGiangVien();
            }
        }
       
        public void openFormDangNhap()
        {
            Application.Run(new frmDangNhap());
        }
        public void openFormMonHoc()
        {
            Application.Run(new frmThongTinMonHoc());
        }
       
       
        

       

        private void tsmiQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openFormMonHoc);
            thread.Start();
        }

        private void tsmiQuanLyDiemSo_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openFormDiemSo);
            thread.Start();
       }
        void openFormHS()
        {
            Application.Run(new frmQuanLySinhVien()); 
        } 
        void openFormDiemSo()
        {
            Application.Run(new frmQuanLyDiemSo()); 
        }
     
  

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread thread = new Thread(openFormDangNhap);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        
        private void btnInfo_Click(object sender, EventArgs e)
        {
            if(tenQuyen == "Giảng viên")
            {
                MessageBox.Show(tenQuyen + Environment.NewLine + giangVien.ToString());
            }
            else if(tenQuyen == "Sinh viên")
            {
                MessageBox.Show(tenQuyen + Environment.NewLine + sinhVien.ToString());
            }
            else if(tenQuyen == "Admin")
            {
                MessageBox.Show(tenQuyen + Environment.NewLine + giangVien.ToString());
            }
        }
        private void btnBaoCaoThongKe_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openFormBCTK);
            thread.Start();
        }

        void openFormQLTKSV()
        {
            Application.Run(new frmQuanLyTaiKhoan());
        }
        void openFormBCTK()
        {
            Application.Run(new frmBaoCaoThongKe());
        }
        void openFormQLMH()
        {
            Application.Run(new frmThongTinMonHoc());
        }
        void openFormQLSV()
        {
            Application.Run(new frmQuanLySinhVien());
        } 
        void openFormQLGV()
        {
            Application.Run(new frmQuanLyGV());
        }
        void openFormQLDS()
        {
            Application.Run(new frmQuanLyDiemSo());
        }
      
        private void btnQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openFormQLTKSV);
            thread.Start();
        }

        private void btnQuanLyMonHoc_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openFormQLMH);
            thread.Start();
        }

        private void btnQuanLySV_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmQuanLySinhVien quanLySinhVien = new frmQuanLySinhVien();
            quanLySinhVien.Show(this);
        }

        private void btnQuanLyGV_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openFormQLSV);
            thread.Start();
        }

        private void btnQuanLyDiemSo_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openFormQLDS);
            thread.Start();
        }

        private void btnQuanLyViPham_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlContent_Paint(object sender, PaintEventArgs e)
        {

        }
        void openFormTKGV()
        {
            Application.Run(new frmQuanLyTaiKhoanGV());
        }
        private void btnQuanLyTaiKhoanGV_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openFormTKGV);
            thread.Start();
        }
    }
}

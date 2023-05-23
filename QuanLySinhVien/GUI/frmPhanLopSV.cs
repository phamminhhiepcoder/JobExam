using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmPhanLopSV : Form
    {
        public frmPhanLopSV()
        {
            InitializeComponent();
        }
        static List<string> listNam = NamDAL.layNam();
        private void frmPhanLopHS_Load(object sender, EventArgs e)
        {
            dgvHocSinhChuaPhanLop.DataSource = SinhVien_LopDAL.layThongTinSVChuaDuocPhanLop();
           

            foreach (string s in listNam)
            {
                cboNamHoc.Items.Add(s);
                cboNamFilter.Items.Add(s);
            }

        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            if (SinhVien_LopDAL.baoCaoThongKeSinhVienPhanLop())
            {

            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra!");
            }
        }

        private void cboKiFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboNamFilter.Text != "")
            {
                   if(cboKiFilter.Text != "")
                {
                    string namHoc = cboNamFilter.Text;
                    int kiHoc = Convert.ToInt32(cboKiFilter.Text);
                    Lop lop = new Lop();
                    lop.maHK = kiHoc;
                    lop.maNam = NamDAL.layMaTheoTen(namHoc);
                    MessageBox.Show(lop.maHK + " " + lop.maNam);
                    dgvThongTinLopTheoKiNam.DataSource = LopDAL.layThongTinLopTheoKiVaNam(lop);
                }
            }
            else
            {

            }
        }

        private void cboHocKi_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboNamHoc.Text != "")
            {
                if(cboHocKi.Text != "")
                {
                    string namHoc = cboNamHoc.Text;
                    int kiHoc = Convert.ToInt32(cboHocKi.Text);
                    List<string> listLop = LopDAL.layTenLopTheoKiVaNam(kiHoc, namHoc);
                    foreach(string s in listLop)
                    {
                        cboLop.Items.Add(s);
                    }
                    cboLop.Enabled = true;
                }
                
            }

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
          if(txtMaHS.Text == "" || txtTenHS.Text == "" || cboHocKi.Text == "" || cboNamHoc.Text == "" || cboLop.Text == "")
            {
                MessageBox.Show("Bạn chưa chọn đủ!");
            }
            else
            {
                SinhVien_Lop sinhVien_Lop = new SinhVien_Lop();

                int maNam = NamDAL.layMaTheoTen(cboNamHoc.Text);
                sinhVien_Lop.maSV = Convert.ToInt32(txtMaHS.Text);
                sinhVien_Lop.maLop = LopDAL.layMaLop(cboLop.Text);
                sinhVien_Lop.maHK = Convert.ToInt32(cboHocKi.Text);
                sinhVien_Lop.maNam = maNam;
                if (SinhVien_LopDAL.themSVVaoLop(sinhVien_Lop))
                {
                    dgvHocSinhChuaPhanLop.DataSource = SinhVien_LopDAL.layThongTinSVChuaDuocPhanLop();
                }
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            foreach(var control in this.Controls)
            {
                if(control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).Text = "";
                }
            }
        }

        private void dgvHocSinhChuaPhanLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaHS.Text = dgvHocSinhChuaPhanLop.Rows[index].Cells[0].Value.ToString();
                txtTenHS.Text = dgvHocSinhChuaPhanLop.Rows[index].Cells[1].Value.ToString();
            }
        }

        private void txtMaHS_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvThongTinLopTheoKiNam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                cboLop.Text = dgvThongTinLopTheoKiNam.Rows[index].Cells[1].Value.ToString() ;
                cboNamHoc.Text = dgvThongTinLopTheoKiNam.Rows[index].Cells[2].Value.ToString() ;
                cboHocKi.Text = dgvThongTinLopTheoKiNam.Rows[index].Cells[3].Value.ToString() ;
            }
        }
    } 
}

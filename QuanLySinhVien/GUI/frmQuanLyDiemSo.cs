using DAL;
using DTO;
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

namespace GUI
{
    public partial class frmQuanLyDiemSo : Form
    {
        public frmQuanLyDiemSo()
        {
            InitializeComponent();
        }

        static List<string> listNam = NamDAL.layNam();
        static List<string> listMon = MonHocDAL.layTenCacMonHoc();
        static GiangVien giangVien = frmDangNhap.layGiangVien();
        
        private void frmQuanLyDiemSo_Load(object sender, EventArgs e)
        {
            foreach(string s in listMon)
            {
                cboMonFilter.Items.Add(s);
                cboTenMon.Items.Add(s); 
            }
           
           foreach(string s in listNam)
            {
                cboNamFilter.Items.Add(s);
                cboNamHoc.Items.Add(s);
            }
        }

      

        private void cboMonFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            

        }

        private void dgvThongTinDiemSo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaSV.Text = dgvThongTinDiemSo.Rows[index].Cells[0].Value.ToString();
                txtTenSV.Text = dgvThongTinDiemSo.Rows[index].Cells[1].Value.ToString();
                cboTenMon.Text = dgvThongTinDiemSo.Rows[index].Cells[3].Value.ToString();
                cboKyHoc.Text = dgvThongTinDiemSo.Rows[index].Cells[4].Value.ToString();
                cboNamHoc.Text = dgvThongTinDiemSo.Rows[index].Cells[5].Value.ToString();
                txtDiemMieng.Text = dgvThongTinDiemSo.Rows[index].Cells[6].Value.ToString();
                txtDiem15Phut.Text = dgvThongTinDiemSo.Rows[index].Cells[7].Value.ToString();
                txtDiem45Phut.Text = dgvThongTinDiemSo.Rows[index].Cells[8].Value.ToString();
                txtDiemGiuaKi.Text = dgvThongTinDiemSo.Rows[index].Cells[9].Value.ToString();
                txtDiemCuoiKi.Text = dgvThongTinDiemSo.Rows[index].Cells[10].Value.ToString();
                txtDiemTongKet.Text = dgvThongTinDiemSo.Rows[index].Cells[11].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "" || cboKyHoc.Text == "" || cboTenMon.Text == "" || cboNamHoc.Text == "" || txtDiemMieng.Text == "" || txtDiem15Phut.Text == "" || txtDiem45Phut.Text == "" ||
                txtDiemGiuaKi.Text == "" || txtDiemCuoiKi.Text == "" || txtDiemTongKet.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu!");
            }
            else
            {
                ChiTietDiem chiTietDiem = new ChiTietDiem();
                chiTietDiem.maMonHoc = MonHocDAL.layMaTheoTen(cboTenMon.Text);
                chiTietDiem.maGV = giangVien.maGV;
                chiTietDiem.maHS = Convert.ToInt32(txtMaSV.Text);
                chiTietDiem.maHK = Convert.ToInt32(cboKyHoc.Text);
                chiTietDiem.maNam = NamDAL.layMaTheoTen(cboNamHoc.Text);

                Diem diem = new Diem();
                diem.maMonHoc = MonHocDAL.layMaTheoTen(cboTenMon.Text);
                diem.diemMieng = float.Parse(txtDiemMieng.Text);
                diem.diem15 = float.Parse(txtDiem15Phut.Text);
                diem.diem45 = float.Parse(txtDiem15Phut.Text);
                diem.diemGiuaKi = float.Parse(txtDiemGiuaKi.Text);
                diem.diemCuoiKi = float.Parse(txtDiemCuoiKi.Text);
                diem.diemTongKet = float.Parse(txtDiemTongKet.Text);
                if (DiemSoDAL.themDiemSo(diem, chiTietDiem))
                {
                    dgvThongTinDiemSo.DataSource = DiemSoDAL.layDiemSoTheoNamHoc(cboNamHoc.Text);
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "" || cboKyHoc.Text == "" || cboTenMon.Text == "" || cboNamHoc.Text == "" || txtDiemMieng.Text == "" || txtDiem15Phut.Text == "" || txtDiem45Phut.Text == "" ||
                txtDiemGiuaKi.Text == "" || txtDiemCuoiKi.Text == "" || txtDiemTongKet.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu!");
            }
            else
            {
                ChiTietDiem chiTietDiem = new ChiTietDiem();
                chiTietDiem.maMonHoc = MonHocDAL.layMaTheoTen(cboTenMon.Text);
                chiTietDiem.maGV = giangVien.maGV;
                chiTietDiem.maHS = Convert.ToInt32(txtMaSV.Text);
                chiTietDiem.maHK = Convert.ToInt32(cboKyHoc.Text);
                chiTietDiem.maNam = NamDAL.layMaTheoTen(cboNamHoc.Text);

                Diem diem = new Diem();
                diem.maMonHoc = MonHocDAL.layMaTheoTen(cboTenMon.Text);
                diem.diemMieng = float.Parse(txtDiemMieng.Text);
                diem.diem15 = float.Parse(txtDiem15Phut.Text);
                diem.diem45 = float.Parse(txtDiem45Phut.Text);
                diem.diemGiuaKi = float.Parse(txtDiemGiuaKi.Text);
                diem.diemCuoiKi = float.Parse(txtDiemCuoiKi.Text);
                diem.diemTongKet = float.Parse(txtDiemTongKet.Text);

                if (DiemSoDAL.capNhatDiemSo(chiTietDiem, diem))
                {
                    dgvThongTinDiemSo.DataSource = DiemSoDAL.layDiemSoTheoNamHoc(cboNamHoc.Text);

                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "" || cboKyHoc.Text == "" || cboTenMon.Text == "" || cboNamHoc.Text == "" || txtDiemMieng.Text == "" || txtDiem15Phut.Text == "" || txtDiem45Phut.Text == "" ||
                 txtDiemGiuaKi.Text == "" || txtDiemCuoiKi.Text == "" || txtDiemTongKet.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu!");
            }
            else
            {
                ChiTietDiem chiTietDiem = new ChiTietDiem();
                chiTietDiem.maHS = Convert.ToInt32(txtMaSV.Text);
                chiTietDiem.maMonHoc = MonHocDAL.layMaTheoTen(cboTenMon.Text);
                chiTietDiem.maNam = NamDAL.layMaTheoTen(cboNamHoc.Text);
                chiTietDiem.maHK = Convert.ToInt32(cboKyHoc.Text);

                Diem diem = new Diem();
                diem.maMonHoc = MonHocDAL.layMaTheoTen(cboTenMon.Text);
                diem.diemMieng = float.Parse(txtDiemMieng.Text);
                diem.diem15 = float.Parse(txtDiem15Phut.Text);
                diem.diem45 = float.Parse(txtDiem15Phut.Text);
                diem.diemGiuaKi = float.Parse(txtDiemGiuaKi.Text);
                diem.diemCuoiKi = float.Parse(txtDiemCuoiKi.Text);
                diem.diemTongKet = float.Parse(txtDiemTongKet.Text);
                if (DiemSoDAL.xoaDiemSo(chiTietDiem, diem))
                {
                    dgvThongTinDiemSo.DataSource = DiemSoDAL.layDiemSoTheoNamHoc(cboNamHoc.Text);
                }
            }

        }

        private void cboKiFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboNamFilter.Text != "")
            {
                if(cboKiFilter.Text != "")
                {
                    cboTenSVFilter.Enabled = true;
                    List<string> list = SinhVienDAL.laySVTheoNamVaKi(cboNamFilter.Text, Convert.ToInt32(cboKiFilter.Text));
                    foreach(string s in list)
                    {
                        cboTenSVFilter.Items.Add(s);
                    }
                    int ki = Convert.ToInt32(cboKiFilter.Text);
                    dgvThongTinDiemSo.DataSource = DiemSoDAL.layDiemSoTheoNamHocVaKiHoc(cboNamFilter.Text, ki);
                }
            }
            else
            {

            }
        }

        private void cboTenHSFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboTenSVFilter.Text != "")
            {
                List<int> listMa = SinhVien_LopDAL.layMaSVTheoKiNamVaTen(cboTenSVFilter.Text, Convert.ToInt32(cboKiFilter.Text), cboNamFilter.Text);
                foreach(int s in listMa)
                {
                    cboMaSVFilter.Items.Add(s);
                }
                cboMaSVFilter.Enabled = true;
                dgvThongTinDiemSo.DataSource = DiemSoDAL.layDiemSoTheoNamKiVaTenHS(cboNamFilter.Text, Convert.ToInt32(cboKiFilter.Text), cboTenSVFilter.Text);
            }
        }

        private void btnReset_Click_1(object sender, EventArgs e)
        {
            foreach (var control in this.Controls)
            {
                if (control is TextBox)
                {
                    ((TextBox)control).Text = "";
                }
                else if (control is ComboBox)
                {
                    ((ComboBox)control).Text = "";
                }
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(txtDiem15Phut.Text  == "" || txtDiemMieng.Text == "" || txtDiem45Phut.Text == "" || txtDiemCuoiKi.Text == "" || txtDiemGiuaKi.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập đủ!");
            }
            else
            {
                float diemMieng = float.Parse(txtDiemMieng.Text);
                float diem15 = float.Parse(txtDiem15Phut.Text);
                float diem45 = float.Parse(txtDiem45Phut.Text);
                float diemGiuaKi = float.Parse(txtDiemGiuaKi.Text);
                float diemCuoiKi = float.Parse(txtDiemCuoiKi.Text);
                float diemTongKet = ((diemMieng + diem15) + (diem45 * 2) + (diemGiuaKi + diemCuoiKi) * 3) / 10;
                txtDiemTongKet.Text = diemTongKet.ToString();
            }
        }

        private void cboNamFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            btnLayDSTheoNam.Enabled = true;
            if(cboNamFilter.Text != "")
            {
                dgvThongTinDiemSo.DataSource = DiemSoDAL.layDiemSoTheoNamHoc(cboNamFilter.Text);
            }

        }

        private void cboMaHSFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboMaSVFilter.Text != "")
            {
                int ma = Convert.ToInt32(cboMaSVFilter.Text);
                dgvThongTinDiemSo.DataSource = DiemSoDAL.layDiemSoTheoNamKiTenHSVaMaHS(cboNamFilter.Text, Convert.ToInt32(cboKiFilter.Text), cboTenSVFilter.Text, ma);
            }
        }

        private void txtMaHS_TextChanged(object sender, EventArgs e)
        {
            if(txtMaSV.Text != "")
            {
                SinhVien sinhVien = SinhVienDAL.layThongTinSVTheoMa(Convert.ToInt32(txtMaSV.Text));
            }
        }

        private void cboKyHoc_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (cboNamHoc.Text != "")
                {
                    if (cboKyHoc.Text != "")
                    {
                        if (txtMaSV.Text != "")
                        {
                            List<string> list = SinhVienDAL.laySVTheoNamVaKi(cboNamFilter.Text, Convert.ToInt32(cboKiFilter.Text));
                            foreach (string s in list)
                            {
                                cboTenSVFilter.Items.Add(s);
                            }
                            cboTenSVFilter.Enabled = true;
                        }
                    }
                }
            
            }catch(Exception ex)
            {

            }

        }

        private void btnLayDSTheoNam_Click(object sender, EventArgs e)
        {
            if(cboNamFilter.Text != "")
            {
                if (SinhVienDAL.bctkSinhVienTheoNam(cboNamFilter.Text))
                {

                }
            }
        }
    }
}

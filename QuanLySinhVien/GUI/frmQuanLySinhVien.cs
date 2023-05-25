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
    public partial class frmQuanLySinhVien : Form
    {
        public frmQuanLySinhVien()
        {
            InitializeComponent();
        }
        void load()
        {
            dgvThongTinSV.DataSource = SinhVienDAL.layThongTinCacSV();
            foreach(string s in listLop)
            {
                cboLop.Items.Add(s);
                cboLopFilter.Items.Add(s);
            }
            cboLopFilter.Items.Add("Toàn bộ");
        }
        static List<string> listLop = LopDAL.getAllTenLop();
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
            load();
        }
        private void btnLayDS_Click(object sender, EventArgs e)
        {
            if(SinhVienDAL.baoCaoThongKeSV())
            {

            }
        }

        private void dgvThongTinSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txtMaSV.Text = dgvThongTinSV.Rows[index].Cells[0].Value.ToString();
                txtTenSV.Text = dgvThongTinSV.Rows[index].Cells[1].Value.ToString();
                txtDiaChi.Text = dgvThongTinSV.Rows[index].Cells[2].Value.ToString();
                txtEmail.Text = dgvThongTinSV.Rows[index].Cells[3].Value.ToString();
                txtSdt.Text = dgvThongTinSV.Rows[index].Cells[4].Value.ToString();
                cboLop.Text = dgvThongTinSV.Rows[index].Cells[5].Value.ToString();
            }
        }
        public bool checkData()
        {
            if(txtTenSV.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || txtSdt.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(checkData())
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.tenSV = txtTenSV.Text;
                sinhVien.email = txtEmail.Text;
                sinhVien.sdt = txtSdt.Text;
                sinhVien.diaChi = txtDiaChi.Text;
                sinhVien.maLop = LopDAL.layMaLop(cboLop.Text);
                if (SinhVienDAL.themSV(sinhVien))
                {
                    dgvThongTinSV.DataSource = SinhVienDAL.layThongTinCacSVTheoLop(cboLopFilter.Text);
                    cboLopFilter.Text = cboLop.Text;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (checkData())
            {
                SinhVien sinhVien = new SinhVien();
                sinhVien.maSV = Convert.ToInt32(txtMaSV.Text);
                sinhVien.tenSV = txtTenSV.Text;
                sinhVien.email = txtEmail.Text;
                sinhVien.sdt = txtSdt.Text;
                sinhVien.diaChi = txtDiaChi.Text;
                sinhVien.maLop = LopDAL.layMaLop(cboLop.Text);
                if (SinhVienDAL.capNhatSV(sinhVien))
                {
                    dgvThongTinSV.DataSource = SinhVienDAL.layThongTinCacSV();
                    cboLopFilter.Text = cboLop.Text;
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SinhVien SinhVien = new SinhVien();
            SinhVien.maSV = Convert.ToInt32(txtMaSV.Text);
            if (SinhVienDAL.xoaSV(SinhVien))
            {
                dgvThongTinSV.DataSource = SinhVienDAL.layThongTinCacSV();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
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

        
      
        private void cboLopFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if(cboLopFilter.Text != "")
            {
                if (cboLopFilter.Text == "Toàn bộ")
                {
                    dgvThongTinSV.DataSource = SinhVienDAL.layThongTinCacSV();
                }
                else
                {
                    dgvThongTinSV.DataSource = SinhVienDAL.layThongTinCacSVTheoLop(cboLopFilter.Text);
                }
                }
        }
    }
}

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
        private void frmQuanLySinhVien_Load(object sender, EventArgs e)
        {
           
        }

        private void cboNienKhoaFilter_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cboLopFilter.Text != "")
            {
                dgvThongTinSV.DataSource = SinhVienDAL.layDanSVachSVTheoNienKhoa(cboLopFilter.Text);
                btnLayDS.Enabled = true;
            }
        }

        private void btnLayDS_Click(object sender, EventArgs e)
        {
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
            if(txtTenSV.Text == "" || txtEmail.Text == "" || txtDiaChi.Text == "" || txtSdt.Text == "" || cboLop.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(checkData())
            {
                SinhVien SinhVien = new SinhVien();
                SinhVien.tenSV = txtTenSV.Text;
                SinhVien.email = txtEmail.Text;
                SinhVien.sdt = txtSdt.Text;
                SinhVien.diaChi = txtDiaChi.Text;
                if (SinhVienDAL.themSV(SinhVien))
                {
                    dgvThongTinSV.DataSource = SinhVienDAL.layDanSVachSVTheoNienKhoa(cboLop.Text);
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
                SinhVien SinhVien = new SinhVien();
                SinhVien.maSV = Convert.ToInt32(txtMaSV.Text);
                SinhVien.tenSV = txtTenSV.Text;
                SinhVien.email = txtEmail.Text;
                SinhVien.sdt = txtSdt.Text;
                SinhVien.diaChi = txtDiaChi.Text;
                if (SinhVienDAL.capNhatSV(SinhVien))
                {
                    dgvThongTinSV.DataSource = SinhVienDAL.layDanSVachSVTheoNienKhoa(cboLop.Text);
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
                dgvThongTinSV.DataSource = SinhVienDAL.layDanSVachSVTheoNienKhoa(cboLop.Text);
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

        void openFormPhanLop()
        {
            Application.Run(new frmPhanLopSV());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(openFormPhanLop);
            thread.Start();
        }
    }
}

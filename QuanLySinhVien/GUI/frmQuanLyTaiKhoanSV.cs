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
    public partial class frmQuanLyTaiKhoan : Form
    {
        public frmQuanLyTaiKhoan()
        {
            InitializeComponent();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(txtMaSV.Text == "" || txtTenSV.Text == "" || txtTenTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu!");
            }
            else
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.tenTaiKhoan = txtTenTaiKhoan.Text;
                taiKhoan.matKhau = txtMatKhau.Text;

                SinhVien SinhVien = new SinhVien();
                SinhVien.maSV = Convert.ToInt32(txtMaSV.Text);
                SinhVien.tenSV = txtTenSV.Text;

                if(TaiKhoanSVDAL.capNhatTaiKhoan(taiKhoan, SinhVien))
                {
                    dgvTaiKhoanSV.DataSource = TaiKhoanSVDAL.layDanhSach();

                }
                else
                {
                    MessageBox.Show("Có lỗi!");
                }
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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSV.Text == "" || txtTenSV.Text == "" || txtTenTaiKhoan.Text == "" || txtMatKhau.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu!");
            }
            else
            {
                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.tenTaiKhoan = txtTenTaiKhoan.Text;
                taiKhoan.matKhau = txtMatKhau.Text;

                SinhVien SinhVien = new SinhVien();
                SinhVien.maSV = Convert.ToInt32(txtMaSV.Text);
                SinhVien.tenSV = txtTenSV.Text;

                if (TaiKhoanSVDAL.xoaTaiKhoan(taiKhoan, SinhVien))
                {
            dgvTaiKhoanSV.DataSource = TaiKhoanSVDAL.layDanhSach();

                }
                else
                {
                    MessageBox.Show("Có lỗi!");
                }
            }
        }

        private void btnLayDS_Click(object sender, EventArgs e)
        {
           
        }

        private void frmQuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            dgvTaiKhoanSV.DataSource = TaiKhoanSVDAL.layDanhSach();
        }

        private void dgvTaiKhoanSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaSV.Text = dgvTaiKhoanSV.Rows[index].Cells[0].Value.ToString();
                txtTenSV.Text = dgvTaiKhoanSV.Rows[index].Cells[1].Value.ToString();
                txtTenTaiKhoan.Text = dgvTaiKhoanSV.Rows[index].Cells[4].Value.ToString();
                txtMatKhau.Text = dgvTaiKhoanSV.Rows[index].Cells[5].Value.ToString();
            }
        }
    }
}

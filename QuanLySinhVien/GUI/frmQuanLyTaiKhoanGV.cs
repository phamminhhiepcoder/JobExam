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
    public partial class frmQuanLyTaiKhoanGV : Form
    {
        public frmQuanLyTaiKhoanGV()
        {
            InitializeComponent();
        }

        private void button18_Click(object sender, EventArgs e)
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

        private void btnLayDS_Click(object sender, EventArgs e)
        {
            if(TaiKhoanGVDAL.bctkTaiKhoanGV())
            {

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "" || txtTenGV.Text == "" || txtTenTaiKhoan.Text == "" || txtMatKhau.Text == "" || cboTenQuyen.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu!");
            }
            else
            {
                GiangVien giangVien = new GiangVien();
                giangVien.maGV = Convert.ToInt32(txtMaGV.Text);
                giangVien.tenGV = txtTenGV.Text;

                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.tenTaiKhoan = txtTenTaiKhoan.Text;
                taiKhoan.matKhau = txtMatKhau.Text;
                taiKhoan.maQuyen = QuyenDAL.layMaQuyen(cboTenQuyen.Text);
                if (TaiKhoanGVDAL.xoaTaiKhoan(taiKhoan, giangVien))
                {
                    dgvTaiKhoanGV.DataSource = TaiKhoanGVDAL.layDanhSach();
                }
            }
        }

        private void frmQuanLyTaiKhoanGV_Load(object sender, EventArgs e)
        {
            dgvTaiKhoanGV.DataSource = TaiKhoanGVDAL.layDanhSach();
        }

        private void dgvTaiKhoanGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaGV.Text = dgvTaiKhoanGV.Rows[index].Cells[0].Value.ToString(); 
                txtTenGV.Text = dgvTaiKhoanGV.Rows[index].Cells[1].Value.ToString(); 
                txtTenTaiKhoan.Text = dgvTaiKhoanGV.Rows[index].Cells[3].Value.ToString(); 
                txtMatKhau.Text = dgvTaiKhoanGV.Rows[index].Cells[4].Value.ToString();
                cboTenQuyen.Text = dgvTaiKhoanGV.Rows[index].Cells[5].Value.ToString();
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaGV.Text == "" || txtTenGV.Text == "" || txtTenTaiKhoan.Text == "" || txtMatKhau.Text == "" || cboTenQuyen.Text == "")
            {
                MessageBox.Show("Bạn nhập thiếu!");
            }
            else
            {
                GiangVien giangVien = new GiangVien();
                giangVien.maGV = Convert.ToInt32(txtMaGV.Text);
                giangVien.tenGV = txtTenGV.Text;

                TaiKhoan taiKhoan = new TaiKhoan();
                taiKhoan.tenTaiKhoan = txtTenTaiKhoan.Text;
                taiKhoan.matKhau = txtMatKhau.Text;
                taiKhoan.maQuyen = QuyenDAL.layMaQuyen(cboTenQuyen.Text);
                MessageBox.Show(giangVien.maGV + Environment.NewLine + giangVien.tenGV + Environment.NewLine + taiKhoan.tenTaiKhoan + Environment.NewLine + taiKhoan.matKhau + Environment.NewLine + taiKhoan.maQuyen);
                if (TaiKhoanGVDAL.capNhatTaiKhoan(taiKhoan, giangVien))
                {
                    dgvTaiKhoanGV.DataSource = TaiKhoanGVDAL.layDanhSach();
                }
            }
        }
    }
}

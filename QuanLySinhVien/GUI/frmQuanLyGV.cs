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
    public partial class frmQuanLyGV : Form
    {
        public frmQuanLyGV()
        {
            InitializeComponent();
        }
        void load()
        {
            dgvThongTinGV.DataSource = GiangVienDAL.layCacGV();
        }
        private void frmQuanLyGV_Load(object sender, EventArgs e)
        {
            load();
        }
        bool checkThem()
        {
            if(txtTenGV.Text == "" || txtEmail.Text == "" || txtSdt.Text == "")
            {
                return false;
            }
            return true;
        }

        bool checkSua()
        {
            if (txtTenGV.Text == "" || txtEmail.Text == "" || txtSdt.Text == "" || txtMaGV.Text == "")
            {
                return false;
            }
            return true;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(checkThem())
            {
                GiangVien gv = new GiangVien();
                gv.maGV = Convert.ToInt32(txtMaGV.Text);
                gv.tenGV = txtTenGV.Text;
                gv.email = txtEmail.Text;
                gv.sdt = txtSdt.Text;
                if(GiangVienDAL.themGV(gv))
                {
                    load();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ!");
            }
        }

        private void dgvThongTinGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                txtMaGV.Text = dgvThongTinGV.Rows[index].Cells[0].Value.ToString(); 
                txtTenGV.Text = dgvThongTinGV.Rows[index].Cells[1].Value.ToString(); 
                txtEmail.Text = dgvThongTinGV.Rows[index].Cells[2].Value.ToString(); 
                txtSdt.Text = dgvThongTinGV.Rows[index].Cells[3].Value.ToString(); 
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if(checkSua())
            {
                GiangVien gv = new GiangVien();
                gv.maGV = Convert.ToInt32(txtMaGV.Text);
                gv.tenGV = txtTenGV.Text;
                gv.email = txtEmail.Text;
                gv.sdt = txtSdt.Text;
                if (GiangVienDAL.suaGV(gv))
                {
                    load();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (checkSua())
            {
                GiangVien gv = new GiangVien();
                gv.maGV = Convert.ToInt32(txtMaGV.Text);
                gv.tenGV = txtTenGV.Text;
                gv.email = txtEmail.Text;
                gv.sdt = txtSdt.Text;
                if (GiangVienDAL.xoaGV(gv))
                {
                    load();
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập đủ!");
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
    }
}

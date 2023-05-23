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
    public partial class frmThongTinMonHoc : Form
    {
        public frmThongTinMonHoc()
        {
            InitializeComponent();
        }

        void loadThongTinMonHoc()
        {
            List<string> tenCacMon = MonHocDAL.layTenCacMonHoc();
            foreach (string s in tenCacMon)
            {
                cboMonHoc.Items.Add(s);
            }
            dgvThongTinMonHoc.DataSource = MonHocDAL.layThongTinMonHoc();
        }
        private void frmThongTinMonHoc_Load(object sender, EventArgs e)
        {
            loadThongTinMonHoc();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtTenMonThem.Text != "")
            {
                if (MonHocDAL.themMonHoc(txtTenMonThem.Text))
                {
                    cboMonHoc.Text = "";
                    cboMonHoc.Items.Clear();
                    loadThongTinMonHoc();
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra!");
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (cboMonHoc.Text != "")
            {
                if (txtTenMonCapNhat.Text != "")
                {
                    if (MonHocDAL.xoaMonHoc(cboMonHoc.Text))
                    {
                        loadThongTinMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Bạn chưa nhập!");
            }
            
            }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            if(cboMonHoc.Text != "")
            {
                MonHoc monHoc = new MonHoc();
                monHoc.tenMonHoc = cboMonHoc.Text;
                monHoc.maMonHoc = MonHocDAL.layMaTheoTen(monHoc.tenMonHoc);
                if(txtTenMonCapNhat.Text != "")
                {
                    if (MonHocDAL.capNhatMonHoc(monHoc, txtTenMonCapNhat.Text))
                    {
                        cboMonHoc.Items.Clear();
                        cboMonHoc.Text = txtTenMonThem.Text;
                        loadThongTinMonHoc();
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra!");
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chưa nhập!");
                }
            }
            
        }

        private void frmThongTinMonHoc_FormClosed(object sender, FormClosedEventArgs e)
        {

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
        static int ma;
        private void dgvThongTinMonHoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if(index >= 0)
            {
                ma = Convert.ToInt32(dgvThongTinMonHoc.Rows[index].Cells[0].Value.ToString());
                cboMonHoc.Text = dgvThongTinMonHoc.Rows[index].Cells[1].Value.ToString();
            }
        }
    }
}

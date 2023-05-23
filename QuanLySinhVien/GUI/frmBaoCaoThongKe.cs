using DAL;
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
    public partial class frmBaoCaoThongKe : Form
    {
        public frmBaoCaoThongKe()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
           if(cboLuaChon.Text == "Lịch sử hoạt động trên hệ thống của giáo viên")
            {
                grbDiem.Enabled = false;
                grbHocBa.Enabled = false;
            }
           else if(cboLuaChon.Text == "Thống kê học bạ")
            {
                grbDiem.Enabled = false;
                grbHocBa.Enabled = true;
            }
           else if(cboLuaChon.Text == "Thống kê điểm")
            {
                grbDiem.Enabled = true;
                grbHocBa.Enabled = false;
            }
           else if(cboLuaChon.Text == "Thống kê vi phạm")
            {
                grbDiem.Enabled = false;
                grbHocBa.Enabled = false;
            }
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            List<string> list = NamDAL.layNam();
            foreach(string s in list)
            {
                cboNamHoc.Items.Add(s);
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (cboLuaChon.Text == "Thống kê học bạ")
            {
                //BCTK Hoc ba theo nien khoa (chi theo lop hoac theo lop, theo hoc sinh)
            }
            else if (cboLuaChon.Text == "Thống kê điểm")
            {
                if (cboNamHoc.Text != "")
                {
                    if (cboKyHoc.Text != "")
                    {
                        if (DiemSoDAL.baoCaoThongKeDiemTheoNamHocVaKiHoc(cboNamHoc.Text, Convert.ToInt32(cboKyHoc.Text)))
                        {

                        }
                    }
                    else
                    {
                        if (DiemSoDAL.baoCaoThongKeDiemTheoNamHoc(cboNamHoc.Text))
                        {

                        }
                    }
                }
                else
                {
                    MessageBox.Show("Bạn chọn thiếu!");
                }
            }
        }

        private void cboViPham_SelectedValueChanged(object sender, EventArgs e)
        {
            
        }

        private void cboViPham_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

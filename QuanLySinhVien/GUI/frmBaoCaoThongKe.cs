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
        }

        private void frmBaoCaoThongKe_Load(object sender, EventArgs e)
        {
            
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (cboLuaChon.Text == "Thống kê học bạ")
            {
            }
            else if (cboLuaChon.Text == "Thống kê điểm")
            {
               

            }
        }

      
    }
}

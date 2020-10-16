using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;

namespace GUI
{
    public partial class MHDangNhapNV : Form
    {
        public MHDangNhapNV()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((txbTaiKhoan.Text != String.Empty) && (txbMatKhau.Text != String.Empty))
            {
                MHChinh mhc = new MHChinh();
                this.Hide();
                mhc.ShowDialog();
            }
            else
                MessageBox.Show("Chưa nhập đầy đủ!");
      
        }

        private void MHDangNhapNV_Load(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MHChung : Form
    {
        public MHChung()
        {
            InitializeComponent();
        }

        private void bt_NhanVien_Click(object sender, EventArgs e)
        {
            MHDangNhapNV mhdnnv = new MHDangNhapNV();
            this.Hide();
            mhdnnv.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bt_KhachHang_Click(object sender, EventArgs e)
        {
            MHDangNhap mhdn = new MHDangNhap();
            this.Hide();
            mhdn.ShowDialog();
        }
    }
}

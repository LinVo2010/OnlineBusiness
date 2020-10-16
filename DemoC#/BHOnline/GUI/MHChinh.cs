using BUS;
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
    public partial class MHChinh : Form
    {
        public MHChinh()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            MHHopDong hd = new MHHopDong();
          
            hd.tb = HopDongBUS.Instance.HienThi();
          //  this.Hide();
            hd.Show();
         
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MHNhanTinKhachHang hd = new MHNhanTinKhachHang();
         //   this.Hide();
            hd.Show();


        }

        private void MHChinh_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MHThongKe tk = new MHThongKe();
            tk.Show();

        }

        private void bt_LapDonTraHang_Click(object sender, EventArgs e)
        {
            MHDonTraHang dth = new MHDonTraHang();
            dth.Show();
          //  this.Hide();
        }

        private void btnSanPham_Click(object sender, EventArgs e)
        {
            MHSanPham sp = new MHSanPham();
            sp.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

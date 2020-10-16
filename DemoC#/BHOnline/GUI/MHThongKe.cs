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
    public partial class MHThongKe : Form
    {
        public MHThongKe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNhapHang_Click(object sender, EventArgs e)
        {            
                MHDonNhapHang dnh = new MHDonNhapHang();
                dnh.Show();
            
        }

        private void MHThongKe_Load(object sender, EventArgs e)
        {
            
            //Danh sach thieu hang la nhuwng danh sach co so luong ton nho hon 500

            dtgvSanPhamThieu.DataSource = SanPhamBUS.Instance.HienThiDSThieuHang(500);
            if (SanPhamBUS.Instance.KiemTraThieuHang(500) == 0)
            {
                btnNhapHang.Enabled = false;
                //MessageBox.Show("Không có sản phẩm nào thiếu hàng");
            }
            else btnNhapHang.Enabled = true;

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;

namespace GUI
{
    public partial class MHThanhToanThe : Form
    {
        public MHThanhToanThe()
        {
            InitializeComponent();
        }

        string taikhoan;

        private void MHThanhToanThe_Load(object sender, EventArgs e)
        {
            taikhoan = MHDangNhap.pTaiKhoan;
            lbNguoiDung.Text = "Xin chào, " + taikhoan;
        }


        private void btn_DongY_Click_1(object sender, EventArgs e)
        {
            if (HoaDonBUS.Instance.CapNhapTrangThai(int.Parse(MHDangNhap.pTaiKhoan)) == true)
            {
                MessageBox.Show("Bạn đã thanh toán thành công!");
                MHThongTinHD_KH mhtthdkh = new MHThongTinHD_KH();
                this.Hide();
                mhtthdkh.Show();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi!");
        }
    }
}

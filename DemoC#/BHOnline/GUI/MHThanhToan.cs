using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;


namespace GUI
{
    public partial class MHThanhToan : Form
    {
        public MHThanhToan()
        {
            InitializeComponent();
        }

        string taikhoan;

        private void MHThanhToan_Load(object sender, EventArgs e)
        {
            taikhoan = MHDangNhap.pTaiKhoan;
            lbNguoiDung.Text = "Xin chào, " + taikhoan;
            txb_TenKH.Text = KhachHangBUS.Instance.LayTenKH(int.Parse(MHDangNhap.pTaiKhoan));
            txb_SDT.Text = MHHoaDon.pSDT;
            txb_DiaChi.Text = MHHoaDon.pDiaChi;
            dgv_DSSP.DataSource = CTGioHangBUS.Instance.HienThiGioHang_CTT(int.Parse(MHDangNhap.pTaiKhoan));

            DataTable data = HoaDonBUS.Instance.LayThongTinHD(int.Parse(MHDangNhap.pTaiKhoan));
            foreach (DataRow item in data.Rows)
            {             
                txb_TongSP.Text = item["TongSP"].ToString();
                txb_TongTien.Text = item["TongTien"].ToString();
                //chuyen doi tong tien sang don vi tien vnd
                txb_TongTien.Text = string.Format(CultureInfo.CreateSpecificCulture("vi-VN"), "{0:C}", double.Parse(txb_TongTien.Text));
            }

        }

        private void txb_TenKH_TextChanged(object sender, EventArgs e)
        {

        }
 

        private void btn_TienMat_Click_1(object sender, EventArgs e)
        {
            if (HoaDonBUS.Instance.CapNhapPTTT_Tien(int.Parse(MHDangNhap.pTaiKhoan)) == true)
            {

                MessageBox.Show("Bạn đã chọn phương thức thanh toán bằng tiền mặt! Vui lòng hoàn tất đơn hàng để đơn hàng được xác nhận.");
            }
            else
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại!");
        }

        private void btn_The_Click_1(object sender, EventArgs e)
        {
            if (HoaDonBUS.Instance.CapNhapPTTT_The(int.Parse(MHDangNhap.pTaiKhoan)) == true)
            {

                MessageBox.Show("Bạn đã chọn phương thức thanh toán thẻ. Vui lòng điền thông tin thẻ!");
                MHThanhToanThe mhttt = new MHThanhToanThe();
                this.Hide();
                mhttt.Show();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi. Vui lòng thử lại!");
        }

        private void btn_HoanThanh_Click_1(object sender, EventArgs e)
        {
            if (HoaDonBUS.Instance.CapNhapTrangThai(int.Parse(MHDangNhap.pTaiKhoan)) == true)
            {
                MessageBox.Show("Đơn hàng đã được xác nhận!");
                MHThongTinHD_KH mhtthdkh = new MHThongTinHD_KH();
                this.Hide();
                mhtthdkh.Show();
            }
            else
                MessageBox.Show("Đã xảy ra lỗi!");
        }
    }
}

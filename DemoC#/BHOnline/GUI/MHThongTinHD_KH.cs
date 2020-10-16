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
    public partial class MHThongTinHD_KH : Form
    {
        public MHThongTinHD_KH()
        {
            InitializeComponent();
        }
        public string taikhoan;

        private void MHThongTinHD_KH_Load(object sender, EventArgs e)
        {
            taikhoan = MHDangNhap.pTaiKhoan;
            lbNguoiDung.Text = "Xin chào, " + taikhoan;
            dgv_DSHD.DataSource = HoaDonBUS.Instance.HienThiHD(int.Parse(MHDangNhap.pTaiKhoan));
            DataTable data = KhachHangBUS.Instance.LayThongTinKH(int.Parse(MHDangNhap.pTaiKhoan));
            foreach (DataRow item in data.Rows)
            {
                txb_TenKH1.Text = item["TenKH"].ToString();
                txb_SDT1.Text = item["SDT"].ToString();
                txb_DiaChi1.Text = item["DiaChi"].ToString();
                txb_Email.Text = item["Gmail"].ToString();
            }
        }

        private void lb_TTHD_Click(object sender, EventArgs e)
        {

        }


        private void btn_TiepTucMua_Click_1(object sender, EventArgs e)
        {
            MHTimSP mhtsp = new MHTimSP();
            this.Hide();
            mhtsp.Show();
        }
    }
}

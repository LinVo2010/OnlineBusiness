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
    public partial class MHHoaDon : Form
    {
        public MHHoaDon()
        {
            InitializeComponent();
        }


        string taikhoan;
        public static string pSDT;
        public static string pDiaChi;

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        public bool KiemTraGmail(string h)
        {
            return h.Contains("@gmail.com");
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            if(txbDiaChi.Text == string.Empty || txbGmail.Text == string.Empty || txbSDT.Text == string.Empty)
            {
                MessageBox.Show("Thông tin giao hàng chưa đầy đủ!");
            }    
            else
            {
                if (KiemTraGmail(txbGmail.Text) == true)
                {

                    if (KiemTraSDT(txbSDT.Text) == true)
                    {
                        //Cập nhật thông tin giao hàng cho hóa đơn
                        if (HoaDonBUS.Instance.Sua(int.Parse(taikhoan), txbSDT.Text, txbGmail.Text, txbDiaChi.Text))
                        {
                            this.Hide();
                            MHThanhToan mhtt = new MHThanhToan();
                            mhtt.ShowDialog();
                        }
                        else
                            MessageBox.Show("Lỗi!");
                    }
                    else MessageBox.Show("Số điện thoại không phù hợp!");
                }
                else MessageBox.Show("Gmail không phù hợp!");
            }    
        }

        private void MHHoaDon_Load(object sender, EventArgs e)
        {
            taikhoan = MHDangNhap.pTaiKhoan;
            lbNguoiDung.Text = "Xin chào, " + taikhoan;
            dtgvDiaChiLuuTru.DataSource = KhachHangBUS.Instance.LayTTKH(int.Parse(taikhoan));
            dtgvLichSuHD.DataSource = HoaDonBUS.Instance.HienThiLichSuHD(int.Parse(taikhoan)); // Hiện thông tin lịch sử đơn hàng
            dtgvTTinDonHang.DataSource = HoaDonBUS.Instance.HienThiTTHDChuaXacNhan(int.Parse(taikhoan)); // hiện thông tin đơn hàng chưa xác nhận
            
        }

        private void dtgvDiaChiLuuTru_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvDiaChiLuuTru.CurrentRow.Index;

            txbDiaChi.Text = dtgvDiaChiLuuTru.Rows[i].Cells[2].Value.ToString();
            txbSDT.Text = dtgvDiaChiLuuTru.Rows[i].Cells[3].Value.ToString();
            txbGmail.Text = dtgvDiaChiLuuTru.Rows[i].Cells[4].Value.ToString();
            pSDT = txbSDT.Text;
            pDiaChi = txbDiaChi.Text;
        }
        public bool IsNumber(string pValue)
        {
            foreach (Char c in pValue)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public bool KiemTraSDT(string pValue)
        {
            if (IsNumber(pValue) == true && pValue.Length == 10)
            {
                return true;
            }
            return false;
        }
    }
}

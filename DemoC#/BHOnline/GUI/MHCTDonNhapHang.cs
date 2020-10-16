using BUS;
using DTO;
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
    public partial class MHCTDonNhapHang : Form
    {
        public MHCTDonNhapHang()
        {
            InitializeComponent();
        }

        private void MHCTDonNhapHang_Load(object sender, EventArgs e)
        {
            tbMaDNH.Text = MHDonNhapHang.pMaDNH.ToString();
            //cbMaDTH.Text = int.madontra.ToString;
            tbMaDNH.Enabled = false;
            cbSanPham.DataSource = SanPhamBUS.Instance.HienThiDSThieuHang(5000);
            cbSanPham.DisplayMember = "TenSP";
            cbSanPham.ValueMember = "MaSP";

            tbSoLuong.Text = DBNull.Value.ToString();
            //tbGia.Text = DBNull.Value.ToString();
            dtgvCTDonNhapHang.DataSource = CTDonNhapHangBUS.Instance.HienThiTheoBien(MHDonNhapHang.pMaDNH);
            //tbGia.Enabled = false;
            //tbGia
            //dtgvCTDonNhapHang.DataSource = CTDonNhapHangBUS.Instance.TimThongTin(madontra);
        }

        private void label1_Click(object sender, EventArgs e)
        {

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

        public bool KiemTraSoLuong(string pValue)
        {
            if (IsNumber(pValue) == true && int.Parse(pValue) > 0)
            {
                return true;
            }
            return false;
        }

        private void BTNLapCT_Click(object sender, EventArgs e)
        {
            if (KiemTraSoLuong(tbSoLuong.Text) == true)
            {
                if (CTDonNhapHangBUS.Instance.KiemTraTonTai(int.Parse(tbMaDNH.Text), int.Parse(cbSanPham.SelectedValue.ToString())) == true)
                {
                    
                    CTDonNhapHang dnh = new CTDonNhapHang(int.Parse(tbMaDNH.Text), int.Parse(cbSanPham.SelectedValue.ToString()), int.Parse(tbSoLuong.Text), 0);
                      if (CTDonNhapHangBUS.Instance.Them(dnh))
                    {
                        CTDonNhapHangBUS.Instance.TinhGia(int.Parse(tbMaDNH.Text), int.Parse(cbSanPham.SelectedValue.ToString()));
                        //int temp = CTDonNhapHangBUS.Instance.TinhGia(5, 1);

                        MessageBox.Show("Thêm thành công");
                        dtgvCTDonNhapHang.DataSource = CTDonNhapHangBUS.Instance.HienThiTheoBien(MHDonNhapHang.pMaDNH);
                        // MHCTDonNhapHang_Load(sender, e);
                    }
                    else MessageBox.Show("Lỗi");
                }
                else MessageBox.Show("Chi tiết đơn nhập hàng đã tồn tại!");

            }
            else MessageBox.Show("Số lượng phải là kiểu số và lớn hơn 0");
        }

        private void tbGia_TextChanged(object sender, EventArgs e)
        {

        }

        private void MHCTDonNhapHang_FormClosing(object sender, FormClosingEventArgs e)
        {
            DonNhapHangBUS.Instance.TinhGia(int.Parse(tbMaDNH.Text));
            MHDonNhapHang nh = new MHDonNhapHang();
            nh.Show();

        }
    }
}

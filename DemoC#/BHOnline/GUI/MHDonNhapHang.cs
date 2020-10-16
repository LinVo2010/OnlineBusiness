using BUS;
using DTO;
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

namespace GUI
{
    public partial class MHDonNhapHang : Form
    {
        public MHDonNhapHang()
        {
            InitializeComponent();
        }

        public static int pMaDNH;
        private void MHDonNhapHang_Load(object sender, EventArgs e)
        {
            tbMaDNH.Text = DonNhapHangBUS.Instance.AutoID().ToString();
            tbMaDNH.Enabled = false;
            cbDT.DataSource = DoiTacBanHangBUS.Instance.HienThi();
            cbDT.DisplayMember = "TenDT";
            cbDT.ValueMember = "MaDT";
            
            tbLyDoNhap.Text = DBNull.Value.ToString();
            //tbTongTien.Text = DBNull.Value.ToString();
            //tbTongTien.Enabled = false;


            cbMaNV.DataSource = NhanVienBUS.Instance.HienThi();
            cbMaNV.DisplayMember = "TenNV";
            cbMaNV.ValueMember = "MaNV";

            
            dtgvDNH.DataSource = DonNhapHangBUS.Instance.HienThi();
            //tb = DonTraHangBUS.Instance.HienThi();
            pMaDNH = int.Parse(tbMaDNH.Text);
        }

        private void btnLapDon_Click(object sender, EventArgs e)
        {
            
            DonNhapHang dnh = new DonNhapHang(int.Parse(tbMaDNH.Text),  int.Parse(cbDT.SelectedValue.ToString()), int.Parse(cbMaNV.SelectedValue.ToString()), DateTime.ParseExact(dtpk_NgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), tbLyDoNhap.Text, 0);
            
            if (DonNhapHangBUS.Instance.Them(dnh))
            {

                MessageBox.Show("Thêm thành công");
                dtgvDNH.DataSource = DonNhapHangBUS.Instance.HienThi();
                //MHDonNhapHang_Load(sender, e);
                MessageBox.Show("Thêm chi tiết đơn nhập hàng");
                MHCTDonNhapHang nh = new MHCTDonNhapHang();
                this.Hide();
                nh.Show();

            }
            else
                MessageBox.Show("Lỗi");
        }
    }
}

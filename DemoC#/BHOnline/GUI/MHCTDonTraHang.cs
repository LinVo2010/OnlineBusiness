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
    public partial class MHCTDonTraHang : Form
    {
        public MHCTDonTraHang()
        {
            InitializeComponent();
        }
        private void tbSoLuong_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtgvCTDTH_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
        private void MHCTDonTraHang_Load(object sender, EventArgs e)
        {

            tbMaDTH.Text = MHDonTraHang.pMaDTH.ToString();
            //cbMaDTH.Text = int.madontra.ToString;
            tbMaDTH.Enabled = false;
            //cbMaDTH.Text = int.madontra.ToString;
            cbSanPham.DataSource = SanPhamBUS.Instance.HienThi();
            cbSanPham.DisplayMember = "TenSP";
            cbSanPham.ValueMember = "MaSP";
            tbSoLuong.Text = DBNull.Value.ToString();
            // dtgvCTDTH.DataSource = CTDonTraHangBUS.Instance.HienThi();

            // dtgvCTDTH.DataSource = CTDonTraHangBUS.Instance.TimThongTin(madontra);
            dtgvCTDTH.DataSource = CTDonTraHangBUS.Instance.HienThiTheoBien(MHDonTraHang.pMaDTH);

            
        }

        private void dtgvCTDTH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvCTDTH.CurrentRow.Index;

            tbMaDTH.Text = MHDonTraHang.pMaDTH.ToString();

            cbSanPham.Text = dtgvCTDTH.Rows[i].Cells[2].Value.ToString();
            tbSoLuong.Text = dtgvCTDTH.Rows[i].Cells[3].Value.ToString();

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

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (CTDonTraHangBUS.Instance.KiemTraTonTai(int.Parse(tbMaDTH.Text), int.Parse(cbSanPham.SelectedValue.ToString())) == true)
            {
                if (KiemTraSoLuong(tbSoLuong.Text) == true)
                {
                    CTDonTraHang dth = new CTDonTraHang(int.Parse(tbMaDTH.Text), int.Parse(cbSanPham.SelectedValue.ToString()), int.Parse(tbSoLuong.Text));

                    if (CTDonTraHangBUS.Instance.Them(dth))
                    {
                        MessageBox.Show("Thêm thành công");
                        dtgvCTDTH.DataSource = CTDonTraHangBUS.Instance.HienThiTheoBien(MHDonTraHang.pMaDTH);
                    }
                    else MessageBox.Show("Lỗi");
                }
                else MessageBox.Show("Số lượng phải là kiểu số và lớn hơn 0");
            }
            else
                MessageBox.Show("Chi tiết đơn trả hàng đã tồn tại!");

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CTDonTraHangBUS.Instance.Xoa(int.Parse(tbMaDTH.Text), int.Parse(cbSanPham.SelectedValue.ToString())))
            {
                MessageBox.Show("Xóa thành công");
                // dtgvCTDTH.DataSource = CTDonTraHangBUS.Instance.HienThi();
                MHCTDonTraHang_Load(sender, e);

            }
            else
                MessageBox.Show("Lỗi");

        }

        

        private void btnSua_Click(object sender, EventArgs e)
        {

            // DonTraHang hd = new DonTraHang(int.Parse(tbMaDTH.Text), int.Parse(cbMaNV.Text), int.Parse(cbDT.Text),  DateTime.ParseExact(dtpk_NgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), tbLiDo.Text);
            CTDonTraHang dth = new CTDonTraHang( int.Parse(tbMaDTH.Text), int.Parse(cbSanPham.SelectedValue.ToString()), int.Parse(tbSoLuong.Text));
            if (CTDonTraHangBUS.Instance.KiemTraTonTai(int.Parse(tbMaDTH.Text), int.Parse(cbSanPham.SelectedValue.ToString())) == false)
            {
                if (CTDonTraHangBUS.Instance.Sua(dth))
                {
                    MessageBox.Show("Sửa thành công");
                    //dtgvCTDTH.DataSource = CTDonTraHangBUS.Instance.HienThi();
                    MHCTDonTraHang_Load(sender, e);

                }
                else
                    MessageBox.Show("Lỗi");

            }
            else
                MessageBox.Show("Chi tiết đơn trả hàng không tồn tại!");
        
    }

        private void tbTMaDTH_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}

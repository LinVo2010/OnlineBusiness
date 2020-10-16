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
    public partial class MHGioHang : Form
    {
        public MHGioHang()
        {
            InitializeComponent();
        }
        string taikhoan;
        private void MHGioHang_Load(object sender, EventArgs e)
        {
            taikhoan = MHDangNhap.pTaiKhoan;
            lbNguoiDung.Text = "Xin chào, " + taikhoan;
            dtgvTTinGioHang.DataSource = CTGioHangBUS.Instance.HienThi(int.Parse(taikhoan));
        }
        int pMaCTGH, pMaSP;
        private void dtgvTTinGioHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvTTinGioHang.CurrentRow.Index;


            if (dtgvTTinGioHang.Rows[i].Cells[0].Value.ToString() == string.Empty)
            {
                //pMaGH = 0;
                pMaCTGH = 0; pMaSP = 0;
                txbMaGH.Enabled = false;
                btnSua.Enabled = false;
                btnXoa.Enabled = false;
                txbSL.Enabled = false;
                txbTenSP.Enabled = false;
                txbThanhTien.Enabled = false;
                txbTongTien.Enabled = false;
                btnMua.Enabled = false;
            }
            else
            {
                //pMaGH = int.Parse(dtgvTTinGioHang.Rows[i].Cells[0].Value.ToString());
                pMaCTGH = int.Parse(dtgvTTinGioHang.Rows[i].Cells[1].Value.ToString());
                pMaSP = int.Parse(dtgvTTinGioHang.Rows[i].Cells[2].Value.ToString());

                txbMaGH.Text = dtgvTTinGioHang.Rows[i].Cells[0].Value.ToString();
                txbMaGH.Enabled = false;
                txbTenSP.Text = dtgvTTinGioHang.Rows[i].Cells[3].Value.ToString();
                txbTenSP.Enabled = false;
                txbSL.Text = dtgvTTinGioHang.Rows[i].Cells[4].Value.ToString();
                txbThanhTien.Text = dtgvTTinGioHang.Rows[i].Cells[5].Value.ToString();
                txbThanhTien.Enabled = false;
                txbTongTien.Text = dtgvTTinGioHang.Rows[i].Cells[6].Value.ToString();
                txbTongTien.Enabled = false;
                txbSL.Enabled = true;
                btnSua.Enabled = true;
                btnXoa.Enabled = true;
                btnMua.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e) // Sủa CT giỏ hàng
        {

            if (KiemTraSL(txbSL.Text) == true && int.Parse(txbSL.Text) > 0)
            {
                if (CTGioHangBUS.Instance.Sua(int.Parse(txbMaGH.Text), pMaCTGH, pMaSP, int.Parse(txbSL.Text)))
                {
                    MessageBox.Show("Sửa thành công");
                    this.Hide();
                    MHGioHang mhGH = new MHGioHang();
                    mhGH.ShowDialog();
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else
                MessageBox.Show("Số lượng không hợp lệ!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CTGioHangBUS.Instance.Xoa(int.Parse(txbMaGH.Text), pMaCTGH))
            {
                MessageBox.Show("Xóa thành công");
                this.Hide();
                MHGioHang mhGH = new MHGioHang();
                mhGH.ShowDialog();
            }
            else
                MessageBox.Show("Lỗi");
        }

        private void btnThemSP_Click(object sender, EventArgs e)
        {
            this.Hide();
            MHTimSP mhtimsp = new MHTimSP();
            mhtimsp.ShowDialog();
        }


        private void btnMua_Click(object sender, EventArgs e)
        {
            //lúc này sẽ update giỏ hàng thành ngưng tiếp nhận 
            //write code here
            int pMaHD;
            if (GioHangBUS.Instance.Sua(int.Parse(txbMaGH.Text)))
            {
                //Tạo mới 1 dòng hóa đơn ở chế độ mặc định chưa có thông tin người dùng
                //Và trạng thái hóa đơn 'chưa xác nhận'

                pMaHD = HoaDonBUS.Instance.AutoID();
                if (HoaDonBUS.Instance.Them(pMaHD, int.Parse(txbMaGH.Text)) == true) // thêm mới hóa đơn
                {
                    this.Hide();
                    MHHoaDon mhhd = new MHHoaDon();
                    mhhd.ShowDialog();
                }
                else
                    MessageBox.Show("Lỗi!");
            }
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

        public bool KiemTraSL(string pValue)
        {
            if (IsNumber(pValue) == true)
            {
                return true;
            }
            return false;
        }

    }
} 


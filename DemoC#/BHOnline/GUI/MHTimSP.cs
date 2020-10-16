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
    public partial class MHTimSP : Form
    {
        public MHTimSP()
        {
            InitializeComponent();
        }


        public DataTable tb;
        string taikhoan;
        public string SLDat; // lấy ra txbSLDat

        public static string pMaSP;
        public static string pTenSP;
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            dtgvDSSP.DataSource = SanPhamBUS.Instance.TimKiemSPTheoTen(txbTimKiem.Text);
        }

        private void MHTimSP_Load(object sender, EventArgs e)
        {
            taikhoan = MHDangNhap.pTaiKhoan;
            lbNguoiDung.Text = "Xin chào, " + taikhoan;
            dtgvDSSP.DataSource = SanPhamBUS.Instance.HienThi();
            txbMaSP.Enabled = false;
            txbTenSP.Enabled = false;
            txbMoTaSP.Enabled = false;
            txbGiaThiTruong.Enabled = false;
        }

        private void dtgvDSSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvDSSP.CurrentRow.Index;            
            txbMaSP.Text = dtgvDSSP.Rows[i].Cells[0].Value.ToString();          
            txbTenSP.Text = dtgvDSSP.Rows[i].Cells[1].Value.ToString();            
            txbMoTaSP.Text = dtgvDSSP.Rows[i].Cells[2].Value.ToString();            
            txbGiaThiTruong.Text = dtgvDSSP.Rows[i].Cells[5].Value.ToString();           
            pMaSP = txbMaSP.Text;
            pTenSP = txbTenSP.Text;           
        }

        private void btnThemVaoGH_Click(object sender, EventArgs e)
        {

            //Hiện form giỏ hàng lên
            //Kiểm tra nếu chưa có giỏ hàng ở trạng thái 'tiếp nhận' thi thêm mới giỏ hàng trạng thái 'tiếp nhận' sau đó thêm sp vô giỏ hàng (thêm CTGH)
            //nếu có giỏ hàng cũ thì chỉ cần thực hiện câu lệnh insert dòng ctgh với mã giỏ hàng 'tiếp nhận'

            if (txbGiaThiTruong.Text != string.Empty)
            {
                if (txbSLDat.Text == string.Empty)
                {
                    MessageBox.Show("Hãy điền số lượng muốn đặt!");
                }
                else
                {
                    int pMaGH, pMaCTGH;
                    if (GioHangBUS.Instance.KiemTraTonTai(int.Parse(taikhoan)) == true) // chưa có giỏ hàng chứa sẵn
                    {
                        //Tạo giỏ hàng mới
                        pMaGH = GioHangBUS.Instance.AutoID();
                        if (GioHangBUS.Instance.Them(pMaGH, int.Parse(taikhoan)) == true) // thêm mới giỏ hàng
                        {
                            MessageBox.Show("Đã có giỏ hàng, tha hồ mua sắm!");
                        }
                        else
                            MessageBox.Show("Lỗi tạo giỏ hàng!");
                    }
                    else
                    {
                        pMaGH = GioHangBUS.Instance.LayMaGH(int.Parse(taikhoan)); // Người dùng đã có sẵn giỏ hàng
                    }
                    //Thêm CTGH vào giỏ hàng
                    if (KiemTraSL(txbSLDat.Text) == true && int.Parse(txbSLDat.Text) > 0) // Số lượng phải là kí tự số > 0
                    {
                        if (SanPhamBUS.Instance.KiemTraSLTon(int.Parse(txbMaSP.Text)) > int.Parse(txbSLDat.Text)) // số lượng đặt phải < số lượng tồn sản phẩm
                        {
                            pMaCTGH = CTGioHangBUS.Instance.AutoID(); // tạo mới chi tiết giỏ hàng

                            if (CTGioHangBUS.Instance.Them(pMaCTGH, pMaGH, int.Parse(txbMaSP.Text), int.Parse(txbSLDat.Text)) == true) // thêm mới giỏ hàng
                            {
                                MessageBox.Show("Thêm thành công!");
                                this.Hide();
                                MHGioHang mhgh = new MHGioHang();
                                mhgh.ShowDialog();
                            }
                            else
                                MessageBox.Show("Lỗi!");
                        }
                        else
                        {
                            MessageBox.Show("Số lượng trong kho không đủ!");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Số lượng không phù hợp");
                    }
                }
            }
            else 
            MessageBox.Show("Hãy chọn sản phẩm bạn muốn đặt! ");            
        }

        private void dtgvDSSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnGioHang_Click(object sender, EventArgs e)
        {

            this.Hide();
            MHGioHang mhgiohang = new MHGioHang();
            mhgiohang.ShowDialog();
        }

        //private void dtgvDSSP(object sender, DataGridViewCellEventArgs e)
        //{

        //}
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (txbGiaThiTruong.Text != String.Empty)
            {
                MHDSComment mhdscmt = new MHDSComment();
                this.Hide();
                mhdscmt.ShowDialog();
            }
            else
                MessageBox.Show("Bạn chưa chọn sản phẩm!");
        }
    }
}






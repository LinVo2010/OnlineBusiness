using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace GUI
{
    public partial class MHDangNhap : Form
    {
        public MHDangNhap()
        {
            InitializeComponent();
        }
        public static string pTaiKhoan; // Biến lấy mã KH dạng string, nếu muốn dạng int dùng int.Parse(Text)
        private void MHDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // coding
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if ((txbTaiKhoan.Text != String.Empty) && (txbMatKhau.Text != String.Empty))
            {
                KhachHang kh = new KhachHang(int.Parse(txbTaiKhoan.Text) , null, null, txbMatKhau.Text , null);
                if (KhachHangBUS.Instance.KiemTraTonTai(int.Parse(txbTaiKhoan.Text), txbMatKhau.Text) == false)
                {
                    pTaiKhoan = txbTaiKhoan.Text;
            
                    MHTimSP mhtimSP = new MHTimSP();
                    this.Hide();
                    mhtimSP.ShowDialog();
                }
                else
                    MessageBox.Show("Tài khoản hoặc mật khẩu không đúng!");
            }
            else
                MessageBox.Show("Chưa nhập đầy đủ!");
        }               
    }
}

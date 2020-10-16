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
    public partial class MHThemComment : Form
    {
        public MHThemComment()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void bt_TroVe_Click(object sender, EventArgs e)
        {
            MHDSComment mhDSComment = new MHDSComment();
            this.Hide();
            mhDSComment.ShowDialog();
        }

        private void MHThemComment_Load(object sender, EventArgs e)
        {
           tb_TenSanPham1.Text = MHTimSP.pTenSP;
            tb_TenSanPham1.Enabled = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bt_ThemComment_Click(object sender, EventArgs e)
        {
            int pMaCMT = (int)CommentBUS.Instance.AutoID();
            string pTrangThai = "đã đăng";
            if (cb_Sao.SelectedItem == null)
            {
                MessageBox.Show("Bạn cần đánh giá sao!");
            }
            else
            {
                Comment cmt = new Comment(pMaCMT, DateTime.Now, int.Parse(cb_Sao.Text), tb_NoiDung.Text, null, int.Parse(MHDangNhap.pTaiKhoan), int.Parse(MHTimSP.pMaSP), pTrangThai.ToString());

                if (CommentBUS.Instance.Them(cmt))
                {
                    MessageBox.Show("Thêm thành công");
                    MHDSComment mhDSComment = new MHDSComment();
                    this.Hide();
                    mhDSComment.ShowDialog();
                }
                else
                    MessageBox.Show("Lỗi");
            } 
        }
    }
}

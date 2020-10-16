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
    public partial class MHDSComment : Form
    {
        public MHDSComment()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MHTimSP mhtimSP = new MHTimSP();
            this.Hide();
            mhtimSP.ShowDialog();
        }

        private void MHDSComment_Load(object sender, EventArgs e)
        {
            tb_TenSanPham.Text = MHTimSP.pTenSP;
            tb_TenSanPham.Enabled = false;
            dGV_DsComment.DataSource = CommentBUS.Instance.HienThi(int.Parse(MHTimSP.pMaSP));
        }

        private void dGV_DsComment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //int i = dGV_DsComment.CurrentRow.Index;
        }

        private void dGV_DsComment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dGV_DsComment.CurrentRow.Index;
            tb_TenKhachHang.Text = dGV_DsComment.Rows[i].Cells[0].Value.ToString();
            tb_Sao.Text = dGV_DsComment.Rows[i].Cells[1].Value.ToString();
            dTP_NgayDang.Text = dGV_DsComment.Rows[i].Cells[2].Value.ToString();
            tb_NoiDung.Text = dGV_DsComment.Rows[i].Cells[3].Value.ToString();
            tb_TenKhachHang.Enabled = false;
            tb_Sao.Enabled = false;
            dTP_NgayDang.Enabled = false;
            tb_NoiDung.Enabled = false;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (CommentBUS.Instance.KiemTraMuaHang(int.Parse(MHDangNhap.pTaiKhoan), int.Parse(MHTimSP.pMaSP)) == false)
            {
                MHThemComment mhThemComment = new MHThemComment();
                this.Hide();
                mhThemComment.ShowDialog();
            }
            else
                MessageBox.Show("Bạn chưa mua sản phẩm này nên không thể đánh giá!");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class MHLoaiSP : Form
    {
        public MHLoaiSP()
        {
            InitializeComponent();
        }

        private void MHLoaiSP_Load(object sender, EventArgs e)
        {

            tbMaLoai.Text = LoaiSPBUS.Instance.AutoID().ToString();
            tbMaLoai.Enabled = false;
            tbTenLoai.Text = DBNull.Value.ToString();
            
            dtgvLoaiSP.DataSource = LoaiSPBUS.Instance.HienThi();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (tbTenLoai.Text != string.Empty)
            {
                LoaiSP sp = new LoaiSP(int.Parse(tbMaLoai.Text), tbTenLoai.Text);
                if (LoaiSPBUS.Instance.Them(sp))
                {
                    MessageBox.Show("Thêm thành công");
                    dtgvLoaiSP.DataSource = LoaiSPBUS.Instance.HienThi();

                }
                else
                    MessageBox.Show("Lỗi");
            }
            else MessageBox.Show("Chưa nhập tên loại sản phẩm !");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            LoaiSP dth = new LoaiSP(int.Parse(tbMaLoai.Text), tbTenLoai.Text);
            if (LoaiSPBUS.Instance.KiemTraTonTai(int.Parse(tbMaLoai.Text)) == false)
            {
                if (LoaiSPBUS.Instance.Sua(dth))
                {
                    MessageBox.Show("Sửa thành công");
                    dtgvLoaiSP.DataSource = LoaiSPBUS.Instance.HienThi();

                }
                else
                    MessageBox.Show("Lỗi");

            }
            else
                MessageBox.Show("Mã loại sản phẩm không tồn tại!");
        }

        private void dtgvLoaiSP_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvLoaiSP.CurrentRow.Index;
            if (dtgvLoaiSP.Rows[i].Cells[0].Value == DBNull.Value)
            {
                tbMaLoai.Text = LoaiSPBUS.Instance.AutoID().ToString();
                tbMaLoai.Enabled = false;
            }
            else
            {
                tbMaLoai.Text = dtgvLoaiSP.Rows[i].Cells[0].Value.ToString();
                //tbMaLoai.Enabled = true;
            }
            // tbMaDTH.Text = dgvTraHang.Rows[i].Cells[0].Value.ToString();
            // tbMaDTH.Enabled = true;
            tbTenLoai.Text = dtgvLoaiSP.Rows[i].Cells[1].Value.ToString();
            
        }

        private void MHLoaiSP_FormClosing(object sender, FormClosingEventArgs e)
        {
            MHSanPham hd = new MHSanPham();
            hd.Show();
        }

        private void MHLoaiSP_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }
    }
}

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
    public partial class MHSanPham : Form
    {
        public MHSanPham()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void MHSanPham_Load(object sender, EventArgs e)
        {
            tbMaSP.Text = SanPhamBUS.Instance.AutoID().ToString();
            tbMaSP.Enabled = false;
            tbTenSP.Text = DBNull.Value.ToString();
            tbMaSP.Enabled = false;
            cbTenLoai.DataSource = LoaiSPBUS.Instance.HienThi();
            cbTenLoai.DisplayMember = "TenLoai";
            cbTenLoai.ValueMember = "MaLoai";
            //tb_maDT.Text = cb_Tendoitac.SelectedValue.ToString();
            tbSoLuongTon.Text = DBNull.Value.ToString();
            tbMoTa.Text = DBNull.Value.ToString();
            tbGia.Text = DBNull.Value.ToString();
                        
            dtgvSanPham.DataSource = SanPhamBUS.Instance.HienThi();
        
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

        public bool KiemTraGia(string pValue)
        {
            if (IsNumber(pValue) == true && int.Parse(pValue) >0)
            {
                return true;
            }
            return false;
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
            if (SanPhamBUS.Instance.KiemTraTonTai(int.Parse(tbMaSP.Text)) == true)
            {
                if (KiemTraGia(tbGia.Text) == true)
                {
                    if (KiemTraSoLuong(tbSoLuongTon.Text) == true)
                    {
                        SanPham sp = new SanPham(int.Parse(tbMaSP.Text), tbTenSP.Text, tbMoTa.Text, int.Parse(cbTenLoai.SelectedValue.ToString()), int.Parse(tbSoLuongTon.Text), int.Parse(tbGia.Text));
                        if (SanPhamBUS.Instance.Them(sp))
                        {
                            MessageBox.Show("Thêm thành công");
                            dtgvSanPham.DataSource = SanPhamBUS.Instance.HienThi();
                        }
                        else MessageBox.Show("Lỗi");
                    }
                    else MessageBox.Show("Số lượng phải là kiểu số và lớn hơn 0");

                }
                else MessageBox.Show("Giá phải là kiểu số và lớn hơn 0");
            }
            else
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
            }

        }
        
        private void btnXoa_Click_1(object sender, EventArgs e)
        {
            if (SanPhamBUS.Instance.KiemTraTonTai(int.Parse(tbMaSP.Text)) == false)
            {
                SanPham sp = new SanPham(int.Parse(tbMaSP.Text), tbTenSP.Text, tbMoTa.Text, int.Parse(cbTenLoai.SelectedValue.ToString()), int.Parse(tbSoLuongTon.Text), int.Parse(tbGia.Text));
                if (SanPhamBUS.Instance.Xoa(sp))
                {
                    MessageBox.Show("Xóa thành công");
                    dtgvSanPham.DataSource = SanPhamBUS.Instance.HienThi();
                }
                else MessageBox.Show("Lỗi");
            }
            else
            {
                MessageBox.Show("Không có sản phẩm này!");
            }

        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            
            if (SanPhamBUS.Instance.KiemTraTonTai(int.Parse(tbMaSP.Text)) == false)
            {
                if (KiemTraGia(tbGia.Text) == true)
                {
                    if (KiemTraSoLuong(tbSoLuongTon.Text) == true)
                    {
                        SanPham sp = new SanPham(int.Parse(tbMaSP.Text), tbTenSP.Text, tbMoTa.Text, int.Parse(cbTenLoai.SelectedValue.ToString()), int.Parse(tbSoLuongTon.Text), int.Parse(tbGia.Text));
                        if (SanPhamBUS.Instance.Sua(sp))
                        {
                            MessageBox.Show("Sửa thành công");
                            dtgvSanPham.DataSource = SanPhamBUS.Instance.HienThi();
                        }
                        else MessageBox.Show("Lỗi");
                    }
                    else MessageBox.Show("Số lượng phải là kiểu số và lớn hơn 0");

                }
                else MessageBox.Show("Giá phải là kiểu số và lớn hơn 0");
            }
            else
            {
                MessageBox.Show("Không có sản phẩm này!");
            }


        }

        private void dtgvSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgvSanPham.CurrentRow.Index;
            if (dtgvSanPham.Rows[i].Cells[0].Value == DBNull.Value)
            {
                tbMaSP.Text = SanPhamBUS.Instance.AutoID().ToString();
                tbMaSP.Enabled = false;
            }
            else
            {
                tbMaSP.Text = dtgvSanPham.Rows[i].Cells[0].Value.ToString();
                tbMaSP.Enabled = false;
            }
            // tb_MaDT.Text = dtgv_DoiTac.Rows[i].Cells[0].Value.ToString();
            tbTenSP.Text = dtgvSanPham.Rows[i].Cells[1].Value.ToString();
            tbMoTa.Text = dtgvSanPham.Rows[i].Cells[2].Value.ToString();
            cbTenLoai.Text = dtgvSanPham.Rows[i].Cells[3].Value.ToString();
            tbSoLuongTon.Text = dtgvSanPham.Rows[i].Cells[4].Value.ToString();
            tbGia.Text = dtgvSanPham.Rows[i].Cells[5].Value.ToString();

        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            this.Hide();
            MHLoaiSP ct = new MHLoaiSP();
            ct.ShowDialog();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            
                dtgvSanPham.DataSource = SanPhamBUS.Instance.TimKiemSPTheoTen(txbTimKiem.Text); 


        }

        private void label8_Click(object sender, EventArgs e)
        {
           
        }

        private void cbTenLoai_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

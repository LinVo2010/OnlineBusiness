using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.Globalization;

namespace GUI
{
    public partial class MHDonTraHang : Form
    {
        public MHDonTraHang()
        {
            InitializeComponent();
        }

        public static int pMaDTH;
        private void MHDonTraHang_Load(object sender, EventArgs e)
        {
            //cbMaNV.Enabled = false;
            //cbDT.Enabled = false;
            tbMaDTH.Text = DonTraHangBUS.Instance.AutoID().ToString();
            tbMaDTH.Enabled = false;
            cbDT.DataSource = DoiTacBanHangBUS.Instance.HienThi();
            cbDT.DisplayMember = "TenDT";
            cbDT.ValueMember = "MaDT";
            //tb_maDT.Text = cb_Tendoitac.SelectedValue.ToString();
            
            tbLiDo.Text = DBNull.Value.ToString();
            cbMaNV.DataSource = NhanVienBUS.Instance.HienThi();
            cbMaNV.DisplayMember = "TenNV";
            cbMaNV.ValueMember = "MaNV";

            dgvTraHang.DataSource = DonTraHangBUS.Instance.HienThi();
            pMaDTH = int.Parse(tbMaDTH.Text);

        }



        private void btnTao_Click(object sender, EventArgs e)
        {
            if (DonTraHangBUS.Instance.KiemTraTonTai(int.Parse(tbMaDTH.Text)) == true)
            {
                //if (cbDT.Text == DBNull.Value.ToString())
                //{
                //    if ((cbMaNV.Text) == DBNull.Value.ToString())
                //    {
                        DonTraHang dth = new DonTraHang(int.Parse(tbMaDTH.Text), int.Parse(cbMaNV.SelectedValue.ToString()), int.Parse(cbDT.SelectedValue.ToString()), DateTime.ParseExact(dtpk_NgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), tbLiDo.Text);
                        if (DonTraHangBUS.Instance.Them(dth))
                        {
                            MessageBox.Show("Thêm thành công");
                            dgvTraHang.DataSource = DonTraHangBUS.Instance.HienThi();
                            MessageBox.Show("Thêm chi tiết đơn trả hàng");
                            MHCTDonTraHang ct = new MHCTDonTraHang();
                            ct.Show();
                        }
                        else
                            MessageBox.Show("Lỗi");
                //    }
                //    else MessageBox.Show("Phải chọn nhân viên");

                //}
                //else MessageBox.Show("Phải chọn đối tác");
            }
            else
            {
                MessageBox.Show("Mã sản phẩm đã tồn tại!");
            }

        }

        private void dgvTraHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnCTDTH_Click(object sender, EventArgs e)
        {
            //Hien thi chi tiet don hang
            MHCTDonTraHang ct = new MHCTDonTraHang();
            //ct.madontra = madt;
            ct.Show();

        }

        //private void btnXoa_Click(object sender, EventArgs e)
        //{
        //    if (DonTraHangBUS.Instance.KiemTraTonTai(int.Parse(tbMaDTH.Text)) == false)
        //        {
        //            if (DonTraHangBUS.Instance.Xoa(int.Parse(tbMaDTH.Text)))
        //            {
        //                MessageBox.Show("Xóa thành công");
        //                dgvTraHang.DataSource = DonTraHangBUS.Instance.HienThi();
                       
        //            }
        //            else
        //                MessageBox.Show("Lỗi");
        //        }
        //        else
        //            MessageBox.Show("Đơn trả hàng không tồn tại!");
        //    }
        int madt;

        private void dgvTraHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dgvTraHang.CurrentRow.Index;
            tbMaDTH.Enabled = false;
            if (dgvTraHang.Rows[i].Cells[0].Value == DBNull.Value)
            {
                tbMaDTH.Text = DonTraHangBUS.Instance.AutoID().ToString();
                tbMaDTH.Enabled = false;
            }
            else
            {
                tbMaDTH.Text = dgvTraHang.Rows[i].Cells[0].Value.ToString();
                //tbMaDTH.Enabled = true;
            }
            // tbMaDTH.Text = dgvTraHang.Rows[i].Cells[0].Value.ToString();
            // tbMaDTH.Enabled = true;
            madt = int.Parse(tbMaDTH.Text);
            cbMaNV.Text = dgvTraHang.Rows[i].Cells[2].Value.ToString();
            dtpk_NgayLap.Text = dgvTraHang.Rows[i].Cells[3].Value.ToString();
            cbDT.Text = dgvTraHang.Rows[i].Cells[5].Value.ToString();
            tbLiDo.Text = dgvTraHang.Rows[i].Cells[6].Value.ToString();
        }

        
        //private void btnSua_Click(object sender, EventArgs e)
        //{
        //    // DonTraHang hd = new DonTraHang(int.Parse(tbMaDTH.Text), int.Parse(cbMaNV.Text), int.Parse(cbDT.Text),  DateTime.ParseExact(dtpk_NgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), tbLiDo.Text);
        //    DonTraHang dth = new DonTraHang(int.Parse(tbMaDTH.Text), int.Parse(cbMaNV.SelectedValue.ToString()), int.Parse(cbDT.SelectedValue.ToString()), DateTime.ParseExact(dtpk_NgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), tbLiDo.Text);
        //    if (DonTraHangBUS.Instance.KiemTraTonTai(int.Parse(tbMaDTH.Text)) == false)
        //    {                
        //            if (DonTraHangBUS.Instance.Sua(dth))
        //            {
        //                MessageBox.Show("Sửa thành công");
        //                dgvTraHang.DataSource = DonTraHangBUS.Instance.HienThi();
                   
        //            }
        //            else
        //                MessageBox.Show("Lỗi");
             
        //    }
        //    else
        //        MessageBox.Show("Mã hợp đồng không tồn tại!");
        //}


    }
    }

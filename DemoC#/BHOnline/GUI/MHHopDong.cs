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
using BUS;
using DTO;

namespace GUI
{
    public partial class MHHopDong : Form
    {
        public MHHopDong()
        {
            InitializeComponent();
        }
        public DateTime pNgayHetHan;
        private void label5_Click(object sender, EventArgs e)
        {

        }
        string GmailDT;

        public DataTable tb;
        public int Ngay { get; internal set; }

        private void HopDong_Load(object sender, EventArgs e)
        {
            tb_MaHD.Enabled = false;
            tb_maDT.Enabled = false;
            tb_maNV.Enabled = false;
            tb_MaHD.Text = HopDongBUS.Instance.AutoID().ToString();
            cb_DoiTac_Load(sender, e);
            tb_maDT.Text = cb_Tendoitac.SelectedValue.ToString();
            tb_NoiDung.Text = DBNull.Value.ToString();
            tb_ViTriDang.Text = DBNull.Value.ToString();
            tb_TenHD.Text = DBNull.Value.ToString(); 
            tb_Gmail.Text = DBNull.Value.ToString(); 

            cb_TenNV.DataSource = NhanVienBUS.Instance.HienThi();
            cb_TenNV.DisplayMember = "TenNV";
            cb_TenNV.ValueMember = "MaNV";
            tb_maNV.Text = cb_TenNV.SelectedValue.ToString();
       //     dtgv_HopDong.DataSource = HopDongBUS.Instance.HienThi();
         dtgv_HopDong.DataSource = tb;
      //   dtgv_HopDong.DataSource = HopDongBUS.Instance.TimHopDongTheoThoiHan(ngay, thang, nam);
      //   MessageBox.Show(pNgayHetHan.ToString("dd-MM-Y"));
      // HopDongBUS.Instance.HienThi(dtgv_HopDong);
        }
        public void cb_DoiTac_Load(object sender, EventArgs e)
        {
            cb_Tendoitac.DataSource = DoiTacBUS.Instance.HienThi();
            cb_Tendoitac.DisplayMember = "TenDT";
            cb_Tendoitac.ValueMember = "MaDT";
        }
        private void dtgv_Load(object sender, EventArgs e)
        {
            dtgv_HopDong.DataSource = HopDongBUS.Instance.HienThi();
        }
    

        private void label12_Click(object sender, EventArgs e)
        {

        }


        private void dtgv_HopDong_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int i = dtgv_HopDong.CurrentRow.Index;
            if (dtgv_HopDong.Rows[i].Cells[0].Value == DBNull.Value)
            {
                tb_MaHD.Text = HopDongBUS.Instance.AutoID().ToString();
                tb_MaHD.Enabled = false;
            }
            else
            {
                tb_MaHD.Text = dtgv_HopDong.Rows[i].Cells[0].Value.ToString();
                tb_MaHD.Enabled = true;
            }
            tb_TenHD.Text = dtgv_HopDong.Rows[i].Cells[1].Value.ToString();
            tb_maDT.Text = dtgv_HopDong.Rows[i].Cells[2].Value.ToString();
            cb_Tendoitac.Text = dtgv_HopDong.Rows[i].Cells[3].Value.ToString();
            tb_maNV.Text = dtgv_HopDong.Rows[i].Cells[4].Value.ToString();
            cb_TenNV.Text = dtgv_HopDong.Rows[i].Cells[5].Value.ToString();
           dtpicker_NgayLap.Text = dtgv_HopDong.Rows[i].Cells[6].Value.ToString();
            dtpicker_Thoihan.Text = dtgv_HopDong.Rows[i].Cells[7].Value.ToString();
           tb_ViTriDang.Text = dtgv_HopDong.Rows[i].Cells[8].Value.ToString();
            tb_NoiDung.Text = dtgv_HopDong.Rows[i].Cells[9].Value.ToString();
            tb_Gmail.Text = dtgv_HopDong.Rows[i].Cells[10].Value.ToString();
            GmailDT = tb_Gmail.Text;

        }

        private void bt_Thêm_Click(object sender, EventArgs e)
        {
          HopDong hd = new HopDong(int.Parse(tb_MaHD.Text), int.Parse(tb_maDT.Text), int.Parse(tb_maNV.Text), tb_TenHD.Text, DateTime.ParseExact(dtpicker_NgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), DateTime.ParseExact(dtpicker_Thoihan.Text , "dd-MM-yyyy", CultureInfo.InvariantCulture), tb_NoiDung.Text, tb_ViTriDang.Text );
            if (HopDongBUS.Instance.KiemTraTonTai(int.Parse(tb_MaHD.Text)) == true)
            {
                if (DoiTacBUS.Instance.KiemTraTonTai(int.Parse(tb_maDT.Text)) == false)
                {
                    if (NhanVienBUS.Instance.KiemTraTonTai(int.Parse(tb_maNV.Text)) == false)
                    {
                        if (TruNgayThang(DateTime.ParseExact(dtpicker_NgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), DateTime.ParseExact(dtpicker_Thoihan.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture)) > 0)
                        {
                            if (HopDongBUS.Instance.Them(hd))
                            {
                                MessageBox.Show("Thêm thành công");
                                tb = HopDongBUS.Instance.HienThi();
                                HopDong_Load(sender, e);
                            }
                            else
                                MessageBox.Show("Lỗi");
                        }
                        else
                            MessageBox.Show("Ngày tháng không hợp lệ!");
                     }
                    else
                        MessageBox.Show("Mã nhân viên không tồn tại!");
                }
                else
                    MessageBox.Show("Mã đối tác không tồn tại!");
            }
            else
            {
                MessageBox.Show("Mã hợp đồng đã tồn tại!");
            }
        }
       // string MaDT;
        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (HopDongBUS.Instance.KiemTraTonTai(int.Parse(tb_MaHD.Text)) == false)
            {
                    if (HopDongBUS.Instance.Xoa(int.Parse(tb_MaHD.Text)))
                    {
                        MessageBox.Show("Xóa thành công");
                    tb = HopDongBUS.Instance.HienThi();
                    HopDong_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Lỗi");
            }
            else
                MessageBox.Show("Mã hợp đồng không tồn tại!");
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            HopDong hd = new HopDong(int.Parse(tb_MaHD.Text), int.Parse(tb_maDT.Text), int.Parse(tb_maNV.Text), tb_TenHD.Text, DateTime.ParseExact(dtpicker_NgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), DateTime.ParseExact(dtpicker_Thoihan.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), tb_NoiDung.Text, tb_ViTriDang.Text);
            if (HopDongBUS.Instance.KiemTraTonTai(int.Parse(tb_MaHD.Text))==false)
            {
                if (TruNgayThang(DateTime.ParseExact(dtpicker_NgayLap.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture), DateTime.ParseExact(dtpicker_Thoihan.Text, "dd-MM-yyyy", CultureInfo.InvariantCulture)) > 0)
                {
                    if (HopDongBUS.Instance.Sua(hd))
                    {
                        MessageBox.Show("Sửa thành công");
                        tb = HopDongBUS.Instance.HienThi();
                        dtgv_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Lỗi");
                }
                else
                    MessageBox.Show("Ngày tháng không hợp lệ!");
                }
            else
                MessageBox.Show("Mã hợp đồng không tồn tại!");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void cb_TenNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_maNV.Text = cb_TenNV.SelectedValue.ToString();
        }

        private void cb_Tendoitac_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_maDT.Text = cb_Tendoitac.SelectedValue.ToString();
        }

        private void tb_maNV_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MHDoiTac dt = new MHDoiTac();
            dt.Show();
           this.Hide();
        }

        private int TruNgayThang(DateTime d1, DateTime d2)
        {
            TimeSpan Time = d2 - d1;
            int TongSoNgay = Time.Days;
            return TongSoNgay;
        }
        private void dtgv_HopDong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_Lich_Click(object sender, EventArgs e)
        {
            MHLichHetHan hd = new MHLichHetHan();
            hd.ShowDialog();
           // hd.tb = HopDongBUS.Instance.HienThi();
           
        }
       
        private void bt_GuiMail_Click(object sender, EventArgs e)
        {
            MHGuiMail mail = new MHGuiMail();
            mail.hdflat = 1;
            mail.DTGmail = GmailDT;
            mail.ShowDialog();
           // this.Hide();
        }

        private void MHHopDong_FormClosing(object sender, FormClosingEventArgs e)
        {
       
        }

        private void lb_HopDong_Click(object sender, EventArgs e)
        {

        }
    }
}

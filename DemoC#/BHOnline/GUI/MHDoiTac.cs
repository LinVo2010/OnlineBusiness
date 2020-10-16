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
    public partial class MHDoiTac : Form
    {
        public MHDoiTac()
        {
            InitializeComponent();
        }
        public bool KiemTraGmail(string h)
        {
            return h.Contains("@gmail.com");
        }

        private void DoiTacGUI_Load(object sender, EventArgs e)
        {
            dtgv_DoiTac.DataSource = DoiTacBUS.Instance.HienThi();
            tb_MaDT.Text = DoiTacBUS.Instance.AutoID().ToString();
            tb_MaDT.Enabled = false;
        }

        private void dtgv_DoiTac_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i = dtgv_DoiTac.CurrentRow.Index;
            if (dtgv_DoiTac.Rows[i].Cells[0].Value == DBNull.Value)
            {
                tb_MaDT.Text = DoiTacBUS.Instance.AutoID().ToString();
                tb_MaDT.Enabled = false;
            }
            else
            {
                tb_MaDT.Text = dtgv_DoiTac.Rows[i].Cells[0].Value.ToString();
                tb_MaDT.Enabled = true;
            }
           // tb_MaDT.Text = dtgv_DoiTac.Rows[i].Cells[0].Value.ToString();
            tb_TenDT.Text = dtgv_DoiTac.Rows[i].Cells[1].Value.ToString();
            tb_DiaChi.Text = dtgv_DoiTac.Rows[i].Cells[2].Value.ToString();
            tb_SDT.Text = dtgv_DoiTac.Rows[i].Cells[3].Value.ToString();
            tb_Gmail.Text = dtgv_DoiTac.Rows[i].Cells[4].Value.ToString();
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

        public bool KiemTraSDT(string pValue)
        {
            if (IsNumber(pValue) == true && pValue.Length == 10)
            {
                return true;
            }
            return false;
        }


        private void bt_Thêm_Click(object sender, EventArgs e)
        {
            if (KiemTraGmail(tb_Gmail.Text))
            {
                DoiTac dt = new DoiTac(int.Parse(tb_MaDT.Text), tb_TenDT.Text, tb_DiaChi.Text, tb_SDT.Text, tb_Gmail.Text);
                if (DoiTacBUS.Instance.KiemTraTonTai(int.Parse(tb_MaDT.Text)) == true)
                {
                    if (KiemTraSDT(tb_SDT.Text) == true)
                    {
                        if (DoiTacBUS.Instance.Them(dt))
                        {
                            MessageBox.Show("Thêm thành công");
                            dtgv_DoiTac.DataSource = DoiTacBUS.Instance.HienThi();

                        }
                        else
                            MessageBox.Show("Lỗi");
                    }
                    else
                        MessageBox.Show("Số điện thoại không hợp lệ. Xin nhập lại!");
                }
                else
                {
                    MessageBox.Show("Mã đối tác đã tồn tại!");
                }
            }
            else
            {
                MessageBox.Show("Gmail không hợp lệ!");
            }
        }

        private void bt_Xoa_Click(object sender, EventArgs e)
        {
            if (DoiTacBUS.Instance.Xoa(int.Parse(tb_MaDT.Text)))
            {
                MessageBox.Show("Xóa thành công");
                dtgv_DoiTac.DataSource = DoiTacBUS.Instance.HienThi();
            }
            else
                MessageBox.Show("Lỗi");
        }

        private void bt_Sua_Click(object sender, EventArgs e)
        {
            if (KiemTraGmail(tb_Gmail.Text))
            {
                DoiTac dt = new DoiTac(int.Parse(tb_MaDT.Text), tb_TenDT.Text, tb_DiaChi.Text, tb_SDT.Text, tb_Gmail.Text);
                if (DoiTacBUS.Instance.Sua(dt))
                {
                    MessageBox.Show("Sửa thành công");
                    dtgv_DoiTac.DataSource = DoiTacBUS.Instance.HienThi();
                }
                else
                    MessageBox.Show("Lỗi");
            }
            else
            {
                MessageBox.Show("Gmail không hợp lệ!");
            }
}

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void MHDoiTac_FormClosing(object sender, FormClosingEventArgs e)
        {
            MHHopDong hd = new MHHopDong();
            hd.tb = HopDongBUS.Instance.HienThi();
            hd.ShowDialog();
            hd.cb_DoiTac_Load(sender, e);
        }
    }
}

using BUS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;

namespace GUI
{
    public partial class MHNhanTinKhachHang : Form
    {
        public MHNhanTinKhachHang()
        {
            InitializeComponent();
        }

        public static int GetWeekOrderInYear(DateTime time)
        {
            CultureInfo myCI = CultureInfo.CurrentCulture;
            Calendar myCal = myCI.Calendar;
            CalendarWeekRule myCWR = myCI.DateTimeFormat.CalendarWeekRule;
            DayOfWeek myFirstDOW = myCI.DateTimeFormat.FirstDayOfWeek;

            return myCal.GetWeekOfYear(time, myCWR, myFirstDOW);
        }

        public DataTable dttb = null;
        public int MaTN_public;

        private void NhanTinGUI_Load(object sender, EventArgs e)
        {
            cb_TenSP.DataSource = SanPhamBUS.Instance.HienThi();
            cb_TenSP.DisplayMember = "TenSP";
            cb_TenSP.ValueMember = "MaSP";
            tb_MaSP.Text = cb_TenSP.SelectedValue.ToString();
            int pMaTN = TinNhanBUS.Instance.TimMaTN(1, GetWeekOrderInYear(DateTime.Today.Date), int.Parse(DateTime.Today.Year.ToString()));
            MaTN_public = pMaTN;
            if (pMaTN == -1)
            {
                pMaTN = TinNhanBUS.Instance.AutoID();
                MaTN_public = pMaTN;
                TinNhan tn = new TinNhan(TinNhanBUS.Instance.AutoID() , int.Parse(tb_MaSP.Text) , GetWeekOrderInYear(DateTime.Today.Date) , int.Parse(DateTime.Today.Year.ToString()), "" , "" );
                TinNhanBUS.Instance.Them(tn);
    
            }
          
               dtgv_KhachHang.DataSource = TinNhan_KhachHangBUS.Instance.KhachHangChuaGuiMail(pMaTN);
               dttb = TinNhan_KhachHangBUS.Instance.KhachHangChuaGuiMail(pMaTN);

            int i = 0;
            foreach (DataRow item in dttb.Rows)
            {
                i = i + 1;
            }
            if (i == 0)
            {
                bt_GuiMail.Enabled = false;
            }
            else
            {
                bt_GuiMail.Enabled = true;
            }
        }

        private void bt_GuiMail_Click(object sender, EventArgs e)
        {
            MHGuiMail dt = new MHGuiMail();
            dt.data = dttb;
            dt.MaTN = MaTN_public;
            dt.ShowDialog();
        }

        private void cb_SanPham_SelectedIndexChanged(object sender, EventArgs e) { }

        private void cb_SanPham_SelectedValueChanged(object sender, EventArgs e) { }


        private void cb_SanPham_SelectionChangeCommitted(object sender, EventArgs e)
        {
            tb_MaSP.Text = cb_TenSP.SelectedValue.ToString();
            int pMaTN = TinNhanBUS.Instance.TimMaTN(int.Parse(tb_MaSP.Text) , GetWeekOrderInYear(DateTime.Today.Date), int.Parse(DateTime.Today.Year.ToString()));
            MaTN_public = pMaTN;
            if (pMaTN == -1)
            {
                pMaTN = TinNhanBUS.Instance.AutoID();
                MaTN_public = pMaTN;
                TinNhan tn = new TinNhan(TinNhanBUS.Instance.AutoID(), int.Parse(tb_MaSP.Text), GetWeekOrderInYear(DateTime.Today.Date), int.Parse(DateTime.Today.Year.ToString()), "", "");
                TinNhanBUS.Instance.Them(tn);
            }

            dtgv_KhachHang.DataSource = TinNhan_KhachHangBUS.Instance.KhachHangChuaGuiMail(pMaTN);
            dttb = TinNhan_KhachHangBUS.Instance.KhachHangChuaGuiMail(pMaTN);
            int i = 0;
            foreach (DataRow item in dttb.Rows)
            {
                i = i + 1;
            }
            if (i == 0)
            {
                bt_GuiMail.Enabled = false;
            }
            else
            {
                bt_GuiMail.Enabled = true;
            }
        }

        private void tb_maSP_TextChanged(object sender, EventArgs e) { }

        private void tb_maSP_Validated(object sender, EventArgs e) { }

        private void cb_SanPham_Validating(object sender, CancelEventArgs e) { }

        private void cb_SanPham_TextChanged(object sender, EventArgs e) { }

        private void dtgv_KhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MHNhanTinKhachHang_FormClosing(object sender, FormClosingEventArgs e)
        {
    
        }
    }
}

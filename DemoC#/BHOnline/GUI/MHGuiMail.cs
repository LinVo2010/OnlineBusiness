using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using GUI;

namespace GUI
{
    public partial class MHGuiMail : Form
    {
        Attachment attach = null;
        public DataTable data = null;
        public int MaTN;
        public string DTGmail;
        public MHGuiMail()
        {
            InitializeComponent();
        }
      private  void GuiMail(string pNguoiGui, string pNguoiNhan, string pChuDe, string pNoiDung, Attachment pDinhKem = null)
        {
            MailMessage mess = new MailMessage(pNguoiGui, pNguoiNhan, pChuDe, pNoiDung);

            if(attach!= null)
            {
                mess.Attachments.Add(attach);
            }
            SmtpClient client = new SmtpClient("smtp.gmail.com", 587);
            client.EnableSsl = true;
            client.Credentials = new NetworkCredential(tb_TenDangNhap.Text, tb_MatKhau.Text);
            client.Send(mess);
            MessageBox.Show("Gui OK");
            //https://myaccount.google.com/u/1/lesssecureapps

        }
        private void tb_Gui_Click(object sender, EventArgs e)
        {
            attach = null;
            try
            {
                FileInfo file = new FileInfo(tb_DinhKem.Text);
                attach = new Attachment(tb_DinhKem.Text);
            }
            catch { }
            //DataTable data = KhachHangBUS.Instance.HienThi();
            if (hdflat == 0)
            {
                foreach (DataRow item in data.Rows)
                {
                    tb_NguoiNhan.Text = item["Gmail"].ToString();
                    int MaKH = int.Parse(item["MaKH"].ToString());
                    GuiMail(tb_TenDangNhap.Text, tb_NguoiNhan.Text, tb_ChuDe.Text, tb_NoiDung.Text, attach);
                    TinNhan tn = TinNhanBUS.Instance.DocThongTin(MaTN);
                    tn.NoiDung = tb_NoiDung.Text;
                    tn.ChuDe = tb_ChuDe.Text;
                    TinNhanBUS.Instance.Sua(tn);
                    TinNhan_KhachHang tnkh = new TinNhan_KhachHang(MaTN, MaKH);
                    TinNhan_KhachHangBUS.Instance.Them(tnkh);
                }
            }
            else
            {
                GuiMail(tb_TenDangNhap.Text, tb_NguoiNhan.Text, tb_ChuDe.Text, tb_NoiDung.Text, attach);
                hdflat = 0;    
            }
            MessageBox.Show("Đã gửi xong.");
            this.Hide();

        }


      

        private void bt_dinhkem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if(dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                tb_DinhKem.Text = dialog.FileName;
            }
        }


        public int hdflat = 0;
        private void GuiMailGUI_Load(object sender, EventArgs e)
        {
            if( hdflat == 0 )
            {
                tb_NguoiNhan.Enabled = false;
                TinNhan tn = TinNhanBUS.Instance.DocThongTin(MaTN);
                if (tn.NoiDung != "" && tn.ChuDe != "")
                {
                    tb_ChuDe.Text = tn.ChuDe;
                    tb_NoiDung.Text = tn.NoiDung;
                    tb_ChuDe.Enabled = false;
                    tb_NoiDung.Enabled = false;
                }
                else
                {
                    tb_ChuDe.Enabled = true;
                    tb_NoiDung.Enabled = true;
                }
               

            }
            else
            {
                tb_NguoiNhan.Text = DTGmail;
            }
        }

        private void tb_NguoiNhan_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

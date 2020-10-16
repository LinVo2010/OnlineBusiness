using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAC;
using System.Windows.Forms;

namespace BUS
{
    public class CommentBUS
    {
        private static CommentBUS instance;
        public static CommentBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CommentBUS();
                return instance;
            }
        }

        private CommentBUS() { }

        public DataTable HienThi(int pMaSP)
        {
            return CommentDAC.Instance.HienThi(pMaSP);
        }

        public bool KiemTraTonTai(int makh, int masp)
        {
            Comment hd = CommentDAC.Instance.DocThongTin(makh, masp);
            if (hd == null)
            {
                return true;//Chưa tồn tại 
            }
            return false;
        }

        public bool Them(Comment cmt)
        {
            return CommentDAC.Instance.Them(cmt);
        }

        public bool KiemTraMuaHang(int makh, int masp)
        {
            Comment cmt = CommentDAC.Instance.DocThongTin(makh, masp);
            if (cmt == null)
            {
                return true;//Chưa tồn tại 
            }
            return false; // Tồn tại 
        }

        public int AutoID()
        {
            return CommentDAC.Instance.AutoID();
        }
    }
}

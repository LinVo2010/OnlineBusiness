using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DTO;
using DAC;

namespace BUS
{
    public class CTGioHangBUS
    {
        private static CTGioHangBUS instance;
        public static CTGioHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTGioHangBUS();
                return instance;
            }
        }
        private CTGioHangBUS() { }

        public DataTable HienThi(int pMaKH)
        {
            return CTGioHangDAC.Instance.HienThi(pMaKH);
        }
        public bool Sua(int MaGH, int MaCTGH, int MaSP, int SL)
        {
            return CTGioHangDAC.Instance.Sua(MaGH, MaCTGH, MaSP, SL);
        }
        public bool Xoa(int MaGH, int MaCTGH)
        {
            return CTGioHangDAC.Instance.Xoa(MaGH, MaCTGH);
        }
        public bool Them(int MaCTGH, int MaGH, int MaSP, int SL)
        {
            return CTGioHangDAC.Instance.Them( MaCTGH, MaGH, MaSP, SL);
        }
        public int AutoID()
        {
            return CTGioHangDAC.Instance.AutoID();
        }
        public DataTable HienThiGioHang_CTT(int pMaKH)
        {
            return CTGioHangDAC.Instance.HienThiGioHang_CTT(pMaKH);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAC;

namespace BUS
{
    public class GioHangBUS
    {
        private static GioHangBUS instance;
        public static GioHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new GioHangBUS();
                return instance;
            }
        }

        private GioHangBUS() { }
        public DataTable HienThi()
        {
            return GioHangDAC.instance.HienThi();
        }
        public bool KiemTraTonTai(int makh)
        {
            GioHang ghtn = GioHangDAC.Instance.DocThongTinGHTN(makh);
            if (ghtn == null)
            {
                return true;//Chưa tồn tại 
            }
            return false; // Tồn tại 
        }
        public bool Them(int MaGH, int MaKH)
        {
            return GioHangDAC.Instance.Them(MaGH, MaKH);
        }
        public int AutoID()
        {
            return GioHangDAC.Instance.AutoID();
        }
        public int LayMaGH (int pMaKH)
        {
            return GioHangDAC.Instance.LayMaGH(pMaKH);
        }
        public bool Sua (int pMaGH)
        {
            return GioHangDAC.Instance.Sua(pMaGH);
        }
    }
}

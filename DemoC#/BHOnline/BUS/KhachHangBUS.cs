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
    public class KhachHangBUS
    {
        private static KhachHangBUS instance;
        public static KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangBUS();
                return instance;
            }
        }
        private KhachHangBUS() { }

        public DataTable HienThi()
        {
            return KhachHangDAC.Instance.HienThi();
        }

        public bool KiemTraTonTai(int makh, string sdt)
        {
            KhachHang kh = KhachHangDAC.Instance.DocThongTin(makh, sdt);
            if (kh == null)
            {
                return true;//Chưa tồn tại 
            }
            return false; // Tồn tại 
        }
        public DataTable LayTTKH(int pMaKH)
        {
            return KhachHangDAC.Instance.LayTTKH(pMaKH);
        }

        public DataTable LayThongTinKH(int pMaKH)
        {
            return KhachHangDAC.Instance.LayThongTinKH(pMaKH);
        }

        public string LayTenKH(int pMaKH)
        {
            return KhachHangDAC.Instance.LayTenKH(pMaKH);
        }
    } 
}

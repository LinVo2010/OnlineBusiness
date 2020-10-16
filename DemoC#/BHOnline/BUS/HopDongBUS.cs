using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAC;
using System.Windows.Forms;
using System.Data;

namespace BUS
{
    public class HopDongBUS
    {
        private static HopDongBUS instance;
        public static HopDongBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HopDongBUS();
                return instance;
            }
        }

        private HopDongBUS() { }

        public DataTable HienThi()
        {
            return HopDongDAC.Instance.HienThi();
        }

        public DataTable TimHopDongTheoThoiHan(int pNgay, int pThang , int pNam)
        {
            return HopDongDAC.Instance.TimHopDongTheoThoiHan(pNgay , pThang , pNam);
        }


        public bool Sua(HopDong hd)
        {
            return HopDongDAC.Instance.Sua(hd);
        }

        public bool Them(HopDong hd)
        {
            return HopDongDAC.Instance.Them(hd);
        }

        public bool Xoa(int mahd)
        {
            return HopDongDAC.Instance.Xoa(mahd);
        }

        public bool KiemTraTonTai(int mahd)
        {
            HopDong hd = HopDongDAC.Instance.DocThongTin(mahd);
            if (hd == null)
            {
                return true;//Chưa tồn tại 
            }
            return false;
        }

        public int AutoID()
        {
            return HopDongDAC.Instance.AutoID();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAC;
using DTO;

namespace BUS
{
    public class DonTraHangBUS
    {

        private static DonTraHangBUS instance;
        public static DonTraHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonTraHangBUS();
                return instance;
            }
        }

        private DonTraHangBUS() { }

        public DataTable HienThi()
        {
            return DonTraHangDAC.Instance.HienThi();
        }

        public int AutoID()
        {
            return DonTraHangDAC.Instance.AutoID();
        }

        public bool Xoa(int mahd)
        {
            return DonTraHangDAC.Instance.Xoa(mahd);
        }

        public bool KiemTraTonTai(int mahd)
        {
            DonTraHang hd = DonTraHangDAC.Instance.DocThongTin(mahd);
            if (hd == null)
            {
                return true;//Chưa tồn tại 
            }
            return false;
        }

        public bool Sua(DonTraHang dth)
        {
            return DonTraHangDAC.Instance.Sua(dth);
        }
        public bool Them(DonTraHang dth)
        {
            return DonTraHangDAC.Instance.Them(dth);
        }
    }
}

using DAC;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class CTDonTraHangBUS
    {
        private static CTDonTraHangBUS instance;
        public static CTDonTraHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTDonTraHangBUS();
                return instance;
            }
        }
        private CTDonTraHangBUS() { }

        public DataTable HienThi()
        {
            return CTDonTraHangDAC.Instance.HienThi();
        }
        public DataTable HienThiTheoBien(int pMaDTH)
        {
            return CTDonTraHangDAC.Instance.HienThiTheoBien(pMaDTH);
        }
        public bool KiemTraTonTai(int madt, int masp)
        {
            CTDonTraHang CT = CTDonTraHangDAC.Instance.DocThongTin(madt, masp);
            if (CT == null)
            {
                return true;//Chưa tồn tại 
            }
            return false;
        }
        public bool Them(CTDonTraHang ctdth)
        {
            return CTDonTraHangDAC.Instance.Them(ctdth);
        }
        public bool Xoa(int madth, int masp)
        {
            return CTDonTraHangDAC.Instance.Xoa(madth, masp);
        }
        public bool Sua(CTDonTraHang dth)
        {
            return CTDonTraHangDAC.Instance.Sua(dth);
        }
        public DataTable TimThongTin(int dth)
        {
            return CTDonTraHangDAC.Instance.TimThongTin(dth);
        }


    }
}

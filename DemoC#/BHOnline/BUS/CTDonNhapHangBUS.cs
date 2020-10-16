
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
    public class CTDonNhapHangBUS
    {
        private static CTDonNhapHangBUS instance;
        public static CTDonNhapHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTDonNhapHangBUS();
                return instance;
            }
        }
        private CTDonNhapHangBUS() { }

        public DataTable HienThi()
        {
            return CTDonNhapHangDAC.Instance.HienThi();
        }

        public DataTable HienThiTheoBien( int pMaDNH)
        {
            return CTDonNhapHangDAC.Instance.HienThiTheoBien(pMaDNH);
        }
        public bool TinhGia(int madnh, int masp)
        {
            return CTDonNhapHangDAC.Instance.TinhGia(madnh, masp);
        }

        public bool KiemTraTonTai(int madnh, int masp)
        {
            CTDonNhapHang CT = CTDonNhapHangDAC.Instance.DocThongTin(madnh, masp);
            if (CT == null)
            {
                return true;//Chưa tồn tại 
            }
            return false;
        }
        public bool Them(CTDonNhapHang ctdth)
        {
            return CTDonNhapHangDAC.Instance.Them(ctdth);
        }

        public DataTable TimThongTin(int dth)
        {
            return CTDonNhapHangDAC.Instance.TimThongTin(dth);
        }
    }
}

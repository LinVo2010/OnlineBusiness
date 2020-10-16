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
    public class HoaDonBUS
    {
        private static HoaDonBUS instance;
        public static HoaDonBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonBUS();
                return instance;
            }
        }
        private HoaDonBUS() { }

        public bool Them(int pMaHD, int pMaGH)
        {
            return HoaDonDAC.Instance.Them(pMaHD, pMaGH);
        }

        public int AutoID()
        {
            return HoaDonDAC.Instance.AutoID();
        }

        public DataTable HienThiLichSuHD (int pMaKH)
        {
            return HoaDonDAC.Instance.HienThiLichSuHD(pMaKH);
        }

        public DataTable HienThiTTHDChuaXacNhan(int pMaKH)
        {
            return HoaDonDAC.Instance.DocTTHDChuaXacNhan(pMaKH);
        }
        public bool Sua(int pMaKH, string pSDT, string pGmail, string pDiaChi)
        {
            return HoaDonDAC.Instance.CapNhatTTinHD(pMaKH, pSDT, pGmail, pDiaChi);
        }

        public DataTable LayThongTinHD(int pMaKH)
        {
            return HoaDonDAC.Instance.LayThongTinHD(pMaKH);
        }


        public bool CapNhapPTTT_The(int pMaKH)
        {
            return HoaDonDAC.Instance.CapNhapPTTT_The(pMaKH);
        }

        public bool CapNhapPTTT_Tien(int pMaKH)
        {
            return HoaDonDAC.Instance.CapNhapPTTT_Tien(pMaKH);
        }

        public bool CapNhapTrangThai(int pMaKH)
        {
            return HoaDonDAC.Instance.CapNhapTrangThai(pMaKH);
        }


        public DataTable HienThiHD(int pMaKH)
        {
            return HoaDonDAC.Instance.HienThiHD(pMaKH);
        }

    }
}

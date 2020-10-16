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
    public class SanPhamBUS
    {
        private static SanPhamBUS instance;
        public static SanPhamBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamBUS();
                return instance;
            }
        }
        private SanPhamBUS() { }

        public DataTable HienThi()
        {
            return SanPhamDAC.Instance.HienThi();
        }
        public DataTable TimKiemSPTheoTen(string pTenSP)
        {
            return SanPhamDAC.Instance.XemTTSP(pTenSP);
        }
        public int KiemTraSLTon (int pMaSP)
        {
            return SanPhamDAC.instance.DocThongTinSLTon(pMaSP);
        }
        public DataTable HienThiDSThieuHang(int dem)
        {
            return SanPhamDAC.Instance.HienThiDSThieuHang(dem);
        }

        public int AutoID()
        {
            return SanPhamDAC.Instance.AutoID();
        }

        public int KiemTraThieuHang(int dem)
        {
            return SanPhamDAC.Instance.KiemTraThieuHang(dem);
        }
        public bool Sua(SanPham sp)
        {
            return SanPhamDAC.Instance.Sua(sp);
        }
        public bool Them(SanPham sp)
        {
            return SanPhamDAC.Instance.Them(sp);
        }
        public bool Xoa(SanPham sp)
        {
            return SanPhamDAC.Instance.Xoa(sp);
        }
        public bool KiemTraTonTai(int masp)
        {
            SanPham hd = SanPhamDAC.Instance.DocThongTin(masp);
            if (hd == null)
            {
                return true;//Chưa tồn tại 
            }
            return false;
        }
    }
}

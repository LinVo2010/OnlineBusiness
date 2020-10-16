using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        private int _MaSP;

        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private string _TenSP;

        public string TenSP
        {
            get { return _TenSP; }
            set { _TenSP = value; }
        }

        private string _MoTa;

        public string MoTa
        {
            get { return _MoTa; }
            set { _MoTa = value; }
        }

        private int _MaLoai;

        public int MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }

        private int _SoLuongTon;

        public int soLuongTon
        {
            get { return _SoLuongTon; }
            set { _SoLuongTon = value; }
        }

        private int _Gia;

        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }

        public SanPham(int pMaSP, string pTenSP, string pMoTa,int pMaLoai, int pSoLuongTon, int pGia)
        {
            this.MaSP = pMaSP;
            this.TenSP = pTenSP;
            this.MoTa = pMoTa;
            this.MaLoai = pMaLoai;
            this.soLuongTon = pSoLuongTon;
            this.Gia = pGia;
        }

    }
}

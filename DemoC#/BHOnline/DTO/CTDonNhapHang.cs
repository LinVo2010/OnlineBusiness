using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTDonNhapHang
    {
        private int _MaDNH;

        public int MaDNH
        {
            get { return _MaDNH; }
            set { _MaDNH = value; }
        }

        private int _MaSP;

        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private int _SoLuong;

        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }

        private int _Gia;

        public int Gia
        {
            get { return _Gia; }
            set { _Gia = value; }
        }


        public CTDonNhapHang(int pMaDTH, int pMaSP, int pSoLuong, int pGia)
        {
            this.MaDNH = pMaDTH;
            this.MaSP = pMaSP;
            this.SoLuong = pSoLuong;
            this.Gia = pGia;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTGioHang
    {
        private int _MaCTGH;

        public int MaCTGH
        {
            get { return _MaCTGH; }
            set { _MaCTGH = value; }
        }

        private int _MaGH;

        public int MaGH
        {
            get { return _MaGH; }
            set { _MaGH = value; }
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

        private int _ThanhTien;

        public int ThanhTien
        {
            get { return _ThanhTien; }
            set { _ThanhTien = value; }
        }

        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public CTGioHang(int pMaCTGH, int pMaGH, int pMaSP, int pSoLuong, int pThanhTien, string pTrangThai)
        {

            this.MaCTGH = pMaCTGH;
            this.MaGH = pMaGH;
            this.MaSP = pMaSP;
            this.SoLuong = pSoLuong;
            this.ThanhTien = pThanhTien;
            this.TrangThai = pTrangThai;
        }
    }
}

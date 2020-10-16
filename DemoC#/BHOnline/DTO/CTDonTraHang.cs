using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
   public class CTDonTraHang
    {
        private int _MaDTH;

        public int MaDTH
        {
            get { return _MaDTH; }
            set { _MaDTH = value; }
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

        
        public CTDonTraHang(int pMaDTH, int pMaSP, int pSoLuong)
        {
            this.MaDTH = pMaDTH;
            this.MaSP = pMaSP;
            this.SoLuong = pSoLuong;
            
        }
    }
}

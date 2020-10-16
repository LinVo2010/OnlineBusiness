using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class TinNhan_KhachHang
    {
        private int _MaTN;

        public int MaTN
        {
            get { return _MaTN; }
            set { _MaTN = value; }
        }
     

        private int _MaKH;

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        public TinNhan_KhachHang(int pMaTN , int pMaKH)
        {
            this.MaTN = pMaTN;
            this.MaKH = pMaKH;
        }

    }
}

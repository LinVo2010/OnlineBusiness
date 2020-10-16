using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public  class KhachHang
    {
        private int _MaKH;

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        private string _TenKH;

        public string TenKH
        {
            get { return _TenKH; }
            set { _TenKH = value; }
        }

        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        private string _Gmail;

        public string Gmail
        {
            get { return _Gmail; }
            set { _Gmail = value; }
        }

        public KhachHang (int pMaKH, string pTenKH, string pDiaChi, string pSDT, string pGmail)
        {
            this.MaKH = pMaKH;
            this.TenKH = pTenKH;
            this.DiaChi = pDiaChi;
            this.SDT = pSDT;
            this.Gmail = pGmail;
        }

    }
}

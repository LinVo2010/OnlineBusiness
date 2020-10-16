using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LoaiSanPham
    {
        private int _MaLoai;

        public int MaLoai
        {
            get { return _MaLoai; }
            set { _MaLoai = value; }
        }

        private string _TenLoai;

        public string TenLoai
        {
            get { return _TenLoai; }
            set { _TenLoai = value; }
        }

        public LoaiSanPham(int pMaLoai, string pTenLoai)
        {
            this.MaLoai = pMaLoai;
            this.TenLoai = pTenLoai;
        }
    }
}

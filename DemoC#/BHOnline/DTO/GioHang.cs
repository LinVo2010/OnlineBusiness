using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class GioHang
    {
        private int _MaGH;

        public int MaGH
        {
            get { return _MaGH; }
            set { _MaGH = value; }
        }

        private int _MaKH;

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        private int _TongTien;

        public int TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }

        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public GioHang(int pMaGH, int pMaKH, int pTongTien, string pTrangThai)
        {
          
            this.MaGH = pMaGH;
            this.MaKH = pMaKH;
            this.TongTien = pTongTien;
            this.TrangThai = pTrangThai;
        }
    }
}

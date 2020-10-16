using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ThongTinTraHang
    {
  
        private int _MaTH;

        public int MaTH
        {
            get { return _MaTH; }
            set { _MaTH = value; }
        }

        private int _MaCTGH;

        public int MaCTGH
        {
            get { return _MaCTGH; }
            set { _MaCTGH = value; }
        }

        private string _LyDoTra;

        public string LyDoTra
        {
            get { return _LyDoTra; }
            set { _LyDoTra = value; }
        }

        private DateTime _NgayTra;

        public DateTime NgayTra
        {
            get { return _NgayTra; }
            set { _NgayTra = value; }
        }

        private int _TienHoanTra;

        public int TienHoanTra
        {
            get { return _TienHoanTra; }
            set { _TienHoanTra = value; }
        }

        public ThongTinTraHang(int pMaTH, int pMaCTGH, string pLyDoTra, DateTime pNgayTra, int pTienHoanTra)
        {
            this.MaTH = pMaTH;
            this.MaCTGH = pMaCTGH;
            this.LyDoTra = pLyDoTra;
            this.NgayTra = pNgayTra;
            this.TienHoanTra = pTienHoanTra;
        }



    }
}
  

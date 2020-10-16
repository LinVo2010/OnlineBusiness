using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonTraHang
    {
        private int _MaDTH;

        public int MaDTH
        {
            get { return _MaDTH; }
            set { _MaDTH = value; }
        }

        private int _MaNV;

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private int _MaDT;

        public int MaDT
        {
            get { return _MaDT; }
            set { _MaDT = value; }
        }

        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }

        private string _LyDo;

        public string LyDo
        {
            get { return _LyDo; }
            set { _LyDo = value; }
        }

        public DonTraHang(int pMaDTH, int pMaNV, int pMaDT, DateTime pNgayLap, string pLyDo)
        {
            this.MaDTH = pMaDTH;
            this.MaNV = pMaNV;
            this.MaDT = pMaDT;
            this.NgayLap = pNgayLap;
            this.LyDo = pLyDo;

        }

    }
}

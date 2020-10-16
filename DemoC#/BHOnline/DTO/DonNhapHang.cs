using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DonNhapHang
    {
             private int _MaDNH;

            public int MaDNH
            {
                get { return _MaDNH; }
                set { _MaDNH = value; }
            }

            private int _MaDT;

            public int MaDT
            {
                get { return _MaDT; }
                set { _MaDT = value; }
            }

            private int _MaNV;

            public int MaNV
            {
                get { return _MaNV; }
                set { _MaNV = value; }
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

            private int _TongTien;

            public int TongTien
            {
                get { return _TongTien; }
                set { _TongTien = value; }
            }

            public DonNhapHang(int pMaDNH, int pMaDT, int pMaNV, DateTime pNgayLap, string pLyDo, int pTongTien)
            {
                this.MaDNH = pMaDNH;
                this.MaDT = pMaDT;
                this.MaNV = pMaNV;
                this.NgayLap = pNgayLap;
                this.LyDo = pLyDo;
                this.TongTien = pTongTien;

            }
    }
}

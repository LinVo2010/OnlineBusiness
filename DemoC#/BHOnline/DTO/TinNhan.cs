using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    //MaTN, MaSP, Ngay, MaNV, ChuDe, NoiDung
    public class TinNhan
    {
        private int _MaTN;

        public int MaTN
        {
            get { return _MaTN; }
            set { _MaTN = value; }
        }

        private int _MaSP;

        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private int _Tuan;

        public int Tuan
        {
            get { return _Tuan; }
            set { _Tuan = value; }
        }

        private int _Nam;

        public int Nam
        {
            get { return _Nam; }
            set { _Nam = value; }
        }

        private string _ChuDe;

        public string ChuDe
        {
            get { return _ChuDe; }
            set { _ChuDe = value; }
        }
        private string _NoiDung;

        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }

        public TinNhan (int pMaTN, int pMaSP, int  pTuan, int pNam, string pChuDe, string pNoiDung)
        {
            this.MaTN = pMaTN;
            this.MaSP = pMaSP;
            this.Tuan = pTuan;
            this.Nam = pNam;
            this.ChuDe = pChuDe;
            this.NoiDung = pNoiDung;
        }

    }
}

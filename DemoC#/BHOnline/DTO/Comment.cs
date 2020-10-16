using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Comment
    {
        private int _MaCMT;

        public int MaCMT
        {
            get { return _MaCMT; }
            set { _MaCMT = value; }
        }

        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }

        private int _Sao;

        public int Sao
        {
            get { return _Sao; }
            set { _Sao = value; }
        }

        private string _NoiDung;

        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }

        private string _Loai;

        public string Loai
        {
            get { return _Loai; }
            set { _Loai = value; }
        }

        private int _MaKH;

        public int MaKH
        {
            get { return _MaKH; }
            set { _MaKH = value; }
        }

        private int _MaSP;

        public int MaSP
        {
            get { return _MaSP; }
            set { _MaSP = value; }
        }

        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        public Comment(int pMaCMT, DateTime pNgayLap, int pSao, string pNoiDung, string pLoai, int pMaKH, int pMaSP, string pTrangThai)
        {
            this.MaCMT = pMaCMT;
            this.NgayLap = pNgayLap;
            this.Sao = pSao;
            this.NoiDung = pNoiDung;
            this.Loai = pLoai;
            this.MaKH = pMaKH;
            this.MaSP = pMaSP;
            this.TrangThai = pTrangThai;
        }

    }
}

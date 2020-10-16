using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    class HoaDon
    {

        private int _MaHD;

        public int MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
        }

        private int _MaGH;

        public int MaGH
        {
            get { return _MaGH; }
            set { _MaGH = value; }
        }

        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }
        private string _TrangThai;

        public string TrangThai
        {
            get { return _TrangThai; }
            set { _TrangThai = value; }
        }

        private string _SDT;
        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        private string _Email;

        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private int _MaPT;

        public int MaPT
        {
            get { return _MaPT; }
            set { _MaPT = value; }
        }


        private int _TongTien;

        public int TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
    }
}

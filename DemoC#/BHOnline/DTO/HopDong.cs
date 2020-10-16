using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HopDong
    {
        private int _MaHD;

        public int MaHD
        {
            get { return _MaHD; }
            set { _MaHD = value; }
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

        private string _TenHD;

        public string TenHD
        {
            get { return _TenHD; }
            set { _TenHD = value; }
        }

        private DateTime _NgayLap;

        public DateTime NgayLap
        {
            get { return _NgayLap; }
            set { _NgayLap = value; }
        }

        private DateTime _ThoiHan;

        public DateTime ThoiHan
        {
            get { return _ThoiHan; }
            set { _ThoiHan = value; }
        }

        private string _NoiDung;

        public string NoiDung
        {
            get { return _NoiDung; }
            set { _NoiDung = value; }
        }

        private string _ViTriDang;

        public string ViTriDang
        {
            get { return _ViTriDang; }
            set { _ViTriDang = value; }
        }
   

        public HopDong(int pMaHD, int pMaDT, int pMaNV, string pTenHD, DateTime pNgayLap, DateTime pThoiHan, string pNoidung, string pViTriDang)
        {
            this.MaHD = pMaHD;
            this.MaDT = pMaDT;
            this.MaNV = pMaNV;
            this.TenHD = pTenHD;
            this.NgayLap = pNgayLap;
            this.ThoiHan = pThoiHan;
            this.NoiDung = pNoidung;
            this.ViTriDang = pViTriDang;   
        }
    }
}

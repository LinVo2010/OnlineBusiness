using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NhanVien
    {
        private int _MaNV;

        public int MaNV
        {
            get { return _MaNV; }
            set { _MaNV = value; }
        }

        private string _TenNV;

        public string TenNV
        {
            get { return _TenNV; }
            set { _TenNV = value; }
        }

        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _ChucVu;

        public string ChucVu
        {
            get { return _ChucVu; }
            set { _ChucVu = value; }
        }

        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        public NhanVien(int pMaNV, string pTenNV, string pDiaChi, string pChucVu, string pSDT)
        {
            this.MaNV = pMaNV;
            this.TenNV = pTenNV;
            this.DiaChi = pDiaChi;
            this.ChucVu = pChucVu;
            this.SDT = pSDT;
        }

    }
}

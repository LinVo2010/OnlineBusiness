using DAC;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class DonNhapHangBUS
    {
        private static DonNhapHangBUS instance;
        public static DonNhapHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonNhapHangBUS();
                return instance;
            }
        }

        private DonNhapHangBUS() { }

        public DataTable HienThi()
        {
            return DonNhapHangDAC.Instance.HienThi();
        }

        public int AutoID()
        {
            return DonNhapHangDAC.Instance.AutoID();
        }

        public bool TinhGia(int madnh)
        {
            return DonNhapHangDAC.Instance.TinhGia(madnh);
        }     

        public bool Them(DonNhapHang dth)
        {
            return DonNhapHangDAC.Instance.Them(dth);
        }
    }
}

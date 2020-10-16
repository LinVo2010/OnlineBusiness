using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAC;
using System.Windows.Forms;
using System.Data;

namespace BUS
{
    public class NhanVienBUS
    {  
        private static NhanVienBUS instance;
        public static NhanVienBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienBUS();
                return instance;
            }
        }

        public DataTable HienThi()
        {
            return NhanVienDAC.Instance.HienThi();
        }

        public bool KiemTraTonTai(int manv)
          {
           NhanVien nv = NhanVienDAC.Instance.DocThongTin(manv);
            if (nv == null)
            {
                return true;//Chưa tồn tại 
            }
            return false;
      }

    }
}

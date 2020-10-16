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
    public class LoaiSPBUS
    {
        private static LoaiSPBUS instance;
        public static LoaiSPBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiSPBUS();
                return instance;
            }
        }

        private LoaiSPBUS() { }

        public DataTable HienThi()
        {
            return LoaiSPDAC.Instance.HienThi();
        }

        public int AutoID()
        {
            return LoaiSPDAC.Instance.AutoID();
        }

        
        public bool KiemTraTonTai(int mahd)
        {
            LoaiSP loai = LoaiSPDAC.Instance.DocThongTin(mahd);
            if (loai == null)
            {
                return true;//Chưa tồn tại 
            }
            return false;
        }

        public bool Sua(LoaiSP loai)
        {
            return LoaiSPDAC.Instance.Sua(loai);
        }
        public bool Them(LoaiSP Loai)
        {
            return LoaiSPDAC.Instance.Them(Loai);
        }
    }
}


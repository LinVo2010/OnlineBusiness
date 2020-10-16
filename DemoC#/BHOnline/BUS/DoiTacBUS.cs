using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAC;
using System.Windows.Forms;


namespace BUS
{
    public class DoiTacBUS
    {
        private static DoiTacBUS instance;
        public static DoiTacBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new DoiTacBUS();
                return instance;
            }
        }
        private DoiTacBUS() { }

        public DataTable HienThi()
        {
            return DoiTacDAC.Instance.HienThi();
        }

        public bool KiemTraTonTai(int madt)
        {
            DoiTac hd = DoiTacDAC.Instance.DocThongTin(madt);
            if (hd == null)
            {
                return true;//Chưa tồn tại 
            }
            return false;
        }

        public bool Sua(DoiTac dt)
        {
            return DoiTacDAC.Instance.Sua(dt);
        }

        public bool Them(DoiTac dt)
        {
            return DoiTacDAC.Instance.Them(dt);
        }

        public bool Xoa(int madt)
        {
            return DoiTacDAC.Instance.Xoa(madt);
        }

        public int AutoID()
        {
            return DoiTacDAC.Instance.AutoID();
        }
    }
}

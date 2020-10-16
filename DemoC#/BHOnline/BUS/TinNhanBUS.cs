using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAC;

namespace BUS
{
    public class TinNhanBUS
    {
        private static TinNhanBUS instance;
        public static TinNhanBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TinNhanBUS();
                return instance;
            }
        }
        private TinNhanBUS() { }

        public DataTable HienThi()
        {
            return TinNhanDAC.Instance.HienThi();
        }
        
        public bool Them(TinNhan tn)
        {
            return TinNhanDAC.Instance.Them(tn);
        }

   
       public TinNhan DocThongTin(int pMaTN)
       {
           return TinNhanDAC.Instance.DocThongTin(pMaTN);
       }

        public int TimMaTN(int pMaSP, int pTuan, int pNam)
        {
            return TinNhanDAC.Instance.TimMaTN(pMaSP, pTuan, pNam);
        }
        public int AutoID()
        {
            return TinNhanDAC.Instance.AutoID();
        }

        public bool Sua(TinNhan tn)
        {
            return TinNhanDAC.Instance.Sua(tn);
        }

    }
}

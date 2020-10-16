using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiTac
    {
        private int _MaDT;

        public int MaDT
        {
            get { return _MaDT; }
            set { _MaDT = value; }
        }

        private string _TenDT;

        public string TenDT
        {
            get { return _TenDT; }
            set { _TenDT = value; }
        }

        private string _DiaChi;

        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }

        private string _SDT;

        public string SDT
        {
            get { return _SDT; }
            set { _SDT = value; }
        }

        private string _Gmail;

        public string Gmail
        {
            get { return _Gmail; }
            set { _Gmail = value; }
        }

        public DoiTac(int pMaDT, string pTenDT, string pDiaChi, string pSDT, string pGmail)
        {
            this.MaDT = pMaDT;
            this.TenDT = pTenDT;
            this.DiaChi = pDiaChi;
            this.SDT = pSDT;
            this.Gmail = pGmail;
        }



    }
}

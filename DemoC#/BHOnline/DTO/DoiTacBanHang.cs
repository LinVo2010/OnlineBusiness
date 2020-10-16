using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DoiTacBanHang
    {
        
            private int _MaDTBH;

            public int MaDTBH
            {
                get { return _MaDTBH; }
                set { _MaDTBH = value; }
            }

            private string _TenDTBH;

            public string TenDTBH
            {
                get { return _TenDTBH; }
                set { _TenDTBH = value; }
            }

            private DateTime _NgayBatDauHopTac;

            public DateTime NgayBatDauHopTac
            {
                    get { return _NgayBatDauHopTac; }
                    set { _NgayBatDauHopTac = value; }
            }

        
            public DoiTacBanHang(int pMaDTBH, string pTenDTBH, DateTime pNgayBDHT)
            {
                this.MaDTBH = pMaDTBH;
                this.TenDTBH = pTenDTBH;
                this.NgayBatDauHopTac = pNgayBDHT;
            }

        }
    }

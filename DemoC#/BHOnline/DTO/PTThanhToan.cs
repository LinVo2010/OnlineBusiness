using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
 
            public class PTThanhToan
            {
                private int _MaPT;

                public int MaPT
                {
                    get { return _MaPT; }
                    set { _MaPT = value; }
                }

                private string _TenPT;

                public string TenPT
                {
                    get { return _TenPT; }
                    set { _TenPT = value; }
                }

                public PTThanhToan(int pMaPT, string pTenPT)
                {
                    this.MaPT = pMaPT;
                    this.TenPT = pTenPT;
                }
            }
 
}

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
        public class DoiTacBanHangBUS
        {
        
            private static DoiTacBanHangBUS instance;
            public static DoiTacBanHangBUS Instance
            {
                get
                {
                    if (instance == null)
                        instance = new DoiTacBanHangBUS();
                    return instance;
                }
            }
            private DoiTacBanHangBUS() { }

            public DataTable HienThi()
            {
                return DoiTacBanHangDAC.Instance.HienThi();
            }
        }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;
using DAC;
using System.Globalization;

namespace BUS
{
  public class TinNhan_KhachHangBUS
    {
        private static TinNhan_KhachHangBUS instance;
        public static TinNhan_KhachHangBUS Instance
        {
            get
            {
                if (instance == null)
                    instance = new TinNhan_KhachHangBUS();
                return instance;
            }
        }
        private TinNhan_KhachHangBUS() { }

        public DataTable KhachHangChuaGuiMail(int pMaTN)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaKH", typeof(int));
            table.Columns.Add("TenKH", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("Gmail", typeof(string));
         
            DataTable pKH = KhachHangDAC.Instance.HienThi();
            DataTable pTNKH = TinNhan_KhachHangDAC.Instance.KhachHangDaNhanTin(pMaTN);
            foreach (DataRow item in pKH.Rows)
            {
                int t = 0;
                if (string.IsNullOrEmpty(item["Gmail"].ToString()) == true)
                {
                    t = 1;
                }
                else
                {
                    foreach (DataRow item1 in pTNKH.Rows)
                    {

                        if ((int)item1["MaKH"] == (int)item["MaKH"])
                        {
                            t = 1;
                        }
                    }
                }

                if(t == 0)
                    {
                        DataRow row = table.NewRow();
                        row["MaKH"] = (int)item["MaKH"];
                        row["TenKH"] = item["TenKH"].ToString();
                        row["DiaChi"] = item["DiaChi"].ToString();
                        row["Gmail"] = item["Gmail"].ToString();

                        table.Rows.Add(row);
                    }
            }
            return table;
        }

        public bool Them(TinNhan_KhachHang tnkh)
        {
            return TinNhan_KhachHangDAC.Instance.Them(tnkh);
        }       
    }

}

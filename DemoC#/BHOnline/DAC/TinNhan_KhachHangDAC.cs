using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAC
{
    public class TinNhan_KhachHangDAC
    {
         public static TinNhan_KhachHangDAC instance;
          public static TinNhan_KhachHangDAC Instance
          {
              get
              {
                  if (instance == null)
                      instance = new TinNhan_KhachHangDAC();
                  return instance;
              }
          }
          private TinNhan_KhachHangDAC() { }

        public DataTable KhachHangChuaGuiMail(int pMaTN)
        {
            string query = "SELECT * FROM KHACHHANG KH WHERE KH.Gmail IS NOT NULL AND KH.MaKH NOT IN ( SELECT TNKH.MaKH FROM TINNHAN_KHACHHANG TNKH WHERE TNKH.MaTN = @MaTN )";
            object[] para = new object[] { pMaTN };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            return data;
        }

          public DataTable KhachHangDaNhanTin(int pMaTN)
           {
               string query = "select * from TinNhan_KhachHang WHERE MaTN = @MaTN";
               object[] para = new object[] { pMaTN };
               DataTable data = DataProvider.Instance.ExecuteQuery(query , para);
               return data;
           }
  
           public bool Them(TinNhan_KhachHang tnkh)
           {
               string query = "Insert INTO TinNhan_KhachHang(MaTN, MaKH) VALUES ( @MaTN , @MaKH ) ";
               object[] para = new object[] {tnkh.MaTN , tnkh.MaKH};
               if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                   return true;
               return false;
           }
    }
}


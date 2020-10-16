using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;


namespace DAC
{
    public class TinNhanDAC
    {
        public static TinNhanDAC instance;
        public static TinNhanDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new TinNhanDAC();
                return instance;
            }
        }
        private TinNhanDAC() { }

        public DataTable HienThi()
        {
            string query = "select * from TinNhan";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool Them(TinNhan tn)
        {
            string query = "Insert INTO TinNhan(MaTN, MaSP, Tuan, Nam, ChuDe, NoiDung) VALUES ( @MaTN , @MaSP , @Tuan , @Nam , @ChuDe , @NoiDung ) ";
            object[] para = new object[] { tn.MaTN , tn.MaSP, tn.Tuan, tn.Nam, tn.ChuDe, tn.NoiDung };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public TinNhan DocThongTin(int pMaTN)
        {
            string query = "SELECT * FROM TINNHAN WHERE MaTN = @MaTN ";
            object[] para = new object[] { pMaTN };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaTN = (int)item["MaTN"];
                int MaSP = (int)item["MaSP"];
                int Tuan = (int)item["Tuan"];
                int Nam = (int)item["Nam"];
                string ChuDe = item["ChuDe"].ToString();
                string NoiDung = item["NoiDung"].ToString();

                TinNhan newtn = new TinNhan(MaTN, MaSP, Tuan, Nam, ChuDe, NoiDung);
                return newtn;
            }
            return null;
        }

        public bool Sua(TinNhan tn)
        {
            string query = "Update TinNhan set ChuDe = @ChuDe , NoiDung = @NoiDung Where MaTN = @MaTN ";
            object[] para = new object[] { tn.ChuDe , tn.NoiDung , tn.MaTN };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        
        public int TimMaTN(int pMaSP, int pTuan, int pNam)
        {
            int MaTN = -1;
            string query = "Select MaTN From TinNhan where MaSP = @MaSP AND Tuan = @Tuan AND Nam = @Nam";
            object[] para = new object[] { pMaSP, pTuan, pNam };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                MaTN = (int)item["MaTN"];
            }
            return MaTN;
        }

        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDTinNhan()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAC
{
    public class GioHangDAC
    {
        public static GioHangDAC instance;
        public static GioHangDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new GioHangDAC();
                return instance;
            }
        }
        private GioHangDAC() { }

        public DataTable HienThi()
        {
            string query = "select * from GIOHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public GioHang DocThongTinGHTN(int makh)
        {
            string query = " sp_XemGHTN @MaKH ";
            object[] para = new object[] { makh };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaGH = (int)item["MaGH"];
                int MaKH = (int)item["MaKH"];
                int TongTien = (int)item["TongTien"];
                string TrangThai = item["TrangThai"].ToString();

                GioHang newkh = new GioHang(MaGH, MaKH, TongTien, TrangThai);
                return newkh;
            }
            return null;
        }
        public bool Them(int MaGH, int MaKH)
        {
            string query = " sp_ThemMoiGH @MaGH , @MaKH ";
            object[] para = new object[] { MaGH, MaKH };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDGH() ";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }
        public int LayMaGH (int pMaKH)
        {
            string query = "SELECT dbo.fn_LayMaGH( @MaKH )";
            object[] para = new object[] { pMaKH };
            object ID = DataProvider.Instance.ExecuteScalar(query, para);
            return (int)ID;
        }
        public bool Sua(int pMaGH)
        {
            string query = " sp_CapNhatTinhTrangGH @MaGH "; 
            object[] para = new object[] { pMaGH };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;

        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    public class LoaiSPDAC
    {
        public static LoaiSPDAC instance;
        public static LoaiSPDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new LoaiSPDAC();
                return instance;
            }
        }
        private LoaiSPDAC() { }

        public DataTable HienThi()
        {
            string query = "select * from LOAISANPHAM";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool Them(LoaiSP dt)
        {
            string query = "Insert INTO LOAISANPHAM( MaLoai , TenLoai ) VALUES ( @MaLoai , @TenLoai ) ";
            object[] para = new object[] { dt.MaLoai, dt.TenLoai};
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Sua(LoaiSP dt)
        {
            string query = "Update LOAISANPHAM set TenLoai = @TenLoai  Where MaLoai = @MaLoai ";
            object[] para = new object[] { dt.TenLoai, dt.MaLoai };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;

        }
        public LoaiSP DocThongTin(int maLoai)
        {
            string query = "Select * From LOAISANPHAM where MaLoai = @MaLoai ";
            object[] para = new object[] { maLoai };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaLoai = (int)item["MaLoai"];
                string TenLoai = item["TenLoai"].ToString();
               
                LoaiSP newloai = new LoaiSP(MaLoai, TenLoai);
                return newloai;
            }
            return null;
        }
        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDLoaiSanPham()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }
    }
}

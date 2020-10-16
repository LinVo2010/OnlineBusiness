using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAC
{
    public class CTGioHangDAC
    {
        public static CTGioHangDAC instance;
        public static CTGioHangDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTGioHangDAC();
                return instance;
            }
        }
        private CTGioHangDAC() { }

        public DataTable HienThi(int pMaKH)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaGH", typeof(int));
            table.Columns.Add("MaCTGH", typeof(int));
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("ThanhTien", typeof(int));
            table.Columns.Add("TongTien", typeof(int));
            string query = "sp_HienThiGioHang @MaKH";
            object[] para = new object[] { pMaKH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaGH"] = (int)item["MaGH"];
                row["MaCTGH"] = (int)item["MaCTGH"];
                row["MaSP"] = (int)item["MaSP"];
                row["TenSP"] = item["TenSP"].ToString();
                row["SoLuong"] = (int)item["SoLuong"];
                row["ThanhTien"] = (int)item["ThanhTien"];
                row["TongTien"] = (int)item["TongTien"];
                table.Rows.Add(row);
            }
            return table;
        }
        public bool Sua(int MaGH, int MaCTGH, int MaSP, int SL)
        {
            string query = "sp_thaydoiCTGH @MaGH , @MaCTGH , @MaSP , @SL ";
            object[] para = new object[] { MaGH, MaCTGH, MaSP, SL };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public bool Xoa (int MaGH, int MaCTGH)
        {
            string query = "sp_XoaCTGH @MaGH , @MaCTGH ";
            object[] para = new object[] { MaGH, MaCTGH };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public bool Them(int MaCTGH, int MaGH, int MaSP, int SL)
        {
            string query = "sp_ThemCTGH @MaCTGH , @MaGH , @MaSP , @SL ";
            object[] para = new object[] { MaCTGH, MaGH, MaSP, SL };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDCTGH()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }
        public DataTable HienThiGioHang_CTT(int pMaKH)
        {
            DataTable table = new DataTable();
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("Gia", typeof(int)); 
            table.Columns.Add("ThanhTien", typeof(int));
            string query = "sp_HienThiGioHang_CTT @MaKH";
            object[] para = new object[] { pMaKH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);

            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["TenSP"] = item["TenSP"].ToString();
                row["SoLuong"] = (int)item["SoLuong"];
                row["Gia"] = (int)item["Gia"];          
                row["ThanhTien"] = (int)item["ThanhTien"];
                table.Rows.Add(row);
            }
            return table;
        }
    }
}

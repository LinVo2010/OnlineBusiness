using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAC
{
   public class KhachHangDAC
    {
        public static KhachHangDAC instance;
        public static KhachHangDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new KhachHangDAC();
                return instance;
            }
        }
        private KhachHangDAC() { }

        public DataTable HienThi()
        {
            string query = "select * from KhachHang";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public KhachHang DocThongTin(int makh, string sdt)
        {
            string query = "Select * From KHACHHANG where MaKH = @MaKH and SDT = @SDT ";
            object[] para = new object[] { makh, sdt };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaKH = (int)item["MaKH"];
                string TenKH = item["TenKH"].ToString();
                string DiaChi = item["DiaChi"].ToString();
                string SDT = item["SDT"].ToString();
                string Gmail = item["Gmail"].ToString();

                KhachHang newkh = new KhachHang(MaKH, TenKH, DiaChi, SDT, Gmail);
                return newkh;
            }
            return null;
        }
        public DataTable LayTTKH (int pMakH)
        {
            string query = "Select * From KHACHHANG where MaKH = @MaKH ";
            object[] para = new object[] { pMakH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            return data;
        }

        public DataTable LayThongTinKH(int pMaKH)
        {
            DataTable table = new DataTable();
            table.Columns.Add("TenKH", typeof(string));
            table.Columns.Add("SDT", typeof(string));
            table.Columns.Add("DiaChi", typeof(string));
            table.Columns.Add("Gmail", typeof(string));

            string query = " sp_LayThongTinKH @MaKH";
            object[] para = new object[] { pMaKH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["TenKH"] = item["TenKH"].ToString();
                row["SDT"] = item["SDT"].ToString();
                row["DiaChi"] = item["DiaChi"].ToString();
                row["Gmail"] = item["Gmail"].ToString();
                table.Rows.Add(row);
            }
            return table;
        }

        public string LayTenKH(int pMaKH)
        {
            string query = "SELECT TenKH FROM KHACHHANG WHERE MaKH = @MaKH ";
            object[] para = new object[] { pMaKH };
            object tenKH = DataProvider.Instance.ExecuteScalar(query, para);
            return (string)tenKH;
        }
    }
}


using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;

namespace DAC
{
    public class DonTraHangDAC
    {
        public static DonTraHangDAC instance;
        public static DonTraHangDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonTraHangDAC();
                return instance;
            }
        }

        private DonTraHangDAC() { }

        public DataTable HienThi()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaDTH", typeof(int));
            table.Columns.Add("MaNV", typeof(int));
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("NgayLap", typeof(DateTime));
            table.Columns.Add("MaDTBH", typeof(int));
            table.Columns.Add("TenDT", typeof(string));
            table.Columns.Add("LyDoTra", typeof(string));
       
            string query = "select dth.MaDTH, dth.MaNV, nv.TenNV, dth.NgayLap, dth.MaDTBH,dtbh.TenDT, dth.LyDoTra from DONTRAHANG dth, DoiTacBanHang dtbh, NhanVien nv where dth.MaDTBH = dtbh.MaDT AND dth.MaNV = nv.MaNV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaDTH"] = (int)item["MaDTH"];
                row["MaNV"] = (int)item["MaNV"];
                row["TenNV"] = item["TenNV"].ToString();
                row["NgayLap"] = item["NgayLap"].ToString();
                row["MaDTBH"] = (int)item["MaDTBH"];
                row["TenDT"] = item["TenDT"].ToString();
                row["LyDoTra"] = item["LyDoTra"].ToString();
                
                table.Rows.Add(row);
            }
            return table;
        }

        public bool Xoa(int madth)
        {
            string query = "DELETE FROM DonTraHang Where MaDTH = @MaDTH ";
            object[] para = new object[] { madth };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDDonTraHang()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }

        public DonTraHang DocThongTin(int madth)
        {
            string query = "Select * From DonTraHang where MaDTH = @MaDTH ";
            object[] para = new object[] { madth };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaDTH = (int)item["MaDTH"];
                int MaNV = (int)item["MaNV"];
                DateTime NgayLap = DateTime.Parse(item["NgayLap"].ToString());
                int MaDT = (int)item["MaDTBH"];
                string Lydo= item["LyDoTra"].ToString();

                DonTraHang newhd = new DonTraHang(MaDTH, MaNV, MaDT, NgayLap, Lydo);
                return newhd;
            }
            return null;
        }

        public bool Sua(DonTraHang dth)
        {
            string query = "Update DONTRAHANG set MaNV = @MaNV , NgayLap = @NgayLap , MaDTBH = @MaDTBH , LyDoTra = @LyDoTra Where MaDTH = @MaDTH ";
            object[] para = new object[] { dth.MaNV, dth.NgayLap, dth.MaDT, dth.LyDo, dth.MaDTH };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
     
        public bool Them(DonTraHang dth)
        {
            string query = "Insert INTO DonTraHang( MaDTH , MaNV ,  NgayLap , MaDTBH, LyDoTra) VALUES (  @MaDTH , @MaNV , @NgayLap , @MaDTBH , @LyDoTra ) ";
            object[] para = new object[] { dth.MaDTH, dth.MaNV, dth.NgayLap, dth.MaDT, dth.LyDo };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}

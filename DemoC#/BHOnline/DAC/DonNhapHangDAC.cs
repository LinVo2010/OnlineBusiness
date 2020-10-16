using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    public class DonNhapHangDAC
    {
        public static DonNhapHangDAC instance;
        public static DonNhapHangDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new DonNhapHangDAC();
                return instance;
            }
        }

        private DonNhapHangDAC() { }

         
        public DataTable HienThi()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaDNH", typeof(int));
            table.Columns.Add("MaDTBH", typeof(int));
            table.Columns.Add("TenDT", typeof(string));
            table.Columns.Add("MaNV", typeof(int));
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("NgayLap", typeof(DateTime));
            table.Columns.Add("LyDoNhap", typeof(string));
            table.Columns.Add("TongTien", typeof(int));

            string query = "select dth.MaDNH,  dth.MaDTBH,dtbh.TenDT, dth.MaNV, nv.TenNV, dth.NgayLap, dth.LyDoNhap, dth.TongTien from DONNHAPHANG dth, DoiTacBanHang dtbh, NhanVien nv where dth.MaDTBH = dtbh.MaDT AND dth.MaNV = nv.MaNV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaDNH"] = (int)item["MaDNH"];
                row["MaDTBH"] = (int)item["MaDTBH"];
                row["TenDT"] = item["TenDT"].ToString();
                row["MaNV"] = (int)item["MaNV"];
                row["TenNV"] = item["TenNV"].ToString();
                row["NgayLap"] = item["NgayLap"].ToString();
                row["LyDoNhap"] = item["LyDoNhap"].ToString();
                row["TongTien"] = (int)item["TongTien"];
                table.Rows.Add(row);
            }
            return table;
        }

        
        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDDonNhapHang()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }
        

        public DonNhapHang DocThongTin(int madth)
        {
            string query = "Select * From DonNhapHang where MaDTH = @MaDTH ";
            object[] para = new object[] { madth };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaDNH = (int)item["MaDNH"];
                int MaDT = (int)item["MaDTBH"];
                int MaNV = (int)item["MaNV"];
                DateTime NgayLap = DateTime.Parse(item["NgayLap"].ToString());
                string Lydo = item["LyDoNhap"].ToString();
                int TongTien = (int)item["TongTien"];

                DonNhapHang newdnh = new DonNhapHang(MaDNH, MaDT, MaNV, NgayLap, Lydo, TongTien);
                return newdnh;
            }
            return null;
        }

        public bool Them(DonNhapHang dnh)
        {
            string query = "Insert INTO DonNhapHang( MaDNH, MaDTBH, MaNV, NgayLap, LydoNhap, TongTien) VALUES (  @MaDTH , @MaDTBH ,  @MaNV , @NgayLap  , @LyDoNhap , @TongTien ) ";
            object[] para = new object[] { dnh.MaDNH, dnh.MaDT, dnh.MaNV, dnh.NgayLap, dnh.LyDo, dnh.TongTien };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public bool TinhGia(int madnh)
        {
            string query = " sp_CapNhatTongTienDNH  @MaDNH  ";
            object[] para = new object[] { madnh };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}


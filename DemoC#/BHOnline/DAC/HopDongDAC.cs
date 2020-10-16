using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;

namespace DAC
{
    public class HopDongDAC
    {
        public static HopDongDAC instance;
        public static HopDongDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new HopDongDAC();
                return instance;
            }
        }
        private HopDongDAC() { }

        public DataTable HienThi()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaHD", typeof(int));
            table.Columns.Add("TenHD", typeof(string));
            table.Columns.Add("MaDT", typeof(int));
            table.Columns.Add("TenDT", typeof(string));
            table.Columns.Add("MaNV", typeof(int));
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("NgayLap", typeof(DateTime));
            table.Columns.Add("ThoiHan", typeof(DateTime));
            table.Columns.Add("ViTriDang", typeof(string));
            table.Columns.Add("NoiDung", typeof(string));
            table.Columns.Add("Gmail", typeof(string));

            string query = "select hd.MaHD, hd.TenHD, hd.MaDT, dt.TenDT, hd.MaNV, nv.TenNV, hd.NgayLap, hd.ThoiHan, hd.ViTriDang, hd.NoiDung, dt.Gmail from HopDong hd, DoiTac dt, NhanVien nv where hd.MaDT = dt.MaDT AND hd.MaNV = nv.MaNV";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaHD"] = (int)item["MaHD"];
                row["TenHD"] = item["TenHD"].ToString();
                row["MaDT"] = (int)item["MaDT"];
                row["TenDT"] = item["TenDT"].ToString();
                row["MaNV"] = (int)item["MaNV"];
                row["TenNV"] = item["TenNV"].ToString();
                row["NgayLap"] = item["NgayLap"].ToString();
                row["ThoiHan"] = item["ThoiHan"].ToString();
                row["ViTriDang"] = item["ViTriDang"].ToString();
                row["NoiDung"] = item["NoiDung"].ToString();
                row["Gmail"] = item["Gmail"].ToString();

                table.Rows.Add(row);
            }
            return table;
        }

        public bool Them(HopDong hd)
        {
            string query = "Insert INTO HOPDONG( MaHD , MaDT , MaNV, TenHD,  NgayLap , ThoiHan, NoiDung, ViTriDang ) VALUES (  @MaHD , @MaDT , @MaNV , @TenHD ,  @NgayLap , @ThoiHan , @NoiDung , @ViTriDang ) ";
            object[] para = new object[] { hd.MaHD, hd.MaDT, hd.MaNV, hd.TenHD, hd.NgayLap, hd.ThoiHan, hd.NoiDung, hd.ViTriDang };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Sua(HopDong hd)
        {
            string query = "Update HOPDONG set  MaDT = @MaDT , MaNV = @MaNV , TenHD = @TenHD ,  NgayLap = @NgayLap , ThoiHan = @ThoiHan , NoiDung = @NoiDung , ViTriDang = @ViTriDang Where MaHD = @MaHD ";
            object[] para = new object[] {  hd.MaDT, hd.MaNV, hd.TenHD, hd.NgayLap , hd.ThoiHan , hd.NoiDung , hd.ViTriDang , hd.MaHD};
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Xoa(int mahd)
        {
            string query = "DELETE FROM HopDong Where MaHD = @MaHD ";
            object[] para = new object[] { mahd };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public HopDong DocThongTin(int mahd)
        {
            string query = "Select * From HopDong where MaHD = @MaHD ";
            object[] para = new object[] { mahd };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaHD = (int)item["MaHD"];
                string TenHD = item["MaNV"].ToString();
                int MaDT = (int)item["MaDT"];
                int MaNV = (int)item["MaNV"];
           
                DateTime NgayLap = DateTime.Parse(item["NgayLap"].ToString());
                DateTime ThoiHan = DateTime.Parse(item["ThoiHan"].ToString());
                string NoiDung = item["NoiDung"].ToString();
                string ViTriDang = item["ViTriDang"].ToString();

                HopDong newhd = new HopDong(MaHD, MaDT, MaNV, TenHD, NgayLap, ThoiHan, NoiDung, ViTriDang);
                return newhd;
            }
            return null;
        }

        public DataTable TimHopDongTheoThoiHan(int pNgay, int pThang , int pNam)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaHD", typeof(int));
            table.Columns.Add("TenHD", typeof(string));
            table.Columns.Add("MaDT", typeof(int));
            table.Columns.Add("TenDT", typeof(string));
            table.Columns.Add("MaNV", typeof(int));
            table.Columns.Add("TenNV", typeof(string));
            table.Columns.Add("NgayLap", typeof(DateTime));
            table.Columns.Add("ThoiHan", typeof(DateTime));
            table.Columns.Add("ViTriDang", typeof(string));
            table.Columns.Add("NoiDung", typeof(string));
            table.Columns.Add("Gmail", typeof(string));

            string query = "select hd.MaHD, hd.TenHD, hd.MaDT, dt.TenDT, hd.MaNV, nv.TenNV, hd.NgayLap, hd.ThoiHan, hd.ViTriDang, hd.NoiDung , dt.Gmail from HopDong hd, DoiTac dt, NhanVien nv where hd.MaDT = dt.MaDT AND hd.MaNV = nv.MaNV AND  Day(hd.ThoiHan) = @Ngay AND Month(hd.ThoiHan) = @Thang AND Year(hd.ThoiHan) = @Nam ";
            object[] para = new object[] { pNgay, pThang, pNam };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaHD"] = (int)item["MaHD"];
                row["TenHD"] = item["TenHD"].ToString();
                row["MaDT"] = (int)item["MaDT"];
                row["TenDT"] = item["TenDT"].ToString();
                row["MaNV"] = (int)item["MaNV"];
                row["TenNV"] = item["TenNV"].ToString();
                row["NgayLap"] = item["NgayLap"].ToString();
                row["ThoiHan"] = item["ThoiHan"].ToString();
                row["ViTriDang"] = item["ViTriDang"].ToString();
                row["NoiDung"] = item["NoiDung"].ToString();
                row["Gmail"] = item["Gmail"].ToString();

                table.Rows.Add(row);
            }
            return table;
        }

        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDHopDong()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }

    }
}

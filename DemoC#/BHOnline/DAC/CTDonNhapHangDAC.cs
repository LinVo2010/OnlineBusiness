using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    public class CTDonNhapHangDAC
    {

        public static CTDonNhapHangDAC instance;
        public static CTDonNhapHangDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTDonNhapHangDAC();
                return instance;
            }
        }

        private CTDonNhapHangDAC() { }

        public bool TinhGia(int madnh, int masp)
        {
            string query = " sp_CapNhatGiaCTDNH  @MaDNH , @MaSP ";
            object[] para = new object[] { madnh , masp };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public DataTable HienThi()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaDNH", typeof(int));
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("Gia", typeof(int));

            string query = "select dnh.MaDNH, sp.MaSP, SP.TENSP, ctdnh.SoLuong, SP.Gia from DONNHAPHANG dnh, CTDONNHAPHANG ctdnh, SANPHAM sp where ctdnh.MaSP=sp.MaSP and dnh.MaDNH=ctdnh.MaDNH";

            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaDNH"] = (int)item["MaDNH"];
                row["MaSP"] = (int)item["MaSP"];
                row["TenSP"] = item["TenSP"].ToString();
                row["SoLuong"] = (int)item["SoLuong"];
                row["Gia"] = (int)item["Gia"];
                table.Rows.Add(row);
            }
            return table;
        }

        public DataTable HienThiTheoBien(int pMaDNH)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaDNH", typeof(int));
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("Gia", typeof(int));

            string query = "select dnh.MaDNH, sp.MaSP, SP.TENSP, ctdnh.SoLuong, ctdnh.Gia from DONNHAPHANG dnh, CTDONNHAPHANG ctdnh, SANPHAM sp where ctdnh.MaSP=sp.MaSP and dnh.MaDNH=ctdnh.MaDNH and dnh.MaDNH = @MaDNH ";
            object[] para = new object[] { pMaDNH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaDNH"] = (int)item["MaDNH"];
                row["MaSP"] = (int)item["MaSP"];
                row["TenSP"] = item["TenSP"].ToString();
                row["SoLuong"] = (int)item["SoLuong"];
                row["Gia"] = (int)item["Gia"];
                table.Rows.Add(row);
            }
            return table;
        }

        public CTDonNhapHang DocThongTin(int madnh, int masp)
        {
            string query = "Select * From CTDonNhapHang where MaDNH = @MaDNH and MaSP = @MaSP";
            object[] para = new object[] { madnh, masp };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaDNH = (int)item["MaDNH"];
                int MaSP = (int)item["MaSP"];
                int SoLuong = (int)item["SoLuong"];
                int Gia = (int)item["Gia"];

                CTDonNhapHang newct = new CTDonNhapHang(MaDNH, MaSP, SoLuong, Gia);
                return newct;
            }
            return null;
        }
        
        public DataTable TimThongTin(int pmadth)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaDTH", typeof(int));
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));
            table.Columns.Add("Gia", typeof(int));

            string query = "Select ct.MaDNH, ct.MaSP, sp.TenSP, ct.SoLuong, ct.Gia From CTDonNhapHang ct, SANPHAM sp where ct.maSP = sp.MaSP and ct.MaDTH = @MaDTH";
            object[] para = new object[] { pmadth };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaDTH"] = (int)item["MaDTH"];
                row["MaSP"] = (int)item["MaSP"];
                row["TenSP"] = item["TenSP"].ToString();
                row["SoLuong"] = (int)item["SoLuong"];
                row["Gia"] = (int)item["Gia"];

                table.Rows.Add(row);

            }
            return table;
        }


        public bool Them(CTDonNhapHang dnh)
        {
            string query = "Insert INTO CTDonNhapHang( MaDNH , MaSP , SoLuong , Gia ) VALUES (  @MaDNH , @MaSP , @SoLuong , @Gia ) ";
            object[] para = new object[] { dnh.MaDNH, dnh.MaSP, dnh.SoLuong, dnh.Gia };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
    }
}

using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{

    public class CTDonTraHangDAC
    {
        public static CTDonTraHangDAC instance;
        public static CTDonTraHangDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new CTDonTraHangDAC();
                return instance;
            }
        }

        private CTDonTraHangDAC() { }


        public DataTable HienThi()
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaDTH", typeof(int));
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));

            string query = "select ctdth.MaDTH, sp.MaSP, SP.TENSP, ctdth.SoLuong from DONTRAHANG dth, CTDONTRAHANG ctdth, SANPHAM sp where ctdth.MaSP=sp.MaSP and dth.MaDTH=ctdth.MaDTH";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaDTH"] = (int)item["MaDTH"];
                row["MaSP"] = (int)item["MaSP"];
                row["TenSP"] = item["TenSP"].ToString();
                row["SoLuong"] = (int)item["SoLuong"];
                table.Rows.Add(row);
            }
            return table;
        }
        public DataTable HienThiTheoBien(int pMaDTH)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaDTH", typeof(int));
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));

           string query = "select ctdth.MaDTH, sp.MaSP, SP.TENSP, ctdth.SoLuong from DONTRAHANG dth, CTDONTRAHANG ctdth, SANPHAM sp where ctdth.MaSP=sp.MaSP and dth.MaDTH=ctdth.MaDTH and dth.MaDTH = @MaDTH ";
            object[] para = new object[] { pMaDTH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaDTH"] = (int)item["MaDTH"];
                row["MaSP"] = (int)item["MaSP"];
                row["TenSP"] = item["TenSP"].ToString();
                row["SoLuong"] = (int)item["SoLuong"];
                table.Rows.Add(row);
            }
            return table;
        }
        public CTDonTraHang DocThongTin(int madth, int masp)
        {
            string query = "Select * From CTDonTraHang where MaDTH = @MaDTH and MaSP = @MaSP";
            object[] para = new object[] { madth, masp };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaDTH = (int)item["MaDTH"];
                int MaSP = (int)item["MaSP"];
                int SoLuong = (int)item["SoLuong"];

                CTDonTraHang newct = new CTDonTraHang(MaDTH, MaSP, SoLuong);
                return newct;
            }
            return null;
        }
        ///
        public DataTable TimThongTin(int pmadth)
        {
            DataTable table = new DataTable();
            table.Columns.Add("MaDTH", typeof(int));
            table.Columns.Add("MaSP", typeof(int));
            table.Columns.Add("TenSP", typeof(string));
            table.Columns.Add("SoLuong", typeof(int));

            string query = "Select ct.MaDTH, ct.MaSP, sp.TenSP, ct.SoLuong From CTDonTraHang ct,SANPHAM sp where ct.maSP = sp.MaSP and ct.MaDTH = @MaDTH";
            object[] para = new object[] { pmadth};
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();
                row["MaDTH"] = (int)item["MaDTH"];
                row["MaSP"] = (int)item["MaSP"]; 
                row["TenSP"] = item["TenSP"].ToString();
                row["SoLuong"] = (int)item["SoLuong"];

                table.Rows.Add(row);
  
            }
            return table;
        }

        
        public bool Them(CTDonTraHang dth)
        {
            string query = "Insert INTO CTDonTraHang( MaDTH , MaSP, SoLuong) VALUES (  @MaDTH , @MaSP , @SoLuong ) ";
            object[] para = new object[] { dth.MaDTH, dth.MaSP, dth.SoLuong };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Xoa(int madth, int masp)
        {
            string query = "DELETE FROM CTDONTRAHANG Where MaDTH = @MaDTH AND MASP = @MASP ";
            object[] para = new object[] { madth, masp };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public bool Sua(CTDonTraHang dth)
        {
            string query = "Update CTDONTRAHANG set SoLuong = @SoLuong Where MaDTH = @MaDTH and MaSP = @MaSP ";
            object[] para = new object[] { dth.SoLuong, dth.MaDTH, dth.MaSP};
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

    }
        
}

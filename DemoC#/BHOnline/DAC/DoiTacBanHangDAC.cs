using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAC
{
    public class DoiTacBanHangDAC
    {
        public static DoiTacBanHangDAC instance;
        public static DoiTacBanHangDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new DoiTacBanHangDAC();
                return instance;
            }
        }
        private DoiTacBanHangDAC() { }

        public DataTable HienThi()
        {
            string query = "select * from DOITACBANHANG";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool Them(DoiTacBanHang dt)
        {
            string query = "Insert INTO DoiTacBanHang( MaDT , TenDT , NgayBatDauHopTac ) VALUES (  @MaDT , @TenDT , @NgayBatDauHopTac) ";
            object[] para = new object[] { dt.MaDTBH, dt.TenDTBH, dt.NgayBatDauHopTac};
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Sua(DoiTacBanHang dt)
        {
            string query = "Update DoiTacBanHang set TenDT = @TenDT ,  NgayBatDauHopTac=@NgayBatDauHopTac Where MaDT = @MaDT ";
            object[] para = new object[] { dt.TenDTBH, dt.NgayBatDauHopTac};
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Xoa(int madt)
        {
            string query = "DELETE FROM DoiTacBanHang Where MaDT = @MaDT ";
            object[] para = new object[] { madt };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public DoiTacBanHang DocThongTin(int madt)
        {
            string query = "Select * From DoiTacBanHang where MaDT = @MaDT ";
            object[] para = new object[] { madt };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaDT = (int)item["MaDT"];
                string TenDT = item["TenDT"].ToString();
                DateTime NgayBatDauHopTac = DateTime.Parse(item["NgayBatDauHopTac"].ToString());
                DoiTacBanHang newdt = new DoiTacBanHang(MaDT, TenDT, NgayBatDauHopTac);
                return newdt;
            }
            return null;
        }
    }
}


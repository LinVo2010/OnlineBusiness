using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAC
{
    public class DoiTacDAC
    {
        public static DoiTacDAC instance;
        public static DoiTacDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new DoiTacDAC();
                return instance;
            }
        }
        private DoiTacDAC() { }

        public DataTable HienThi()
        {
            string query = "select * from DoiTac";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public bool Them(DoiTac dt)
        {
            string query = "Insert INTO DoiTac( MaDT , TenDT ,  DiaChi , SDT , Gmail ) VALUES (  @MaDT , @TenDT , @DiaChi , @SDT , @Gmail ) ";
            object[] para = new object[] {dt.MaDT , dt.TenDT , dt.DiaChi , dt.SDT , dt.Gmail};
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Sua(DoiTac dt)
        {
            string query = "Update DoiTac set TenDT = @TenDT ,  DiaChi = @DiaChi , SDT = @SDT , Gmail = @Gmail Where MaDT = @MaDT ";
            object[] para = new object[] { dt.TenDT , dt.DiaChi , dt.SDT ,  dt.Gmail , dt.MaDT };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Xoa(int madt)
        {
            string query = "DELETE FROM DoiTac Where MaDT = @MaDT ";
            object[] para = new object[] { madt };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public DoiTac DocThongTin(int madt)
        {
            string query = "Select * From DoiTac where MaDT = @MaDT ";
            object[] para = new object[] { madt };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaDT = (int)item["MaDT"];
                string TenDT = item["TenDT"].ToString();
                string DiaChi = item["DiaChi"].ToString();
                string SDT = item["SDT"].ToString();
                string Gmail = item["Gmail"].ToString();
                DoiTac newdt = new DoiTac(MaDT, TenDT, DiaChi, SDT , Gmail);
                return newdt;
            }
            return null;
        }

        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDDoiTac()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }


    }
}

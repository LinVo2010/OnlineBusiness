using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;


namespace DAC
{
    public class NhanVienDAC
    {
        public static NhanVienDAC instance;
        public static NhanVienDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new NhanVienDAC();
                return instance;
            }
        }
        private NhanVienDAC() { }

        public DataTable HienThi()
        {
            string query = "select * from NhanVien";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }

        public NhanVien DocThongTin(int manv)
        {
            string query = "Select * From NhanVien where MaNV = @MaNV ";
            object[] para = new object[] { manv };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaNV = (int)item["MaNV"];
                string TenNV = item["TenNV"].ToString();
                string DiaChi = item["DiaChi"].ToString();
                string ChucVu = item["ChucVu"].ToString();
                string SDT = item["SDT"].ToString();
                NhanVien newnv = new NhanVien( MaNV , TenNV , DiaChi , ChucVu , SDT );
                return newnv;
            }
            return null;
        }
    }
}

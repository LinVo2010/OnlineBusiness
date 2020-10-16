using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAC
{
    public class HoaDonDAC
    {
        public static HoaDonDAC instance;
        public static HoaDonDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new HoaDonDAC();
                return instance;
            }
        }

        private HoaDonDAC() { }

        public bool Them(int MaHD, int MaGH)
        {
            string query = " sp_ThemMoiHD @MaHD , @MaGH ";
            object[] para = new object[] { MaHD, MaGH };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }
        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDHD()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }
        public DataTable HienThiLichSuHD(int pMaKH)
        {
            string query = "sp_DSHD @MaKH ";
            object[] para = new object[] { pMaKH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            return data;
        }


        public DataTable DocTTHDChuaXacNhan(int pMaKH)
        {
            string query = "sp_DocTTHDChuaXacNhan @MaKH ";
            object[] para = new object[] { pMaKH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            return data;
        }

        public bool CapNhatTTinHD (int pMaKH, string pSDT, string pGmail, string pDiaChi)
        {
            string query = " sp_CapNhatTTinHD @MaKH , @SDT , @Gmail , @DiaChi ";
            object[] para = new object[] { pMaKH, pSDT, pGmail, pDiaChi };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public DataTable LayThongTinHD(int pMaKH)
        {
            DataTable table = new DataTable();
            table.Columns.Add("TongTien", typeof(int));
            table.Columns.Add("TongSP", typeof(int));

            string query = "exec sp_LayThongTinHD @MaKH";
            object[] para = new object[] { pMaKH };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                DataRow row = table.NewRow();

                row["TongTien"] = (int)item["TongTien"];
                row["TongSP"] = (int)item["TongSP"];

                table.Rows.Add(row);
            }
            return table;
        }

        public bool CapNhapPTTT_The(int pMaKH)
        {
            string query = "select dbo.fn_KiemTraHoaDon ( @MaKH ) ";
            object temp = DataProvider.Instance.ExecuteScalar(query, new object[] { pMaKH });
            if ((int)temp > 0)
            {
                string query1 = " sp_CapNhapPTTT_The @MaKH ";
                DataTable result = DataProvider.Instance.ExecuteQuery(query1, new object[] { pMaKH });
                return true;
            }
            return false;
        }

        public bool CapNhapPTTT_Tien(int pMaKH)
        {
            string query = "select dbo.fn_KiemTraHoaDon ( @MaKH ) ";
            object temp = DataProvider.Instance.ExecuteScalar(query, new object[] { pMaKH });
            if ((int)temp > 0)
            {
                string query1 = " sp_CapNhapPTTT_Tien @MaKH ";
                DataTable result = DataProvider.Instance.ExecuteQuery(query1, new object[] { pMaKH });
                return true;
            }
            return false;
        }

        public bool CapNhapTrangThai(int pMaKH)
        {
            string query = "select dbo.fn_KiemTraHoaDon ( @MaKH ) ";
            object temp = DataProvider.Instance.ExecuteScalar(query, new object[] { pMaKH });
            if ((int)temp > 0)
            {
                string query1 = " sp_CapNhapTrangThai @MaKH ";
                DataTable result = DataProvider.Instance.ExecuteQuery(query1, new object[] { pMaKH });
                return true;
            }
            return false;
        }

        public DataTable HienThiHD(int pMaKH)
        {
            string query = " sp_HienThiHD @MaKH ";
            DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { pMaKH });
            return result;
        }
    }
}

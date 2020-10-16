using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;


namespace DAC
{
    public class SanPhamDAC
    {
        public static SanPhamDAC instance;
        public static SanPhamDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new SanPhamDAC();
                return instance;
            }
        }
        private SanPhamDAC() { }

        public DataTable HienThi()
        {
            string query = "select * from SanPham";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            return data;
        }
        public DataTable XemTTSP(string pTenSP)
        {
            string query = "SELECT * FROM SANPHAM WHERE TenSP LIKE @TenSP ";
            object[] para = new object[] {'%' + pTenSP + '%'};
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            return data;
        }
        //Hàm đọc thông tin số lượng sản phẩm hiện có
        public int DocThongTinSLTon (int pMaSP)
        {
            string query = "select dbo.fn_LaySL( @MaSP )";
            object[] para = new object[] { pMaSP };
            object sl = DataProvider.Instance.ExecuteScalar(query, para);
            return (int)sl;
        }

        public DataTable HienThiDSThieuHang(int dem)
        {
            string query = "select * from SanPham where SoLuongTon < @dem and SoLuongTon > 0 ";
            object[] para = new object[] { dem };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            return data;
        }

        public int KiemTraThieuHang(int dem)
        {
            string query = " select dbo.fn_KiemTra_ThieuHang( @dem ) ";
            object[] para = new object[] { dem };
            object ID = DataProvider.Instance.ExecuteScalar(query, para);
            return (int)ID;
        }
        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDSanPham()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }

        public SanPham DocThongTin(int masp)
        {
            string query = "Select * From SanPham where MaSP = @MaSP ";
            object[] para = new object[] { masp };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaSP = (int)item["MaSP"];
                string TenSP = item["TenSP"].ToString();
                string MoTa = item["MoTa"].ToString();
                int MaLoai = (int)item["MaLoai"];
                int SoLuongTon = (int)item["SoLuongTon"];
                int Gia = (int)item["Gia"];

                SanPham newsp = new SanPham(MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia);
                return newsp;
            }
            return null;
        }
        public bool Them(SanPham sp)
        {
            string query = "Insert INTO SANPHAM ( MaSP , TenSP , MoTa , MaLoai , SoLuongTon , Gia ) VALUES ( @MaSP , @TenSP , @MoTa , @MaLoai , @SoLuongTon , @Gia ) ";
            object[] para = new object[] { sp.MaSP, sp.TenSP, sp.MoTa, sp.MaLoai, sp.soLuongTon, sp.Gia };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public bool Sua(SanPham sp)
        {
            string query = "Update SANPHAM set TenSP = @TenSP , MoTa = @MoTa , MaLoai = @MaLoai , SoLuongTon = @SoLuongTon , Gia = @Gia  Where MaSP = @MaSP ";
            object[] para = new object[] { sp.TenSP, sp.MoTa, sp.MaLoai, sp.soLuongTon, sp.Gia, sp.MaSP };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;

        }


        public bool Xoa(SanPham sp)
        {
            string query = "Update SANPHAM set SoLuongTon = 0 Where MaSP = @MaSP ";
            object[] para = new object[] { sp.MaSP };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;

        }
    }
}

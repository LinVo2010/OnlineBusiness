using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DTO;

namespace DAC
{
    public class CommentDAC
    {
        public static CommentDAC instance;

        public static CommentDAC Instance
        {
            get
            {
                if (instance == null)
                    instance = new CommentDAC();
                return instance;
            }
        }

        private CommentDAC() { }

        public DataTable HienThi(int pMaSP)
        {
            string query = " sp_SelectCommentByMaSP @MaSP ";
            object[] para = new object[] {pMaSP};
            DataTable data = DataProvider.Instance.ExecuteQuery(query , para);
            return data;
        }

        public bool Them(Comment cmt)
        {
            string query = " INSERT INTO COMMENT (MaCMT, NgayLap, Sao, NoiDung, MaKH, MaSP, TrangThai) VALUES ( @MaCMT , @NgayLap , @Sao , @NoiDung , @MaKH , @MaSP , @TrangThai ) ";
            object[] para = new object[] { cmt.MaCMT, cmt.NgayLap, cmt.Sao, cmt.NoiDung, cmt.MaKH, cmt.MaSP, cmt.TrangThai };
            if (DataProvider.Instance.ExecuteNonQuery(query, para) > 0)
                return true;
            return false;
        }

        public Comment DocThongTin(int makh, int masp)
        {
            string query = "SELECT * FROM COMMENT LEFT JOIN ((HOADON JOIN GIOHANG ON HOADON.MAGH = GIOHANG.MAGH) JOIN CTGIOHANG ON GIOHANG.MAGH = CTGIOHANG.MAGH) ON COMMENT.MAKH = 1 WHERE GIOHANG.MAKH = 1 AND CTGIOHANG.MASP = 3 AND HOADON.TrangThai = N'hoàn tất'";
            object[] para = new object[] { makh, masp };
            DataTable data = DataProvider.Instance.ExecuteQuery(query, para);
            foreach (DataRow item in data.Rows)
            {
                int MaCMT = (int)item["MaCMT"];
                DateTime NgayLap = DateTime.Parse(item["NgayLap"].ToString());
                int Sao = (int)item["Sao"];
                string NoiDung = item["NoiDung"].ToString();
                string Loai = item["Loai"].ToString();
                int MaKH = (int)item["MaKH"];
                int MaSP = (int)item["MaSP"];
                string TrangThai = item["TrangThai"].ToString();
                Comment newdt = new Comment(MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai);
                return newdt;
            }
            return null;
        }

        public int AutoID()
        {
            string query = "SELECT dbo.fn_Auto_IDCOMMENT()";
            object ID = DataProvider.Instance.ExecuteScalar(query);
            return (int)ID;
        }
    }
}

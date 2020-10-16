USE [OnlineBusiness]

SELECT * FROM NHANVIEN;
SELECT * FROM KHACHHANG;
SELECT * FROM LOAISANPHAM;
SELECT * FROM SANPHAM;
SELECT * FROM DOITAC;
SELECT * FROM DOITACBANHANG;
SELECT * FROM GIOHANG;
SELECT * FROM CTGIOHANG;
SELECT * FROM HOADON;
SELECT * FROM PTTHANHTOAN;
SELECT * FROM THONGTINTRAHANG;
SELECT * FROM DONTRAHANG;
SELECT * FROM CTDONTRAHANG;
SELECT * FROM DONNHAPHANG;
SELECT * FROM CTDONNHAPHANG;
SELECT * FROM TINNHAN;
SELECT * FROM TINNHAN_KHACHHANG;
SELECT * FROM HOPDONG;
SELECT * FROM COMMENT;

-- Nhap du lieu
-- Bang [NHANVIEN]
insert into NHANVIEN (MaNV, TenNV, ChucVu, SDT, DiaChi) values (1, N'Nguyễn Văn A', N'Nhân viên quản lý', '0664226917', N'01 Trần Hưng Đạo');
insert into NHANVIEN (MaNV, TenNV, ChucVu, SDT, DiaChi) values (2, N'Nguyễn Văn B', N'Nhân viên bán hàng', '0825456156', N'02 Trường Chinh');
insert into NHANVIEN (MaNV, TenNV, ChucVu, SDT, DiaChi) values (3, N'Nguyễn Văn C', N'Nhân viên giao hàng', '0641688460', N'03 Hoàng Văn Thụ');
insert into NHANVIEN (MaNV, TenNV, ChucVu, SDT, DiaChi) values (4, N'Nguyễn Văn D', N'Nhân viên đăng tin', '0572593037', N'04 Nguyễn Trãi');
insert into NHANVIEN (MaNV, TenNV, ChucVu, SDT, DiaChi) values (5, N'Nguyễn Văn E', N'Thủ quỷ', '0372279428', N'05 Lê Lai');
insert into NHANVIEN (MaNV, TenNV, ChucVu, SDT, DiaChi) values (6, N'Nguyễn Văn F', N'Nhân viên quảng cáo', '0372279429', N'06 Nguyễn Tất Thành');
insert into NHANVIEN (MaNV, TenNV, DiaChi, ChucVu, SDT) values (7, N'Phạm Thị Hoa', N'Trần Hưng Đạo,Quận 1', N'nhân viên đăng tin','0123456789');
insert into NHANVIEN (MaNV, TenNV, DiaChi, ChucVu, SDT) values (8, N'Trần Tuấn Anh', N'Nguyễn Văn Cừ,Quận 5', N'nhân viên đăng tin','0987654321');
insert into NHANVIEN (MaNV, TenNV, DiaChi, ChucVu, SDT) values (9, N'Phan Thị Hường', N'Trần Hưng Đạo,Quận 1', N'nhân viên đăng tin','0123456789');
go

-- Bang [KHACHHANG]
insert into KHACHHANG (MaKH, TenKH, DiaChi, SDT, Gmail) values (1, N'Võ Thuỳ Linh', N'01 Nguyễn Thái Học', '0123456789', 'vothuylinh@gmail.com');
insert into KHACHHANG (MaKH, TenKH, DiaChi, SDT, Gmail) values (2, N'Nguyễn Thị Hồng', N'02 Nguyễn Văn Cừ', '0846850844', 'nguyenthihong@gmail.com');
insert into KHACHHANG (MaKH, TenKH, DiaChi, SDT, Gmail) values (3, N'Nguyễn Thị Thanh Hồng', N'03 An Dương Vương', '0734109586', 'nguyenthithanhhong@gmail.com');
insert into KHACHHANG (MaKH, TenKH, DiaChi, SDT, Gmail) values (4, N'Thạch Thị Hồng Lụa', N'04 Nguyễn Thị Nghĩa', '0457608325', 'thachthihonglua@gmail.com');
insert into KHACHHANG (MaKH, TenKH, DiaChi, SDT, Gmail) values (5, N'Phan Thi Hườnng', N'05 Võ Văn Kiệt', '0749653128', 'phanthihuong@gmail.com');
go

-- Bang [LOAISANPHAM]
insert into LOAISANPHAM (MaLoai, TenLoai) values (1, N'Quần áo');
insert into LOAISANPHAM (MaLoai, TenLoai) values (2, N'Giày dép');
insert into LOAISANPHAM (MaLoai, TenLoai) values (3, N'Đồ điện tử');
insert into LOAISANPHAM (MaLoai, TenLoai) values (4, N'Mĩ phẩm');
insert into LOAISANPHAM (MaLoai, TenLoai) values (5, N'Dụng cụ nhà bếp');
insert into LOAISANPHAM (MaLoai, TenLoai) values (6, N'Điện thoại');
insert into LOAISANPHAM (MaLoai, TenLoai) values (7, N'Nhu yếu phẩm');
go

-- Bang [SANPHAM]
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (1, N'Áo thun nữ', N'Chất liệu mềm, thoáng mát.', 1, 93, 43736);
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (2, N'Áo khoác nam', N'Bền, đẹp. Phù hợp với nhiều lứa tuổi.', 1, 90, 21202);
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (3, N'Giày thể thao nữ', N'Phong cách thể thao.', 2, 86, 37613);
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (4, N'Dép tổ ong', N'Bền, rẻ.', 2, 78, 15251);
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (5, N'Chuột máy tính', N'Chất lượng cao, mẫu mã đẹp.', 3, 71, 2147);
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (6, N'Sạc dự phòng', N'Đa năng, tiện lợi.', 3, 58, 97481);
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (7, N'Kem chống nắng', N'Phù hợp với mọi loại da.', 4, 44, 2721);
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (8, N'Sửa rửa mặt', N'Trắng da, mềm mịn.', 4, 91, 86458);
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (9, N'Chảo chống dính', N'Lựa chọn số 1 cho căn bếp của bạn.', 5, 96, 38379);
insert into SANPHAM (MaSP, TenSP, MoTa, MaLoai, SoLuongTon, Gia) values (10, N'Ấm siêu tốc', N'Dễ sử dụng, an toan.', 5, 51, 53228);
insert into SANPHAM (MaSP, TenSP, Mota, MaLoai, SoLuongTon, Gia) values (11, N'Điện thoại SAMSUNG XXX', N'Màn hình 6.2 - Cảm ứng - Bộ nhớ 32GB - Chụp hình 13MP/5MP', 6, 1500, 16000000);
insert into SANPHAM (MaSP, TenSP, Mota, MaLoai, SoLuongTon, Gia) values (12, N'Mì ăn liền BA CON TÔM', N'Vừa chua vừa cay, ăn vào mặn mà da dẻ', 7, 8000, 3200);
insert into SANPHAM (MaSP, TenSP, Mota, MaLoai, SoLuongTon, Gia) values (13, N'Sữa đậu nành ZZZ', N'Uống nhiều đẹp nhiều, nhất dáng nhì da thứ 3 sữa đậu nành', 7, 8000, 5000);
go

-- Bang [DOITAC]
insert into DOITAC (MaDT, TenDT, DiaChi, SDT, Gmail) values (1, 'Eabox', N'01 Võ Văn Ngân', '0168298879', 'Eabox@gmail.com');
insert into DOITAC (MaDT, TenDT, DiaChi, SDT, Gmail) values (2, 'Jabbersphere', N'02 Luỹ Bán Bích', '0182665423', 'Jabbersphere@gmail.com');
insert into DOITAC (MaDT, TenDT, DiaChi, SDT, Gmail) values (3, 'Innojam', N'03 Huỳnh Thúc Kháng', '0233626713', 'Innojam@gmail.com');
insert into DOITAC (MaDT, TenDT, DiaChi, SDT, Gmail) values (4, 'Thoughtsphere', N'04 Cống Quỳnh', '0115907365', 'Thoughtsphere@gmail.com');
insert into DOITAC (MaDT, TenDT, DiaChi, SDT, Gmail) values (5, 'Centimia', N'05 Cộng Hòa', '0628174062', 'Centimia@gmail.com');
insert into DOITAC (MaDT, TenDT, DiaChi, SDT, Gmail) values (6, N'Công ty quảng cáo ABC', N'Trần Hưng Đạo,Quận 1', '0123456781', 'thachthihonglua1904@gmail.com');
insert into DOITAC (MaDT, TenDT, DiaChi, SDT, Gmail) values (7, N'Công ty quảng cáo HẾT HỒN', N'Nguyễn Văn Cừ,Quận 5', '0123456782', 'thachthihonglua@gmail.com');
go

-- Bang [DOITACBANHANG]
insert into DOITACBANHANG (MaDT, TenDT, NgayBatDauHopTac) values (1, 'Bubblebox', CAST(N'2020-05-27' AS date));
insert into DOITACBANHANG (MaDT, TenDT, NgayBatDauHopTac) values (2, 'Buzzdog', CAST(N'2019-08-14' AS date));
insert into DOITACBANHANG (MaDT, TenDT, NgayBatDauHopTac) values (3, 'Quire', CAST(N'2019-12-14' AS date));
insert into DOITACBANHANG (MaDT, TenDT, NgayBatDauHopTac) values (4, 'Skivee', CAST(N'2019-04-26' AS date));
insert into DOITACBANHANG (MaDT, TenDT, NgayBatDauHopTac) values (5, 'Tekfly', CAST(N'2020-08-09' AS date));
insert into DOITACBANHANG (MaDT, TenDT, NgayBatDauHopTac) values (6, N'Công ty Phương Nam', '2018-07-23');
go

-- Bang [GIOHANG]
insert into GIOHANG (MaGH, MaKH, TongTien, TrangThai) values (1, 1, 961976, N'ngưng tiếp nhận');
insert into GIOHANG (MaGH, MaKH, TongTien, TrangThai) values (2, 2, 660347, N'ngưng tiếp nhận');
insert into GIOHANG (MaGH, MaKH, TongTien, TrangThai) values (3, 3, 364753, N'ngưng tiếp nhận');
insert into GIOHANG (MaGH, MaKH, TongTien, TrangThai) values (4, 4, 119634, N'ngưng tiếp nhận');
insert into GIOHANG (MaGH, MaKH, TongTien, TrangThai) values (5, 5, 878377, N'ngưng tiếp nhận');
insert into GIOHANG (MaGH, MaKH, TongTien, TrangThai) values (6, 5, 878377, N'ngưng tiếp nhận');
go

-- Bang [CTGIOHANG]
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (1, 1, 1, 8, 79436, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (2, 1, 2, 9, 407698, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (3, 1, 3, 3, 511238, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (4, 2, 4, 1, 933063, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (5, 2, 5, 4, 698295, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (6, 3, 6, 4, 553119, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (7, 3, 7, 2, 454509, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (8, 4, 8, 3, 446076, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (9, 4, 9, 3, 828853, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (10, 5, 10, 10, 776080, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (11, 6, 4, 1, 15251, N'tốt');
insert into CTGIOHANG (MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (12, 6, 1, 2, 87472, N'tốt');
go

-- Bang [PTTHANHTOAN]
insert into PTTHANHTOAN (MaPT, TenPT) values (1, N'Tiền mặt');
insert into PTTHANHTOAN (MaPT, TenPT) values (2, N'Thẻ');
go

-- Bang [HOADON]
insert into HOADON (MaHD, MaGH, NgayLap, TrangThai, SDT, Gmail, DiaChi, MaPT, TongTien, MaNV) values (1, 1, CAST(N'2019-06-01' AS date), N'hoàn tất', '0371799749', 'vothuylinh@gmail.com', N'01 Nguyễn Thái Học', 1, 446893, 3);
insert into HOADON (MaHD, MaGH, NgayLap, TrangThai, SDT, Gmail, DiaChi, MaPT, TongTien, MaNV) values (2, 2, CAST(N'2019-09-23' AS date), N'hoàn tất', '0847408590', 'nguyenthihong@gmail.com', N'02 Nguyễn Văn Cừ', 2, 844542, 3);
insert into HOADON (MaHD, MaGH, NgayLap, TrangThai, SDT, Gmail, DiaChi, MaPT, TongTien, MaNV) values (3, 3, CAST(N'2019-08-06' AS date), N'hoàn tất', '0752936223', 'nguyenthithanhhong@gmail.com', N'03 An Dương Vương', 1, 284444, 3);
insert into HOADON (MaHD, MaGH, NgayLap, TrangThai, SDT, Gmail, DiaChi, MaPT, TongTien, MaNV) values (4, 4, CAST(N'2020-04-06' AS date), N'hoàn tất', '0683120748', 'thachthihonglua@gmail.com', N'04 Nguyễn Thị Nghĩa', 2, 35064, 3);
insert into HOADON (MaHD, MaGH, NgayLap, TrangThai, SDT, Gmail, DiaChi, MaPT, TongTien, MaNV) values (5, 5, CAST(N'2019-10-28' AS date), N'hoàn tất', '564743680', 'phanthihuong@gmail.com', N'05 Võ Văn Kiệt', 1, 759418, 3);
insert into HOADON (MaHD, MaGH, NgayLap, TrangThai, SDT, Gmail, DiaChi, MaPT, TongTien, MaNV) values (6, 6, CAST(N'2020-08-20' AS date), N'chưa xác nhận', '564743680', 'phanthihuong@gmail.com', N'05 Võ Văn Kiệt', 1, 102723, 3);
go

-- Bang [THONGTINTRAHANG]
insert into THONGTINTRAHANG (MaTH, MaCTGH, LyDoTra, NgayTra, TienHoanTra, TrangThai) values (1, 1, N'Sản phẩm lỗi', CAST(N'2019-09-06' AS date), 743060, N'đã xử lý');
insert into THONGTINTRAHANG (MaTH, MaCTGH, LyDoTra, NgayTra, TienHoanTra, TrangThai) values (2, 2, N'Gửi nhầm sản phẩm', CAST(N'2019-07-31' AS date), 591589, N'đã xử lý');
go

-- Bang [DONTRAHANG]
insert into DONTRAHANG (MaDTH, MaNV, NgayLap, MaDTBH, LyDoTra) values (1, 1, CAST(N'2019-11-07' AS date), 1, N'Sản phẩm lỗi');
insert into DONTRAHANG (MaDTH, MaNV, NgayLap, MaDTBH, LyDoTra) values (2, 1, CAST(N'2020-07-09' AS date), 2, N'Sản phẩm lỗi');
go

-- Bang [CTDONTRAHANG]
insert into CTDONTRAHANG (MaDTH, MaSP, SoLuong) values (1, 1, 3);
insert into CTDONTRAHANG (MaDTH, MaSP, SoLuong) values (2, 2, 7);
go

-- Bang [DONNHAPHANG]
insert into DONNHAPHANG (MaDNH, MaDTBH, MaNV, NgayLap, LyDoNhap, TongTien) values (1, 1, 1, CAST(N'2019-10-04' AS date), N'Hết hàng', 7408824);
insert into DONNHAPHANG (MaDNH, MaDTBH, MaNV, NgayLap, LyDoNhap, TongTien) values (2, 2, 1, CAST(N'2020-05-11' AS date), N'Hết hàng', 6687801);
insert into DONNHAPHANG (MaDNH, MaDTBH, MaNV, NgayLap, LyDoNhap, TongTien) values (3, 3, 1, CAST(N'2020-04-10' AS date), N'Hết hàng', 9771087);
insert into DONNHAPHANG (MaDNH, MaDTBH, MaNV, NgayLap, LyDoNhap, TongTien) values (4, 4, 1, CAST(N'2020-02-14' AS date), N'Hết hàng', 3587383);
insert into DONNHAPHANG (MaDNH, MaDTBH, MaNV, NgayLap, LyDoNhap, TongTien) values (5, 5, 1, CAST(N'2019-11-15' AS date), N'Hết hàng', 4403466);
go

-- Bang [CTDONNHAPHANG]
insert into CTDONNHAPHANG (MaDNH, MaSP, SoLuong, Gia) values (1, 1, 10, 98365);
insert into CTDONNHAPHANG (MaDNH, MaSP, SoLuong, Gia) values (2, 2, 74, 32555);
insert into CTDONNHAPHANG (MaDNH, MaSP, SoLuong, Gia) values (3, 3, 59, 37346);
insert into CTDONNHAPHANG (MaDNH, MaSP, SoLuong, Gia) values (4, 4, 86, 88768);
insert into CTDONNHAPHANG (MaDNH, MaSP, SoLuong, Gia) values (5, 5, 63, 44763);
go

-- Bang [TINNHAN]
insert into TINNHAN (MaTN, MaSP, Tuan, Nam, ChuDe, NoiDung) values (1, 11, 1, 2020, N'Nguyễn Thị ABC', N'Trần Hưng Đạo - Quận 1');
insert into TINNHAN (MaTN, MaSP, Tuan, Nam, ChuDe, NoiDung) values (2, 11, 2, 2020, N'Quảng bá điện thoại', N'Từ ngày x tới ngày y, giảm 90% khi mua tại cửa hàng, địa chỉ abc');
insert into TINNHAN (MaTN, MaSP, Tuan, Nam, ChuDe, NoiDung) values (3, 12, 1, 2020, N'Quảng bá Mì ăn liền', N'Từ ngày x tới ngày y, mua 10 gói tặng 2 gói , địa chỉ abc');
insert into TINNHAN (MaTN, MaSP, Tuan, Nam, ChuDe, NoiDung) values (4, 12, 3, 2020, N'Quảng bá Mì ăn liền', N'Từ ngày x tới ngày y, mua 10 gói tặng 2 gói , địa chỉ abc');
insert into TINNHAN (MaTN, MaSP, Tuan, Nam, ChuDe, NoiDung) values (5, 12, 2, 2020, N'Quảng bá Mì ăn liền', N'Từ ngày x tới ngày y, mua 10 gói tặng 2 gói , địa chỉ abc');
go

-- Bang [TINNHAN_KHACHHANG]
insert into TINNHAN_KHACHHANG (MaTN, MaKH) VALUES (1,1);
insert into TINNHAN_KHACHHANG (MaTN, MaKH) VALUES (1,2);
insert into TINNHAN_KHACHHANG (MaTN, MaKH) VALUES (1,3);
insert into TINNHAN_KHACHHANG (MaTN, MaKH) VALUES (2,1);
insert into TINNHAN_KHACHHANG (MaTN, MaKH) VALUES (2,2);
insert into TINNHAN_KHACHHANG (MaTN, MaKH) VALUES (2,3);
go

-- Bang [HOPDONG]
insert into HOPDONG (MaHD, TenHD, MaDT, MaNV, NgayLap, ThoiHan, NoiDung, ViTriDang) values (1, 'Gigabox', 1, 4, CAST(N'2019-06-26' AS date), CAST(N'2020-07-10' AS date), 'abcdefghiklmnopqrstuvwxyz', N'Website XYZ, Facebook, Youtube');
insert into HOPDONG (MaHD, TenHD, MaDT, MaNV, NgayLap, ThoiHan, NoiDung, ViTriDang) values (2, 'Oyonder', 2, 4, CAST(N'2019-04-28' AS date), CAST(N'2020-05-11' AS date), 'abcdefghiklmnopqrstuvwxyz', N'Website XYZ, Facebook, Youtube');
insert into HOPDONG (MaHD, TenHD, MaDT, MaNV, NgayLap, ThoiHan, NoiDung, ViTriDang) values (3, 'Twinte', 3, 4, CAST(N'2019-03-16' AS date), CAST(N'2020-05-18' AS date), 'abcdefghiklmnopqrstuvwxyz', N'Website XYZ, Facebook, Youtube');
insert into HOPDONG (MaHD, TenHD, MaDT, MaNV, NgayLap, ThoiHan, NoiDung, ViTriDang) values (4, 'Fatz', 4, 4, CAST(N'2019-04-05' AS date), CAST(N'2020-02-25' AS date), 'abcdefghiklmnopqrstuvwxyz', N'Website XYZ, Facebook, Youtube');
insert into HOPDONG (MaHD, TenHD, MaDT, MaNV, NgayLap, ThoiHan, NoiDung, ViTriDang) values (5, 'Pixoboo', 5, 4, CAST(N'2020-08-16' AS date), CAST(N'2020-10-17' AS date), 'abcdefghiklmnopqrstuvwxyz', N'Website XYZ, Facebook, Youtube');
insert into HOPDONG (MaHD, MaDT, MaNV, TenHD, NgayLap, ThoiHan, NoiDung, ViTriDang) values (6, 6, 7, N'Hợp đồng XXX', '2010-10-11', '2011-10-11', N'ĐIỀU 1: NỘI DUNG CÔNG VIỆC\na) Hình thức: Bên A thuê bên B làm dịch vụ quảng cáo ABC bằng hình thức XYZ b) Nội dung: Được hai bên thỏa thuận có phụ lục đính kèm phù hợp với pháp luật hiện hành. ĐIỀU 2: PHƯƠNG THỨC, PHƯƠNG TIỆN QUẢNG CÁO\n2.1. Phương thức: Yêu cầu nêu được hình thức, chất lượng bằng hình ảnh, biểu tượng, âm thanh, lời nói … có sức hấp dẫn lôi cuốn khách hàng.\n2.2. Phương tiện: Yêu cầu quay hình ảnh, vẽ biển hiệu, panô, áp phích, bảng có hộp đèn, chữ nổi, hay trên báo chí, tạp chí, truyền hình…\nViệc sử dụng phương tiện quảng cáo thương mại phải đảm bảo:\na) Tuân thủ các quy định của pháp luật về báo chí, xuất bản, thông tin, chương trình hoạt động văn hoá, thể thao, hội chợ, triển lãm;\nb) Tuân thủ quy định về địa điểm quảng cáo, không gây ảnh hưởng xấu đến cảnh quan, môi trường, trật tự an toàn giao thông, an toàn xã hội;\nc) Đúng mức độ, thời lượng, thời điểm quy định đối với từng loại phương tiện thông tin đại chúng.' , N'Website XYZ, Facebook, Youtube');
insert into HOPDONG (MaHD, MaDT, MaNV, TenHD, NgayLap, ThoiHan, NoiDung, ViTriDang) values (7, 7, 7, N'Hợp đồng XYZ', '2010-10-11', '2011-10-11', N'ĐIỀU 1: NỘI DUNG CÔNG VIỆC\na) Hình thức: Bên A thuê bên B làm dịch vụ quảng cáo ABC bằng hình thức XYZ b) Nội dung: Được hai bên thỏa thuận có phụ lục đính kèm phù hợp với pháp luật hiện hành.' ,N'Website XYZ, Facebook, Youtube');
insert into HOPDONG (MaHD, MaDT, MaNV, TenHD, NgayLap, ThoiHan, NoiDung, ViTriDang) values (8, 7, 7, N'Hợp đồng ZZZ', '2010-10-11', '2011-10-11', N'ĐIỀU 1: NỘI DUNG CÔNG VIỆC'+ CHAR(13) + 'a) Hình thức: Bên A thuê bên B làm dịch vụ quảng cáo ABC bằng hình thức XYZ '+ CHAR(13) + 'b) Nội dung: Được hai bên thỏa thuận có phụ lục đính kèm phù hợp với pháp luật hiện hành.' , N'Website XYZ, Facebook, Youtube');
insert into HOPDONG (MaHD, MaDT, MaNV, TenHD, NgayLap, ThoiHan, NoiDung, ViTriDang) values (9, 7, 7, N'Hợp đồng ZZZ', '2010-10-11', '2020-8-11', N'ĐIỀU 1: NỘI DUNG CÔNG VIỆC'+ CHAR(13) + 'a) Hình thức: Bên A thuê bên B làm dịch vụ quảng cáo ABC bằng hình thức XYZ '+ CHAR(13) + 'b) Nội dung: Được hai bên thỏa thuận có phụ lục đính kèm phù hợp với pháp luật hiện hành.' , N'Website XYZ, Facebook, Youtube');
insert into HOPDONG (MaHD, MaDT, MaNV, TenHD, NgayLap, ThoiHan, NoiDung, ViTriDang) values (10, 7, 7, N'Hợp đồng ZZZ', '2010-10-13', '2020-8-11', N'ĐIỀU 1: NỘI DUNG CÔNG VIỆC'+ CHAR(13) + 'a) Hình thức: Bên A thuê bên B làm dịch vụ quảng cáo ABC bằng hình thức XYZ '+ CHAR(13) + 'b) Nội dung: Được hai bên thỏa thuận có phụ lục đính kèm phù hợp với pháp luật hiện hành.' , N'Website XYZ, Facebook, Youtube');
go

-- Bang [COMMENT]
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (1, CAST(N'2019-04-04' AS date), 3, N'Vải không đẹp lắm.', null, 1, 1, N'đã đăng');
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (2, CAST(N'2020-05-26' AS date), 4, N'Tạm ổn, đóng gói cẩn thận.', N'Tốt', 2, 2, N'đã đăng');
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (3, CAST(N'2019-01-16' AS date), 3, N'Giày bị lỗi form.', N'Tốt', 3, 3, N'đã đăng');
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (4, CAST(N'2020-06-30' AS date), 1, N'Dép nhanh hư.', N'Xấu', 4, 4, N'đã đăng');
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (5, CAST(N'2020-07-30' AS date), 3, N'Hơi khó sử dụng, chuột phản ứng chậm.', null, 5, 5, N'đã đăng');
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (6, CAST(N'2019-02-24' AS date), 2, N'Nhanh hết pin.', N'Xấu', 1, 6, N'đã đăng');
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (7, CAST(N'2020-01-10' AS date), 3, N'Tạm ổn.', null, 2, 7, N'đã đăng');
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (8, CAST(N'2019-04-23' AS date), 5, N'Hiệu quả, dễ chịu khi sử dụng.', N'Tốt', 3, 8, N'đã đăng');
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (9, CAST(N'2020-04-14' AS date), 5, N'Tuyệt vời.', null, 4, 9, N'đã đăng');
insert into COMMENT (MaCMT, NgayLap, Sao, NoiDung, Loai, MaKH, MaSP, TrangThai) values (10, CAST(N'2019-03-18' AS date), 5, null, null, 5, 10, N'đã đăng');
go

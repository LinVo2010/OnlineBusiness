USE [OnlineBusiness]

-- TTHL - 1712581

-- MãKH tăng tự động
-- OutPut: Int - MaDP tiếp theo
CREATE FUNCTION fn_Auto_IDHopDong()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaHD FROM HOPDONG WHERE MaHD = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx=@Idx+1 
END
RETURN @MA-- Trả về  @Ma
END
GO

CREATE FUNCTION fn_Auto_IDDoiTac()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaDT FROM DOITAC WHERE MaDT = @MA)
BEGIN
	SET @MA = @MA + 1
	SET @Idx = @Idx + 1 
END
RETURN @MA -- Trả về @Ma
END
GO

CREATE FUNCTION fn_Auto_IDTinNhan()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaTN FROM TINNHAN WHERE MaTN = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx = @Idx + 1 
END
RETURN @MA -- Trả về @Ma
END
GO
-------------------------------------------------------------------------------------------------------------------
-- VTL - 1712563

-- MaCMT tang tu dong

CREATE FUNCTION fn_Auto_IDCOMMENT()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaCMT FROM COMMENT WHERE MaCMT = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx = @Idx + 1 
END
RETURN @MA-- Trả về  @Ma
END
GO

-- Kiem tra xem khach hang da mua san pham do hay chua

CREATE FUNCTION fn_CheckForCmt(@MaKH INT, @MaSP INT)
RETURNS INT
AS
BEGIN
	IF NOT EXISTS (SELECT * 
				   FROM (HOADON JOIN GIOHANG ON HOADON.MAGH = GIOHANG.MAGH) JOIN CTGIOHANG ON GIOHANG.MAGH = CTGIOHANG.MAGH
				   WHERE GIOHANG.MAKH = @MaKH
				   AND CTGIOHANG.MASP = @MaSP
				   AND HOADON.TrangThai = N'hoàn tất')
	BEGIN
		RETURN 0
	END
	RETURN 1
END
GO

DECLARE @check INT
SET @check = dbo.fn_CheckForCmt(1,4)
print(@check)

-- Xuat comment cua 1 san pham

CREATE PROC sp_SelectCommentByMaSP(@MaSP int)
AS
BEGIN
SELECT KHACHHANG.TenKH, COMMENT.Sao, COMMENT.NgayLap, COMMENT.NoiDung
FROM KHACHHANG JOIN COMMENT ON KHACHHANG.MaKH = COMMENT.MaKH
WHERE COMMENT.MaSP = @MaSP
AND COMMENT.TrangThai = N'đã đăng'
END
GO

EXEC sp_SelectCommentByMaSP '3'

-- Them comment

CREATE PROC sp_InsertComment(@MaKH int, @MaSP int, @Sao int, @NoiDung nvarchar(200))
AS
BEGIN
	DECLARE @MaCMT INT
	SET @MaCMT = dbo.fn_Auto_IDCOMMENT()
	DECLARE @NgayLap DATE = GETDATE()
	INSERT INTO COMMENT VALUES (@MaCMT, @NgayLap, @Sao, @NoiDung, NULL, @MaKH, @MaSP, N'đã đăng') 
END
GO

SELECT * FROM COMMENT LEFT JOIN ((HOADON JOIN GIOHANG ON HOADON.MAGH = GIOHANG.MAGH) JOIN CTGIOHANG ON GIOHANG.MAGH = CTGIOHANG.MAGH) ON COMMENT.MAKH = 1 WHERE GIOHANG.MAKH = 1 AND CTGIOHANG.MASP = 3 AND HOADON.TrangThai = N'hoàn tất'

----------------------------------------------------------------------------------------------------------
-- PTH - 1712487

--sp hiện thị chi tiet gio hang cua tai khoan kh co ten dang nhap truyen vao
--drop proc sp_HienThi
create proc sp_HienThiGioHang_CTT @MaKH int
as
begin
select sp.TenSP, ct.SoLuong, sp.Gia, ct.ThanhTien 
from HOADON hd, CTGIOHANG ct, SANPHAM sp, GIOHANG gh
where gh.MaKH = @MaKH
and gh.MaGH = ct.MaGH 
and sp.MaSP = ct.MaSP 
and hd.MaGH = gh.MaGH 
and hd.TrangThai = N'chưa xác nhận'
end
go

exec sp_HienThiGioHang_CTT 1
go


--sp lay thong tin hoa đon cua khach hang dang nhap vao he thong
create proc sp_LayThongTinHD @MaKH int
as
begin
select hd.TongTien, (ct.SoLuong) as TongSP 
from HOADON hd, CTGIOHANG ct, GIOHANG gh 
where gh.MaKH = @MaKH 
and gh.MaGH = ct.MaGH 
and hd.MaGH = gh.MaGH 
and hd.TrangThai= N'chưa xác nhận'
end
go

select* from HOADON
exec sp_LayThongTinHD 1
go


--sp lay thong tin  cua khach hang dang nhap vao he thong
--drop proc sp_LayThongTinKH
create proc sp_LayThongTinKH @MaKH int
as
begin
select  TenKH, SDT, Gmail, DiaChi 
from  KHACHHANG
where MaKH = @MaKH
end
go

exec sp_LayThongTinKH 1
go


--sp: lay hoa don cua khach hang dang nhap vao

--drop proc sp_HienThiHD
create proc sp_HienThiHD @MaKH int
as
begin
	select hd.MaHD, hd.NgayLap, hd.DiaChi, hd.SDT, hd.TongTien, pt.TenPT, hd.TrangThai 
	from HOADON hd, GIOHANG gh, PTTHANHTOAN pt, CTGIOHANG ct
	where gh.MaKH= @MaKH 
	and hd.MaGH = gh.MaGH 
	and pt.MaPT = hd.MaPT 
	and ct.MaGH = gh.MaGH
end
go

--select * from HOADON
exec sp_HienThiHD 1
go


--sp Cap nhap MaPT cua hoa don thanh 1
create proc sp_CapNhapPTTT_The @MaKH int
as
begin
	update HOADON set MaPT = 2 
	from HOADON hd, GIOHANG gh 
	where gh.MaKH = @MaKH 
	and hd.MaGH = gh.MaGH 
	and hd.TrangThai= N'chưa xác nhận'
end
go

create proc sp_CapNhapPTTT_Tien @MaKH int
as
begin
	update HOADON set MaPT = 1 
	from HOADON hd, GIOHANG gh 
	where gh.MaKH= @MaKH 
	and hd.MaGH=gh.MaGH 
	and hd.TrangThai= N'chưa xác nhận'
end
go

--exec sp_CapNhapPTTT_The pth
--exec sp_CapNhapPTTT_Tien pth
--select * from HOADON

--sp cập nhập trạng thái cua một hóa đơn thanh đã xác nhận
--drop proc sp_CapNhapTrangThai
create proc sp_CapNhapTrangThai @MaKH int
as
begin
	update HOADON set TrangThai = N'đã xác nhận' 
	from HOADON hd, GIOHANG gh 
	where gh.MaKH = @MaKH 
	and hd.MaGH=gh.MaGH 
	and hd.TrangThai= N'chưa xác nhận'
end
go

--exec sp_CapNhapTrangThai pth
--select * from HOADON
--update HOADON set TrangThai=N'chưa xác nhận' where MaHD=6
--go


--kiem tra hoa don
create function fn_KiemTraHoaDon (@MaKH int)
RETURNS INT
as
begin
DECLARE @temp int = 0;
SET  @temp = (select COUNT(*) 
from HOADON hd, GIOHANG gh 
where gh.MaKH = @MaKH 
and hd.MaGH = gh.MaGH 
and hd.TrangThai= N'chưa xác nhận');
RETURN @temp
end
go

SELECT dbo.fn_KiemTraHoaDon(1)
----------------------------------------------------------------------------------------------
-- NTH - 1712463
------------------- FUNCTION ---------------------
-- 1.
-- MaGH tăng tự động
-- OutPut: Int - MaGH tiếp theo
CREATE FUNCTION fn_Auto_IDGH()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaGH FROM GIOHANG WHERE MaGH = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx=@Idx+1 
END
RETURN @MA-- Trả về  @Ma
END
GO

SELECT dbo.fn_Auto_IDGH()
-- 2.
-- MaCTGH tăng tự động
-- OutPut: Int - MaCTGH tiếp theo
CREATE FUNCTION fn_Auto_IDCTGH()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaCTGH FROM CTGIOHANG WHERE MaCTGH = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx=@Idx+1 
END
RETURN @MA-- Trả về  @Ma
END
GO
-- 3.
-- MaHD tăng tự động
-- OutPut: Int - MaHD tiếp theo
CREATE FUNCTION fn_Auto_IDHD()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaHD FROM HOADON WHERE MaHD = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx=@Idx+1 
END
RETURN @MA-- Trả về  @Ma
END
GO
-- 4.
CREATE FUNCTION fn_kiemtra_KHACHHANG(@MaKH INT)
RETURNS INT
AS
BEGIN
IF(EXISTS (SELECT * FROM KHACHHANG WHERE MaKH = @MaKH))
	RETURN 1 -- có tồn tại
RETURN 0
END
GO

-- 5.
CREATE FUNCTION fn_LaySL(@MaSP INT)
RETURNS INT
AS
BEGIN
	RETURN (SELECT SoLuongTon FROM SANPHAM WHERE MaSP = @MaSP)
END
GO

SELECT dbo.fn_LaySL(1)
-- 6.
CREATE FUNCTION fn_LayMaGH(@MaKH INT)
RETURNS INT
AS
BEGIN
	RETURN (SELECT MaGH FROM GIOHANG WHERE MaKH = @MaKH AND TrangThai = N'tiếp nhận');
END
GO

------------------- STORED PROC ---------------------
-- 1.
CREATE PROC sp_HienThiGioHang @MaKH INT
AS
BEGIN
	SELECT GIOHANG.MaGH, CTGIOHANG.MaCTGH,SANPHAM.MaSP, SANPHAM.TenSP, CTGIOHANG.SoLuong, CTGIOHANG.ThanhTien, GIOHANG.TongTien  
    FROM (GIOHANG inner join CTGIOHANG on GIOHANG.MaGH = CTGIOHANG.MaGH) INNER JOIN SANPHAM ON SANPHAM.MaSP = CTGIOHANG.MaSP
    WHERE MaKH = @MaKH and GIOHANG.TrangThai = N'tiếp nhận'
END
GO

-- 2.
CREATE PROC sp_CapNhatTienCTGH @MaGH INT, @MaCTGH INT
AS
BEGIN
	DECLARE @DonGia INT = 0
	SELECT @DonGia = Gia
	FROM SANPHAM INNER JOIN CTGIOHANG ON SANPHAM.MaSP = CTGIOHANG.MaSP
	WHERE  CTGIOHANG.MaCTGH = @MaCTGH
	UPDATE CTGIOHANG SET ThanhTien	= SoLuong * @DonGia WHERE MaGH = @MaGH AND MaCTGH = @MaCTGH
END
GO

-- 3.
CREATE PROC sp_CapNhatTongTienGH @MaGH INT
AS
BEGIN
	DECLARE @TongTien INT = 0
	SELECT @TongTien = SUM(CTGIOHANG.ThanhTien)
	FROM CTGIOHANG
	WHERE CTGIOHANG.MaGH = @MaGH
	UPDATE GIOHANG SET TongTien = @TongTien WHERE MaGH = @MaGH 
END
GO

-- 4.
CREATE PROC sp_CapNhatTongTienHD @MaHD INT
AS
BEGIN 
	DECLARE @tien INT = 0
	SELECT @tien = CTGIOHANG.ThanhTien
	FROM CTGIOHANG INNER JOIN HOADON ON CTGIOHANG.MaGH = HOADON.MaGH
	WHERE HOADON.MaHD = @MaHD
	UPDATE HOADON SET TongTien = @tien WHERE MaHD = @MaHD
END
GO

-- 5.
CREATE PROC sp_thaydoiCTGH 
@MaGH INT, 
@MaCTGH INT, 
@MaSP INT, 
@SoLuong INT
AS
BEGIN
	UPDATE CTGIOHANG SET SoLuong = @SoLuong WHERE MaGH = @MaGH AND MaCTGH = @MaCTGH AND MaSP = @MaSP
	UPDATE SANPHAM SET SoLuongTon = SoLuongTon - @SoLuong WHERE MaSP = @MaSP
	EXEC sp_CapNhatTienCTGH @MaGH, @MaCTGH
	EXEC sp_CapNhatTongTienGH @MaGH
END
GO

-- 6.
CREATE PROC sp_ThemCTGH
@MaCTGH int,
@MaGH int,
@MaSP int,
@SL int
AS
BEGIN
	insert into CTGIOHANG(MaCTGH, MaGH, MaSP, SoLuong, ThanhTien, TrangThai) values (@MaCTGH, @MaGH, @MaSP, @SL, 0, N'tốt')
	UPDATE SANPHAM SET SoLuongTon = SoLuongTon - @SL WHERE MaSP = @MaSP
	exec sp_CapNhatTienCTGH @MaGH, @MaCTGH
	exec sp_CapNhatTongTienGH @MaGH
END
GO

-- 7.
CREATE PROC sp_XoaCTGH
@MaGH INT,
@MaCTGH INT
AS
BEGIN
	DECLARE @pSL int = 0, @pMaSP int
	SET @pMaSP = (SELECT MaSP FROM CTGIOHANG WHERE MaCTGH = @MaCTGH AND MaGH = @MaGH)
	SET @pSL = @pSL + (select SoLuong from CTGIOHANG where MaCTGH = @MaCTGH and MaGH = @MaGH)
	UPDATE SANPHAM SET SoLuongTon = SoLuongTon + @pSL where MaSP = @pMaSP
	DELETE FROM CTGIOHANG WHERE MaCTGH = @MaCTGH AND MaGH = @MaGH 
	EXEC sp_CapNhatTongTienGH @MaGH
END
GO

-- 8.
create proc sp_ThemMoiGH 
@MaGH int,
@MaKH int
as
begin
	INSERT INTO GIOHANG( MaGH , MaKH ,  TongTien , TrangThai ) VALUES (  @MaGH , @MaKH , 0 , N'tiếp nhận' )
end
go

-- 9.
create proc sp_ThemMoiHD 
@MaHD int,
@MaGH int
as
begin
	declare @SDT varchar(10)
	declare @Gmail varchar(30)
	declare @DiaChi nvarchar(100)
	declare @tien int
	SET @SDT = (SELECT K.SDT FROM KHACHHANG K INNER JOIN GIOHANG G ON K.MaKH = G.MaKH WHERE G.MaGH = @MaGH)
	SET @Gmail = (SELECT K.Gmail FROM KHACHHANG K INNER JOIN GIOHANG G ON K.MaKH = G.MaKH WHERE G.MaGH = @MaGH)
	SET @DiaChi = (SELECT K.DiaChi FROM KHACHHANG K INNER JOIN GIOHANG G ON K.MaKH = G.MaKH WHERE G.MaGH = @MaGH)
	SET @tien = (select TongTien from GIOHANG where MaGH = @MaGH)
	INSERT INTO HOADON( MaHD, MaGH, NgayLap, TrangThai, SDT, Gmail, DiaChi, MaPT, TongTien, MaNV ) VALUES (  @MaHD , @MaGH , GETDATE() , N'chưa xác nhận', @SDT, @Gmail, @DiaChi, 1, @tien, 3)
end
go

-- 10.
create proc sp_DSHD @MaKH int 
as
begin
	select H.MaHD, H.NgayLap, H.TongTien, H.DiaChi, H.Gmail, H.SDT
	from (HOADON H inner join GIOHANG G ON H.MaGH = G.MaGH) INNER JOIN KHACHHANG K ON G.MaKH = K.MaKH
	where k.MaKH = @MaKH and (H.TrangThai = N'đã xác nhận' or H.TrangThai = N'chưa giao' or H.TrangThai = N'hoàn tất')
end
go

-- 11.
create proc sp_DocTTHDChuaXacNhan @MaKH int 
as
begin
	select H.MaHD, H.NgayLap, H.TongTien
	from (HOADON H inner join GIOHANG G ON H.MaGH = G.MaGH) INNER JOIN KHACHHANG K ON G.MaKH = K.MaKH
	where k.MaKH = @MaKH and H.TrangThai = N'chưa xác nhận'
end
go

-- 12.
create proc sp_CapNhatTinhTrangGH @MaGH INT
AS
BEGIN
	UPDATE GIOHANG SET TrangThai = N'ngưng tiếp nhận' where MaGH = @MaGH
END
GO

-- 13.
create proc sp_CapNhatTTinHD 
@MaKH int,
@SDT varchar(10),
@Gmail varchar(30),
@DiaChi nvarchar(100)
as
begin
	declare @MaHD int
	SET @MaHD = (SELECT H.MaHD FROM HOADON H INNER JOIN GIOHANG G ON H.MaGH = G.MaGH WHERE G.MaKH = @MaKH AND H.TrangThai = N'chưa xác nhận')
	UPDATE HOADON SET SDT = @SDT WHERE  MaHD = @MaHD
	UPDATE HOADON SET Gmail = @Gmail WHERE  MaHD = @MaHD
	UPDATE HOADON SET DiaChi = @DiaChi WHERE  MaHD = @MaHD
end
go

-- 14. 
-- đọc thông tin giỏ hàng còn tiếp nhận //phục vụ công việc kiểm tra tồn tại giỏ hàng
create proc sp_XemGHTN(@MaKH int)
as
begin
	select * from GIOHANG where MaKH = @MaKH and TrangThai = N'tiếp nhận'
end
go

delete from HOADON where MaHD = 7 or MaHD = 8 or MaHD = 9
delete from CTGIOHANG where MaGH = 7 or MaGH = 8 or MaGH = 9
delete from GIOHANG where MaGH = 7 or MaGH = 8 or MaGH = 9


select * from CTGIOHANG
select* from GIOHANG inner join CTGIOHANG ON GIOHANG.MaGH = CTGIOHANG.MaGH where GIOHANG.TrangThai = N'tiếp nhận'

-----------------------------------------------
-- NTTH - 1712464

CREATE FUNCTION fn_Auto_IDDonTraHang()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaDTH FROM DONTRAHANG WHERE MaDTH = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx=@Idx+1 
END
RETURN @MA-- Trả về  @Ma
END
GO


CREATE FUNCTION fn_Auto_IDDonNhapHang()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaDNH FROM DONNHAPHANG WHERE MaDnH = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx=@Idx+1 
END
RETURN @MA-- Trả về  @Ma
END
GO

select * from DONTRAHANG
DELETE FROM DonTraHang Where MaDTH = 4

--mấy cái auto sản phẩm, loại sp nữa
CREATE FUNCTION fn_Auto_IDSanPham()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaSP FROM SANPHAM WHERE MaSP = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx=@Idx+1 
END
RETURN @MA-- Trả về  @Ma
END
GO

CREATE FUNCTION fn_Auto_IDLoaiSanPham()
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @MA INT = 1
DECLARE @Idx INT -- biến đếm
SET @Idx = 1
WHILE EXISTS (SELECT MaLoai FROM LOAISANPHAM WHERE MaLoai = @MA)
BEGIN
	SET @MA= @MA + 1
	SET @Idx=@Idx+1 
END
RETURN @MA-- Trả về  @Ma
END
GO


create FUNCTION fn_KiemTra_ThieuHang(@dem int)
RETURNS INT
AS
BEGIN
--Khởi tạo biến
DECLARE @temp INT = 0;
begin
set @temp = (select count(*) from SanPham where SoLuongTon < @dem and SoLuongTon > 0);
end
RETURN @temp-- Trả về  @Ma
END
GO
--select dbo.fn_KiemTra_ThieuHang(50)

---Hàm tính giá cho sản phẩm ở chi tiết DNH sản phẩm
create proc sp_TinhGia_CTDNH
AS
BEGIN
update CTDonNhapHang set CTDonNhapHang.Gia = (CTDonNhapHang.MaSP  * (select sp.Gia from SANPHAM sp where CTDonNhapHang.MaSP = sp.MaSP))
END
GO


--create trigger tg_TinhGia_CTDNH()
--BEGIN
--update CTDonNhapHang set CTDonNhapHang.Gia = (CTDonNhapHang.MaSP  * (select sp.Gia from SANPHAM sp where CTDonNhapHang.MaSP = sp.MaSP))
--END
--CREATE TRIGGER tg_TinhGia_CTDNH before  trigger_event
-- ON table_name
-- FOR EACH ROW
-- BEGIN
-- ...
-- END;

--select * from CTDonNhapHang

--update CTDonNhapHang set Gia = 0;

--select dbo.fn_TinhGia_CTDNH(1, 13);

CREATE PROC sp_CapNhatTongTienDNH @MaDNH INT
AS
BEGIN 
	DECLARE @tien INT = 0
	SET @tien = (SELECT SUM(CT.GIA)
	FROM CTDONNHAPHANG CT INNER JOIN DONNHAPHANG DNH ON CT.MaDNH = DNH.MADNH
	WHERE CT.MaDNH = @MaDNH );
	UPDATE DONNHAPHANG SET TongTien = @tien WHERE  DONNHAPHANG.MADNH= @MADNH
END
GO

--Cap nhap gia tien chi tiet don nhap hang
CREATE PROC sp_CapNhatGiaCTDNH @dnh int , @masp INT
AS
BEGIN 
	DECLARE @DonGia INT = 0
	SELECT @DonGia = SANPHAM.GIA
	FROM SANPHAM INNER JOIN CTDONNHAPHANG ON SANPHAM.MaSP = CTDONNHAPHANG.MaSP
	WHERE  CTDONNHAPHANG.MADNH = @dnh
	UPDATE CTDONNHAPHANG SET GIA = SoLuong * @DonGia WHERE MADNH = @dnh AND MaSP = @masp
END
GO

--select *from CTDONNHAPHANG
select * from sanpham

--EXEC sp_CapNhatGiaCTDNH 16, 2

EXEC sp_CapNhatTongTienDNH 11

select * from KHACHHANG
select * from GIOHANG where MaKH = 1
select * from HOADON where MaGH = 8
select * from HOADON where MaGH = 7

select * from CTGIOHANG
delete from HOADON where MaHD = 7 or MaHD = 8 or MaHD = 9
delete from CTGIOHANG where MaCTGH = 13 or MaCTGH = 14 or MaCTGH = 15 or MaCTGH = 16
delete from GIOHANG where MaGH = 7 or MaGH = 8 or MaGH = 9



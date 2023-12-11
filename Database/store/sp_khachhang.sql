-- ================================================
-- Khách hàng thêm
-- ================================================
drop procedure if exists sp_khachhang_them
go
CREATE PROCEDURE sp_khachhang_them
	@maKH char(10),
    @tenKH nvarchar(30),
    @SDT char(10),
    @ngaySinh char(10),
    @diemTichLuy int
AS
BEGIN
	INSERT INTO KhachHang VALUES (@maKH, @tenKH, @SDT, @ngaySinh, @diemTichLuy)
END
GO
-- ================================================
-- Khách hàng xóa
-- ================================================
DROP PROCEDURE IF EXISTS sp_khachhang_xoa
GO
CREATE PROCEDURE sp_khachhang_xoa
	@maKH char(10)
AS
BEGIN

	DELETE FROM KhachHang WHERE maKH = @maKH
END
GO
-- ================================================
-- Khách hàng sửa
-- ================================================
drop procedure if exists sp_khachhang_sua
go
CREATE PROCEDURE sp_khachhang_sua
	@maKH char(10),
    @tenKH nvarchar(30),
    @SDT char(10),
    @ngaySinh char(10),
    @diemTichLuy int
AS
BEGIN
	
	update KhachHang set tenKH = @tenKH , SDT = @SDT, ngaySinh = @ngaySinh, diemTichLuy = @diemTichLuy where maKH = @maKH 
END
GO
-- ================================================
-- Khách hàng lấy danh sách
-- ================================================
drop procedure if exists sp_khachhang_layDanhSach
go
CREATE PROCEDURE sp_khachhang_layDanhSach
AS
BEGIN
	SELECT * from KhachHang
END
GO
exec sp_khachhang_layDanhSach




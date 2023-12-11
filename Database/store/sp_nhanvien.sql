-- ================================================
-- Nhân viên thêm
-- ================================================
drop procedure if exists sp_nhanvien_them
go
CREATE PROCEDURE sp_nhanvien_them
	@maNV char(10),
	@tenNV nvarchar(30),
	@gioiTinh tinyint,
	@ngaySinh char(10),
	@SDT char(10),
	@CCCD char(11),
	@luong int,
	@maCN char(10)
AS
BEGIN
	INSERT INTO NhanVien VALUES (@maNV, @tenNV, @gioiTinh, @ngaySinh, @SDT, @CCCD, @luong, @maCN)
END
GO
-- ================================================
-- Nhân viên xóa
-- ================================================ 
DROP PROCEDURE IF EXISTS sp_nhanvien_xoa
GO
CREATE PROCEDURE sp_nhanvien_xoa
	@maNV char(10)
AS
BEGIN
	
	DELETE FROM NhanVien WHERE maNV = @maNV
END
GO
-- ================================================
-- Nhân viên sửa
-- ================================================
drop procedure if exists sp_nhanvien_sua
go
CREATE PROCEDURE sp_nhanvien_sua
	@maNV char(10),
	@tenNV nvarchar(30),
	@gioiTinh tinyint,
	@ngaySinh char(10),
	@SDT char(10),
	@CCCD char(11),
	@luong int,
	@maCN char(10)
AS
BEGIN

	update NhanVien set tenNV = @tenNV, gioiTinh = @gioiTinh, ngaySinh = @ngaySinh, SDT = @SDT, 
    CCCD = @CCCD, luong = @luong , maCN = @maCN 
	where maNV = @maNV -- chuẩn sql
END
GO
-- ================================================
-- Nhân viên lấy danh sách
-- ================================================
drop procedure if exists sp_nhanvien_layDanhSach
go
CREATE PROCEDURE sp_nhanvien_layDanhSach
AS
BEGIN
	
	SELECT * from NhanVien
END
GO

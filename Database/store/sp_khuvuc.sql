-- ================================================
-- Khu vực thêm
-- ================================================
drop procedure if exists sp_khuvuc_them
go
CREATE PROCEDURE sp_khuvuc_them
	@maKV char(10),
    @tenKV nvarchar(50)
AS
BEGIN
	INSERT INTO KhuVuc VALUES (@maKV, @tenKV)
END
GO
-- ================================================
-- Khu vực xóa
-- ================================================
DROP PROCEDURE IF EXISTS sp_khuvuc_xoa
GO
CREATE PROCEDURE sp_khuvuc_xoa
	@maKV char(10)
AS
BEGIN
	DELETE FROM KhuVuc WHERE maKV = @maKV
END
GO
-- ================================================
-- Khu vực sửa
-- ================================================
drop procedure if exists sp_khuvuc_sua
go
CREATE PROCEDURE sp_khuvuc_sua
	@maKV char(10),
    @tenKV nvarchar(50)
AS
BEGIN
	
	update KhuVuc set tenKV = @tenKV where maKV = @maKV -- chuẩn sql
END
GO
-- ================================================
-- Khu vực lấy danh sách
-- ================================================
drop procedure if exists sp_khuvuc_layDanhSach
go
CREATE PROCEDURE sp_khuvuc_layDanhSach
AS
BEGIN
	
	SELECT * from KhuVuc
END
GO
exec sp_khuvuc_layDanhSach





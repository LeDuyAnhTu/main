-- ================================================
-- Nhà cung cấp thêm
-- ================================================
drop procedure if exists sp_nhacungcap_them
go
CREATE PROCEDURE sp_nhacungcap_them(
	@maNCC char(10),
	@tenNCC nvarchar(30),
	@SDTNCC char(10),
	@diaChi nvarchar(100))
AS
BEGIN
	INSERT INTO NhaCungCap VALUES (@maNCC, @tenNCC, @SDTNCC, @diachi)
END
GO
-- ================================================
-- Nhà cung cấp xóa
-- ================================================
DROP PROCEDURE IF EXISTS sp_nhacungcap_xoa
GO
CREATE PROCEDURE sp_nhacungcap_xoa(
	@maNCC char(10))
AS
BEGIN

	DELETE FROM NhaCungCap WHERE maNCC = @maNCC
END
GO
-- ================================================
-- Nhà cung cấp sửa
-- ================================================
drop procedure if exists sp_nhacungcap_sua
go
CREATE PROCEDURE sp_nhacungcap_sua(
	@maNCC char(10),
	@tenNCC nvarchar(30),
	@SDTNCC char(10),
	@diaChi nvarchar(100))
AS
BEGIN
	update NhaCungCap set tenNCC = @tenNCC, SDTNCC = @SDTNCC, diachi = @diachi where maNCC = @maNCC -- chuẩn sql
END
GO
-- ================================================
-- Nhà cung cấp lấy danh sách
-- ================================================
drop procedure if exists sp_nhacungcap_layDanhSach
go
CREATE PROCEDURE sp_nhacungcap_layDanhSach
AS
BEGIN
	SELECT * from NhaCungCap
END
GO
exec sp_nhacungcap_layDanhSach
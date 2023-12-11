-- ================================================
-- Loại sản phẩm thêm
-- ================================================
drop procedure if exists sp_loaisanpham_them
go
CREATE PROCEDURE sp_loaisanpham_them
	@maLoai char(10),
    @tenLoai nvarchar(30)
AS
BEGIN
	
	INSERT INTO LoaiSP VALUES (@maLoai, @tenLoai)
END
GO
-- ================================================
-- Loại sản phẩm xóa
-- ================================================
DROP PROCEDURE IF EXISTS sp_loaisanpham_xoa
GO
CREATE PROCEDURE sp_loaisanpham_xoa
	@maLoai char(10)
AS
BEGIN

	DELETE FROM LoaiSP WHERE maLoai = @maLoai
END
GO
-- ================================================
-- Loại sản phẩm sửa
-- ================================================
drop procedure if exists sp_loaisanpham_sua
go
CREATE PROCEDURE sp_loaisanpham_sua
	@maLoai char(10),
    @tenLoai nvarchar(30)
AS
BEGIN
	
	update LoaiSP set tenLoai = @tenLoai  where maLoai = @maLoai -- chuẩn sql
END
GO

-- ================================================
-- Loại sản phẩm lấy danh sách
-- ================================================
drop procedure if exists sp_loaisanpham_layDanhSach
go
CREATE PROCEDURE sp_loaisanpham_layDanhSach
AS
BEGIN
	SELECT * from LoaiSP
END
GO
exec sp_loaisanpham_layDanhSach




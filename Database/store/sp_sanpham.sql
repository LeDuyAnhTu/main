-- ================================================
-- Sản phẩm thêm
-- ================================================ 
drop procedure if exists sp_sanpham_them
go
CREATE PROCEDURE sp_sanpham_them
	@maSP char(10),
	@tenSP nvarchar(30),
	@hsd Date,
	@donGia int,
	@soLuongConLai int,
	@maLoai char(10),
	@maNCC char(10)
AS
BEGIN
	INSERT INTO SanPham VALUES (@maSP, @tenSP, @hsd, @donGia, @soLuongConLai, @maLoai, @maNCC)
END
GO

-- ================================================
-- Sản phẩm xóa
-- ================================================ 
DROP PROCEDURE IF EXISTS sp_sanpham_xoa
GO
CREATE PROCEDURE sp_sanpham_xoa
	@maSP char(10)
AS
BEGIN
	
	DELETE FROM SanPham WHERE maSP = @maSP
END
GO
-- ================================================
-- Sản phẩm sửa
-- ================================================ 
drop procedure if exists sp_sanpham_sua
go
CREATE PROCEDURE sp_sanpham_sua
		@maSP char(10),
		@tenSP nvarchar(30),
		@hsd date,
		@donGia int,
		@soLuongConLai int,
		@maLoai char(10),
		@maNCC char(10)
AS
BEGIN
	update SanPham set tenSP = @tenSP, donGia = @donGia, HSD = @hsd, soLuongConLai = @soLuongConLai, maLoai = @maLoai, maNCC = @maNCC
	 where maSP = @maSP -- chuẩn sql
END
GO
-- ================================================
-- Sản phẩm lấy danh sách
-- ================================================ 
drop procedure if exists sp_sanpham_layDanhSach
go
CREATE PROCEDURE sp_sanpham_layDanhSach
AS
BEGIN
	select maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', HSD, donGia as N'Đơn giá', soLuongConLai as N'Tồn kho', maLoai, maNCC 
	from SanPham
END
GO
exec sp_sanpham_layDanhSach

-- ================================================
-- Tìm kiếm 
-- ================================================ 
DROP PROCEDURE IF EXISTS sp_sanpham_timkiem_tenSP
GO
CREATE PROCEDURE sp_sanpham_timkiem_tenSP
    @key nvarchar(30)
AS
BEGIN
    SELECT maSP as N'Mã sản phẩm', tenSP as N'Tên sản phẩm', HSD, donGia as N'Đơn giá', soLuongConLai as N'Tồn kho', maLoai, maNCC 
	FROM SanPham 
	WHERE tenSP LIKE '%' + @key + '%'
END
GO

-- ================================================
-- Tìm kiếm theo mã
-- ================================================ 
DROP PROCEDURE IF EXISTS sp_sanpham_timkiem_maSP
GO
CREATE PROCEDURE sp_sanpham_timkiem_maSP
    @key char(10)
AS
BEGIN
    SELECT * 
	FROM SanPham 
	WHERE maSP = @key
END
GO
DROP PROCEDURE IF EXISTS sp_sanpham_timkiem_tenSP
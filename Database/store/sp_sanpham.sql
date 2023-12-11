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
	-- Đặt số lượng sản phẩm về 0
	UPDATE SanPham SET soLuongConLai = 0 WHERE maSP = @maSP
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
	select sp.maSP as N'Mã sản phẩm', sp.tenSP as N'Tên sản phẩm', sp.HSD, sp.donGia as N'Đơn giá', sp.soLuongConLai as N'Số lượng còn lại', lsp.tenLoai as N'Tên loại', ncc.tenNCC as N'Tên nhà cung cấp'
	from SanPham sp, LoaiSP lsp, NhaCungCap ncc
END
GO
exec sp_sanpham_layDanhSach

-- ================================================
-- Tìm kiếm 
-- ================================================ 
DROP PROCEDURE IF EXISTS sp_sanpham_timkiem
GO
CREATE PROCEDURE sp_sanpham_timkiem
    @key nvarchar(30)
AS
BEGIN
   select sp.maSP as N'Mã sản phẩm', sp.tenSP as N'Tên sản phẩm', sp.HSD, sp.donGia as N'Đơn giá', sp.soLuongConLai as N'Số lượng còn lại', lsp.tenLoai as N'Tên loại', ncc.tenNCC as N'Tên nhà cung cấp'
	from SanPham sp, LoaiSP lsp, NhaCungCap ncc
	WHERE tenSP LIKE '%' + @key + '%'
END
GO

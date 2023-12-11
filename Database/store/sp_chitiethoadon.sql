-- ================================================
-- Chi tiết hóa đơn thêm
-- ================================================
drop procedure if exists sp_chitiethoadon_them
go
CREATE PROCEDURE sp_chitiethoadon_them
	@maHD char(10),
    @maSP char(10),
    @soLuong int
AS
BEGIN
	INSERT INTO ChiTietHD VALUES (@maHD, @maSP, @soLuong)
END
GO
-- ================================================
-- Chi tiết Hóa đơn xóa
-- ================================================
DROP PROCEDURE IF EXISTS sp_chitiethoadon_xoa_hoadon
GO
CREATE PROCEDURE sp_chitiethoadon_xoa_hoadon
	@maHD char(10)
AS
BEGIN
	DELETE FROM ChiTietHD WHERE maHD = @maHD
END
DROP PROCEDURE IF EXISTS sp_chitiethoadon_xoa_sanpham
GO
CREATE PROCEDURE sp_chitiethoadon_xoa_sanpham
	@maHD char(10),
	@maSP char(10)
AS
BEGIN
	DELETE FROM ChiTietHD WHERE maHD = @maHD AND maSP = @maSP
END
---- ================================================
---- Chi tiết Hóa đơn sửa
---- ================================================
drop procedure if exists sp_chitiethoadon_sua
go
CREATE PROCEDURE sp_chitiethoadon_sua
	@maHD char(10),
    @maSP char(10),
    @soLuong int
AS
BEGIN
	update ChiTietHD set maSP = @maSP , soLuong = @soLuong where maHD = @maHD -- chuẩn sql
END
GO
-- ================================================
-- Chi tiết hóa đơn lấy danh sách
-- ============================================
drop procedure if exists sp_chitiethoadon_layDanhSach
go
CREATE PROCEDURE sp_chitiethoadon_layDanhSach
AS
BEGIN
	SELECT * from ChiTietHD
END
GO
exec sp_chitiethoadon_layDanhSach

-- ================================================
-- Tìm kiếm theo mã hóa đơn
-- ============================================
drop procedure if exists sp_chitiethoadon_timKiemTheoMaHD
go
CREATE PROCEDURE sp_chitiethoadon_timKiemTheoMaHD
	@maHD char(10)
AS
BEGIN
	SELECT * FROM ChiTietHD WHERE maHD = @maHD
END


-- ================================================
-- Chi tiết hóa đơn lấy danh sách chi tiết
-- ============================================
drop procedure if exists sp_chitiethoadon_layDanhSach_chitiet
go
CREATE PROCEDURE sp_chitiethoadon_layDanhSach_chitiet
@maHD char(10)
AS
BEGIN
	SELECT sp.tenSP as N'Tên sản phẩm', sp.donGia as N'Đơn giá', ct.soLuong as N'Số lượng', sp.donGia * ct.soLuong as N'Thành tiền'
	from ChiTietHD ct, SanPham sp
	where ct.maSP = sp.maSP AND ct.maHD = @maHD
END
GO
exec sp_chitiethoadon_layDanhSach





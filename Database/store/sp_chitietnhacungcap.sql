-- ================================================
-- Chi tiết nhà cung cấp thêm
-- ================================================
drop procedure if exists sp_chitietnhacungcap_them
go
CREATE PROCEDURE sp_chitietnhacungcap_them
	@maNCC char(10),
    @maSP char(10),
    @soLuong int
AS
BEGIN
	INSERT INTO ChiTietCC VALUES (@maNCC, @maSP, @soLuong)
END
GO
-- ================================================
-- Chi tiết nhà cung cấp xóa
-- ================================================
DROP PROCEDURE IF EXISTS sp_chitietnhacungcap_xoa
GO
CREATE PROCEDURE sp_chitietnhacungcap_xoa
	@maNCC char(10)
AS
BEGIN
	DELETE FROM ChiTietCC WHERE maNCC = @maNCC
END
--GO
---- ================================================
---- Chi tiết nhà cung cấp sửa
---- ================================================
--drop procedure if exists sp_chitietnhacungcap_sua
--go
--CREATE PROCEDURE sp_chitietnhacungcap_sua
--	@maNCC char(10),
--    @maSP char(10),
--    @soLuong int
--AS
--BEGIN
--	update ChiTietCC set maSP = @maSP , soLuong = @soLuong where maNCC = @maNCC -- chuẩn sql
--END
GO
-- ================================================
-- Chi tiết nhà cung cấp lấy danh sách
-- ================================================
drop procedure if exists sp_chitietnhacungcap_layDanhSach
go
CREATE PROCEDURE sp_chitietnhacungcap_layDanhSach
AS
BEGIN
	SELECT * from ChiTietCC
END
GO
exec sp_chitietnhacungcap_layDanhSach




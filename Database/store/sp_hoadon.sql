-- ================================================
-- hóa đơn thêm
-- ================================================
drop procedure if exists sp_hoadon_them
go
CREATE PROCEDURE sp_hoadon_them
	@maHD char(10),
    @ngayLap date,
    @maNV char(10),
    @maKH char(10),
	@maKM char(10),
    @thanhTien int
AS
BEGIN
	INSERT INTO HoaDon VALUES (@maHD, @ngayLap, @maNV,@maKH, @maHD, @thanhTien)
END
GO
-- ================================================
-- Hóa đơn xóa
-- ===============================================

DROP PROCEDURE IF EXISTS sp_hoadon_xoa
GO
CREATE PROCEDURE sp_hoadon_xoa
	@maHD char(10)
AS
BEGIN
	DELETE FROM HoaDon WHERE maHD = @maHD
END
GO
-- ================================================
-- Hóa đơn sửa
-- ================================================
drop procedure if exists sp_hoadon_sua
go
CREATE PROCEDURE sp_hoadon_sua
	@maHD char(10),
    @ngayLap date,
    @maNV char(10),
    @maKH char(10),
    @thanhTien int
AS
BEGIN
	update HoaDon set ngayLap = @ngayLap , maNV = @maNV, maKH = @maKH where maHD = @maHD -- chuẩn sql
END
GO
-- ================================================
-- Hóa đơn lấy danh sách
-- ================================================
drop procedure if exists sp_hoadon_layDanhSach
go
CREATE PROCEDURE sp_hoadon_layDanhSach
AS
BEGIN
	SELECT * from HoaDon
END
GO
exec sp_hoadon_layDanhSach



drop procedure if exists sp_hoadon_timkiem
go
CREATE PROCEDURE sp_hoadon_timkiem
    @ngayBatDau date,
    @ngayKetThuc date
AS
BEGIN
    SET NOCOUNT ON;

    SELECT *
    FROM HoaDon
    WHERE ngayLap BETWEEN @ngayBatDau AND @ngayKetThuc;
END
GO



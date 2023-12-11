-- ================================================
-- Chi nhánh thêm
-- ================================================
drop procedure if exists sp_chinhanh_them
go
CREATE PROCEDURE sp_chinhanh_them
	@maCN char(10),
    @tenCN nvarchar(30),
    @diaChi nvarchar(100),
    @maKV char(10),
    @maTRP char(10)
AS
BEGIN
	INSERT INTO ChiNhanh VALUES (@maCN, @tenCN, @diaChi, @maKV, @maTRP)
END
GO

-- ================================================
-- Chi nhánh xóa
-- ================================================

DROP PROCEDURE IF EXISTS sp_chinhanh_xoa
GO
CREATE PROCEDURE sp_chinhanh_xoa
	@maCN char(10)
AS
BEGIN
	DELETE FROM ChiNhanh WHERE maCN = @maCN
END
GO

-- ================================================
-- Chi nhánh sửa
-- ================================================
drop procedure if exists sp_chinhanh_sua
go
CREATE PROCEDURE sp_chinhanh_sua
	@maCN char(10),
    @tenCN nvarchar(30),
    @diaChi nvarchar(100),
    @maKV char(10),
    @maTRP char(10)
AS
BEGIN
	update ChiNhanh set tenCN = @tenCN , diaChi = @diaChi,  maKV = @maKV, maTRP = @maTRP where maCN = @maCN
END
GO
-- ================================================
-- Chi nhánh lấy danh sách
-- ================================================

drop procedure if exists sp_chinhanh_layDanhSach
go
CREATE PROCEDURE sp_chinhanh_layDanhSach
AS
BEGIN
	
	SELECT * from ChiNhanh
END
GO
exec sp_chinhanh_layDanhSach

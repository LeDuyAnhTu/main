--In danh sách loại sản phẩm
go
create proc sp_loaisp_selectall
as
begin
	SELECT *
	FROM LOAISP
end

--Thêm loại sản phẩm
go
create proc sp_loaisp_them
@maloai CHAR(11)
,@tenloai NVARCHAR(30)
,@ghichu NVARCHAR(100)
as
begin
	INSERT INTO LOAISP
	VALUES(@maloai, @tenloai, @ghichu)
end

--Sửa thông tin loại sản phẩm
go
create proc sp_loaisp_sua
@maloai CHAR(11)
,@tenloai NVARCHAR(30)
,@ghichu NVARCHAR(100)
as
begin
	UPDATE LOAISP
	SET TENLOAI = @tenloai, GHICHU = @ghichu
	WHERE MALOAI = @maloai;
end

--Xóa loại sản phẩm
go
create proc sp_loaisp_xoa
@maloai CHAR(11)
as
begin
	DELETE FROM LOAISP
	WHERE MALOAI = @maloai;
end

--Tìm kiếm theo mã loại
go
create proc sp_loaisp_timkem
@maloai CHAR(11)
as
begin
	SELECT *
	FROM LOAISP
	WHERE MALOAI = @maloai
end
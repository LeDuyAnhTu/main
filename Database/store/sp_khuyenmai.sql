drop proc if exists sp_khuyenmai_layDanhSach
go
create proc sp_khuyenmai_layDanhSach
as
begin
	select *
	from KhuyenMai
end
go
exec sp_khuyenmai_layDanhSach

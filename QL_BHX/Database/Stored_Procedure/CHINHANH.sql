--In danh sách các chi nhánh
go
create proc sp_chinhanh_selectall
as
begin
	SELECT *
	FROM CHINHANH
end

--Thêm chi nhánh
go
create proc sp_chinhanh_them
as
@macn CHAR(4) 
, @tencn NVARCHAR(30)
, @diachicn NVARCHAR(100))
begin
	INSERT INTO CHINHANH
	VALUES(@macn, @tencn, @diachicn)
end


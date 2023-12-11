set dateformat dmy;
---------------------------------------------------------------------
----------------------------- Nhân Viên -----------------------------
---------------------------------------------------------------------
go
insert into KhuVuc
values ('KV01',N'TPHCM'),
('KV02',N'Hải phòng'),
('KV03',N'Hà nội')

go
insert into ChiNhanh
values ('CN01', N'Chi nhánh Q1', N'160 Đ. Đề Thám, Phường Cầu Ông Lãnh, Quận 1, Thành phố Hồ Chí Minh', 'KV01', null),
('CN02', N'Chi nhánh Q2', N'72 Quốc Hương, Ấp Thảo Điền, P. Thảo Điền, Quận 2, TP. HCM', 'KV01', null),
('CN03', N'Chi nhánh Q3', N'268/16 Lý Thái Tổ, Phường 01, Quận 3, TP. Hồ Chí Minh', 'KV01', null)

go
insert into NhanVien
values ('NV0001', N'Bùi Quang Huy',1,'20/10/2010','0321654987','03216549871',5000000,'CN01'),
('NV0002', N'Bùi Hoàng Nam',1,'20/10/2010','0321654987','03216549871',3000000,'CN01'),
('NV0003', N'Bùi Anh Nghĩa',1,'20/10/2010','0321654987','03216549871',3000000,'CN01'),
('NV0004', N'Bùi Trúc Nhi',0,'20/10/2010','0321654987','03216549871',5000000,'CN02'),
('NV0005', N'Bùi Yến Mĩ',0,'20/10/2010','0321654987','03216549871',3000000,'CN02'),
('NV0006', N'Bùi Nhật Nam', 1,'20/10/2010','0321654987','03216549871',5000000,'CN03')

go
update ChiNhanh
set maTRP = 'NV0001'
where maCN = 'CN01'
go
update ChiNhanh
set maTRP = 'NV0004'
where maCN = 'CN02'
go
update ChiNhanh
set maTRP = 'NV0006'
where maCN = 'CN03'


go
insert into KhachHang
values ('KH0001',N'Bùi Anh Tuấn', '0123456789', '10/10/2010', 0),
('KH0002',N'Bùi Anh Huy', '0123456789', '06/03/2010', 10),
('KH0003',N'Bùi Quốc Đạt', '0123456789', '12/11/2010', 3000)

go
insert into QuyenTruyCap
values ('Q1', N'Admin'),
('Q2', N'Quản lý'),
('Q3', N'Nhân Viên')

go
insert into TaiKhoan
values ('admin', '012356789',null,'Q1');

---------------------------------------------------------------------
----------------------------- Sản phẩm ------------------------------
---------------------------------------------------------------------

go
insert into NhaCungCap
values ('NCC01', N'Vissan', '8435533999', N'420 Nơ Trang Long, P. 13, Quận Bình Thạnh, TP.HCM, Việt Nam'),
('NCC02', N'Orion Vina', '0283512312', N'Tầng 22, TTTM Pearl Plaza, 561A Điện Biên Phủ, phường 25, quận Bình Thạnh, TP HCM'),
('NCC03', N'Vinamilk', '0285415555', N'Số 10, Đường Tân Trào, Phường Tân Phú, Quận 7, Tp. Hồ Chí Minh')

go
insert into LoaiSP
values ('LS01', N'Thịt'),
('LS02', N'Sữa'),
('LS03', N'Bánh'),
('LS04', N'Nước')

go
insert into SanPham
values ('SP0001', N'Heo 2 Lát', '1/12/2024', 30000, 300, 'LS01', 'NCC01'),
('SP0002', N'ChocoPie',  '1/12/2024', 30000, 300, 'LS03', 'NCC02'),
('SP0003', N'Sữa tươi Vinamilk',  '1/12/2024', 30000, 300, 'LS02', 'NCC03'),
('SP0004', N'Xúc xích dinh dưỡng',  '1/12/2024', 30000, 300, 'LS01', null), 
('SP0005', N'Tiêu đen', '1/12/2024', 20000, 200, 'LS02', 'NCC03'),
('SP0006', N'Bánh quy hạt dẻ cười', '1/12/2024', 25000, 150, 'LS03', 'NCC01'),
    ('SP0007', N'Nước ngọt Pepsi', '1/12/2024', 18000, 350, 'LS01', 'NCC02'),
    ('SP0008', N'Thịt bò Úc', '1/12/2024', 35000, 100, 'LS02', 'NCC02'),
    ('SP0009', N'Rau cải thảo', '1/12/2024', 15000, 400, 'LS03', 'NCC03'),
    ('SP0010', N'Kẹo sô cô la Kinder', '1/12/2024', 22000, 250, 'LS01', 'NCC03'),
    ('SP0011', N'Sữa đậu nành', '1/12/2024', 27000, 180, 'LS02', 'NCC03'),
    ('SP0012', N'Bánh mì sandwich thịt', '1/12/2024', 20000, 300, 'LS03', 'NCC01'),
    ('SP0013', N'Nước suối Lavie', '1/12/2024', 12000, 500, 'LS01', 'NCC02'),
    ('SP0014', N'Mì gói Hảo Hảo', '1/12/2024', 8000, 700, 'LS02', 'NCC02'),
    ('SP0015', N'Gà ta', '1/12/2024', 30000, 120, 'LS03', 'NCC01'),
    ('SP0016', N'Kem dừa', '1/12/2024', 25000, 180, 'LS01', 'NCC02'),
    ('SP0017', N'Rượu vang Chile', '1/12/2024', 42000, 90, 'LS02', 'NCC03'),
    ('SP0018', N'Pizza hải sản', '1/12/2024', 28000, 200, 'LS03', 'NCC02'),
    ('SP0019', N'Bột ngọt Ajinomoto', '1/12/2024', 10000, 400, 'LS01', 'NCC01'),
    ('SP0020', N'Cà chua', '1/12/2024', 5000, 600, 'LS02', 'NCC01');

---------------------------------------------------------------------
------------------------------ Hóa đơn ------------------------------
---------------------------------------------------------------------

go
insert into HoaDon
values ('HD0001', '18-11-2023', 'NV0002',null,null, 0),
('HD0002', '18-11-2023', 'NV0004',null,null, 0),
('HD0003', '18-11-2023', 'NV0006',null,null, 0),
('HD0004', '15-11-2023', 'NV0003',null,null, 0)


go
insert into ChiTietHD
values ('HD0001','SP0001',20),
('HD0002','SP0001',20),
('HD0001','SP0002',20),
('HD0002','SP0003',20),
('HD0003','SP0001',20),
('HD0003','SP0003',20),
('HD0001','SP0004',20),
('HD0003','SP0004',20)


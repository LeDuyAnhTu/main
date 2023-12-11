go
use master
drop database QLBHX

go
create database QLBHX

go
use QLBHX

go
create table KhuVuc(
maKV char(10) not null,
tenKV nvarchar(50) not null)

go
create table ChiNhanh(
maCN char(10) not null,
tenCN nvarchar(30) not null,
diaChi nvarchar(100) not null,
maKV char(10),
maTRP char(10))

go
create table NhanVien(
maNV char(10) not null,
tenNV nvarchar(30) not null,
gioiTinh tinyint not null,
ngaySinh date not null,
SDT char(10) not null,
CCCD char(11) not null,
luong int,
maCN char(10))

go
create table QuyenTruyCap(
maQTC char(10) not null,
tenQTC nvarchar(30) not null)

go
create table TaiKhoan(
tenTK char(30) not null,
matKhau char(30) not null,
maNV char(10),
maQTC char(10))

go
create table LoaiSP(
maLoai char(10) not null,
tenLoai nvarchar(30) not null)

go
create table NhaCungCap(
maNCC char(10) not null,
tenNCC nvarchar(30) not null,
SDTNCC char(10) not null,
diaChi nvarchar(100) not null)

go
create table SanPham(
maSP char(10) not null,
tenSP nvarchar(30) not null,
HSD date not null,
donGia int not null,
soLuongConLai int not null,
maLoai char(10),
maNCC char(10))

go
create table KhachHang(
maKH char(10) not null,
tenKH nvarchar(30) not null,
SDT char(10) not null,
ngaySinh date not null,
diemTichLuy int)

go
create table HoaDon(
maHD char(10) not null,
ngayLap date not null,
maNV char(10) not null,
maKH char(10),
maKM char(10),
thanhTien int)

go
create table ChiTietHD(
maHD char(10) not null,
maSP char(10) not null,
soLuong int not null)

go
create table ChiTietCC(
maNCC char(10) not null,
maSP char(10) not null,
soLuong int not null)

go
create table KhuyenMai(
maKM char(10) not null,
tenKM nvarchar(30) not null,
ngayBD date not null,
ngayKT date not null,
hinhThucKM nvarchar(30) not null)

go
create table ChiTietKM(
maKM char(10) not null,
maSP char(10) not null)

------------------------------PRIMARY KEYS------------------------------
go 
alter table KhuVuc
add constraint pk_khuvuc primary key (maKV)
go 
alter table NhanVien
add constraint pk_nhanvien primary key (maNV)
go 
alter table TaiKhoan
add constraint pk_taikhoan primary key (tenTK)
go 
alter table QuyenTruyCap
add constraint pk_quyentruycap primary key (maQTC)
go 
alter table ChiNhanh
add constraint pk_chinhanh primary key (maCN)
go 
alter table NhaCungCap
add constraint pk_nhacungcap primary key (maNCC)
go 
alter table LoaiSP
add constraint pk_loaisp primary key (maLoai)
go 
alter table SanPham
add constraint pk_sanpham primary key (maSP)
go 
alter table HoaDon
add constraint pk_hoadon primary key (maHD)
go 
alter table KhachHang
add constraint pk_khachhang primary key (maKH)
go 
alter table KhuyenMai
add constraint pk_khuyenmai primary key (maKM)
go 
alter table ChiTietKM
add constraint pk_chitietkm primary key (maKM,maSP)

------------------------------fOREIGN KEYS------------------------------
go 
alter table ChiNhanh
add constraint fk_chinhanh_khuvuc foreign key (maKV) references KhuVuc(maKV)
go 
alter table ChiNhanh
add constraint fk_chinhanh_truongphong foreign key (maTRP) references NhanVien(maNV)
go 
alter table NhanVien
add constraint fk_nhanvien_chinhanh foreign key (maCN) references ChiNhanh(maCN)
go 
alter table TaiKhoan
add constraint fk_taikhoan_nhanvien foreign key (maNV) references NhanVien(maNV)
go 
alter table TaiKhoan
add constraint fk_taikhoan_quyentruycap foreign key (maQTC) references QuyenTruyCap(maQTC)
go 
alter table SanPham
add constraint fk_sanpham_loaisp foreign key (maLoai) references LoaiSP(maLoai)
go 
alter table SanPham
add constraint fk_sanpham_nhacungcap foreign key (maNCC) references NhaCungCap(maNCC)
go 
alter table HoaDon
add constraint fk_hoadon_nhanvien foreign key (maNV) references NhanVien(maNV)
go 
alter table HoaDon
add constraint fk_hoadon_khachhang foreign key (maKH) references KhachHang(maKH)
go 
alter table HoaDon
add constraint fk_hoadon_khuyenmai foreign key (maKM) references KhuyenMai(maKM)
go 
alter table ChiTietHD
add constraint fk_chitiethd_hoadon foreign key (maHD) references HoaDon(maHD)
go 
alter table ChiTietHD
add constraint fk_chitiethd_sanpham foreign key (maSP) references SanPham(maSP)
go 
alter table ChiTietCC
add constraint fk_chitietcc_nhacungcap foreign key (maNCC) references NhaCungCap(maNCC)
go 
alter table ChiTietCC
add constraint fk_chitietcc_sanpham foreign key (maSP) references SanPham(maSP)
go 
alter table ChiTietKM
add constraint fk_chitietkm_khuyenmai foreign key (maKM) references KhuyenMai(maKM)
go 
alter table ChiTietKM
add constraint fk_chitietkm_sanpham foreign key (maSP) references SanPham(maSP)

------------------------------UNIQUE KEYS------------------------------
go 
alter table TaiKhoan
add constraint uk_taikhoan unique (maNV)
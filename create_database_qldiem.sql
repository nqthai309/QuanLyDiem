use master
go

create database QuanLyDiemSinhVien
go

use QuanLyDiemSinhVien
go

create table SinhVien(
	MaSV int PRIMARY KEY IDENTITY(1,1),
	HoVaTen nvarchar(250),
	NgaySinh datetime,
	Khoa nvarchar(250),
	Lop nvarchar(250),
	TenMonHoc nvarchar(250),
	MaMonHoc nvarchar(250),
	SoTinChi int,
	ThiGiuaKi int,
	ChuyenCan int,
	ThiCuoiKi int,
	TrungBinh real,
)
go

create table NguoiDung(
	TenDangNhap varchar(250) PRIMARY KEY,
	MatKhau varchar(250)
)
go


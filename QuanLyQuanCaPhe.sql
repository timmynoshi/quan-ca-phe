USE master
GO

IF EXISTS (SELECT * FROM sysdatabases WHERE name='QuanLyQuanCaPhe')
	DROP DATABASE QuanLyQuanCaPhe
GO

CREATE DATABASE QuanLyQuanCaPhe
GO

USE QuanLyQuanCaPhe
GO

CREATE TABLE NguoiDung ( TenDangNhap nvarchar(20), 
						 MatKhau nvarchar(10),	
						 QuyenHan nvarchar(10)
						 )

CREATE TABLE KhachHang ( MaKH nvarchar(10),
						 TenKH nvarchar(50),
						 SoDienThoaiKH nvarchar(10),
						 PRIMARY KEY (MaKH)
						 )
GO

CREATE TABLE Nuoc ( MaNuoc nvarchar(10),
					TenNuoc nvarchar(50),
					DonGia int,
					PRIMARY KEY (MaNuoc)
					)
GO

CREATE TABLE NhanVien ( MaNV nvarchar(10),
						TenNV nvarchar(30),
						SoDienThoaiNV nvarchar(10),
						NamSinh nvarchar(5),
						PRIMARY KEY (MaNV)
						)
GO
CREATE TABLE Ban ( MaBan nvarchar(10),
				   SoCho int,
				   MaNV nvarchar(10),
				   PRIMARY KEY  (MaBan),
				   FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
				   )
GO
CREATE TABLE HoaDon ( MaHD nvarchar(10),
					  MaKH nvarchar(10),
					  MaBan nvarchar(10),
					  NgayNhapDon date,
					  PRIMARY  KEY (MaHD),
					  FOREIGN KEY (MaKH) REFERENCES KhachHang(MaKH),
					  FOREIGN KEY (MaBan) REFERENCES Ban(MaBan)
					 )
GO
CREATE TABLE CTHD ( MaHD nvarchar(10),
				    MaNuoc nvarchar(10),
					SoLuong int,
					ThanhTien int,
					TrangThai nvarchar(20),
				    PRIMARY KEY (MaHD,MaNuoc),
					FOREIGN KEY (MaHD) REFERENCES HoaDon(MaHD),
					FOREIGN KEY (MaNuoc) REFERENCES Nuoc(MaNuoc)
					)

--Bàn: 10
--Nhân viên:5
--Nước: 10
INSERT INTO Nuoc VALUES (N'NC1',N'Cà Phê Đen',20000),
						(N'NC2',N'Cà Phê Sữa Đá',22000),
						(N'NC3',N'Bạc Xỉu',22000),
						(N'NC4',N'Cà Phê Trứng',30000),
						(N'NC5',N'Trà Ô Lông',30000),
						(N'NC6',N'Trà Đào',35000),
						(N'NC7',N'Trà Vải ',35000),
						(N'NC8',N'Trà Hoa Cúc',30000),
						(N'NC9',N'Sinh Tố Dâu',35000),
						(N'NC10',N'Sinh Tố Bơ',35000)
GO
						
INSERT INTO NhanVien VALUES (N'NV1',N'Dương Hoàng Dũng',N'0978657374',N'2003'),
							(N'NV2',N'Đổ Nhật Trường',N'0912353124',N'2003'),
							(N'NV3',N'Vương Quốc Anh',N'0923121335',N'2003'),
							(N'NV4',N'Nguyễn Thanh Tùng',N'0945123156',N'2003'),
							(N'NV5',N'Diệp Minh Trọng',N'0938117225',N'2003')
GO
INSERT INTO Ban VALUES (N'B1',4,N'NV1'),
					   (N'B2',4,N'NV1'),
					   (N'B3',4,N'NV2'),
					   (N'B4',4,N'NV2'),
					   (N'B5',4,N'NV3'),
					   (N'B6',4,N'NV3'),
					   (N'B7',4,N'NV4'),
					   (N'B8',4,N'NV4'),
					   (N'B9',4,N'NV5'),
					   (N'B10',4,N'NV5')
GO

INSERT INTO NguoiDung VALUES (N'Admin',N'123',N'QuanTri'),
							 (N'Nhanvien',N'123',N'NhanVien')
GO
					  
INSERT INTO KhachHang VALUES (N'KH1',N'Nguyễn Thanh Tí',N'0287261827'),
							 (N'KH2',N'Vương Ngọc Khôi Ngu',N'0923548712'),
							 (N'KH3',N'Diệp Bảo Thà',N'0612542363')

GO
SELECT * 
FROM Ban
SELECT * 
FROM NhanVien
SELECT *
FROM Nuoc

/*INSERT INTO HoaDon (MaHD, MaKH, MaBan, NgayNhapDon) VALUES (N'HD1', N'KH1', N'B1', '07/01/2024')*/

SELECT *
FROM KhachHang

SELECT *
FROM HoaDon

SELECT *
FROM CTHD

SELECT NV.MaNV AS N'Mã nhân viên', TenNV AS N'Họ tên', COUNT(*) AS N'Số lần phục vụ'
FROM NhanVien NV INNER JOIN Ban B ON NV.MaNV=B.MaNV
				 INNER JOIN HoaDon HD ON B.MaBan=HD.MaBan
GROUP BY NV.MaNV, TenNV
ORDER BY COUNT(*) DESC



SELECT KH.MaKH AS N'Mã khách hàng', TenKH AS N'Họ tên', COUNT(*) AS N'Số lần ghé quán'
FROM KhachHang KH INNER JOIN HoaDon HD ON KH.MaKH=HD.MaKH
GROUP BY KH.MaKH, TenKH
ORDER BY COUNT(*) DESC

SELECT TenNuoc, SoLuong, DonGia
FROM Nuoc N INNER JOIN CTHD CT ON N.MaNuoc=CT.MaNuoc
			INNER JOIN HoaDon HD ON CT.MaHD=HD.MaHD
WHERE HD.MaHD='HD12'

-- Trong VS có class ConString, chỉ cần đổi chuỗi đó thôi nha là chạy đc




use master
drop database QL_BANMAYLANH
-------------------------------------------------TẠO DATABASE---------------------------------------
CREATE DATABASE QL_BANMAYLANH
GO
USE QL_BANMAYLANH
GO
-------------------------------------------------TẠO BẢNG-------------------------------------------
--Bảng nhà cung cấp
CREATE TABLE NHACUNGCAP
(
	MANCC VARCHAR(20) not null,
	TENNCC NVARCHAR(50) not null,
	DIACHI nvarchar(100),
	CONSTRAINT PK_NCC PRIMARY KEY(MANCC)
)
GO
--Bảng bộ phận
CREATE TABLE BOPHAN
(
	 MABP VARCHAR(20) not null,
	 TENBP nvarchar(50) not null,
	 CONSTRAINT PK_BP PRIMARY KEY(MABP)
)
GO
--Bảng nhân viên
CREATE TABLE NHANVIEN
(
	MANV VARCHAR(20) not null,
	MABP VARCHAR(20),
	TENNV nvarchar(50),
	GIOITINH nvarchar(3),
	NGAYVAOLAM datetime,
	NGAYSINH datetime,
	DIENTHOAI char(10),
	DIACHI nvarchar(100),
	CONSTRAINT PK_NV PRIMARY KEY(MANV),
	CONSTRAINT FK_NV_BP FOREIGN KEY(MABP) REFERENCES BOPHAN(MABP)
)
GO
--Bảng khách hàng
CREATE TABLE KHACHHANG
(
	MAKH VARCHAR(20) NOT NULL,
	TENKH NVARCHAR(30) NOT NULL,
	DIACHI NVARCHAR(100),
	SDT  CHAR(10),
	GHICHU NVARCHAR(100),
	CONSTRAINT PK_KH PRIMARY KEY(MAKH)
)
GO
-----------Loai hang hoa---------------
CREATE TABLE LOAI_HANGHOA
(
	MALOAI VARCHAR(20) NOT NULL,
	TENLOAI NVARCHAR(30),
	TRUSOCHINH NVARCHAR(100),
	EMAIL VARCHAR(30),
	CONSTRAINT PK_LOAIHH PRIMARY KEY(MALOAI),
	
)
GO
--Bảng hàng hóa 
CREATE TABLE HANGHOA
(
	MAHH VARCHAR(20) not null,
	TENHH nvarchar(50),
	GIANHAP money,
	HINHANH NVARCHAR(MAX),
	SOLUONG int,
	MALOAI VARCHAR(20),
	MANCC VARCHAR(20),
	CONSTRAINT PK_HH PRIMARY KEY(MAHH),
	CONSTRAINT FK_HH_LOAI FOREIGN KEY(MALOAI) REFERENCES LOAI_HANGHOA(MALOAI)
)
GO
---------------Bang thong so ky thuat----------------
CREATE TABLE THONGSOKT_HH
(
	MAHH VARCHAR(20) NOT NULL,
	KICHTHUOC VARCHAR(20),
	CONGSUAT FLOAT ,
	TIETKIEMDIEN VARCHAR(10),
	TRONGLUONG FLOAT,
	NAMSX INT,
	BAOHANH VARCHAR(20),
	CONSTRAINT PK_THONGSOKT_HH PRIMARY KEY(MAHH),
	CONSTRAINT FK_THONGSOKT_HANGHOA FOREIGN KEY(MAHH) REFERENCES HANGHOA(MAHH)
)
GO
--Bảng hóa đơn nhập
CREATE TABLE HOADONNHAP
(
	MAHDN VARCHAR(20) not null,
	MANV VARCHAR(20),
	MANCC VARCHAR(20),
	TONGTIEN float,
	NGAY_GIONHAP DATETIME,
	CONSTRAINT PK_HDN PRIMARY KEY(MAHDN),
	CONSTRAINT FK_HDN_NV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
	CONSTRAINT FK_HDN_NCC FOREIGN KEY(MANCC) REFERENCES NHACUNGCAP(MANCC)
)
GO
SELECT * FROM HOADONNHAP
CREATE TABLE CHITIETHOADONNHAP
(
	MAHDN VARCHAR(20) NOT NULL,
	MAHH VARCHAR(20),
	TENHH NVARCHAR(50),
	SOLUONG INT,
	DONGIA DECIMAL(10,2),
	GIAMGIA FLOAT,
	THANHTIEN DECIMAL(10,2), 
	CONSTRAINT FK_CTHDN_HDN FOREIGN KEY(MAHDN) REFERENCES HOADONNHAP(MAHDN),
	CONSTRAINT FK_CTHDN_HH FOREIGN KEY(MAHH) REFERENCES HANGHOA(MAHH)
)
GO
--Bảng hoa đơn xuất
CREATE TABLE HOADON_BANHANG
(
	MAHDX VARCHAR(20) not null,
	MAKH VARCHAR(20),
	TONGTIEN float,
	NGAY_GIOXUAT datetime,
	MANV VARCHAR(20),
	CONSTRAINT PK_HDBH PRIMARY KEY(MAHDX),
	CONSTRAINT FK_HDBH_KH FOREIGN KEY(MAKH) REFERENCES KHACHHANG(MAKH),
	CONSTRAINT FK_HDBH_NV FOREIGN KEY(MANV) REFERENCES NHANVIEN(MANV),
)
GO

--Bảng chi tiết hóa đơn xuất
CREATE TABLE CHITIETHOADON_BANHANG
(
	MAHDX VARCHAR(20) not null,
	MAHH VARCHAR(20) NOT NULL,
	TENHH VARCHAR(20),
	SOLUONG int,
	DONGIABAN DECIMAL(10,2),
	GIAMGIA FLOAT,
	THANHTIEN DECIMAL(10,2),
	CONSTRAINT FK_CTHDBH_HDBH FOREIGN KEY(MAHDX) REFERENCES HOADON_BANHANG(MAHDX),
	CONSTRAINT FK_CTHDBH_HH FOREIGN KEY(MAHH) REFERENCES HANGHOA(MAHH)
)
GO
--Bảng người dùng
create table NGUOIDUNG(
	username char(10) not null primary key,
	password char(50),
	QuyenTC char(10),
	MANV varchar(20),
	constraint FK_MaNV_NguoiDung foreign key(MANV) references NHANVIEN(MANV))
GO
---------------------CẬP NHẬT LẠI SỐ LƯỢNG BẢNG HÀNG HÓA KHI NHẬP HÀNG----------------------------
GO
CREATE TRIGGER trg_UpdateSoLuongHangHoa
ON CHITIETHOADONNHAP
AFTER INSERT
AS
BEGIN
    -- Cập nhật số lượng trong bảng HANGHOA
    UPDATE HANGHOA
    SET SOLUONG +=  i.SOLUONG
    FROM HANGHOA
    INNER JOIN INSERTED i ON HANGHOA.MAHH = i.MAHH;
END;
GO
------------------------------CẬP NHẬT LẠI SỐ LƯỢNG HÀNG HÓA KHI BÁN HÀNG -----------------------
GO
CREATE TRIGGER trg_UpdateSoLuongHangHoa_Ban
ON CHITIETHOADON_BANHANG
AFTER INSERT
AS
BEGIN
    -- Cập nhật số lượng trong bảng HANGHOA
    UPDATE HANGHOA
    SET SOLUONG -=  i.SOLUONG
    FROM HANGHOA
    INNER JOIN INSERTED i ON HANGHOA.MAHH = i.MAHH;

    -- Kiểm tra nếu số lượng bán nhiều hơn số lượng trong bảng HANGHOA, thì hiện thông báo
    IF EXISTS (
        SELECT 1
        FROM INSERTED i
        INNER JOIN HANGHOA h ON i.MAHH = h.MAHH
        WHERE i.SOLUONG > h.SOLUONG
    )
    BEGIN
        RAISERROR(N'Số lượng bán nhiều hơn số lượng trong kho.', 16, 1);
    END;
END;


-----------------------------------------NHẬP LIỆU--------------------------------------
--Bảng nhà cung cấp
INSERT INTO NHACUNGCAP
VALUES('NCC01',N'Gree Electric Appliances Inc - Chi nhánh Việt Nam',N'Tầng 12, Toà nhà Sông Đà, 9 Đinh Công Tráng, Tân Mai, Hoàng Mai, Hà Nội'),
('NCC02',N'Panasonic - Chi nhánh Việt Nam',N'Lầu 10, Tòa nhà số 14, Đường Tôn Đức Thắng, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh'),
('NCC03',N'Daikin - Chi nhánh Việt Nam',N'Tầng 4, Tòa nhà CDC, 25 Lê Đại Hành, Phường 7, Quận 11, TP. Hồ Chí Minh'),
('NCC04',N'Samsung - Chi nhánh Việt Nam',N'Lô J1-J2 Tổ 16A, Khu công nghiệp Yên Phong, Huyện Yên Phong, Bắc Ninh'),
('NCC05',N'LG - Chi nhánh Việt Nam',N'Lầu 17, Tòa nhà Kumho Asiana Plaza, 39 Lê Duẩn, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh'),
('NCC07',N'Carrier',N'13995 Pasteur Blvd., Palm Beach Gardens, FL 33418, USA.'),
('NCC08',N'Trane Technologies',N'800 Beaty Street, Davidson, NC 28036, USA.'),
('NCC09',N'Fujitsu General',N'4-1-1, Kamikodanaka, Nakahara-ku, Kawasaki, Kanagawa 211-8526, Japan.'),
('NCC10',N'Sharp Corporation',N'1 Takumi-cho, Sakai-ku, Sakai City, Osaka 590-8522, Japan.'),
('NCC11',N'Hitachi Cooling & Heating',N'1-1, Hitotsubashi, Chiyoda-ku, Tokyo 100-8280, Japan.'),
('NCC012',N'Mitsubishi Electric',N'Tokyo Building, 2-7-3 Marunouchi, Chiyoda-ku, Tokyo 100-8310, Japan.'),
('NCC013',N'GREE Electric Appliances Inc. of Zhuhai',N'No. 384, East Jiangnan Avenue, Zhuhai, Guangdong, China.'),
('NCC014',N'Toshiba (Toshiba Carrier Corporation)',N' 1-1, Shibaura 1-chome, Minato-ku, Tokyo 105-8001, Japan.'),
('NCC015',N'Johnson Controls - Hitachi Air Conditioning',N'1012-1, Hikarinooka, Yokohama, Kanagawa 235-8523, Japan.');
go
--Bảng nhà bộ phận 
INSERT INTO BOPHAN
VALUES('BP01',N'Bộ phận kế toán'),
('BP02',N'Bộ phận quản lý kho'),
('BP03',N'Bộ phận quản lý sản phẩm'),
('BP04',N'Bộ phận quản lý khách hàng'),
('BP05',N'Bộ phận quản lý đơn hàng'),
('BP06',N'Bộ phận giao hàng'),
('BP07', N'Bộ phận bảo dưỡng máy lạnh'),
('BP08', N'Bộ phận kỹ thuật sửa chữa'),
('BP09', N'Bộ phận tư vấn mua hàng'),
('BP10',N'Bộ phận bán hàng');
--Bảng nhà nhân viên
INSERT INTO NHANVIEN
VALUES('NV001', 'BP01', N'Nguyễn Văn An', N'Nam', '2023-10-01', '1990-03-15', '0123456789', N'Hà Nội'),
    ('NV002', 'BP05', N'Nguyễn Thị Bích', N'Nữ', '2023-10-05', '1992-07-20', '0987654321', N'Hồ Chí Minh'),
    ('NV003', 'BP01', N'Trần Văn Chính', N'Nam', '2023-09-15', '1985-12-10', '0369871245', N'Đà Nẵng'),
    ('NV004', 'BP03', N'Lê Thị Dung', N'Nữ', '2023-10-10', '1995-02-28', '0765432190', N'Hải Phòng'),
    ('NV005', 'BP02', N'Hoàng Văn Huy', N'Nam', '2023-08-20', '1988-06-05', '0999999999', N'Cần Thơ'),
    ('NV006', 'BP04', N'Nguyễn Thị Hoa', N'Nữ', '2023-09-25', '1991-04-18', '0777777777', N'Huế'),
    ('NV007', 'BP01', N'Vũ Đình Giang', N'Nam', '2023-08-05', '1987-10-30', '0888888888', N'Nha Trang'),
    ('NV008', 'BP02', N'Trần Thị Linh', N'Nữ', '2023-07-10', '1994-01-08', '0333333333', N'Quy Nhơn'),
    ('NV009', 'BP03', N'Phạm Văn Tứ', N'Nam', '2023-07-01', '1986-11-20', '0555555555', N'Phú Quốc'),
    ('NV010', 'BP05', N'Hà Văn Kiện', N'Nam', '2023-06-15', '1993-09-12', '0444444444', N'Vũng Tàu'),
    ('NV011', 'BP07', N'Nguyễn Văn Nam', N'Nam', '2023-12-01', '1989-08-25', '0111222333', N'Hồ Chí Minh'),
    ('NV012', 'BP02', N'Lê Thị Mai', N'Nữ', '2023-12-05', '1993-01-05', '0222333444', N'Hà Nội'),
    ('NV013', 'BP03', N'Phạm Văn Long', N'Nam', '2023-11-15', '1984-04-10', '0333444555', N'Cần Thơ'),
    ('NV014', 'BP08', N'Trần Thị Ngọc', N'Nữ', '2023-12-10', '1990-12-28', '0444555666', N'Hải Phòng'),
    ('NV015', 'BP05', N'Đỗ Văn Đức', N'Nam', '2023-11-20', '1987-07-15', '0555666777', N'Đà Nẵng'),
    ('NV016', 'BP04', N'Nguyễn Thị Tâm', N'Nữ', '2023-10-25', '1995-03-18', '0666777888', N'Hà Nội'),
    ('NV017', 'BP01', N'Huỳnh Văn Hùng', N'Nam', '2023-11-05', '1986-09-30', '0777888999', N'Hồ Chí Minh'),
    ('NV018', 'BP09', N'Lê Thị Anh', N'Nữ', '2023-10-10', '1992-02-08', '0888999000', N'Đà Nẵng'),
    ('NV019', 'BP06', N'Phan Văn Đức', N'Nam', '2023-09-01', '1988-10-20', '0999000111', N'Cần Thơ'),
    ('NV020', 'BP05', N'Nguyễn Thị Loan', N'Nữ', '2023-08-15', '1994-05-12', '0111222333', N'Hồ Chí Minh'),
	('NV021', 'BP10', N'Nguyễn Văn Chí', N'Nam', '2023-10-01', '1990-03-15', '0123456782', N'Hà Nội'),
    ('NV022', 'BP10', N'Nguyễn Thị Lan Anh', N'Nữ', '2023-10-05', '1992-07-20', '0987654321', N'Hồ Chí Minh');
--Bảng khách hàng
INSERT INTO KHACHHANG
VALUES('KH001', N'Nguyễn Văn An', N'Hà Nội', '0123456789', NULL),
    ('KH002', N'Trần Thị Bình', N'Hồ Chí Minh', '0987654321',NULL),
    ('KH003', N'Phạm Văn Cường', N'Đà Nẵng', '0369871245', NULL),
    ('KH004', N'Lê Thị Dương', N'Hải Phòng', '0765432190', NULL),
    ('KH005', N'Hồ Quang Duy', N'Cần Thơ', '0742699999', NULL),
    ('KH006', N'Nguyễn Thị Hà', N'Huế', '0773859777',NULL),
    ('KH007', N'Trần Đình Gia', N'Nha Trang', '0388378088', NULL),
    ('KH008', N'Vũ Thị Hoa', N'Quy Nhơn', '0333732433',NULL),
    ('KH009', N'Đặng Văn Khanh', N'Phú Quốc', '0555555555', NULL),
    ('KH010', N'Nguyễn Thị Linh', N'Vũng Tàu', '0915237851', NULL),
    ('KH011', N'Phan Văn Long', N'Cần Thơ', '0123456789', NULL),
    ('KH012', N'Lê Thị Mai', N'Hà Nội', '0987654321', NULL),
    ('KH013', N'Trần Thị Ngọc', N'Đà Nẵng', '0369871245', NULL),
    ('KH014', N'Huỳnh Văn Đức', N'Hồ Chí Minh', '0765432190', NULL),
    ('KH015', N'Đỗ Văn Nam', N'Hải Phòng', '0742699999', NULL),
    ('KH016', N'Nguyễn Thị Tâm', N'Huế', '0773859777', NULL),
    ('KH017', N'Phạm Văn Hùng', N'Nha Trang', '0388378088', NULL),
    ('KH018', N'Lê Thị Anh', N'Quy Nhơn', '0333732433', NULL),
    ('KH019', N'Hồ Thị Loan', N'Phú Quốc', '0555555555', NULL),
    ('KH020', N'Vũ Văn Kiệt', N'Vũng Tàu', '0915237851', NULL);
--Bảng loại hàng hóa 
INSERT INTO LOAI_HANGHOA
VALUES('LOAI001', N'Máy lạnh cửa sổ', N'Hà Nội', 'info@mlcuaso.com'),
    ('LOAI002', N'Máy lạnh tường', N'Hồ Chí Minh', 'info@mltuong.com'),
    ('LOAI003', N'Máy lạnh trung tâm', N'Đà Nẵng', 'info@mltrungtam.com'),
    ('LOAI004', N'Máy lạnh gắn trần', N'Hải Phòng', 'info@mlgantran.com'),
    ('LOAI005', N'Máy lạnh ẩn', N'Cần Thơ', 'info@mlan.com'),
    ('LOAI006', N'Máy lạnh cục bộ', N'Huế', 'info@mlcuboc.com'),
    ('LOAI007', N'Máy lạnh đứng', N'Nha Trang', 'info@mldung.com'),
    ('LOAI008', N'Máy lạnh công nghiệp', N'Quy Nhơn', 'info@mlcongnghiep.com'),
    ('LOAI009', N'Máy lạnh đa dạng', N'Phú Quốc', 'info@mldadang.com'),
    ('LOAI010', N'Máy lạnh mini', N'Vũng Tàu', 'info@mlmini.com'),
    ('LOAI011', N'Máy lạnh treo tường', N'Hồ Chí Minh', 'info@mltreotuong.com'),
    ('LOAI012', N'Máy lạnh âm trần', N'Hà Nội', 'info@mlamtran.com'),
    ('LOAI013', N'Máy lạnh giấu trần', N'Đà Nẵng', 'info@mlgiautran.com'),
    ('LOAI014', N'Máy lạnh công suất lớn', N'Hải Phòng', 'info@mlcongsuatlon.com'),
    ('LOAI015', N'Máy lạnh hộ gia đình', N'Cần Thơ', 'info@mlhogiadinh.com'),
    ('LOAI016', N'Máy lạnh thương mại', N'Huế', 'info@mlthuongmai.com'),
    ('LOAI017', N'Máy lạnh nhà xưởng', N'Nha Trang', 'info@mlnhaxuong.com'),
    ('LOAI018', N'Máy lạnh công ty', N'Quy Nhơn', 'info@mlcongty.com'),
    ('LOAI019', N'Máy lạnh phòng sạch', N'Phú Quốc', 'info@mlphongsach.com'),
    ('LOAI020', N'Máy lạnh thông minh', N'Vũng Tàu', 'info@mlthongminh.com');
--Bảng hàng hóa
INSERT INTO HANGHOA (MAHH, TENHH, GIANHAP, HINHANH, SOLUONG, MALOAI, MANCC)
VALUES
    ('HH001', N'Máy lạnh Panasonic 2021', 5000000.00,'000001.jpg', 10, 'LOAI001', 'NCC002'),
    ('HH002', N'Máy lạnh LG A3', 4500000.00, '000002.jpg', 8, 'LOAI002', 'NCC005'),
    ('HH003', N'Máy lạnh Daikin 2020', 5500000.00, '000003.jpg', 12, 'LOAI001', 'NCC003'),
    ('HH004', N'Máy lạnh Samsung 2022', 4800000.00, '000004.jpg', 15, 'LOAI013', 'NCC011'),
    ('HH005', N'Máy lạnh Mitsubishi Electric', 6000000.00, '000005.jpg', 7, 'LOAI014', 'NCC014'),
    ('HH006', N'Máy lạnh Gree Inverter', 5200000.00, '000006.jpg', 9, 'LOAI005', 'NCC015'),
    ('HH007', N'Máy lạnh Toshiba Vario 2021', 5600000.00, '000007.jpg', 11, 'LOAI020', 'NCC011'),
    ('HH008', N'Máy lạnh Daikin Inverter 2023', 6200000.00, '000008.jpg', 6, 'LOAI018', 'NCC015'),
    ('HH009', N'Máy lạnh LG Dual Inverter', 7000000.00, '000009.jpg', 8, 'LOAI013', 'NCC004'),
    ('HH010', N'Máy lạnh Panasonic Aero Series', 5300000.00, '000010.jpg', 10, 'LOAI010', 'NCC009'),
    ('HH011', N'Máy lạnh Hitachi Premium', 6800000.00, '000011.jpg', 10, 'LOAI009', 'NCC006'),
    ('HH012', N'Máy lạnh Sharp J-Tech Inverter', 7200000.00, '000012.jpg', 8, 'LOAI003', 'NCC009'),
    ('HH013', N'Máy lạnh Haier Tropical', 5000000.00, '000013.jpg', 12, 'LOAI006', 'NCC003'),
    ('HH014', N'Máy lạnh Trane CleanEffects', 8000000.00, '000014.jpg', 6, 'LOAI007', 'NCC001'),
    ('HH015', N'Máy lạnh Carrier Optima', 6200000.00, '000015.jpg', 9, 'LOAI008', 'NCC004');
--Bảng thông số KT
INSERT INTO THONGSOKT_HH
VALUES('HH001','550 x 658 x 253','2.78','2 sao','9',2021,'12 tháng'),
	('HH002','525 x 623 x 453','3.12','3 sao','10.6',2020,'15 tháng'),
	('HH003','450 x 558 x 353','2.62','2 sao','8.9',2020,'12 tháng'),
    ('HH004', '600 x 712 x 303', '3.45', '4 sao', '11.2', 2022, '18 tháng'),
    ('HH005', '480 x 598 x 353', '2.98', '3 sao', '9.8', 2023, '24 tháng'),
    ('HH006', '550 x 658 x 253', '3.20', '4 sao', '10.5', 2021, '15 tháng'),
    ('HH007', '620 x 732 x 353', '3.80', '4.5 sao', '12.5', 2022, '20 tháng'),
    ('HH008', '540 x 640 x 403', '3.15', '3.5 sao', '10.2', 2023, '24 tháng'),
    ('HH009', '500 x 590 x 303', '2.92', '3 sao', '9.5', 2021, '12 tháng'),
    ('HH010', '580 x 678 x 353', '3.60', '4 sao', '11.8', 2022, '18 tháng'),
	('HH011', '530 x 628 x 353', '3.25', '3.5 sao', '10.9', 2023, '24 tháng'),
    ('HH012', '570 x 678 x 403', '3.50', '4 sao', '11.5', 2022, '18 tháng'),
    ('HH013', '490 x 580 x 303', '2.80', '3 sao', '9.2', 2021, '12 tháng'),
    ('HH014', '610 x 722 x 353', '3.70', '4 sao', '12.0', 2022, '20 tháng'),
    ('HH015', '520 x 618 x 353', '3.10', '3.5 sao', '10.0', 2023, '24 tháng');
--Bảng hóa đơn nhập
INSERT INTO HOADONNHAP
VALUES
    ('HDN001', 'NV022', 'NCC01', 18000000.00, '2023-12-01 08:30:00'),
    ('HDN002', 'NV010', 'NCC02', 10500000.00, '2023-12-02 09:15:00'),
    ('HDN003', 'NV002', 'NCC03', 24300000.00, '2023-12-03 10:00:00'),
    ('HDN004', 'NV020', 'NCC04', 35000000.00, '2023-12-04 11:45:00'),
    ('HDN005', 'NV015', 'NCC05', 24000000.00, '2023-12-05 13:30:00'),
    ('HDN006', 'NV018', 'NCC01', 42360000.00, '2023-12-06 14:15:00'),
    ('HDN007', 'NV022', 'NCC02', 61200000.00, '2023-12-07 15:00:00'),
    ('HDN008', 'NV010', 'NCC03', 22500000.00, '2023-12-08 16:45:00'),
    ('HDN009', 'NV002', 'NCC04', 12825000.00, '2023-12-09 17:30:00'),
    ('HDN010', 'NV010', 'NCC05', 29760000.00, '2023-12-10 18:15:00'),
    ('HDN011', 'NV022', 'NCC05', 21120000.00, '2023-12-11 08:30:00'),
    ('HDN012', 'NV020', 'NCC07', 45000000.00, '2023-12-12 09:15:00'),
    ('HDN013', 'NV018', 'NCC08', 34200000.00, '2023-12-13 10:00:00'),
    ('HDN014', 'NV005', 'NCC09', 63360000.00, '2023-12-14 11:45:00'),
    ('HDN015', 'NV015', 'NCC10', 61200000.00, '2023-12-15 13:30:00'),
    ('HDN016', 'NV010', 'NCC03', 21120000.00, '2023-12-16 14:15:00'),
    ('HDN017', 'NV010', 'NCC07', 45000000.00, '2023-12-17 15:00:00'),
    ('HDN018', 'NV002', 'NCC08', 34200000.00, '2023-12-18 16:45:00'),
    ('HDN019', 'NV002', 'NCC09', 63360000.00, '2023-12-19 17:30:00'),
    ('HDN020', 'NV020', 'NCC10', 61200000.00, '2023-12-20 18:15:00');
GO
--Bảng chi tiết hóa đơn nhập
INSERT INTO CHITIETHOADONNHAP (MAHDN, MAHH, TENHH, SOLUONG, DONGIA, GIAMGIA, THANHTIEN)
VALUES
    ('HDN001', 'HH001', N'Máy lạnh Panasonic 2021', 5, 4000000.00, 0.1, 18000000.00),
    ('HDN002', 'HH002', N'Máy lạnh LG A3', 3, 3500000.00, 0, 10500000.00),
    ('HDN003', 'HH003', N'Máy lạnh Daikin 2020', 6, 4500000.00, 0.1, 24300000.00),
    ('HDN003', 'HH004', N'Máy lạnh Samsung 2022', 4, 3800000.00, 0.1, 13680000.00),
	('HDN004', 'HH005', N'Máy lạnh Panasonic 2021', 10, 3500000.00, 0.2, 35000000.00),
    ('HDN005', 'HH009', N'Máy lạnh LG A3', 8, 3000000.00, 0, 24000000.00),
    ('HDN006', 'HH015', N'Máy lạnh Daikin 2020', 12, 3500000.00, 0.08, 42360000.00),
    ('HDN007', 'HH014', N'Máy lạnh Samsung 2022', 15, 3800000.00, 0.12, 61200000.00),
	('HDN008', 'HH008', N'Máy lạnh Panasonic 2021', 5, 4000000.00, 0.1, 22500000.00),
    ('HDN009', 'HH007', N'Máy lạnh LG A3', 3, 4000000.00, 0.05, 12825000.00),
    ('HDN010', 'HH006', N'Máy lạnh Daikin 2020', 6, 4200000.00, 0.08, 29760000.00),
    ('HDN011', 'HH014', N'Máy lạnh Samsung 2022', 4, 4000000.00, 0.12, 21120000.00),
	('HDN012', 'HH011', N'Máy lạnh Panasonic 2021', 10, 4200000.00, 0.1, 45000000.00),
    ('HDN013', 'HH012', N'Máy lạnh LG A3', 8, 4000000.00, 0.05, 34200000.00),
    ('HDN014', 'HH003', N'Máy lạnh Daikin 2020', 12, 4900000.00, 0.08, 63360000.00),
    ('HDN015', 'HH007', N'Máy lạnh Samsung 2022', 15, 4200000.00, 0.12, 61200000.00),
	('HDN016', 'HH015', N'Máy lạnh Samsung 2022', 4, 4200000.00, 0.12, 21120000.00),
	('HDN017', 'HH007', N'Máy lạnh Panasonic 2021', 10, 4500000.00, 0.1, 45000000.00),
    ('HDN018', 'HH002', N'Máy lạnh LG A3', 8, 4200000.00, 0.05, 34200000.00),
    ('HDN019', 'HH003', N'Máy lạnh Daikin 2020', 12, 4900000.00, 0.08, 63360000.00),
    ('HDN020', 'HH004', N'Máy lạnh Samsung 2022', 15, 4000000.00, 0.12, 61200000.00);
--Bảng hóa đơn bán hàng
INSERT INTO HOADON_BANHANG
VALUES('HDX001','KH001','10000000','2023-09-12 00:00:00.000','NV005'),
('HDX002','KH002','4500000','2023-09-12 00:00:00.000','NV004'),	
('HDX003','KH003','5500000','2023-09-12 00:00:00.000','NV001'),
('HDX004','KH004','9600000','2023-09-12 00:00:00.000','NV001'),				
('HDX005','KH005','6000000','2023-09-12 00:00:00.000','NV003'),					
('HDX006','KH006','16200000','2023-09-12 00:00:00.000','NV010'),	
('HDX007','KH007','5200000','2023-10-12 00:00:00.000','NV023'),	
('HDX008','KH008','26200000','2023-10-12 00:00:00.000','NV024'),	
('HDX009','KH009','7000000','2023-10-12 00:00:00.000','NV025'),	
('HDX010','KH010','5300000','2023-10-12 00:00:00.000','NV026');
		
--Bảng chi tiết hóa đơn bán hàng
INSERT INTO CHITIETHOADON_BANHANG
VALUES('HDX001','HH001',N'Máy lạnh Panasonic 2021',2,5000000.00,0,10000000.00),
('HDX002','HH002',N'Máy lạnh LG A3',1,4500000.00,0,4500000.00),
('HDX003','HH003',N'Máy lạnh Daikin 2020',1,5500000.00,0,5500000.00),
('HDX004','HH004',N'Máy lạnh Samsung 2022',2,4800000.00,0,9600000.00),
('HDX005','HH005',N'Máy lạnh Mitsubishi Electric',1,6000000.00,0,6000000.00),
('HDX006','HH006',N'Máy lạnh Mitsubishi Electric',3,6000000.00,0.1,16200000.00),
('HDX007','HH007',N'Máy lạnh Gree Inverter',1,5200000.00,0,5200000.00),
('HDX008','HH008',N'Máy lạnh Toshiba Vario 2021',5,5600000.00,0.1,26200000.00),
('HDX009','HH009',N'Máy lạnh LG Dual Inverter',1,7000000.00,0,7000000.00),
('HDX010','HH010',N'Máy lạnh Panasonic Aero Series',1,5300000.00,0,5300000.00);

--Bảng người dùng
--Bảng người dùng
insert into NGUOIDUNG
values ('thuhien','123','admin','NV001'),
	   ('trung','123','admin','NV002'),
	   ('tricao','123','nhanvien','NV003')
-------------------------------- -------XEM DỮ LIỆU -----------------------------------
select * from NHACUNGCAP
select * from NHANVIEN
select * from HANGHOA
SELECT * FROM BOPHAN
select * from HOADONNHAP
select * from CHITIETHOADONNHAP
SELECT * FROM HOADON_BANHANG
SELECT * FROM CHITIETHOADON_BANHANG
select * from NGUOIDUNG
----------------------------------------------------------------------------------------
GO
CREATE proc Usp_KiemTraAccount
@username char(10),@password char(50)
As
	begin
	select QuyenTC from dbo.NGUOIDUNG where username = @username and  password = @password
	end;
exec Usp_KiemTraAccount 'thuhien','123'
-----------------------------------------------
go
create proc USP_getIdEmPloyee
@username varchar(255),@password varchar(255)
as
	begin
	select MANV from dbo.NGUOIDUNG where username = @username and  password = @password
	end;

exec USP_getIdEmPloyee 'ThuHien','123'



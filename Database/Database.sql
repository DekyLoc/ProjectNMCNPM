CREATE DATABASE QUANLYKHACHSAN;
GO
USE QUANLYKHACHSAN;

CREATE TABLE KHACHHANG
(
	MAKH VARCHAR(20) NOT NULL,
	HO_TEN NVARCHAR(50) NOT NULL,
	LOAI_KH NVARCHAR(20) NOT NULL,
	CMND VARCHAR(20) NOT NULL,
	DIA_CHI NVARCHAR(50) NOT NULL,
	CONSTRAINT KHACHHANG_PK PRIMARY KEY (MAKH)
);
CREATE TABLE PHONG
(
	MAPNG CHAR(3) NOT NULL,
	LOAI_PNG NVARCHAR(20) NOT NULL,
	DON_GIA INT NOT NULL,
	GHI_CHU NVARCHAR(50),
	TINH_TRANG BIT NOT NULL
	CONSTRAINT PHONG_PK PRIMARY KEY (MAPNG)
);
CREATE TABLE PHIEUTHUE
(
	MAPHIEU CHAR(5) NOT NULL,
	NGAY_THUE DATE NOT NULL,
	MAKH VARCHAR(20) NOT NULL,
	MAPNG CHAR(3) NOT NULL,
	SO_LUONG INT NOT NULL,
	LOAI_KHACH BIT NOT NULL,
	THANH_TOAN BIT NOT NULL,
	CONSTRAINT PHIEUTHUE_PK PRIMARY KEY (MAPHIEU),
	CONSTRAINT FK_PHIEUTHUE_MAPNG_PHONG FOREIGN KEY (MAPNG) REFERENCES PHONG(MAPNG),
	CONSTRAINT FK_PHIEUTHUE_MAKH_KHACHHANG FOREIGN KEY (MAKH) REFERENCES KHACHHANG(MAKH)
);
CREATE TABLE HOADON
(
	MAHD CHAR(5) NOT NULL,
	MAPHIEU CHAR(5) NOT NULL,
	NGAY_TRA DATETIME NOT NULL,
	SO_NGAY_THUE INT NOT NULL,
	PHU_THU INT,
	THANH_TIEN INT NOT NULL,
	TRI_GIA INT NOT NULL,
	CONSTRAINT HOADON_PK PRIMARY KEY (MAHD),
	CONSTRAINT FK_HOADON_MAPHIEU_PHIEUTHUE FOREIGN KEY (MAPHIEU) REFERENCES PHIEUTHUE(MAPHIEU)
);
CREATE TABLE BAOCAO
(
	MABC CHAR(5) NOT NULL,
	LOAI_PNG NVARCHAR(20) NOT NULL,
	THANG INT NOT NULL,
	DOANH_THU INT NOT NULL,
	TY_LE VARCHAR(50) NOT NULL,
	CONSTRAINT BAOCAO_PK PRIMARY KEY (MABC,LOAI_PNG),
	
);

SET DATEFORMAT DMY

CREATE TABLE DANGNHAP
(
	User_Name varchar(20),
	Pass_Word varchar(20)
);
USE QUANLYKHACHSAN;
CREATE TABLE THAYDOIQUYDINH
(
	MAPHONG VARCHAR(50),
	GIA INT,
	SLNG INT,
	TYLE FLOAT
);
INSERT INTO THAYDOIQUYDINH(MAPHONG,GIA,SLNG,TYLE) VALUES('A','150000','3','1.5');
INSERT INTO THAYDOIQUYDINH(MAPHONG,GIA,SLNG,TYLE) VALUES('B','170000','3','1.5');
INSERT INTO THAYDOIQUYDINH(MAPHONG,GIA,SLNG,TYLE) VALUES('C','170000','3','1.5');

INSERT INTO DANGNHAP(User_Name,Pass_Word) VALUES('admin','admin');
update GIA set GIA='300000' where MAPHONG='A'
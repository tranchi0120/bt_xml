CREATE DATABASE LibraryDb
GO
USE LibraryDb
GO
----------

CREATE FUNCTION auto_ids()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @id VARCHAR(5)
	IF (SELECT COUNT(masach) FROM SACH) = 0
		SET @id = '0'
	ELSE
		SELECT @id = MAX(RIGHT(masach, 3)) FROM SACH
		SELECT @id = CASE
			WHEN @id >= 0 and @id < 9 THEN 'S000' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9 THEN 'S00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
		END
	RETURN @id
END
GO
CREATE TABLE SACH
(
	masach CHAR(5) default dbo.auto_ids() PRIMARY KEY,
	tensach NVARCHAR(50) Not NULL,
	theloai NVARCHAR(50) Not NULL,
	mota NVARCHAR(100),  
	namxb char(4),
	nhaxuatban NVARCHAR(50) Not NULL,
	tacgia NVARCHAR(50) Not NULL,
	soluong INT,
	capnhat nchar(10),
)
GO
INSERT INTO SACH VALUES(default,N'Toán Cao Cấp 1',N'Toán học',N'Sách hay','2005',N'Kim Đồng',N'Ngô Bảo Châu',48,null)
INSERT INTO SACH VALUES(default,N'Toán Cao Cấp 2',N'Toán học',N'Sách hay','2008',N'Kim Đồng',N'Ngô Bảo Châu',49,null)
INSERT INTO SACH VALUES(default,N'Toán Cao Cấp 3',N'Toán học',N'Sách hay','2008',N'Kim Đồng',N'Ngô Bảo Châu',50,null)
INSERT INTO SACH VALUES(default,N'Phương Pháp Tính',N'Toán học',N'Sách hay','2008',N'Kim Đồng',N'Ngô Bảo Châu',39,null)
INSERT INTO SACH VALUES(default,N'Toán Rời Rạc',N'Toán học',N'Sách hay','2000',N'Kim Đồng',N'Ngô Bảo Châu',40,null)
INSERT INTO SACH VALUES(default,N'Xác Suất Thống Kê',N'Toán học',N'Sách hay','2008',N'Kim Đồng',N'Ngô Bảo Châu',48,null)
INSERT INTO SACH VALUES(default,N'Những nguyên lý cơ bản của chủ nghĩa mác',N'Triết học',N'Sách hay','1995',N'Kim Đồng',N'MacLenin',50,null)
INSERT INTO SACH VALUES(default,N'Đường Lối Cách Mạng',N'Triết học',N'Sách hay','1995',N'Kim Đồng',N'Hồ Chí Minh',38,null)
INSERT INTO SACH VALUES(default,N'Tư Tưởng Hồ Chí Minh',N'Triết học',N'Sách hay','1995',N'Kim Đồng',N'Hồ Chí Minh',50,null)
INSERT INTO SACH VALUES(default,N'Những Nguyên Lý Chính Trị Cơ Bản',N'Triết học',N'Sách hay','1995',N'Kim Đồng',N'MacLenin',39,null)
INSERT INTO SACH VALUES(default,N'Kinh Tế Đại Cương',N'Kinh tế',N'Sách hay','2003',N'Kinh tế',N'Nguyễn Hoàng Dũng',50,null)
INSERT INTO SACH VALUES(default,N'Kinh Tế Kế Toán',N'Kinh tế',N'Sách hay','2003',N'Kinh tế',N'Nguyễn Hoàng Dũng',50,null)
INSERT INTO SACH VALUES(default,N'Nguyên Lý Kế Toán',N'Kinh tế',N'Sách hay','2003',N'Kinh tế',N'Nguyễn Hoàng Dũng',50,null)
INSERT INTO SACH VALUES(default,N'Đầu Tư',N'Kinh tế',N'Sách hay','2003',N'Kinh tế',N'Nguyễn Hoàng Dũng',50,null)
INSERT INTO SACH VALUES(default,N'Pháp Luật Đại Cương',N'Pháp Luật',N'Sách hay','2003',N'Pháp luật',N'Trần Đăng Khoa',40,null)
INSERT INTO SACH VALUES(default,N'Pháp Luật Tổng Hợp',N'Pháp Luật',N'Sách hay','2003',N'Pháp luật',N'Trần Đăng Khoa',40,null)
INSERT INTO SACH VALUES(default,N'Giáo Dục Tổng Hợp',N'Pháp Luật',N'Sách hay','2003',N'Pháp luật',N'Trần Đăng Khoa',50,null)
INSERT INTO SACH VALUES(default,N'Giáo Dục Chính Trị',N'Pháp Luật',N'Sách hay','2003',N'Pháp luật',N'Trần Đăng Khoa',50,null)

GO
----------
CREATE FUNCTION auto_iddg()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @id VARCHAR(5)
	IF (SELECT COUNT(madg) FROM DOCGIA) = 0
		SET @id = '0'
	ELSE
		SELECT @id = MAX(RIGHT(madg, 3)) FROM DOCGIA
		SELECT @id = CASE
			WHEN @id >= 0 and @id < 9 THEN 'DG00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9 THEN 'DG0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
		END
	RETURN @id
END
GO
CREATE TABLE DOCGIA
(
	madg CHAR(5) default dbo.auto_iddg() PRIMARY KEY,
	tendg NVARCHAR(30) Not NULL,
	ngaysinh DATE NULL,
	gioitinh NVARCHAR(3) Not NULL,
	cmnd CHAR(9) Not NULL,
	diachi NVARCHAR(50) Not NULL,
	sdt VARCHAR(11),
	capnhat nchar(10)
)
GO
INSERT INTO DOCGIA VALUES(default,N'Phùng Văn Phong','12/20/1991',N'Nam','211667208',N'Tư Nghĩa, Quảng Ngãi','01668135131',null)
INSERT INTO DOCGIA VALUES(default,N'Phạm Tuấn Việt','2/10/1991',N'Nam','211667209',N'Hải Châu, Đà Nẵng','01668135132',null)
INSERT INTO DOCGIA VALUES(default,N'Nguyễn Thị Vân Anh','3/4/1991',N'Nữ','211667201',N'Hải Châu, Đà Nẵng','01668135133',null)
INSERT INTO DOCGIA VALUES(default,N'Nguyễn Thị Thái Thủy','1/2/1992',N'Nữ','211667202',N'Hải Châu, Đà Nẵng','01668135134',null)
INSERT INTO DOCGIA VALUES(default,N'Đỗ Thị Hương','2/6/1992',N'Nữ','211667203',N'Hải Châu, Đà Nẵng','01668135135',null)
INSERT INTO DOCGIA VALUES(default,N'Phạm Văn Nghiã','1/23/1991',N'Nam','211667204',N'Hải Châu, Đà Nẵng','01668135136',null)
INSERT INTO DOCGIA VALUES(default,N'Phạm Văn A','1/23/1991',N'Nam','211667205',N'Hải Châu, Đà Nẵng','01668135137',null)
INSERT INTO DOCGIA VALUES(default,N'Phạm Văn B','2/23/1992',N'Nam','211667206',N'Hải Châu, Đà Nẵng','01668135138',null)
INSERT INTO DOCGIA VALUES(default,N'Phạm Văn C','3/23/1993',N'Nam','211667207',N'Hải Châu, Đà Nẵng','01668135139',null)
INSERT INTO DOCGIA VALUES(default,N'Phạm Văn D','4/23/1994',N'Nam','211667210',N'Hải Châu, Đà Nẵng','01668135140',null)
INSERT INTO DOCGIA VALUES(default,N'Phan Văn A','1/23/1957',N'Nam','211667211',N'Hải Châu, Đà Nẵng','01668135140',null)
INSERT INTO DOCGIA VALUES(default,N'Phan Văn B','3/23/1976',N'Nam','211667212',N'Hải Châu, Đà Nẵng','01668135142',null)
INSERT INTO DOCGIA VALUES(default,N'Phan Văn C','7/23/1958',N'Nam','211667213',N'Hải Châu, Đà Nẵng','01668135143',null)
INSERT INTO DOCGIA VALUES(default,N'Phan Văn T','9/23/1968',N'Nam','211667214',N'Hải Châu, Đà Nẵng','01668135144',null)
INSERT INTO DOCGIA VALUES(default,N'Phan Văn G','12/23/1978',N'Nam','211667215',N'Hải Châu, Đà Nẵng','01668135145',null)
INSERT INTO DOCGIA VALUES(default,N'Phan Văn U','11/23/1986',N'Nam','211667216',N'Hải Châu, Đà Nẵng','01668135146',null)

GO
----------
CREATE FUNCTION auto_idnv()
RETURNS VARCHAR(5)
AS
BEGIN
	DECLARE @id VARCHAR(5)
	IF (SELECT COUNT(manv) FROM NHANVIEN) = 0
		SET @id = '0'
	ELSE
		SELECT @id = MAX(RIGHT(manv, 3)) FROM NHANVIEN
		SELECT @id = CASE
			WHEN @id >= 0 and @id < 9 THEN 'NV00' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
			WHEN @id >= 9 THEN 'NV0' + CONVERT(CHAR, CONVERT(INT, @id) + 1)
		END
	RETURN @id
END
GO
CREATE TABLE NHANVIEN
(
	manv CHAR(5) default dbo.auto_idnv() PRIMARY KEY,
	tennv NVARCHAR(30) Not NULL,
	gioitinh NVARCHAR(3) Not NULL,
	diachi NVARCHAR(100) Not NULL,
	cmnd CHAR(9) Not NULL,
	email VARCHAR(50) NULL,
	dienthoai VARCHAR(11) Not NULL,
	capnhat nchar(10)
)
GO
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Thị Hoàng Anh',N'Nữ',N'Hải Châu, Đà Nẵng',N'211667216','hoanganh@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Thị A',N'Nữ',N'Hải Châu, Đà Nẵng',N'211667216','NV01@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Thị B',N'Nữ',N'Hải Châu, Đà Nẵng',N'211667216','NV02@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Thị C',N'Nữ',N'Hải Châu, Đà Nẵng',N'211667216','NV03@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Thị D',N'Nữ',N'Hải Châu, Đà Nẵng',N'211667216','NV04@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Thị E',N'Nữ',N'Hải Châu, Đà Nẵng',N'211667216','NV05@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Thị F',N'Nữ',N'Hải Châu, Đà Nẵng',N'211667216','NV06@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Văn G',N'Nam',N'Hải Châu, Đà Nẵng',N'211667216','NV08@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Văn K',N'Nam',N'Hải Châu, Đà Nẵng,',N'211667216','NV09@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Văn I',N'Nam',N'Hải Châu, Đà Nẵng',N'211667216','NV10@gmail.com','01668135146',null)
INSERT INTO NHANVIEN VALUES (default,N'Nguyễn Văn p',N'Nam',N'Hải Châu, Đà Nẵng',N'211667216','NV11@gmail.com','01668135146',null)

GO
----------
CREATE TABLE MUONSACH
(
	idmuons INT IDENTITY(1000,2) Not NULL PRIMARY KEY,
	manv CHAR(5) Not NULL FOREIGN KEY(manv) REFERENCES NHANVIEN(manv)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	madg CHAR(5) Not NULL FOREIGN KEY(madg) REFERENCES DOCGIA(madg)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	ngaymuon DATE Not NULL,
	ngaytra DATE Not NULL,
	soluong INT Not NULL,
	trangthai BIT,
	capnhat nchar(10)
)
GO
INSERT INTO MUONSACH VALUES('NV001','DG002','05/12/2014','12/12/2014',3,0,null)
INSERT INTO MUONSACH VALUES('NV001','DG003','05/12/2014','12/12/2014',2,0,null)
INSERT INTO MUONSACH VALUES('NV001','DG004','05/12/2014','12/12/2014',1,1,null)
INSERT INTO MUONSACH VALUES('NV001','DG005','05/11/2014','12/11/2014',1,1,null)
INSERT INTO MUONSACH VALUES('NV001','DG006','05/11/2014','12/11/2014',2,0,null)

GO
---------
CREATE TABLE SACHMUON
(
	idmuons INT Not NULL FOREIGN KEY (idmuons) REFERENCES MUONSACH(idmuons)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	masach CHAR(5) Not NULL FOREIGN KEY (masach) REFERENCES SACH(masach)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	PRIMARY KEY(masach,idmuons)
)
GO
INSERT INTO SACHMUON VALUES('1000','S0004')
INSERT INTO SACHMUON VALUES('1000','S0006')
INSERT INTO SACHMUON VALUES('1000','S0008')
INSERT INTO SACHMUON VALUES('1002','S0001')
INSERT INTO SACHMUON VALUES('1002','S0002')
INSERT INTO SACHMUON VALUES('1004','S0006')
INSERT INTO SACHMUON VALUES('1006','S0008')
INSERT INTO SACHMUON VALUES('1008','S0001')
INSERT INTO SACHMUON VALUES('1008','S0010')

GO
----------
CREATE TABLE QUANTRIVIEN
(
	manv char(5) Not NULL  FOREIGN KEY (manv) REFERENCES NHANVIEN(manv)
	ON DELETE CASCADE
	ON UPDATE CASCADE,
	matkhau CHAR(5) Not NULL,
	primary key(manv)
)
GO
INSERT INTO QUANTRIVIEN VALUES('NV001','11111')
INSERT INTO QUANTRIVIEN VALUES('NV003','33333')
INSERT INTO QUANTRIVIEN VALUES('NV005','55555')

GO

CREATE PROC DSQH
AS
BEGIN
	Select ms.madg,tendg,ngaysinh,gioitinh,cmnd,diachi,sdt From DOCGIA as dg,MUONSACH as ms
	Where ms.madg = dg.madg and ms.trangthai = 0
END

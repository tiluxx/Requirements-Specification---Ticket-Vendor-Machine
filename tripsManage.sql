CREATE DATABASE Trips_Manage
USE Trips_Manage

CREATE TABLE Destination 
(
	destinationId varchar(10) PRIMARY KEY,
	destiantionName nvarchar(100),
	detailAddress nvarchar(200),
)

CREATE TABLE Transport 
(
	transportId varchar(10) PRIMARY KEY,
	transportName nvarchar(100),
	transportNumber varchar(10),
	transportType nvarchar(10),
)

CREATE TABLE Trip 
(
	tripId varchar(10),
	condition varchar(10),
	price money,
	startTime datetime,
	endTime datetime,
	destinationId varchar(10),
	pickupLocationId varchar(10),
	transportId varchar(10),

	CONSTRAINT FK_TRIP_DES
	FOREIGN KEY (destinationId) REFERENCES Destination(destinationId),
	CONSTRAINT FK_TRIP_PICKUP
	FOREIGN KEY (pickupLocationId) REFERENCES Destination(destinationId),
	CONSTRAINT FK_TRIP_TRANS
	FOREIGN KEY (transportId) REFERENCES Transport(transportId),
	CONSTRAINT PK_TRIP
	PRIMARY KEY(tripId, destinationId, transportId)
)

--
INSERT INTO Destination VALUES ('VNHCM00001', N'Đại học Tôn Đức Thắng', N'Số 19 Nguyễn Hữu Thọ, Phường Tân Phong, Quận 7, TP. Hồ Chí Minh, Việt Nam')
INSERT INTO Destination VALUES ('VNHCM00002', N'Đại học RMIT Việt Nam', N'702 Nguyễn Văn Linh, Phường Tân Phong, Quận 7, TP. Hồ Chí Minh, Việt Nam')
INSERT INTO Destination VALUES ('VNHCM00003', N'Đại Học Swinburne Việt Nam', N'A35, Bạch Đằng, Quận Tân Bình, TP. Hồ Chí Minh, Việt Nam')
INSERT INTO Destination VALUES ('VNHCM00004', N'Vincom Center Đồng Khởi', N'Số 72 Lê Thánh Tôn và 45A Lý Tự Trọng, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh, Việt Nam')
INSERT INTO Destination VALUES ('VNHCM00005', N'MUJI', N'35-45 Lê Thánh Tôn, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh, Việt Nam')
INSERT INTO Destination VALUES ('VNHCM00006', N'LOTTE Mart Quận 7', N'469 Nguyễn Hữu Thọ, Phường Tân Hưng, Quận 7, TP. Hồ Chí Minh, Việt Nam')
INSERT INTO Destination VALUES ('VNHCM00007', N'Crescent Mall Shopping Center', N'101 Tôn Dật Tiên, Phú Mỹ Hưng Phường Tân Phú, Quận 7, TP. Hồ Chí Minh, Việt Nam')
INSERT INTO Destination VALUES ('VNHCM00008', N'Bảo tàng Thành phố Hồ Chí Minh', N'65 Lý Tự Trọng, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh, Việt Nam')
INSERT INTO Destination VALUES ('VNHCM00009', N'Viettel Complex Building', N'285/68 Hẻm 285 Cách Mạng Tháng Tám, Phường 12, Quận 10, TP. Hồ Chí Minh, Việt Nam')
INSERT INTO Destination VALUES ('VNHCM00010', N'Công ty TNHH Giáo dục IDP Việt Nam', N'161 Hai Bà Trưng, Phường Võ Thị Sáu, Quận 3, TP. Hồ Chí Minh, Việt Nam')

INSERT INTO Transport VALUES ('HCMBUS0001', N'Toyota', '51A-12345', N'Bus')
INSERT INTO Transport VALUES ('HCMBUS0002', N'Huyndai', '51A-34251', N'Bus')
INSERT INTO Transport VALUES ('HCMBUS0003', N'Toyota', '51A-87899', N'Bus')

INSERT INTO Trip VALUES ('HCM00001AA', 'available', 5000, '2023-11-03 06:20:00', '2023-11-03 06:45:00', 'VNHCM00001', 'VNHCM00006', 'HCMBUS0001')
INSERT INTO Trip VALUES ('HCM00002BA', 'available', 5000, '2023-11-03 06:45:00', '2023-11-03 07:10:00', 'VNHCM00002', 'VNHCM00001', 'HCMBUS0001')
INSERT INTO Trip VALUES ('HCM00002OB', 'available', 10000, '2023-11-03 07:10:00', '2023-11-03 07:20:00', 'VNHCM00007', 'VNHCM00002', 'HCMBUS0001')
INSERT INTO Trip VALUES ('HCM00001XY', 'available', 5000, '2023-11-03 06:20:00', '2023-11-03 06:45:00', 'VNHCM00008', 'VNHCM00005', 'HCMBUS0002')
INSERT INTO Trip VALUES ('HCM00001TI', 'available', 5000, '2023-11-03 06:20:00', '2023-11-03 06:45:00', 'VNHCM00009', 'VNHCM00003', 'HCMBUS0003')
INSERT INTO Trip VALUES ('HCM00005HI', 'available', 10000, '2023-11-03 06:45:00', '2023-11-03 07:20:00', 'VNHCM00004', 'VNHCM00008', 'HCMBUS0002')
INSERT INTO Trip VALUES ('HCM00005LO', 'available', 5000, '2023-11-03 06:45:00', '2023-11-03 07:15:00', 'VNHCM00004', 'VNHCM00009', 'HCMBUS0003')
INSERT INTO Trip VALUES ('HCM00005XO', 'full', 5000, '2023-11-03 07:30:00', '2023-11-03 08:10:00', 'VNHCM00010', 'VNHCM00006', 'HCMBUS0003')
--
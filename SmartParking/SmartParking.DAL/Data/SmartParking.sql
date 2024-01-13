CREATE DATABASE SmartParking

USE SmartParking

CREATE TABLE Accounts
(
    AccountId INT PRIMARY KEY IDENTITY(1,1),
    Username VARCHAR(50) NOT NULL,
    Email VARCHAR(100) UNIQUE NOT NULL,
    [Password] VARCHAR(50) NOT NULL,
    [Role] VARCHAR(30) NOT NULL
);

CREATE TABLE Informations
(
	Id INT PRIMARY KEY,
	[Name] VARCHAR(50),
	Latitude VARCHAR(20),
	Longitude VARCHAR(20)
);

CREATE TABLE LargeParkings
(
	Id INT PRIMARY KEY,
	InformationsId INT,
	ParkingSpaces INT,
	MonthlySubscriptionPrice VARCHAR(30),
	StayForADayPrice VARCHAR(30),
	StayPerHourPrice VARCHAR(30),
	FOREIGN KEY (InformationsId) REFERENCES Informations(Id)
);

CREATE TABLE ChargingStations
(
	Id INT PRIMARY KEY,
	InformationsId INT ,
	Capacity VARCHAR(150),
	WorkingHours VARCHAR(20),
	FOREIGN KEY (InformationsId) REFERENCES Informations(Id)
);

CREATE TABLE ParkingForDisabled
(
	Id INT PRIMARY KEY,
	InformationsId INT,
	FOREIGN KEY (InformationsId) REFERENCES Informations(Id)
);


INSERT INTO Accounts (Username, Email, [Password], [Role])
VALUES ('ObshtinaBurgas', 'obshtina@burgas.bg', '1234', 'Admin');

INSERT INTO Informations (Id, [Name], Latitude, Longitude)
VALUES (1, 'Parking Gurko', '42.50050', '27.47595'),
	(2, 'Parking Opera', '42.494393', '27.469998'),
	(3, 'Megalan Charge Euroservice', '42.447691', '27.394357'),
	(4, 'Eldrive Mr. Bricolage Burgas', '42.471860', '27.432060'),
	(5, 'Fines Charging Honda Apostolov', '42.49097270030741', '27.448147543434217'),
	(6, 'ElDrive Borisova garden', '42.496047', '27.465731'),
	(7, 'Eldrive Parking Gurko Burgas', '42.500422', '27.474917'),
	(8, 'ElDrive Lazur', '42.503320', '27.479067'),
	(9, 'ElDrive Rhodopes', '42.504754', '27.467409'),
	(10, 'Megalan Charge Business zone Apollo', '42.510495', '27.450155'),
	(11, 'ElDrive Sports complex Boycho Branzov', '42.515511', '27.467118'),
	(12, 'Fines Charging WestAuto-M Audi', '42.516986', '27.429531'),
	(13, 'Fines Charging Masterhaus Burgas', '42.519431', '27.437143'),
	(14, 'Eldrive OMV Burgas Izgrev', '42.528384', '27.452319'),
	(15, 'Eldrive Gazprom Burgas', '42.528831', '27.454900'),
	(16, 'Eldrive Mall Plaza', '42.530885', '27.458653'),
	(17, 'Kaufland Burgas', '42.531675', '27.461105'),
	(18, 'Fines Charging Moto Pfohe Burgas', '42.534165', '27.447438'),
	(19, 'Fines Charging Hyandai Burgas', '42.540733', '27.440936'),
	(20, 'KIA Hypercharge Autocenter Burgas', '42.473685', '27.439787'),
	(21, 'AutoBOX Burgas', '42.472870', '27.442079'),
	(22, 'ElDrive Blvd. Zheni Pateva', '42.491822', '27.469173'),
	(23, 'Grand Hotel and SPA Primorets', '42.491203', '27.479786'),
	(24, 'EVPoint Marine Station Burgas', '42.485562', '27.482577'),
	(25, 'ElDrive Red Cross Burgas', '42.500479', '27.461614'),
	(26, 'Hotel Opera', '42.498750', '27.466609'),
	(27, 'ElDrive DZI Burgas', '42.498614', '27.471907'),
	(28, 'ElDrive Sea Garden Burgas', '42.507032', '27.482002'),
	(29, 'eCars Park Arena Burgas', '42.512896', '27.458273'),
	(30, 'Hotel Aqua Burgas', '42.511020', '27.467292'),
	(31, 'EVPoint Burgas Residences', '42.513734', '27.471254'),
	(32, 'EVPoint Moto Uni - Mazda', '42.521663', '27.441459'),
	(33, 'EVPoint Westauto-M Volkswagen', '42.524651', '27.444687'),
	(34, 'Eldrive Metro Burgas', '42.529406', '27.452710'),
	(35, 'ElDrive Hotel Avenue', '42.529079', '27.453730'),
	(36, 'ElDrive Smart Business Center', '42.531588', '27.464406'),
	(37, 'EVPoint Sofia France Auto Retail', '42.532036', '27.467672'),
	(38, 'AutoBOX CBA Bolero', '42.528531', '27.462925'),
	(39, 'Eldrive Moto Pfohe Burgas', '42.534124', '27.447238'),
	(40, 'eCars Hyundai Burgas', '42.540392', '27.441232'),
	(41, 'Parking space for disabled people', '42.50187', '27.47687'),
	(42, 'Parking space for disabled people', '42.50282', '27.47722'),
	(43, 'Parking space for disabled people', '42.50284', '27.47718'),
	(44, 'Parking space for disabled people', '42.50310', '27.47640'),
	(45, 'Parking space for disabled people', '42.50312', '27.47636'),
	(46, 'Parking space for disabled people', '42.50348', '27.47652'),
	(47, 'Parking space for disabled people', '42.50350', '27.47650'),
	(48, 'Parking space for disabled people', '42.50393', '27.47643'),
	(49, 'Parking space for disabled people', '42.50396', '27.47648'),
	(50, 'Parking space for disabled people', '42.50307', '27.47796'),
	(51, 'Parking space for disabled people', '42.50359', '27.47933'),
	(52, 'Parking space for disabled people', '42.50361', '27.47928'),
	(53, 'Parking space for disabled people', '42.50378', '27.48062'),
	(54, 'Parking space for disabled people', '42.50381', '27.48062'),
	(55, 'Parking space for disabled people', '42.50390', '27.48061'),
	(56, 'Parking space for disabled people', '42.50392', '27.48061'),
	(57, 'Parking space for disabled people', '42.50415', '27.47988'),
	(58, 'Parking space for disabled people', '42.50418', '27.47987'),
	(59, 'Parking space for disabled people', '42.50425', '27.48051'),
	(60, 'Parking space for disabled people', '42.50429', '27.48050'),
	(61, 'Parking space for disabled people', '42.50471', '27.47934'),
	(62, 'Parking space for disabled people', '42.50526', '27.47980'),
	(63, 'Parking space for disabled people', '42.50557', '27.47922'),
	(64, 'Parking space for disabled people', '42.50505', '27.47796'),
	(65, 'Parking space for disabled people', '42.50508', '27.47793')


INSERT INTO LargeParkings (Id, InformationsId, ParkingSpaces, MonthlySubscriptionPrice, StayForADayPrice, StayPerHourPrice)
VALUES (1, 1, 470, 'BGN 100', 'BGN 10', 'BGN 1'),
	(2, 2, 450, 'BGN 170', 'BGN 20', 'BGN 1')

INSERT INTO ChargingStations (Id, InformationsId, Capacity, WorkingHours)
VALUES (3, 3, 'Two CCS plugs 180 kW DC fast charging station', '24/7'),
		(4, 4, 'One CHAdeMO 50 kW plug and one CCS 50 kW DC fast charging station', '8 AM - 10 PM'),
		(5, 5, 'One CCS 30 kW DC fast charging station', '24/7'),
		(6, 6, 'Three CCS 24 kW DC fast charging station', '24/7'),
		(7, 7, 'One Type 2 22 kW plug AC standard charging, one CHAdeMO 24 kW plug and one CCS 24 kW DC fast charging station', '24/7'),
		(8, 8, 'One Type 2 22 kW plug AC standard charging and one CCS 24 kW DC fast charging station', '24/7'),
		(9, 9, 'One Type 2 22 kW plug AC standard charging and one CCS 24 kW DC fast charging station', '24/7'),
		(10, 10, 'Two CCS 180 kW DC fast charging station', '24/7'),
		(11, 11, 'One CCS 50 kW DC fast charging station', '24/7'),
		(12, 12, 'One CCS 24 kW DC fast charging station', '8:30 AM - 6 PM'),
		(13, 13, 'Two CCS 150 kW DC fast charging station', '8 AM - 8 PM'),
		(14, 14, 'One CHAdeMO 50 kW plug and one CCS 50 kW DC fast charging station', '24/7'),
		(15, 15, 'One CHAdeMO 50 kW plug and one CCS 50 kW DC fast charging station', '24/7'),
		(16, 16, 'One CCS 50 kW and two CCS 120 kW DC fast charging station', '24/7'),
		(17, 17, 'One Type 2 43 kW plug AC standard charging, one CHAdeMO 50 kW plug and one CCS 50 kW DC fast charging station', '7 AM - 10 PM'),
		(18, 18, 'Two CCS 120 kW DC fast charging station', '9 AM - 6 PM'),
		(19, 19, 'Two CCS 120 kW DC fast charging station', '24/7'),
		(20, 20, 'One Type 2 22 kW plug AC standard charging station', '9 AM - 18 PM'),
		(21, 21, 'One Type 2 22 kW plug AC standard charging station', '24/7'),
		(22, 22, 'Two Type 2 22 kW plug AC standard charging station', '24/7'),
		(23, 23, 'Two Type 2 11 kW plug AC standard charging station', '24/7'),
		(24, 24, 'Two Type 2 22 kW plug AC standard charging station', '24/7'),
		(25, 25, 'Three Type 2 22 kW plug AC standard charging station', '24/7'),
		(26, 26, 'One Type 2 22 kW plug AC standard charging station', '24/7'),
		(27, 27, 'Two Type 2 22 kW plug AC standard charging station', '24/7'),
		(28, 28, 'Three Type 2 22 kW plug AC standard charging station', '24/7'),
		(29, 29, 'One Type 2 22 kW plug AC standard charging station', '24/7'),
		(30, 30, 'One Type 2 22 kW plug AC standard charging station', '24/7'),
		(31, 31, 'One Type 2 22 kW plug AC standard charging station', '24/7'),
		(32, 32, 'Two Type 2 22 kW plug AC standard charging station', '24/7'),
		(33, 33, 'Two Type 2 24 kW plug AC standard charging station', '24/7'),
		(34, 34, 'Two Type 2 22 kW plug AC standard charging station', '6 AM - 12 PM'),
		(35, 35, 'One Type 2 22 kW plug AC standard charging station', '24/7'),
		(36, 36, 'One Type 2 20 kW plug AC standard charging station', '24/7'),
		(37, 37, 'Two Type 2 22 kW plug AC standard charging station', '9 AM - 6 PM'),
		(38, 38, 'One Type 2 22 kW plug AC standard charging station', '24/7'),
		(39, 39, 'One Type 2 22 kW plug AC standard charging station', '8 AM - 7 PM'),
		(40, 40, 'One Type 2 22 kW plug AC standard charging station', '9 AM - 6 PM')

INSERT INTO ParkingForDisabled (Id, InformationsId)
VALUES (41, 41), (42, 42), (43, 43), (44, 44), (45, 45), (46, 46), (47, 47), (48, 48), (49, 49),
		(50, 50), (51, 51), (52, 52), (53, 53), (54, 54), (55, 55), (56, 56), (57, 57), (58, 58),
		(59, 59), (60, 60), (61, 61), (62, 62), (63, 63), (64, 64), (65, 65)

SELECT * FROM Accounts
SELECT * FROM LargeParkings
SELECT * FROM ChargingStations
SELECT * FROM Informations
SELECT * FROM ParkingForDisabled

DROP TABLE Accounts
DROP TABLE LargeParkings
DROP TABLE ChargingStations
DROP TABLE Informations
DROP TABLE ParkingForDisabled

DELETE FROM Accounts
DELETE FROM LargeParkings
DELETE FROM ChargingStations
DELETE FROM Informations
DELETE FROM ParkingForDisabled
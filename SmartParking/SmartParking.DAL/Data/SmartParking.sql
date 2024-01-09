CREATE DATABASE SmartParking

USE SmartParking

CREATE TABLE Accounts
(
	AccountId INT PRIMARY KEY,
    Username NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    [Password] NVARCHAR(50) NOT NULL,
	[Role] NVARCHAR(30) NOT NULL
);

INSERT INTO Accounts (AccountId, Username, Email, [Password], [Role])
VALUES ('1', 'ObshtinaBurgas', 'obshtina@burgas.bg', '1234', 'Admin')
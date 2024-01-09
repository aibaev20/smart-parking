CREATE DATABASE SmartParking

USE SmartParking

CREATE TABLE Accounts
(
    AccountId INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(50) NOT NULL,
    Email NVARCHAR(100) UNIQUE NOT NULL,
    [Password] NVARCHAR(50) NOT NULL,
    [Role] NVARCHAR(30) NOT NULL
);

INSERT INTO Accounts (Username, Email, [Password], [Role])
VALUES ('ObshtinaBurgas', 'obshtina@burgas.bg', '1234', 'Admin');
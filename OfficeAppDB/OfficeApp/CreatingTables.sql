USE MASTER
IF EXISTS(SELECT * FROM sysdatabases WHERE name='Office_Application')
DROP DATABASE Office_Application
GO

CREATE DATABASE Office_Application
GO

USE Office_Application
GO

CREATE TABLE Offices (
	officeId INT IDENTITY(1, 1) NOT NULL,
	officeName NVARCHAR(50) NOT NULL,
	field NVARCHAR(70) NOT NULL,
	founded INT NOT NULL

	CONSTRAINT PK_Offices
		PRIMARY KEY NONCLUSTERED (officeId)
)

CREATE TABLE Owners (
	ownerId INT IDENTITY(1, 1) NOT NULL,
	ownerName NVARCHAR(50) NOT NULL,
	ownerSurname NVARCHAR(50) NOT NULL

	CONSTRAINT PK_Owners
		PRIMARY KEY NONCLUSTERED (ownerId)
)

CREATE TABLE OfficesOwners (
	officeId INT NOT NULL,
	ownerId INT NOT NULL,

	CONSTRAINT FK_Offices_Owners
		FOREIGN KEY (officeId)
		REFERENCES Offices (officeId),

	CONSTRAINT FK_Owners
		FOREIGN KEY (ownerId)
		REFERENCES Owners (ownerId)
)

CREATE TABLE Computers (
	computerId INT IDENTITY(1,1) NOT NULL,
	officeId INT NOT NULL,
	manufacturer NVARCHAR(50) NOT NULL,
	model NVARCHAR(50) NOT NULL,
	computerYear INT NOT NULL,
	operatingSystem NVARCHAR(50) NOT NULL

	CONSTRAINT PK_Computers
		PRIMARY KEY NONCLUSTERED (computerId)

	CONSTRAINT FK_Offices_Computers
		FOREIGN KEY (officeId)
		REFERENCES Offices (officeId)
)

CREATE TABLE Desktop (
	computerId INT NOT NULL,
	mouse NVARCHAR(50) NOT NULL

	CONSTRAINT PK_Desktop
		PRIMARY KEY NONCLUSTERED (computerId),

	CONSTRAINT FK_Desktop_Computers
		FOREIGN KEY (computerId)
		REFERENCES Computers (computerId)
)

CREATE TABLE Laptop (
	computerId INT NOT NULL,
	touchpad NVARCHAR(50) NOT NULL

	CONSTRAINT PK_Laptop
		PRIMARY KEY NONCLUSTERED (computerId),

	CONSTRAINT FK_Laptop_Computers
		FOREIGN KEY (computerId)
		REFERENCES Computers (computerId)
)

CREATE TABLE Tablet (
	computerId INT NOT NULL,
	touchscreen NVARCHAR(50) NOT NULL

	CONSTRAINT PK_Tablet
		PRIMARY KEY NONCLUSTERED (computerId),

	CONSTRAINT FK_Tablet_Computers
		FOREIGN KEY (computerId)
		REFERENCES Computers (computerId)
)


SELECT * FROM Offices
GO

SELECT * FROM Owners
GO

SELECT * FROM OfficesOwners
GO

SELECT * FROM Computers
GO

SELECT * FROM Desktop
GO

SELECT * FROM Laptop
GO

SELECT * FROM Tablet
GO
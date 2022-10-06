USE Office_Application
GO

--Offices
INSERT Offices
VALUES (N'Elektro', 'elektronika', 2010)

INSERT Offices
VALUES (N'Programming', 'programiranje', 2012)

--Owners
INSERT Owners
VALUES ('Mate', 'Matić')

INSERT Owners
VALUES ('Ana', 'Anić')

INSERT Owners
VALUES ('Jure', 'Jurić')

--OfficesOwners
INSERT OfficesOwners
VALUES (1, 1)

INSERT OfficesOwners
VALUES (1, 2)

INSERT OfficesOwners
VALUES (2, 3)

--Computers
INSERT Computers
VALUES (1, 'Asus', 'X456G', 2017, 'Windows 10')

INSERT Computers
VALUES (1, 'Lenovo', 'G10-50S', 2018, 'Windows 10')

INSERT Computers
VALUES (1, 'Samsung', 'S10XEA', 2019, 'Android 8.1')

INSERT Computers
VALUES (2, 'Hp', 'X456G', 2016, 'Windows 7')

INSERT Computers
VALUES (2, 'Asus', 'A224E', 2018, 'Windows 10')

INSERT Computers
VALUES (2, 'Huawei', 'UQX-26', 2018, 'Android 7.1')

--Desktop
INSERT Desktop
VALUES (2, 'Logitech')

INSERT Desktop
VALUES (4, 'Hp')

--Laptop
INSERT Laptop
VALUES (1, 'Asus')

INSERT Laptop
VALUES (5, 'Asus')

--Tablet
INSERT Tablet
VALUES (3, 'Samsung')

INSERT Tablet
VALUES (6, 'Huawei')


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
--***********************WareHouse***********************--
--*********************Create/DropDB*********************--

CREATE DATABASE WareHouse
ON
(
NAME = 'WareHouse',
FILENAME = 'B:\HomeWorks\SQLEssential\DDL\WareHouse.mdf',
SIZE = 10MB,
MAXSIZE = 100MB,
FILEGROWTH = 10MB
)
LOG ON
(
NAME = 'logWareHouse',
FILENAME = 'B:\HomeWorks\SQLEssential\DDL\logWareHouse.ldf',
SIZE = 10MB,
MAXSIZE = 100MB,
FILEGROWTH = 10MB
)
GO

DROP DATABASE WareHouse
GO

--*************************TABLES************************--

USE WareHouse
GO

CREATE TABLE Suppliers
(
SupID int IDENTITY PRIMARY KEY,
Company varchar(100) NOT NULL,
Phone varchar(11),
[Address] varchar(100) NOT NULL
)

CREATE TABLE Products
(
ProductID int IDENTITY PRIMARY KEY,
[Name] varchar(100) NOT NULL
)

CREATE TABLE SuppliesHistory
(
SupID int NOT NULL FOREIGN KEY REFERENCES Suppliers(SupID),
ProductID int NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
[Count] int NOT NULL,
DeliveryDate date NOT NULL
)

CREATE TABLE Stock
(
ProductID int NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
[Count] int NOT NULL DEFAULT 0,
)

CREATE TABLE Positions
(
PositionID int IDENTITY PRIMARY KEY, 
[Name] varchar(100) NOT NULL,
[Salary] money NOT NULL DEFAULT 0
)

CREATE TABLE Employees
(
EmpID int IDENTITY PRIMARY KEY,
FirstName varchar(100) NOT NULL,
LastName varchar(100) NOT NULL,
PositionID int NOT NULL FOREIGN KEY REFERENCES Positions(PositionID),
)

CREATE TABLE Customers
(
CustomerID int IDENTITY PRIMARY KEY,
FirstName varchar(100) NOT NULL,
LastName varchar(100) NOT NULL,
[Address] varchar(100) NOT NULL,
Company varchar(100) NULL
)

CREATE TABLE RegularCustomers
(
CustomerID int UNIQUE FOREIGN KEY REFERENCES Customers(CustomerID),
OrdersCounr int NOT NULL DEFAULT 0
)

CREATE TABLE SalesHistory
(
CustomerID int NOT NULL FOREIGN KEY REFERENCES Customers(CustomerID),
ProductID int NOT NULL FOREIGN KEY REFERENCES Products(ProductID),
[Count] int NOT NULL,
SaleDate date NOT NULL
)

GO

--******************SELECT_ALL***************************--

SELECT * FROM Suppliers
SELECT * FROM Products
SELECT * FROM SuppliesHistory
SELECT * FROM Stock
SELECT * FROM Positions
SELECT * FROM Employees
SELECT * FROM Customers
SELECT * FROM RegularCustomers
SELECT * FROM SalesHistory
GO
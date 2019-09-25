--*********************Human Resources Department*********************--

CREATE DATABASE HumanResourcesDepartment
ON
(
NAME = 'HumanResourcesDepartment',
FILENAME = 'B:\HomeWorks\SQLEssential\DDL\HumanResourcesDepartment.mdf',
SIZE = 10MB,
MAXSIZE = 100MB,
FILEGROWTH = 10MB
)
LOG ON
(
NAME = 'logHumanResolutionDepartment',
FILENAME = 'B:\HomeWorks\SQLEssential\DDL\logHumanResourcesDepartment.ldf',
SIZE = 5MB,
MAXSIZE = 50MB,
FILEGROWTH = 5 MB
)
COLLATE Cyrillic_General_CI_AS
GO

USE HumanResourcesDepartment
GO

CREATE TABLE Person
(
Id int IDENTITY
     PRIMARY KEY,
FName varchar(20) NOT NULL,
LName varchar(20) NOT NULL,
Phone char(18) NOT NULL
    CHECK (Phone LIKE '[0-9] ([0-9][0-9][0-9]) [0-9][0-9][0-9] [0-9][0-9] [0-9][0-9]'),
[Address] nvarchar(20) NOT NULL,
FirstWorkDay date NOT NULL,
BirthDate date NOT NULL,
)

CREATE TABLE Position
(
[Name] varchar(30) NOT NULL
PRIMARY KEY,
Salary money NOT NULL
)

CREATE TABLE Salaries
(
EmployeeId int NOT NULL
FOREIGN KEY REFERENCES Person(Id)
ON UPDATE CASCADE
ON DELETE CASCADE,
Position varchar(30) NOT NULL
FOREIGN KEY REFERENCES Position([Name])
ON UPDATE CASCADE
ON DELETE CASCADE,
[Date] date NOT NULL,
[Salary] tinyint DEFAULT 0
)

--********************************************
DROP TABLE Salaries
DROP TABLE Person
DROP TABLE Position
DROP DATABASE HumanResourcesDepartment

--*********************Создание Базы Данных*********************

CREATE DATABASE MyDB
ON ( NAME = 'MyDB', FILENAME = 'B:\HomeWorks\SQLEssential\HW1\MyDB.mdf', SIZE = 10MB, MAXSIZE = 100MB, FILEGROWTH = 10MB) --создание основного файла базы данных
LOG ON ( NAME = 'LogMyDB', FILENAME = 'B:\HomeWorks\SQLEssential\HW1\LogMyDB.ldf', SIZE = 5MB, MAXSIZE = 50MB, FILEGROWTH = 5MB )--создание лог файла базы данных
COLLATE Cyrillic_General_CI_AS --установка кодировки

--******************Подключение к базе данных*********************

USE MYDB 
GO

--*********************Создание таблиц в базе*********************
--Имена сотрудников и номера телефонов
create table Employee
(
ID int IDENTITY not null PRIMARY KEY,
Name varchar(20) not null,
Phone char(12) not null
)
--Зарплаты сотрудников и должности
CREATE TABLE SalaryAndPost
(
EmpID int NOT NULL
FOREIGN KEY REFERENCES Employee(ID)
ON DELETE CASCADE
ON UPDATE CASCADE,
Post varchar(20) NOT NULL,
Salary money NOT NULL
)

--Семейное положение, дата рождения и место проживания
CREATE TABLE FamilyStatus_DOB_Residendce
(
EmpID int NOT NULL
FOREIGN KEY REFERENCES Employee(ID)
ON DELETE CASCADE
ON UPDATE CASCADE,
FamilyStatus varchar(50) NOT NULL,
DOB date NOT NULL,
Residendce varchar(100) NOT NULL
)

--**************Удаление**************

DROP DATABASE MyDB

DROP TABLE Employee
DROP TABLE SalaryAndPost
DROP TABLE FamilyStatus_DOB_Residendce

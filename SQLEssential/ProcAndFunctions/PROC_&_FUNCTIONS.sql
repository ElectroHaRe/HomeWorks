CREATE DATABASE MyFuncDB
ON
(
NAME = 'MyFuncDB',
FILENAME ='B:\HomeWorks\SQLEssential\ProcAndFunctions\MyFuncDB.mdf',
SIZE = 1MB,
MAXSIZE = 3MB,
FILEGROWTH = 1MB
)
LOG ON
(
NAME = 'logMyFuncDB',
FILENAME ='B:\HomeWorks\SQLEssential\ProcAndFunctions\logMyFuncDB.ldf',
SIZE = 500KB,
MAXSIZE = 1500KB,
FILEGROWTH = 500KB
)
COLLATE Cyrillic_General_CI_AS

--************************Initializing************************--

USE MyFuncDB

CREATE TABLE JobTitles
(
JobTitle varchar(100) NOT NULL PRIMARY KEY,
Salary money NOT NULL DEFAULT 0
)

CREATE TABLE Names_JobTitles_Phones
(
EmpID int NOT NULL PRIMARY KEY CLUSTERED,
FirstName varchar(255) NOT NULL,
LastName varchar(255) NOT NULL,
Phone varchar(100) NOT NULL,
JobTitle varchar(100) NOT NULL FOREIGN KEY REFERENCES JobTitles(JobTitle),
UNIQUE (FirstName,LastName,Phone)
)

CREATE TABLE FamilyStatus_Address_BirthDate
(
EmpID int NOT NULL FOREIGN KEY REFERENCES Names_JobTitles_Phones(EmpID),
FamilyStatus varchar(255) NOT NULL DEFAULT 'Unknown',
[Address] varchar(255) NOT NULL DEFAULT 'Unknown',
BithDate varchar(255) NOT NULL
)
GO

INSERT JobTitles(JobTitle,Salary)
SELECT Position, Salary FROM MyJoinsDB.dbo.Positions

INSERT Names_JobTitles_Phones(EmpID, FirstName, LastName, Phone, JobTitle)
SELECT EmpID, FName, Lname, Phone, Pos FROM MyJoinsDB.dbo.Employees 

INSERT FamilyStatus_Address_BirthDate(EmpID,FamilyStatus,[Address],BithDate)
SELECT EmpID, FamilyStatus, [Address], BirthDate FROM MyJoinsDB.dbo.Person 
GO

SELECT * FROM JobTitles
SELECT * FROM Names_JobTitles_Phones
SELECT * FROM FamilyStatus_Address_BirthDate
GO

--*************************PROC_&_FUNC************************--

USE MyFuncDB
GO

--*********************Phones_&_Addreses**********************--

CREATE PROC SelectContacts
AS
	SELECT T1.EmpID, FirstName, LastName, Phone, [Address] FROM Names_JobTitles_Phones AS T1
		JOIN FamilyStatus_Address_BirthDate AS T2
		ON T1.EmpID = T2.EmpID
GO

EXEC SelectContacts
GO

--****************BirthDates_Phones_Unmarried*****************--

CREATE PROC SelectUnmarried
AS
	SELECT FirstName, LastName, FamilyStatus, Phone, BithDate FROM Names_JobTitles_Phones AS T1
		JOIN FamilyStatus_Address_BirthDate AS T2
		ON T1.EmpID = T2.EmpID
		WHERE FamilyStatus = 'Unmarried'
GO

EXEC SelectUnmarried
GO

--*****************BirthDates_Phones_Managers*****************--

CREATE PROC SelectManagers
AS
	SELECT FirstName, LastName, JobTitle, Phone, BithDate FROM Names_JobTitles_Phones AS T1
		JOIN FamilyStatus_Address_BirthDate AS T2
		ON T1.EmpID = T2.EmpID
		WHERE JobTitle = 'Manager'
GO

EXEC SelectManagers
GO

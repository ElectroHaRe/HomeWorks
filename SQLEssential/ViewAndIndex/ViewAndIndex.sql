USE MyJoinsDB
GO


--*******************id = 1 - clustered index*******************--

SELECT [name] , schema_id FROM sys.tables

--*****************************VIEW*****************************--

USE MyJoinsDB
GO

SELECT * FROM Employees
SELECT * FROM Person
SELECT * FROM Positions
GO

--************************Phone_&_Address***********************--

USE MyJoinsDB
GO

CREATE VIEW Contacts
WITH SCHEMABINDING
AS SELECT Employees.EmpID, FName, LName, [Address], Employees.Phone FROM dbo.Employees
		JOIN dbo.Person ON dbo.Person.EmpID = dbo.Employees.EmpID
GO

SELECT * FROM Contacts
GO

--*******************Phone_&_BirtDate_Unmarried*****************--

USE MyJoinsDB
GO

CREATE VIEW Unmarried
WITH SCHEMABINDING
AS 
	SELECT Employees.EmpID, FName AS FirstName, LName AS LastName, FamilyStatus, Phone, BirthDate FROM dbo.Employees
	JOIN dbo.Person ON Person.EmpID = Employees.EmpID
	WHERE Person.FamilyStatus = 'Unmarried'
GO

SELECT * FROM Unmarried
GO

--*********************Phone_&_BirtDate_Manager*****************--

USE MyJoinsDB
GO

CREATE VIEW Managers
WITH SCHEMABINDING
AS	
	SELECT Employees.EmpID, FName AS FirstName, LName AS LastName, Pos, Phone, BirthDate FROM dbo.Employees
	JOIN dbo.Person ON Person.EmpID = Employees.EmpID
	WHERE Employees.Pos = 'Manager'
GO

SELECT * FROM Managers
GO
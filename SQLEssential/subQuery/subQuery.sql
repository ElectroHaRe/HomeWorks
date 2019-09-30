USE MyJoinsDB
GO

--***************************EmpPhoneAndAdress***************************--

SELECT Employees.EmpID, FName, LName, Phone, [Address] FROM Employees
	LEFT OUTER JOIN Person
	ON Person.EmpID = Employees.EmpID
GO

WITH Addreses( EmpID , [Address]) AS
	(
	SELECT Person.EmpID , Person.[Address] FROM Person
	)
	SELECT Employees.EmpID, Employees.FName, Employees.LName, Employees.Phone, [Address] FROM Employees
		LEFT OUTER JOIN Addreses ON Addreses.EmpID = Employees.EmpID

--****************************BirthDate_&_Phone**************************--

SELECT Person.EmpID, Person.FamilyStatus,Person.BirthDate ,Phones.Phone FROM Person
	JOIN (SELECT EmpID ,Phone FROM Employees) AS Phones
	ON Phones.EmpID = Person.EmpID
WHERE Person.FamilyStatus = 'Unmarried'

SELECT EmpID , BirthDate , (SELECT Phone FROM Employees WHERE P1.EmpID = Employees.EmpID) AS Phone FROM Person AS P1
WHERE EXISTS (SELECT FamilyStatus FROM Person AS P2
				WHERE P1.EmpID = P2.EmpID AND P2.FamilyStatus = 'Unmarried')
GO

--**********************BirthDate_&_Phone_For_Managers*******************--

SELECT Employees.EmpID, Fname, LName, BirthDate, Phone FROM Employees
	LEFT OUTER JOIN Person ON Person.EmpID = Employees.EmpID
WHERE Pos = 'Manager'

SELECT Employees.EmpID, Employees.FName, Employees.LName , 
	(SELECT Person.BirthDate FROM Person WHERE Employees.EmpID = Person.EmpID) AS BirthDate, Employees.Phone FROM Employees
WHERE Employees.Pos = 'Manager'
GO

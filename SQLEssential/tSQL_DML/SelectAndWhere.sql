--********************_1_**********************
--*************AdventureWorks2017**************

USE AdventureWorks2017

SELECT * FROM Production.Product

SELECT * FROM Production.Product
WHERE StandardCost > 100
ORDER BY StandardCost

SELECT * FROM Production.Product
WHERE [Name] LIKE 'ML%' 
AND ProductNumber LIKE 'RM%'

GO

--********************_2_**********************

CREATE DATABASE HomeWork
ON
(
NAME = 'HomeWork',
FILENAME = 'B:\HomeWorks\SQLEssential\tSQL_DML\HomeWork.mdf',
SIZE = 10MB,
MAXSIZE = 100MB,
FILEGROWTH = 10MB
)
LOG ON
(
NAME = 'logHomeWork',
FILENAME = 'B:\HomeWorks\SQLEssential\tSQL_DML\logHomeWork.ldf',
SIZE = 5MB,
MAXSIZE = 50MB,
FILEGROWTH = 5MB
)
COLLATE Cyrillic_General_CI_AS

USE HomeWork
GO

CREATE TABLE Product
(
ProductID int NOT NULL IDENTITY,
[Name] nvarchar(20) NOT NULL,
ProductNumber varchar(20) NOT NULL,
Cost money NOT NULL,
[Count] int DEFAULT 0,
SellStartDate date NULL
)

INSERT Product
([Name],ProductNumber,Cost,[Count],SellStartDate)
VALUES
('Корона','AK-53818',5,50, '20110815'),
('Милка', 'AM-51122',6.1,50,'20110715'),  
('Аленка','AA-52211',2.5,20,'20110615'),  
('Snickers','BS-32118',2.8,50,'20110815'),  
('Snickers','BSL-3818',5,100,'20110820'),  
('Bounty','BB-38218',3,100,'20110801'),  
('Nuts','BN-37818',3,100,'20110821'),  
('Mars','BM-3618',2.5,50,'20110824'), 
('Свиточ','AS-54181',5,100,'20110812'),
('Свиточ','AS-54182',5,100,'20110812')

SELECT * FROM Product

--********************_3_**********************

SELECT * FROM Product
WHERE [Count] > 59

SELECT * FROM Product
WHERE Cost>3 AND SellStartDate = '20110820'

--********************_3_**********************

SELECT * FROM Product

SELECT [Cost] FROM Product
WHERE [Name] = 'Свиточ'

UPDATE Product
SET [Cost] = [Cost] + 0.25
WHERE [Name] = 'Свиточ'

SELECT * FROM Product

--************Сбросы и удаления************

TRUNCATE TABLE Product
DROP DATABASE HomeWork
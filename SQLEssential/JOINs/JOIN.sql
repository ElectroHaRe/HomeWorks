--********************************Iinitialization********************************--

CREATE DATABASE MyJoinsDB
ON(
NAME = 'MyJoinsDB',
FILENAME = 'B:\HomeWorks\SQLEssential\JOINs\MyJoinsDB.mdf',
SIZE = 1MB,
MAXSIZE = 3MB,
FILEGROWTH = 1MB
) 
LOG ON
(
NAME = 'logMyJoinsDB',
FILENAME = 'B:\HomeWorks\SQLEssential\JOINs\logMyJoinsDB.ldf',
SIZE = 500KB,
MAXSIZE = 1500KB,
FILEGROWTH = 500KB
)

USE MyJoinsDB
GO

CREATE TABLE Positions
(
Position varchar(100) NOT NULL PRIMARY KEY,
Salary varchar(100) NOT NULL
)

CREATE TABLE Employees (
  EmpID int IDENTITY NOT NULL PRIMARY KEY,
  FName varchar(255) NOT NULL,
  LName varchar(255) NOT NULL,
  Phone varchar(100) NOT NULL,
  Pos varchar(100) FOREIGN KEY REFERENCES Positions(Position),
  UNIQUE (FName,LName,Phone)
);

CREATE TABLE Person (
  EmpID int NOT NULL FOREIGN KEY REFERENCES Employees(EmpID),
  FamilyStatus varchar(255) default NULL,
  BirthDate varchar(255),
  [Address] varchar(255) default NULL
);

INSERT INTO Positions
VALUES
('CEO', 10000),
('Manager', 2000),
('Worker', 1000)

INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Geraldine','Hewitt','CEO','1-876-580-4389'),('Preston','Glenn','CEO','1-978-622-4146'),('Robert','Moody','Manager','1-243-238-2343'),('Kane','England','Worker','1-402-232-8490'),('Alvin','Moses','Manager','1-498-441-4215'),('Rhiannon','Horne','CEO','1-683-469-2601'),('Shafira','Conner','Manager','1-466-163-8132'),('Lyle','Faulkner','CEO','1-334-965-7856'),('Bethany','Porter','CEO','1-530-759-5097'),('Talon','Macias','CEO','1-893-780-5091');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Jin','Cobb','Manager','1-685-548-4370'),('September','Flynn','Worker','1-741-413-3174'),('Glenna','Aguilar','Worker','1-612-190-0482'),('Ciara','Powell','Manager','1-904-313-3419'),('Lacey','Henson','Worker','1-877-663-7005'),('Adam','Brady','Worker','1-896-152-3039'),('Nehru','Barker','Manager','1-475-121-6021'),('Carson','Vazquez','Worker','1-859-339-4538'),('Willa','Beard','Manager','1-392-620-5492'),('Hunter','Sweet','Worker','1-519-543-2273');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Raphael','Conley','CEO','1-539-407-7678'),('Evangeline','Holder','Manager','1-545-566-9563'),('Kareem','Reilly','CEO','1-278-990-3863'),('Jael','Ramirez','Manager','1-258-565-5465'),('Kaden','Watkins','Manager','1-739-112-8322'),('Jameson','Griffith','Manager','1-309-317-3611'),('Finn','Cunningham','Worker','1-662-736-2559'),('Mia','Baldwin','Worker','1-266-566-6651'),('Sandra','Russell','CEO','1-843-126-8344'),('Mari','Mendez','CEO','1-632-560-0623');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Uta','Henson','Manager','1-472-917-7700'),('Emi','Pittman','Worker','1-468-466-6133'),('Ayanna','Davis','Manager','1-687-372-8330'),('Carson','Calhoun','CEO','1-893-785-2212'),('Ezra','Vinson','Worker','1-122-391-2900'),('Declan','Kerr','CEO','1-826-354-9709'),('Hollee','Jefferson','CEO','1-974-763-5386'),('Moses','Wade','CEO','1-802-573-9485'),('Mason','Short','Worker','1-730-740-4343'),('Judah','Lindsay','Worker','1-380-469-9231');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Molly','Monroe','Manager','1-159-221-8419'),('Aphrodite','Haley','CEO','1-339-343-5299'),('Gary','Jensen','Manager','1-288-788-1098'),('Sasha','Rose','Manager','1-732-280-1929'),('Zane','Koch','CEO','1-442-643-2179'),('Sophia','Hurst','CEO','1-542-852-9108'),('Aidan','Holcomb','Manager','1-928-872-4320'),('Tallulah','Cox','Worker','1-578-270-0947'),('Liberty','Houston','CEO','1-799-814-3466'),('Alice','Mccarthy','Manager','1-493-230-3386');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Clayton','Reilly','Manager','1-337-691-5985'),('Keelie','Wood','CEO','1-782-926-0730'),('Nehru','Crosby','Worker','1-325-933-6433'),('Alika','Puckett','Manager','1-677-603-2362'),('Vivian','Burns','Worker','1-691-891-6925'),('Bertha','Rosario','Manager','1-142-991-3489'),('Oleg','Webster','CEO','1-786-579-6360'),('Summer','Mendez','CEO','1-896-450-3086'),('Kevin','Gardner','Worker','1-653-506-1941'),('Ignatius','Carey','Worker','1-649-191-2358');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Ayanna','Woodward','CEO','1-517-564-8585'),('Maya','Barron','Manager','1-588-443-3727'),('Rhea','Barber','Worker','1-604-457-6769'),('Lani','Elliott','CEO','1-215-869-6781'),('Grant','Ingram','CEO','1-518-669-1561'),('Abbot','Petersen','Manager','1-920-556-6344'),('Wyoming','Moses','Worker','1-333-378-1630'),('Katell','Wooten','Worker','1-726-912-6395'),('Jesse','Kemp','Worker','1-324-602-5239'),('Denise','Best','Worker','1-821-765-2368');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Emerson','Foley','CEO','1-571-912-7997'),('Akeem','Sharp','Manager','1-940-407-7639'),('Clio','Hyde','CEO','1-207-226-8210'),('Howard','Boyle','CEO','1-315-684-4056'),('Vivien','Hampton','CEO','1-430-250-8273'),('Grant','Duke','CEO','1-130-714-3158'),('Maile','Perry','Worker','1-320-608-0944'),('Zephr','Roy','CEO','1-582-590-1529'),('Kuame','Grimes','CEO','1-359-875-1677'),('Pascale','Park','Manager','1-933-737-1075');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Marshall','Dalton','CEO','1-961-245-4513'),('Sean','Justice','Manager','1-357-955-9567'),('Francis','Mccarthy','Worker','1-403-715-5781'),('James','Ayala','Worker','1-990-373-9386'),('Faith','White','Worker','1-897-740-2429'),('Virginia','Johns','CEO','1-797-629-3179'),('Burton','Sosa','Manager','1-402-860-5570'),('Silas','Hess','Worker','1-536-172-5790'),('Brendan','Middleton','Worker','1-180-860-8579'),('Fleur','Woodard','Worker','1-537-997-8520');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('Griffin','Humphrey','Manager','1-194-867-6767'),('Haviva','Chen','Manager','1-209-605-6760'),('Denton','Hanson','Worker','1-187-346-1380'),('Ivan','Gross','Manager','1-512-306-6327'),('Akeem','Austin','Worker','1-412-749-2210'),('Wang','Velez','Manager','1-723-357-3660'),('Tucker','Mueller','Manager','1-670-728-2272'),('Dylan','Cook','Worker','1-450-122-6453'),('Dustin','Watson','Manager','1-222-647-4284'),('Channing','Slater','CEO','1-352-276-8626');
INSERT INTO Employees (FName,LName,Pos,Phone) VALUES ('FUNKNOWN','LUNKNOWN','Manager','3-555-333-2211')

INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (1,'Unmarried','11/02/2001','Ap #313-6898 Pede Rd.'),(2,'Married','24/02/1993','2720 Metus. St.'),(3,'Unmarried','02/10/1992','Ap #286-7689 Egestas Avenue'),(4,'Married','26/10/1999','Ap #279-7187 Congue Road'),(5,'Unmarried','30/10/2000','9776 Dictum Rd.'),(6,'Married','26/04/2002','P.O. Box 133, 4260 Non St.'),(7,'Married','25/08/1997','753-3053 Dignissim Road'),(8,'Married','23/06/1995','Ap #884-4946 Lorem St.'),(9,'Unmarried','07/10/1996','Ap #200-6858 Commodo St.'),(10,'Unmarried','25/09/2000','1979 Ante Ave');
INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (11,'Unmarried','17/12/1994','P.O. Box 655, 9362 Ut, Road'),(12,'Married','08/09/2001','7386 Faucibus Av.'),(13,'Married','10/03/1992','173-4400 Etiam Rd.'),(14,'Unmarried','09/05/1997','Ap #328-2259 Tincidunt, St.'),(15,'Married','29/01/1993','339-9285 Dignissim. Av.'),(16,'Married','14/07/1996','116-2108 Tortor, Avenue'),(17,'Married','13/01/1993','P.O. Box 713, 1994 Sed Rd.'),(18,'Married','24/05/1994','737-7927 Eleifend. Road'),(19,'Unmarried','18/05/1996','680-390 Vitae Av.'),(20,'Married','24/07/2001','Ap #681-2875 Feugiat St.');
INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (21,'Married','12/01/1996','9165 Ac Av.'),(22,'Married','22/11/1996','P.O. Box 141, 6616 Et St.'),(23,'Married','24/04/1999','1269 Ridiculus St.'),(24,'Unmarried','02/08/1991','Ap #488-3983 Purus St.'),(25,'Unmarried','21/06/1992','4969 Dignissim Rd.'),(26,'Married','09/12/1995','Ap #411-9440 Sit Road'),(27,'Unmarried','20/12/2001','P.O. Box 174, 1372 Porttitor St.'),(28,'Unmarried','18/02/1993','9864 Eleifend Ave'),(29,'Unmarried','11/04/1999','386-5298 Nam Av.'),(30,'Married','12/06/1995','P.O. Box 756, 9699 In St.');
INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (31,'Unmarried','14/05/1995','606 Sed Road'),(32,'Married','19/01/2001','Ap #255-6510 Eu Ave'),(33,'Married','18/08/1995','P.O. Box 664, 7336 Rhoncus. St.'),(34,'Married','14/03/1991','4245 In Rd.'),(35,'Unmarried','29/08/2002','Ap #440-5621 Ac Street'),(36,'Married','29/03/2002','675-8311 Vitae, Rd.'),(37,'Unmarried','02/04/1992','P.O. Box 366, 7228 Nec Avenue'),(38,'Married','24/02/1996','735 A Rd.'),(39,'Married','03/05/1996','P.O. Box 345, 2228 Mauris St.'),(40,'Unmarried','29/11/1995','238-9483 Aliquet. Street');
INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (41,'Unmarried','12/04/1999','Ap #514-543 A, Rd.'),(42,'Married','08/11/1992','P.O. Box 109, 7781 Magna. Road'),(43,'Unmarried','17/12/1991','Ap #563-5657 Per Rd.'),(44,'Married','05/12/1994','8047 Malesuada Rd.'),(45,'Unmarried','29/10/1991','Ap #638-7855 Ut Avenue'),(46,'Married','11/03/1996','113-461 Pellentesque Street'),(47,'Married','29/10/1991','P.O. Box 277, 6276 Placerat. Rd.'),(48,'Unmarried','07/09/1994','506-9432 Vulputate Avenue'),(49,'Unmarried','02/12/1999','P.O. Box 311, 8630 Sodales Rd.'),(50,'Married','19/09/1992','Ap #965-5488 Auctor Street');
INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (51,'Married','07/09/1992','P.O. Box 180, 1515 Orci, Street'),(52,'Unmarried','14/09/1999','Ap #317-3438 Taciti Av.'),(53,'Unmarried','05/07/1994','P.O. Box 999, 9807 Lorem Rd.'),(54,'Married','19/06/1997','P.O. Box 831, 2074 Mauris Ave'),(55,'Unmarried','19/06/1998','175-8191 At, Av.'),(56,'Married','04/04/1992','P.O. Box 251, 582 Nec St.'),(57,'Unmarried','09/01/1992','P.O. Box 235, 1795 Mauris Road'),(58,'Married','10/08/1996','P.O. Box 707, 6965 Nibh Ave'),(59,'Married','11/08/1994','4602 Non, Rd.'),(60,'Unmarried','27/02/2002','P.O. Box 500, 6899 Id, Avenue');
INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (61,'Married','23/03/1992','P.O. Box 229, 409 Ipsum. Ave'),(62,'Married','11/06/1992','Ap #170-8228 Sem. Road'),(63,'Married','25/02/1995','P.O. Box 817, 3274 Tincidunt Avenue'),(64,'Unmarried','28/06/2002','Ap #833-3055 Pede Avenue'),(65,'Unmarried','19/12/1996','P.O. Box 914, 8190 Fusce St.'),(66,'Unmarried','25/03/1998','P.O. Box 635, 5467 At, Avenue'),(67,'Married','18/01/2001','450-4112 Quis Ave'),(68,'Married','20/12/2000','Ap #225-2350 Semper Rd.'),(69,'Married','03/11/1991','Ap #921-3624 Consequat Avenue'),(70,'Married','06/01/1991','P.O. Box 975, 2364 Nam Rd.');
INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (71,'Married','13/06/2002','Ap #810-2252 Imperdiet Avenue'),(72,'Married','27/07/1997','Ap #116-1228 Vivamus Avenue'),(73,'Unmarried','16/08/1991','Ap #712-9126 Nam St.'),(74,'Married','13/02/2000','Ap #420-6082 Eu Rd.'),(75,'Married','31/01/1999','7601 Nisi. Avenue'),(76,'Married','29/05/1998','Ap #648-8083 Iaculis Ave'),(77,'Unmarried','10/11/1999','Ap #194-3749 Risus. St.'),(78,'Unmarried','30/09/2001','1874 Conubia Road'),(79,'Married','04/08/1996','Ap #136-7436 Diam St.'),(80,'Married','13/03/1995','904-2987 Quam Avenue');
INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (81,'Married','01/03/1993','Ap #612-5147 Sit Avenue'),(82,'Unmarried','13/05/2000','Ap #227-8670 Sollicitudin Av.'),(83,'Unmarried','05/11/1996','3626 Parturient Ave'),(84,'Unmarried','29/07/1993','P.O. Box 932, 5217 Luctus Rd.'),(85,'Married','12/03/2000','285-5245 At Av.'),(86,'Married','02/02/1994','Ap #805-4279 Ligula. Avenue'),(87,'Married','23/06/2000','673-3065 Nulla Street'),(88,'Married','06/02/1995','Ap #157-9718 Dignissim Road'),(89,'Unmarried','13/01/1995','Ap #751-9363 Dui, Ave'),(90,'Unmarried','21/04/1998','Ap #217-5952 Aliquet St.');
INSERT INTO Person (EmpID,FamilyStatus,BirthDate,[Address]) VALUES (91,'Unmarried','26/09/2000','619-3466 Elit Ave'),(92,'Married','27/09/1996','8209 Metus Rd.'),(93,'Unmarried','09/11/1998','Ap #106-9721 Posuere Avenue'),(94,'Unmarried','13/11/2000','Ap #720-4741 Euismod St.'),(95,'Married','20/10/1994','2531 Id Rd.'),(96,'Married','16/11/1994','5159 A, Ave'),(97,'Unmarried','06/09/2001','P.O. Box 812, 4093 Urna. Rd.'),(98,'Married','18/02/2002','884-1341 Hendrerit St.'),(99,'Unmarried','01/05/1996','1325 Malesuada Ave'),(100,'Married','10/10/1996','P.O. Box 584, 1062 Erat. Avenue');

SELECT * FROM Positions
SELECT * FROM Employees
SELECT * FROM Person
GO

--*************************************JOIN's************************************--
USE MyJoinsDB
GO

--Phone_&_Address
SELECT Employees.EmpID, Phone, [Address] FROM Employees
	INNER JOIN Person
ON Person.EmpID = Employees.EmpID
GO

--Unmarried_BirthDate_&_Phone
SELECT Person.EmpID, BirthDate, Phone FROM Person
	INNER JOIN Employees
ON Person.EmpID = Employees.EmpID
WHERE FamilyStatus = 'Unmarried'

--Managers_BirthDate_&_Phone
SELECT  Employees.EmpID,Fname,LName, BirthDate, Phone FROM Employees
	JOIN Person
ON Person.EmpID = Employees.EmpID
WHERE Pos = 'Manager'

--LEFT OUTER JOIN
SELECT  Employees.EmpID,Fname,LName, BirthDate, Phone FROM Employees
	LEFT OUTER JOIN Person
ON Person.EmpID = Employees.EmpID
WHERE Pos = 'Manager'
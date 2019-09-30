--*************************Initialize_DB_&_TABLE*************************--

CREATE DATABASE NormalizedDB
ON
(
NAME = 'NormalizedDB',
FILENAME = 'B:\HomeWorks\SQLEssential\DBNormalization\NormalizedDB.mdf',
SIZE = 1MB,
MAXSIZE = 3MB,
FILEGROWTH = 1MB
)
LOG ON
(
NAME = 'logNormalizedDB',
FILENAME = 'B:\HomeWorks\SQLEssential\DBNormalization\logNormalizedDB.ldf',
SIZE = 500KB,
MAXSIZE = 1500KB,
FILEGROWTH = 500KB
)
COLLATE Cyrillic_General_CI_AS
GO

CREATE TABLE DenormilizedTable
(
ФИО varchar(100) NOT NULL,
Взвод int NOT NULL,
Оружие varchar(100) NOT NULL,
[Оружие выдал] varchar(100) NOT NULL
)
GO

INSERT DenormilizedTable
(ФИО, Взвод, Оружие, [Оружие выдал])
VALUES
('Петров В.А.', 222, 'АК-47', 'Буров О.С., майор'), 
('Петров В.А.', 222, 'Глок20', 'Рыбаков Н.Г., майор'),
('Лодарев П.С.', 232, 'АК-74', 'Деребанов В.Я., подполковник'), 
('Лодарев П.С.', 232, 'Глок20', 'Рыбаков Н.Г., майор'),
('Леонтьев К.В.', 212, 'АК-47', 'Буров О.С., майор'), 
('Леонтьев К.В.', 212, 'Глок20', 'Рыбаков Н.Г., майор'),
('Духов Р.М.', 200, 'АК-47', 'Буров О.С., майор') 
SELECT * FROM DenormilizedTable
GO

--***********************************1NF*********************************--

USE NormalizedDB
GO

CREATE TABLE NF1
(
Фамилия varchar(100) NOT NULL,
Имя varchar(100) NOT NULL,
Отчество varchar(100) NOT NULL,
Взвод int NOT NULL,
Оружие varchar(100) NOT NULL,
[Фамилия выдавшего оружие] varchar(100) NOT NULL,
[Имя выдавшего оружие] varchar(100) NOT NULL,
[Отчество выдавшего оружие] varchar(100) NOT NULL,
[Звание выдавшего оружие] varchar(100) NOT NULL
)

INSERT NF1
(Фамилия, Имя, Отчество, Взвод, Оружие, [Фамилия выдавшего оружие], [Имя выдавшего оружие],  [Отчество выдавшего оружие], [Звание выдавшего оружие])
VALUES
('Петров', 'Виктор', 'Алексеевич', 222, 'АК-47', 'Буров', 'Олег', 'Сергеевич', 'майор'), 
('Петров', 'Виктор', 'Алексеевич', 222, 'Глок20', 'Рыбаков', 'Никита', 'Генадиевич', 'майор'),
('Лодарев' ,'Павел', 'Сергеевич', 232, 'АК-74', 'Деребанов' ,'Валерий', 'Ярославович', 'подполковник'), 
('Лодарев' ,'Павел', 'Сергеевич', 232, 'Глок20', 'Рыбаков', 'Никита', 'Генадиевич', 'майор'),
('Леонтьев', 'Кирил', 'Виталиевич', 212, 'АК-47', 'Буров', 'Олег', 'Сергеевич', 'майор'), 
('Леонтьев', 'Кирил', 'Виталиевич', 212, 'Глок20', 'Рыбаков', 'Никита', 'Генадиевич', 'майор'),
('Духов', 'Роман', 'Михайлович', 200, 'АК-47', 'Буров', 'Олег', 'Сергеевич', 'майор')
SELECT * FROM NF1
GO

--***********************************2NF*********************************--

CREATE TABLE Cadets
(
CadetID int IDENTITY NOT NULL PRIMARY KEY,
Фамилия varchar(100) NOT NULL,
Имя varchar(100) NOT NULL,
Отчество varchar(100) NOT NULL,
Взвод int NOT NULL
)

CREATE TABLE Officers
(
OfficerID int IDENTITY NOT NULL PRIMARY KEY,
Фамилия varchar(100) NOT NULL,
Имя varchar(100) NOT NULL,
Отчество varchar(100) NOT NULL,
Звание varchar(100) NULL
)

CREATE TABLE Weapons
(
Наименование varchar(100) NOT NULL PRIMARY KEY,
--Здесь должно быть что-то ещё, однако у меня больше нет информации
)

CREATE TABLE NF2
(
ID int IDENTITY NOT NULL PRIMARY KEY,
Получил int NOT NULL FOREIGN KEY REFERENCES Cadets(CadetID),
Оружие varchar(100) NOT NULL FOREIGN KEY REFERENCES Weapons(Наименование),
Выдал int NOT NULL FOREIGN KEY REFERENCES Officers(OfficerID)
)
GO

INSERT Cadets
SELECT Фамилия , Имя , Отчество, Взвод FROM NF1
GROUP BY Фамилия , Имя , Отчество, Взвод
SELECT * FROM Cadets

INSERT Officers
SELECT [Фамилия выдавшего оружие], [Имя выдавшего оружие], [Отчество выдавшего оружие],
[Звание выдавшего оружие] FROM NF1
GROUP BY [Фамилия выдавшего оружие], [Имя выдавшего оружие], [Отчество выдавшего оружие], [Звание выдавшего оружие]
SELECT * FROM Officers

INSERT Weapons
SELECT Оружие FROM NF1
GROUP BY Оружие
SELECT * FROM Weapons

SELECT * FROM Cadets
SELECT * FROM Officers

INSERT NF2
VALUES
(4, 'АК-47', 1), 
(4, 'Глок20', 3),
(3, 'АК-74', 2), 
(3, 'Глок20', 3),
(2,'АК-47', 1), 
(2, 'Глок20', 3),
(1, 'АК-47', 1)
SELECT *  FROM NF2
GO

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
SELECT * FROM DenormilizedTable
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
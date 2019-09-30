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
��� varchar(100) NOT NULL,
����� int NOT NULL,
������ varchar(100) NOT NULL,
[������ �����] varchar(100) NOT NULL
)
GO

INSERT DenormilizedTable
(���, �����, ������, [������ �����])
VALUES
('������ �.�.', 222, '��-47', '����� �.�., �����'), 
('������ �.�.', 222, '����20', '������� �.�., �����'),
('������� �.�.', 232, '��-74', '��������� �.�., ������������'), 
('������� �.�.', 232, '����20', '������� �.�., �����'),
('�������� �.�.', 212, '��-47', '����� �.�., �����'), 
('�������� �.�.', 212, '����20', '������� �.�., �����'),
('����� �.�.', 200, '��-47', '����� �.�., �����') 
SELECT * FROM DenormilizedTable
GO

--***********************************1NF*********************************--

USE NormalizedDB
GO

CREATE TABLE NF1
(
������� varchar(100) NOT NULL,
��� varchar(100) NOT NULL,
�������� varchar(100) NOT NULL,
����� int NOT NULL,
������ varchar(100) NOT NULL,
[������� ��������� ������] varchar(100) NOT NULL,
[��� ��������� ������] varchar(100) NOT NULL,
[�������� ��������� ������] varchar(100) NOT NULL,
[������ ��������� ������] varchar(100) NOT NULL
)

INSERT NF1
(�������, ���, ��������, �����, ������, [������� ��������� ������], [��� ��������� ������],  [�������� ��������� ������], [������ ��������� ������])
VALUES
('������', '������', '����������', 222, '��-47', '�����', '����', '���������', '�����'), 
('������', '������', '����������', 222, '����20', '�������', '������', '����������', '�����'),
('�������' ,'�����', '���������', 232, '��-74', '���������' ,'�������', '�����������', '������������'), 
('�������' ,'�����', '���������', 232, '����20', '�������', '������', '����������', '�����'),
('��������', '�����', '����������', 212, '��-47', '�����', '����', '���������', '�����'), 
('��������', '�����', '����������', 212, '����20', '�������', '������', '����������', '�����'),
('�����', '�����', '����������', 200, '��-47', '�����', '����', '���������', '�����')
SELECT * FROM NF1
GO

--***********************************2NF*********************************--

CREATE TABLE Cadets
(
CadetID int IDENTITY NOT NULL PRIMARY KEY,
������� varchar(100) NOT NULL,
��� varchar(100) NOT NULL,
�������� varchar(100) NOT NULL,
����� int NOT NULL
)

CREATE TABLE Officers
(
OfficerID int IDENTITY NOT NULL PRIMARY KEY,
������� varchar(100) NOT NULL,
��� varchar(100) NOT NULL,
�������� varchar(100) NOT NULL,
������ varchar(100) NULL
)

CREATE TABLE Weapons
(
������������ varchar(100) NOT NULL PRIMARY KEY,
--����� ������ ���� ���-�� ���, ������ � ���� ������ ��� ����������
)

CREATE TABLE NF2
(
ID int IDENTITY NOT NULL PRIMARY KEY,
������� int NOT NULL FOREIGN KEY REFERENCES Cadets(CadetID),
������ varchar(100) NOT NULL FOREIGN KEY REFERENCES Weapons(������������),
����� int NOT NULL FOREIGN KEY REFERENCES Officers(OfficerID)
)
GO

INSERT Cadets
SELECT ������� , ��� , ��������, ����� FROM NF1
GROUP BY ������� , ��� , ��������, �����
SELECT * FROM Cadets

INSERT Officers
SELECT [������� ��������� ������], [��� ��������� ������], [�������� ��������� ������],
[������ ��������� ������] FROM NF1
GROUP BY [������� ��������� ������], [��� ��������� ������], [�������� ��������� ������], [������ ��������� ������]
SELECT * FROM Officers

INSERT Weapons
SELECT ������ FROM NF1
GROUP BY ������
SELECT * FROM Weapons

SELECT * FROM Cadets
SELECT * FROM Officers

INSERT NF2
VALUES
(4, '��-47', 1), 
(4, '����20', 3),
(3, '��-74', 2), 
(3, '����20', 3),
(2,'��-47', 1), 
(2, '����20', 3),
(1, '��-47', 1)
SELECT *  FROM NF2
GO

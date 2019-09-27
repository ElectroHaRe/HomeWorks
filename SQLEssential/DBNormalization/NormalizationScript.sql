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
SELECT * FROM DenormilizedTable
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
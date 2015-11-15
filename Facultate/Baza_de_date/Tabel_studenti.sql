CREATE TABLE [dbo].[Tabel_studenti]
(
	[Nr_matricol] INT NOT NULL PRIMARY KEY, 
    [Nume] NVARCHAR(50) NOT NULL, 
    [Prenume] NVARCHAR(50) NOT NULL, 
    [Note] TEXT NULL, 
    [An] INT NOT NULL, 
    [Facultate] VARCHAR(50) NOT NULL, 
    [Cazare_camin] BIT NULL DEFAULT 0, 
    [Bursa] BIT NULL DEFAULT 0
)

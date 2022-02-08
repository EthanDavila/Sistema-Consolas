Create Database Consolas

use Consolas

Create Table Consolas(IdConsola int primary key identity(0, 1), Consola Nvarchar(40), PrecioxMin Money)
Drop Table Consolas
Select * from Consolas

Create Table Servicio(IdServicio int primary key identity(0, 1), IdConsola int, Tiempo int, Dinero Money)
Drop Table Servicio
Select * from Servicio

Insert into Consolas (Consola, PrecioxMin) values ('Xbox One 1', 0.33333333333333333333333333333333);
Insert into Consolas (Consola, PrecioxMin) values ('Xbox One 2', 0.33333333333333333333333333333333);
Insert into Consolas (Consola, PrecioxMin) values ('Xbox One 3', 0.33333333333333333333333333333333);
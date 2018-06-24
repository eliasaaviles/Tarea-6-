
create database CotizacionDB
use CotizacionDB
go
create table Articulos
(

	ArticuloId int primary key identity(1,1),
	Descripcion varchar(30),
	Precio int,
	Cantidad int,
	FechaVencimiento DateTime
	);

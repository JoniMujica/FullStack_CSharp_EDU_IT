/* crear base de datos */
create database PruebaDigitalers;
create database PruebaDigitalersNoCrea;

/*Elminiar base de datos */
drop database PruebaDigitalers;
drop database PruebaDigitalersNoCrea;
/*con USE le indicamos con que base de datos vamos a trabajar*/
use PruebaDigitalers;

/* crear tabla (en PruebaDigitalers)*/
create table Prueba(
	Texto INT
)

create table Productos(
idProducto int not null  primary key,
Nombre varchar not null,
Precio float,
Marca varchar not null,
Categoria varchar not null,
Stock int not null,
Disponible bit default 0
);
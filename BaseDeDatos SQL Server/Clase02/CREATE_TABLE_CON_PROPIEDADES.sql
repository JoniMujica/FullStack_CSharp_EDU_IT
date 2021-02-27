CREATE DATABASE Digitalers; -- Esto es un comentario
/* 
Esto es comentarios
de varias lineas
*/
use Digitalers;
/*creo una tabla en Digitalers*/
create table Personas(
	DNI int,
	Apellido varchar(255),
	Nombre varchar(255),
	Direccion varchar(255),
	FechaDeNacimiento datetime,
	Activa bit
);

drop table Personas;

/* Inserto datos en la tabla creada */
insert into Personas
	(DNI,Apellido)
	VALUES
	(1568121,'Mujica');

insert into Personas
	(Apellido)
	values
	('Pepe');
/* ver los datos de la tabla */
select * from Personas;
select DNI,Apellido from Personas;


/*creo una tabla en Digitalers con primary key*/
create table Personas(
	DNI int primary key, --al ser primary key, no admite valores NULL
	Apellido varchar(255),
	Nombre varchar(255),
	Direccion varchar(255),
	FechaDeNacimiento datetime,
	Activa bit
);

/*creo una tabla en Digitalers con primary key y incrementacion*/
create table Personas(
	Id int primary key identity(1,1), --identity dice que incrementa desde "1" de "1" en "1" --
	DNI int,
	Apellido varchar(255),
	Nombre varchar(255),
	Direccion varchar(255),
	FechaDeNacimiento datetime,
	Activa bit
);

/*creo una tabla en Digitalers con primary key, incrementacion y espacios no NULL*/
create table Personas(
	Id int primary key identity(1,1), --identity dice que incrementa desde "1" de "1" en "1" --
	DNI int not null, -- not null , no permite que en esa celda este null (vacio)
	Apellido varchar(255) not null,
	Nombre varchar(255),
	Direccion varchar(255) not null,
	FechaDeNacimiento datetime,
	Activa bit
);
/*inserto para esta tabla ↑ */
insert into Personas
	(Legajo,DNI,Apellido,Direccion)
	VALUES
	(2,15682121,'Mujica','Pasaje San Jose 2762');

	/*Insertar datos de varias filas ↑*/
insert into Personas
	(dni,apellido,direccion) -- <--- los nombres de las columnas, no son key sensitive --
	VALUES
	(1568581,'Mujica23','Pasaje 2 San Jose 2763'),
	(4889421,'Martinez12','Calle 21 falsa 123');
select * from Personas

----------------------------------------------------------------------------------------------
/*Clave primaria compuesta*/
create table Personas(
	Legajo int identity(1,1), --identity dice que incrementa desde "1", de "1" en "1" (puede funcionar sin PK)--
	DNI int,
	Apellido varchar(255),
	Nombre varchar(255),
	Direccion varchar(255),
	FechaDeNacimiento datetime,
	Activa bit,
	primary key(Legajo,DNI) /* Con esto le asigno a mas de un campo los PK*/
);

/* Legajo sin identity */
create table Personas(
	Legajo int,
	DNI int,
	Apellido varchar(255) not null,
	Nombre varchar(255) not null,
	Direccion varchar(255) not null,
	FechaDeNacimiento datetime,
	Activa bit,
	primary key(Legajo,DNI) /* Con esto le asigno a mas de un campo los PK*/
);

/* datos unicos (sin repetir) */
create table Personas(
	Legajo int unique, -- con UNIQUE le decimos que dicho campo puede tener un valor y no se puede repetir en otros registros
	DNI int,
	Apellido varchar(255) not null,
	Nombre varchar(255),
	Direccion varchar(255) not null,
	FechaDeNacimiento datetime,
	Activa bit,
	primary key(Legajo,DNI) /* Con esto le asigno a mas de un campo los PK*/
);

-------------------------------------Agregar fechas----------------------------------
insert into Personas
	(Legajo,DNI,Apellido,Direccion,FechaDeNacimiento)
	VALUES
	(7,15682121,'Mujica','Pasaje San Jose 2762','2009-12-19 10:22:05');

select * from Personas
/* Agregar fechas en modo estandar (para cualquier tipo de maquina o configuracion */
insert into Personas
	(Legajo,DNI,Apellido,Direccion,FechaDeNacimiento)
	VALUES
	(9,151,'naza','Pasaje San Jose 2762','2009-12-16T18:22:05'); --Le agrego la "T" en medio para que agarre formato
--ADMINISTRACION DEL MOTOR
select * from sys.syslanguages
select GETDATE(); --devuelve el formato del tiempo actual del sistema
/* leer todas las bases de datos*/
select name from sys.databases
/* Leer todas las tablas de la base de datos actual*/
select * from sys.tables
/* Leer todas las bases de datos en gral */
select * from master.sys.tables

SELECT * from sys.all_columns
--BBDD.SCHEMA.TABLE
--si no le pongo BBDD, usa el actual
--Si no le pongo el SCHEMA, usa el actual

/*PARA VER TODAS LAS DB*/
exec sp_databases
/* Para ver informacion de la tabla*/
SP_HELP 'Personas'
/* seleccionar columnas*/
select * from Personas

/***********operaciones en SELECT*****************/
SELECT Legajo *3 as multi3, --con el as le asigno un alias (me devuelve tabla sin nombre y con esto se lo asigno)
DNI,Apellido,
'TengoSueño' as frase 
from Personas
order by
Apellido asc, multi3 desc /*oirdena apellido de forma descendiente
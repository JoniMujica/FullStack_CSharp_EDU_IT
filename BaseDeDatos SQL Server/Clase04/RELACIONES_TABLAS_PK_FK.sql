select * from Clientes
use DigitalersCompras
/**************************ALTERAR UNA TABLA*********************/
--Agregar columna fechaDeNacimiento--
ALTER TABLE Clientes
add fechaDeNaciemiento date;

--Agregar columna Proviencia--
ALTER TABLE Clientes
add Provincia varchar(1);

/************************Alterar una columna ya creada******************************/
ALTER TABLE Clientes
ALTER COLUMN Provincia varchar(3);  --CAMBIA EL TIPO VARCHAR de varchar(1) a varchar(3) de la columna Provincia

ALTER TABLE Clientes
ALTER COLUMN Provincia varchar(30);  --CAMBIA EL TIPO VARCHAR de varchar(1) a varchar(3) de la columna Provincia

--NOTA: si ya tenia varchar(30) con un string de 30 caracteres y luego actualizo a varchar(3), solo me va a quedar las primeras 3 letras del dato que tenia en dicha fila/columna, utilizando SUBSTRING(COLUMN,POSINIT,POSEND)
update Clientes set Provincia = 'Buenos Aires' where ClienteID = 1; --le asigno valor de 13 caracteres 
update Clientes set Provincia = SUBSTRING(Provincia,1,3) --utilizo SUBSTRING para achicar el texto/dato que pide la DB al pasar de varchar 30 a 3

--cambiar adecuadamente el subtring--
select SUBSTRING(provincia,1,3) from Clientes  --primero veo como quedaria
UPDATE Clientes set Provincia = SUBSTRING(Provincia,1,3); -- con esto realizo los cambios de la tabla



update Clientes set fechaDeNaciemiento = '2000-12-13' where ClienteID = 1;

/****Modificar columnas para no nulls*******/
alter table Clientes
alter column Provincia varchar(30) not null; /*con esto me tira error*/

--si tengo nulls y quiero cambiar la columna a not null, primero cambio el tipo de dato a vacio '' y luego el not null
UPDATE Clientes set Provincia = '' where Provincia is null;

--Si tengo datos en todos los campos y quiero cambiar a null o not null, no pasara nada
alter table Clientes alter column Apellido varchar(50) NOT NULL 
alter table Clientes alter column Apellido varchar(50) NULL

/********************************BORRAR UNA COLUMNA*************************/
ALTER TABLE Clientes DROP COLUMN fechaDeNaciemiento

/*****************************SABER TODAS LAS TABLAS DE LA BASE DE DATOS******************/
select * from sys.tables
/***************************SABER TODAS LAS COLUMNAS CON DETERMINADO CRITERIO*******************/
select * from sys.all_columns where name = 'Nombre';


/*-------------------------------RELACIONES DE TABLAS (PK,FK)-----------------------------------*/
select * from Facturas
select * from Clientes
ALTER TABLE Facturas
ADD Foreign key (ClienteID) --agarra de la tabla Facturas la columna 'ClienteID'
REFERENCES Clientes(ClienteID) -- y aca hace la referencia de la tabla 'Clientes' la columna 'ClienteID'  //nota: se suele elegir como referencia la clave primaria de la columnda de la tabla referenciada



/*****************CONSULTA RELACIONADA**************/
Select * from Facturas;

Select * from Facturas,Clientes where Facturas.ClienteID = Clientes.ClienteID;  -- con esto me trae todos los datos de las 2 tablas con la relacion de clienteId

/*****************Unir tablas (Join)***************/
select f.Letra,f.Numero,f.Fecha,f.Monto,C.* from Facturas as F
join Clientes as C on f.ClienteID = C.ClienteID; -- UNE LAS 2 TABLAS

select f.Letra,f.Numero,f.Fecha,f.Monto,C.*,A.* from Facturas as F
LEFT join Clientes as C on f.ClienteID = C.ClienteID
LEFT join Articulos as A on A.ArticuloID = F.ArticuloID; --UNE LAS 2 TABLAS INCLUYENDO LOS QUE ON SE RELACIONAN DE LA TABLA IZQUIERDA


select f.Letra,f.Numero,f.Fecha,f.Monto,C.* from Facturas as F
right join Clientes as C on f.ClienteID = C.ClienteID; --UNE LAS 2 TABLAS INCLUYENDO LOS QUE ON SE RELACIONAN DE LA TABLA DERECHA

select f.Letra,f.Numero,f.Fecha,f.Monto,C.* from Facturas as F
cross join Clientes as C   --UNE LAS 2 TABLAS HACIENDO UN PRODUCTO CARTESIANO



/*************UNIR LA 2 CONSULTAS*************/
SELECT * FROM Clientes where ClienteID = 1
union
SELECT * FROM Clientes where ClienteID = 2;

SELECT * FROM Clientes where ClienteID = 1
union  --TRAE TODOS LOS REGISTROS DISPONIBLE (POR MAS QUE SE REPITAN)
SELECT * FROM Clientes where ClienteID IN (1,2);

SELECT * FROM Clientes where ClienteID = 1
union ALL --TRAE TODOS LOS REGISTROS DISPONIBLE (POR MAS QUE SE REPITAN)
SELECT * FROM Clientes where ClienteID IN (1,2);
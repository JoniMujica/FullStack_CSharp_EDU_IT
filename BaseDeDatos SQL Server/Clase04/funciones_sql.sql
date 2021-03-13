Use master;
drop database if exists DigitalersCompras;
create database DigitalersCompras;
Use DigitalersCompras;

create table Facturas
(
	Letra 		char,
	Numero 	int,
    ClienteID  int,
    ArticuloID int,
	Fecha 		date,
	Monto 		money,
	primary key (Letra, Numero)
);

create table Articulos
(
	ArticuloID	int,
	Nombre 	varchar(50),
	Precio 	money,
	Stock 		int,
	primary key (ArticuloID)
);

create table Clientes
(
	ClienteID      	int,
	Nombre    		varchar(50),
	Apellido   	varchar(50),
	Cuit       	char(16),
	Direccion  	varchar(50),
    Comentarios 	varchar(50),
    primary key (ClienteID)
);

create table agenda(
	Contacto int,
	Nombre varchar(20),
	Domicilio varchar(30),
	Telefono varchar(9),
	primary key (Contacto)
);

insert into articulos(ArticuloID, Nombre, Precio, Stock) values (1, 'Destornillador', 25, 50);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (2, 'Pinza'         , 35, 22);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (3, 'Martillo'      , 15, 28);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (4, 'Maza'          , 35, 18);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (5, 'Balde'         , 55, 13);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (6,  'Cinta'	 , 110, 50);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (7,  'Espatula'  , 20 , 22);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (8,  'Fratas'    , 35 , 28);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (9,  'Regrla'    , 20 , 78);
insert into articulos(ArticuloID, Nombre, Precio, Stock) values (10, 'Tenaza'    , 12 , 13);

insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('A', 1, 1, 1, '2011/10/18', 500);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('A', 2, 2, 2, '2011/10/18', 2500);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('A', 3, 3, 3, '2011/10/18', 320);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('A', 4, 4, 4, '2011/10/18', 120);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 1, 1, 1, '2011/11/18', 5000);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 2, 2, 2, '2011/11/18', 200);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 3, 3, 3, '2011/11/18', 3020);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 4, 4, 4, '2011/11/18', 1200);
insert into facturas(Letra, Numero, ClienteID, ArticuloID, Fecha, Monto) values ('B', 5, 5, 5, getdate()   , 3300);

insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (1 , 'Carlos'  , 'Diaz' , '21-15977008-8', 'Aguero 635'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (2 , 'Martín'  , 'Gomez' , '19-39552864-5', 'Nazca 1532'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (3 , 'Esteban', 'Suarez', '20-31447315-8', 'Chipre 5'     , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (4 , 'Susana', 'Villalba' , '21-22982335-2', 'Jufre 3651'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (5, 'Lucía'   , 'Perez', '19-10584471-9', 'Belgrano 6525', NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (6 , 'Mario'  , 'Pena' , '20-13817008-8', 'Aguero 635'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (7 , 'Jorge'  , 'Rios' , '20-37562854-5', 'Nazca 1532'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (8 , 'Valeria', 'Lagos', '20-25487418-8', 'Chipre 5'     , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (9 , 'Natalia', 'Peña' , '20-25982665-2', 'Jufre 3651'   , NULL);
insert into Clientes (ClienteID, Nombre, Apellido, Cuit, Direccion, Comentarios) values (10, 'Juan'   , 'Khorn', '20-23587171-9', 'Belgrano 6525', NULL);

insert into agenda (Contacto, Nombre, Domicilio, Telefono) values (1, 'Alberto Mores', 'Colon 123', '4234567');
insert into agenda (Contacto, Nombre, Domicilio, Telefono) values (2, 'Juan Torres', 'Avellaneda 135', '4458787');
insert into agenda (Contacto, Nombre, Domicilio, Telefono) values (3, 'Carla Paez', 'Lima 2335', '6658747');

select * from Clientes;

/*---------------------------------------------------ACTUALIZAR DATOS--------------------------------*/
UPDATE Clientes set Comentarios = 'un comentario'; /*la sintaxis es UPDATE <TABLA> SET <COLUMNA = VALOR> //ESTO ACTUALIZA TODAS LAS FILAS DE LA COLUMNA*/
 --UPDATE con condiciones de filas
 update Clientes SET Comentarios = 'Actualizado con where' where ClienteID = 10; /*aca lo mismo, a diferencia que le agregamos WHERE para cambiar un campo especifico*/

 /*Actualizare cliente por Id Y por apellido*/
 update Clientes set 
 Nombre = 'Juan Carlos',
 Apellido = 'KOHN',
 Comentarios = 'Actualizados datos invalidos'
 where ClienteID = 10;

 update Clientes set 
 Nombre = 'Karol G',
 Comentarios = 'Actualizados datos invalidos'
 where Apellido = 'KOHN';

 /*****************ACTUALIZACION DE ARTICULOS*********************/
 select * from Articulos;

 update Articulos set
 Nombre = 'Regla'
 where Nombre = 'Regrla';

 /****actualizar precio****/
 update Articulos set
 Precio = 22.50
 where Nombre = 'Regla';


 /*******Actualizar comentarios donde APELLIDO no sea KOHN*/
 update Clientes set
 Comentarios = null
 where Apellido <> 'KOHN';


 /*******************************borrar registro de la DB*****************************/
 delete from Clientes where ClienteID = 5;


 /**********************************Aumentar precio en porcentaje********************/
 select * from Articulos;

 update Articulos set
 Precio = Precio*1.1;

 delete from Articulos; /* si elimino una tabla que tenia autoincremental....*/
 truncate table articulos; /*con TRUNCATE puedo reiniciar la incrementacion a 1++    //esto le cuesta menos a la DB y mi app*/



















 /*****************EJERCICIOS ALUMNI************************/
 SELECT * FROM Articulos where Precio>100;

 --articulos con precio mayor a 20 y menor que 40
 --caso 1
 select * from Articulos where Precio > 20 and precio < 40;
  --caso 2
 select * from Articulos where Precio between 20 and 40;

 select * from Articulos where
 precio = 20 and Stock > 30;

 --ORDENAR PRECIOS DE MAYOR A MENOR y nombre ascendiente--
 select * from Articulos 
 order by Precio desc, Nombre asc

 --PRECIO CON IVA--
 select articuloId,
 precio,
 stock,
 precio*1.21 as precioConIva,
 convert(decimal(10,2),Precio*1.21) as precioConIvaConvert  /*redondear numeros decimales largos*/
 from Articulos


 /********************************************FUNCIONES DE AGRUPAMIENTO************************************/

 --CANTIDAD DE ELEMENTOS--
 select count(*) from Articulos  --Me dice la cantidada de elementos que tengo
  select count(*) as Cantidad from Articulos where Stock > 35

  --SUMA DE TODOS LOS ELEMENTOS DE UNA COLUMNA
  select sum(stock) from Articulos
  select sum(precio) from Articulos
  select sum(monto) from Facturas
  select stock from Articulos

  --obtener el elemento mas barato--
  select min(precio) from Articulos
  --obtener el elemento mas caro--
  select max(precio) from Articulos

  --sacar el promedio--
  select avg(precio) from Articulos
  select avg(monto) from Facturas
  select avg(monto),sum(monto) from Facturas;
  select avg(precio),sum(stock) from Articulos

  /*--------------	AGRUPAR SUMA POR CADA ARTICULO------------SIRVE PARA SABER CUANTAS VENTAS HICE DE x ARTICULO-*/
  select letra,sum(monto) from Facturas group by letra;
  SELECT ArticuloID,SUM(MONTO) FROM Facturas group by ArticuloID;

  --agrupar con condiciones--
  select sum(Precio) from Articulos having sum(stock) > 10 --quier buscar los precios, en donde la suma de stock de articulos sea mayor a 10
  select ArticuloID, sum(monto) from Facturas group by ArticuloID having sum(monto)  > 2000 --traigo la suma de cada articulo separado,y con HAVING condiciono a que me traiga la msuma de precios de articulos mayores a 2000

  select * from Facturas where monto > 2000

  update Clientes set Nombre = 'Jorge' where ClienteID = 3;
  select nombre,count(nombre) from Clientes group by Nombre /*me trae la lista de nombres, y la cantidada de nombres repetidos*/






/***************************EJERCICIO  ALUMNI LAB3*****************************/
--Obtener el monto maximo y minimo de facturas
select max(monto) from Facturas;
select min(monto) from Facturas;

--obtener el monto minimo de factura entre los años 2011 y 2020
select min(monto)from Facturas where Fecha between '2011-01-01' AND '2020-12-31';
--obtener la factura con el monto promedio del año 2011
select avg(monto) from facturas where fecha between '2011-01-01' and '2011-12-31'
select avg(monto) from Facturas where year(fecha) = 2011;

--obtener la cantidad de facturas que tienen un monto entre 500 y 3500
select count(Monto) from Facturas where Monto between 500 and 3500;
--obtener la suma del monto y el promedio de las facturas segun la letra--
select Letra,sum(monto) as Suma_Monto,avg(monto) as Promedio_Monto from Facturas group by Letra

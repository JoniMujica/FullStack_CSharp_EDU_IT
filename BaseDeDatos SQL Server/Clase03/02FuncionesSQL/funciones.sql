/*order by asc*/
select Legajo,DNI,Apellido from Personas order by DNI,Legajo,Apellido asc
select Legajo,DNI,Apellido from Personas order by DNI,Legajo,Apellido
/*order by desc*/
select Legajo,DNI,Apellido from Personas order by DNI,Legajo,Apellido desc

/*----------------------FUNCIONES A LAS CONSULTAS----------------------------*/
/*DATOS EN MAYUSCULAS*/
select DNI,Legajo, UPPER(Apellido) as Apellido from Personas order by DNI,Legajo /*El 'UPPER(args)' sirve para devolver datos en mayusculas*/

/*DATOS EN MINUSCULAS*/
select DNI,Legajo, LOWER(Nombre) as Nombre_Minuscula from Personas order by DNI,Legajo /*El 'LOWER(args)' sirve para devolver datos en minuscula*/

/*CONCATENAR COLUMNAS*/
select DNI,Legajo, UPPER(Apellido) + ' ' + LOWER(Nombre) as datos_personales from Personas order by DNI,Legajo 

/*obtener fecha actual*/
select 
DNI,
Legajo,
UPPER(Apellido) + ' ' + LOWER(Nombre) as datos_personales,
getdate() as Fecha_Actual
from Personas order by DNI,Legajo 

/*------------------------concatenar columnas de distintos tipos-----------------------------*/
/*CON CAST*/
select 
DNI,
Legajo,
UPPER(Apellido) + ' ' + LOWER(Nombre) + ' ' + CAST(Legajo as varchar) as datos_personales_cast, /*con CAST(COLUMN as TYPE) convierte el tipo de dato*/
getdate() as Fecha_Actual
from Personas order by DNI,Legajo 
/*CON CONVERT*/
select 
DNI,
Legajo,
UPPER(Apellido) + ' ' + LOWER(Nombre) + ' ' + CONVERT(varchar,Legajo) as datos_personales_convert, /*con CONVERT(TYPE,COLUMN) convierte el tipo de dato*/
getdate() as Fecha_Actual
from Personas order by DNI,Legajo 

/*----------------------Convertir formatos de fechas-------------------------*/

select 
DNI,
Legajo,
UPPER(Apellido) + ' ' + LOWER(Nombre) + ' ' + CONVERT(varchar,Legajo) as datos_personales_convert, /*con CONVERT(TYPE,COLUMN) convierte el tipo de dato*/
CONVERT(varchar,GETDATE(),111) as Fecha_Mod, /* convierto a un tipo de fecha especifico*/
getdate() as Fecha_Actual
from Personas order by DNI,Legajo 

/*-----------------------Obtener datos especifico de tiempo------------------------*/
select 
DNI,
Legajo,
UPPER(Apellido) + ' ' + LOWER(Nombre) + ' ' + CONVERT(varchar,Legajo) as datos_personales_convert, /*con CONVERT(TYPE,COLUMN) convierte el tipo de dato*/
getdate() as Fecha_Actual,
year(getdate()) as anio_actual, /*con year(getdate()) me trae el año actual*/
year(FechaDeNacimiento) as anio_nac,
month(FechaDeNacimiento) as mes_nac,
day(FechaDeNacimiento) as dia_nac,
year(getdate()) - year(FechaDeNacimiento) as Edad
from Personas order by DNI,Legajo 

/*----------------------------Consulta condicionales--------------------------------*/
select * from Personas 
Where Nombre = 'Jonathan'

/* OPERADORES:
 = IGUAL
 < MENOR
 > MAYOR
 >= MAYOR O IGUAL
 >= MENOR O IGUAL
 <> DISTINTO
*/

select * from Personas 
Where FechaDeNacimiento < '1999-01-01';

select * from Personas 
Where DNI > 10000;

/*Operadores logicos
 AND "y logico"
 OR  "o logico"
*/

select * from Personas
where DNI > 10000 AND Apellido = 'Mujica';

--NOT
SELECT * FROM Personas
where not DNI > 10000;

/*--------------------RANGO DE VALORES---------------------------*/
select * from Personas
where DNI between 0 and 100000;  -- indica que el DNI tiene que estar entre 0 y 100000

select * from Personas
where Legajo in (0,1,6);  --Lo que indica 'IN' es que busque de la columna Legajo, valores que esten entre 0,1,6

select * from Personas
where Legajo NOT in (0,1,6);  --Lo que indica 'NOT IN' es que busque de la columna Legajo, valores que NO esten entre 0,1,6

/*----------------Buscar datos especificos----------------------*/
select * from Personas
WHERE Apellido = 'Mujica'

/*Buscar datos que empiecen con caracteres especificos sin importar lo que le siga*/
select * from Personas
where Apellido like 'Mujica%';

/*Buscar datos que empiecen o terminen con caracteres especificos sin importar lo que le siga*/
select * from Personas
where Apellido like '%Mujica%';

/*Buscar datos que termine con caracteres especificos sin importar lo que le siga*/
select * from Personas
where Apellido like '%Mujica';

/*----------------------TRAER DATOS NULOS-----------------------*/
select * from Personas where FechaDeNacimiento is null;
select * from Personas where FechaDeNacimiento is not null;



/*Buscar datos que empiecen con caracteres especificos restringiendo lo que le sigue*/
select * from Personas
where Apellido like 'Mujica_';

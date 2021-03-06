﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient; //necesito agregar esta dependencia para usar conexiones SQL
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01IntegracionConCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /* ===========conexion a sql server
             *  SI TENGO USUARIO Y CONTRASEÑA:
             *  Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=myPassword;
             * 
             * SI INICIO DESDE MI PROPIA PC/WINDOWS
             *  Server=myServerAddress;Database=myDataBase;Trusted_Connection=True;
             */

            /*Si usa SQL EXPRESS:
             * Server=localhost\\SQLEXPRESS
             * 
             * Si no usa SQL EXPRESS:
             * Server=localhost;
             */

            //CREO LA CADENA DE CONEXION A LA BASE DE DATOS Digitalers
            string cadena = "Server=localhost;Database=Digitalers;Trusted_Connection=True;";
            //CREO LA CONEXION SQL A MI PROYECTO
            SqlConnection conexion = new SqlConnection(cadena);
            //ABRO LA CONEXION AL PROYECTO
            conexion.Open();
            Console.WriteLine("Estado de la conexion: {0}", conexion.State);

            //CREO UNA CADENA DE CONSULTA SQL (INSERCION DE DATOS)
            string NuevaPersona = "insert into Personas(Legajo, DNI, Apellido, Nombre, Direccion, FechaDeNacimiento, Activa) values (3, 41969938, 'Mujica Mujica', 'Jose Alejandro', 'Pasaje San Jose 2762', '1973-11-26T13:00:00', 1);";
            //Creo una variable que ejecuta comando SQL la cual recibe como parametros (StringDeLaConsulta , StringDeLaConexion)
            SqlCommand comandoInsercion = new SqlCommand(NuevaPersona, conexion); //indico que ejecute la consulta 'NuevaPersona' en la conexion 'conexion'
            //Ejecuta la consulta a SQLServer
            comandoInsercion.ExecuteNonQuery();
            Console.WriteLine("Termino de ejecutar la consulta!");
            conexion.Close();
            Console.ReadKey();
        }
    }
}

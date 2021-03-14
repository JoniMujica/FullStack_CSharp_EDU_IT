using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase02
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            // creo un objeto Alumno (Instancia de la clase alumno)
            Alumno alumno = new Alumno();
            alumno.nombre = "Andres"; //me marca error por que la visibilidad de Alumno esta protegida
            alumno.apellido = "Villa";
            alumno.documento = "123123";
            alumno.pagosAlDia = true;
            alumno.imprimirEstadoAlumno();

            Alumno miOtroAlumno = new Alumno();
            miOtroAlumno.nombre = "Juan";
            miOtroAlumno.apellido = "Perez";
            miOtroAlumno.documento = "987654";
            miOtroAlumno.imprimirEstadoAlumno();*/

            // Alumno con Array
            Alumno[] misAlumnos = new Alumno[3];
            /*
             [ ] [ ] [ ]
              0   1   2 
            */
            for (int i = 0; i < misAlumnos.Length; i++)
            {
                Console.Write("Por favor, ingrese el nombre del aulmno: ");
                string nombre = Console.ReadLine();
                Console.Write("Por favor, Ingrese el Apellido del alumno: ");
                string apellido = Console.ReadLine();
                Console.Write("Por favor, Ingrese el documento del alumno: ");
                string documento = Console.ReadLine();

                Alumno alumno = new Alumno();
                alumno.nombre = nombre;
                alumno.apellido = apellido;
                alumno.documento.numeroDeDocumento = documento;
                misAlumnos[i] = alumno;
            }
            for (int i = 0; i < misAlumnos.Length; i++)
            {
                misAlumnos[i].imprimirEstadoAlumno();
                misAlumnos[i].Saludar();
                misAlumnos[i].Saludar("Chau");
            }
            Console.WriteLine(misAlumnos[1].nombre);
            Console.ReadKey();
        }
    }
}

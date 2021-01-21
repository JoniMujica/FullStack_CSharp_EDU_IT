using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            const string saludo = "hola {0}{1}";
            int miNumero = 10;
            string nombre;
            Console.Write("Escriba su nombre: ");
            nombre = Console.ReadLine();
            Console.Write("Escriba su apellido: ");
            string apellido = Console.ReadLine();
            Console.WriteLine(saludo, nombre,apellido);
            //Console.WriteLine("Hola {0}", nombre);
            // tambien se puede  Console.WriteLine("Hola " + nombre);
            Console.ReadKey();
        }
    }
}

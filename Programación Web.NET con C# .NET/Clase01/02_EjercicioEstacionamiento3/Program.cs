using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EjercicioEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto();
            auto.Patente = "CCC123"; //al tener a Auto heredado de Vehiculo, puedo utilizar las propiedades de la clase Vehiculo | con esto evito duplicar codigo
            Console.WriteLine(auto.Patente);
            Console.ReadKey();

           

        }
    }
}

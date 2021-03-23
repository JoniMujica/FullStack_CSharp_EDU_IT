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
            //Vehiculo vehiculo = new Vehiculo("aa");
            //CON LA CLASE ENCAPSULADA
            Vehiculo miVehiculo = new Vehiculo();
            miVehiculo.establecerPatente("AAA123");
            Console.WriteLine(miVehiculo.obtenerPatente());
            Console.ReadKey();
        }
    }
}

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
            /*
            miVehiculo.setPatente("AAA123");
            Console.WriteLine(miVehiculo.getPatente());*/

            //Con los getter y setters uso esta sintaxis, seria como utilizar una propiedad public
            miVehiculo.Patente = "AAA123";
            Console.WriteLine(miVehiculo.Patente); //con esto sin los () usando getters y setters puedo obtener el valor de la propiedad sin llamarlo como funcion/operacion
            Console.ReadKey();
        }
    }
}

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
            
            //Vehiculo miVehiculo = new Vehiculo();
            /*
            miVehiculo.setPatente("AAA123");
            Console.WriteLine(miVehiculo.getPatente());*/

            //Con los getter y setters uso esta sintaxis, seria como utilizar una propiedad public
            /*
            miVehiculo.Patente = "AAA123";
            Console.WriteLine(miVehiculo.MetodoEjemeplo());
            Console.WriteLine(miVehiculo.Patente); //con esto sin los () usando getters y setters puedo obtener el valor de la propiedad sin llamarlo como funcion/operacion
            */
            Auto auto = new Auto();
            auto.Patente = "CCC123"; //al tener a Auto heredado de Vehiculo, puedo utilizar las propiedades de la clase Vehiculo | con esto evito duplicar codigo
            Console.WriteLine(auto.MetodoEjemeplo()); //TAMBIEN puede acceder alas operaciones que hereda del padre
            Console.WriteLine(auto.Patente);
            Console.ReadKey();

            Vehiculo miVehiculo = new Auto(); //el hijo puede actuar como el padre

        }
    }
}

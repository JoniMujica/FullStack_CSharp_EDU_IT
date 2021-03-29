using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EjercicioEstacionamiento
{
    class Auto: Vehiculo //con los ":" le digo que la clase Auto hereda de Vehiculo, esto me permite utilizar las propiedades de la clase Vehiculo
    {
        public Auto(string patente, decimal precioDeUso): base(patente) //base se refiere al contructor padre --seria como llamar o referir al contructor Vehiculo [ Vehiculo(string patente)]
        {
            PrecioDeUso = precioDeUso;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// ENCAPSULAMIENTO
/// </summary>
///
namespace _03_EjercicioEstacionamiento
{
    abstract class Vehiculo //con abstract no puedo crear una instancia de esta clase
    {
        public string Patente { get; set;}

        public virtual decimal PrecioDeUso { get; set; } // virtual:  lo que hace virtual es indicar que puede ser sobreEscribir (permite)

        public Vehiculo(string patente)
        {
            Patente = patente;
        }

        public override string ToString()
        {
            return "Pantente" + Patente + " Precio de uso " + PrecioDeUso;
        }

    }
}

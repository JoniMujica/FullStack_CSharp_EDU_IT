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
    class Vehiculo
    {
        // private char[] patente;
        private string patente;
        public Vehiculo(string patente) //al string lo puedo tomar como un array de caracteres
        {
            establecerPatente(patente);
        }

        public void establecerPatente(string patente)
        {
            this.patente = patente;
        }
        public string obtenerPatente()
        {
            return patente;
        }

        public Vehiculo() //al string lo puedo tomar como un array de caracteres
        {

        }
    }
}

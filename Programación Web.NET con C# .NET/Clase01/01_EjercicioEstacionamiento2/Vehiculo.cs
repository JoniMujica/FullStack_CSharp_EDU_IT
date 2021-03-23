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
        private char[] patente;
        public Vehiculo(string patente) //al string lo puedo tomar como un array de caracteres
        {
            establecerPatente(patente);
        }

        public void establecerPatente(string patente)
        {
            this.patente = new char[patente.Length];
            for (int i = 0; i < patente.Length; i++)
            {
                this.patente[i] = patente[i];  //copio caracter por caracter del string patente a char[] patente 
            }
        }
        public string obtenerPatente()
        {
            string res = "";
            for (int i = 0; i < this.patente.Length; i++)
            {
                res += this.patente[i];
            }
            return res;
        }

        public Vehiculo() //al string lo puedo tomar como un array de caracteres
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EjercicioEstacionamiento
{
    class Camioneta: Vehiculo
    {
        public override decimal PrecioDeUso { get; set; } = 200; //para sobrescribir debo marcar en el padre que es sobreescribible
        public Camioneta(string patente) :base(patente)
        {

        }
    }
}

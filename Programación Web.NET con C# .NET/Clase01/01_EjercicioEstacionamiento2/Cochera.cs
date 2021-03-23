using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EjercicioEstacionamiento
{
    class Cochera
    {
        private int numero;
        private Vehiculo vehiculo;

        public bool estaDisponible()
        {
            /*
            bool res = false;
            if (vehiculo != null)
            {
                res = true;
            }
            return res;*/

            return (vehiculo == null) ? true : false;
        }

        public Vehiculo Egresar(string patente)
        {
            Vehiculo res = null;

            if(estaDisponible() == true)
            {
                if (vehiculo.getPatente() == patente)
                {
                    res = vehiculo;
                    vehiculo = null;
                }
            }

            return res;
        }

        public bool Ingresar(Vehiculo vehiculo)
        {
            bool res = false;

            if (estaDisponible() == true)
            {
                this.vehiculo = vehiculo;
                res = true;
            }

            return res;
        }
    }
}

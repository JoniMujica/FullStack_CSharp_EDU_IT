using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EjercicioEstacionamiento
{
    class Estacionamiento
    {
        private decimal totalFacturado = 0;
        private Cochera[] cocheras;

        public Estacionamiento(decimal elPrecio, int cantidadDeCocheras)
        {
            precioDeUso = elPrecio;
            cocheras = new Cochera[cantidadDeCocheras];
            for (int i = 0; i < cantidadDeCocheras; i++)
            {
                Cochera nuevaCochera = new Cochera();
                cocheras[i] = nuevaCochera;
            }
        }
        public Estacionamiento(decimal elPrecio, int cantidadDeCocheras, decimal cajaInicial)
            :this(elPrecio,cantidadDeCocheras) //con ":this" indico que primero ejecute el contructor inicial/anterior y luego el bloque de codigo dentro, (esto sirve para evitar duplicar codigo
        {
            /*precioDeUso = elPrecio;
            cocheras = new Cochera[cantidadDeCocheras];
            for (int i = 0; i < cantidadDeCocheras; i++)
            {
                Cochera nuevaCochera = new Cochera();
                cocheras[i] = nuevaCochera;
            }*/
            totalFacturado = cajaInicial;
        }

        public bool estaLLeno()
        {
            bool res = true;
            for (int i = 0; i < cocheras.Length; i++)
            {
                if (cocheras[i].estaDisponible() == true)
                {
                    //res = false;
                    
                    //return moderno
                    return res = false;
                    break;
                }
            }

            /*                             CON WHILE
            int control = 0;
            while (control < cocheras.Length)
            {
                if (cocheras[control].estaDisponible() == true)
                {
                    res = false;
                    break;
                }
                control++;
            }*/
            return res;
        }
        public Cochera BuscarCocheraDisponible()
        {
            Cochera res = null;
            for (int i = 0; i < cocheras.Length; i++)
            {
                if (cocheras[i].estaDisponible() == true)
                {
                    res = cocheras[i];
                    break;
                }
            }
            return res;
        }
    }
}

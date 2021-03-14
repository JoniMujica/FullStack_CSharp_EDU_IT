using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01_POO_PRACTICA_INTRODUCCION.Clases
{
    //esto seria como un 'molde' de caja de ahorro, cuando se use (se llene datos en ejecucion) pasa a ser objeto
    class CajaDeAhorro
    {
        //Atributos
        decimal saldo;

        //Metodos
        void informarSaldo()
        {
            Console.WriteLine(saldo);
        }

        decimal obtenerSaldo()
        {
            return saldo;
        }
        void depositarDinero(decimal monto)
        {
            saldo += monto;
        }
        void extraerDinero(decimal monto)
        {
            saldo -= monto;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Procedimientos_Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1 = CapturarDatos();
            int numero2 = CapturarDatos();
            int res = Sumar(numero1, numero2);
            InformarRes(res);
            Console.ReadKey();
        }
        static int CapturarDatos()
        {
            Console.Write("Por favor, ingrese un numero pasa sumar: ");
            string datoIngresdo = Console.ReadLine();
            int datoConvertido = Convert.ToInt32(datoIngresdo);
            return datoConvertido;
        }
        static int Sumar(int numero1, int numero2)
        {
            int resultado = numero1 + numero2;
            return resultado;
        }
        static void InformarRes(int res)
        {
            Console.Write("El resultado de la suma es: {0}", res);
        }
    }
}

using System;

namespace _03VectoresNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de numero que quiera procesar: ");
            int cantidadNumeros = Convert.ToInt32(Console.ReadLine());
            /*
             * Equivalente a
             * string cantidadNumerosString = Console.ReadLine();
             * int cantidadDeNumeros = Convert.ToInt32(cantidadNumerosString);
             */
            // int[] numeros; //una puesto la cantidad de array [N], N no puede ser cambiado nuevamente
            int[] numeros = new int[cantidadNumeros];
            for (int i = 0; i < cantidadNumeros; i++)
            {
                Console.Write("Ingrese el numero que desea rellenar: ");
                int nuevoNumero = Convert.ToInt32(Console.ReadLine());
                numeros[i] = nuevoNumero;
            }
            //Agrego Elemento
            /*
            int[] nuevoArray = new int[numeros.Length + 1];
            for (int i = 0; i < numeros.Length; i++)
            {
                nuevoArray[i] = numeros[i];
            }
            nuevoArray[numeros.Length] = 999;
            numeros = nuevoArray;
            */
            //Console.WriteLine(numeros);  me imprime el tipo de dato 'System.Int32[]'
            int max = numeros[0];
            Console.WriteLine("Datos Ingresados: ");
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i]>max)
                {
                    max = numeros[i];
                }
                Console.Write(numeros[i] + " ");
            }
            Console.WriteLine("Valor Maximo: {0}", max);
            Console.ReadKey();
        }
    }
}

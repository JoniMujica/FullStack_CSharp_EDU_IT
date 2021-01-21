using System;

namespace _02ListadoPersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            string listado = "";
            bool sigue; // por defecto tiene valor falso

            do
            {
                Console.Write("Ingrese un nombre: ");
                listado += Console.ReadLine() + Environment.NewLine; //Environment.NewLine crea un salto de linea

                Console.Write("¿Desea continuar? (S/N)");
                string continua = Console.ReadLine();
                sigue = continua.ToUpper() == "S" ? true : false;
            } while (sigue == true);

            Console.WriteLine(listado);
            Console.ReadKey();
        }
    }
}

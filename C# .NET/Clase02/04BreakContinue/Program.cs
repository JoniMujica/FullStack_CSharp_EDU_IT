using System;

namespace _04BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Break
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine("Iteracion {0}", i);
                if (i == 10)
                {
                    break;
                }
            }
            Console.Write("Termino el primer for de ejemplo para el break");

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine("Iteracion {0}", i);
            }
            Console.Write("Termino el segundo for de ejemplo para el continue");
            Console.ReadKey();
        }
    }
}

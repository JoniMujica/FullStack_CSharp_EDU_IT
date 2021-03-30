using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_EjercicioEstacionamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            Auto auto = new Auto("AAA", 100);

            Camioneta camioneta = new Camioneta("AAA1321");
            Console.WriteLine(auto);
            Console.WriteLine(camioneta);
            Console.ReadKey();
        }
    }
}

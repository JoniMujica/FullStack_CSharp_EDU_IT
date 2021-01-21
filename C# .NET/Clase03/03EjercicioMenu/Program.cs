using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03EjercicioMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] MenuPrincipal = new string[] { "Laptop","Teclado","Cables","Memorias","Salir"}; //equivalente a new string [5];
            string[] MenuLaptop = new string[] { "Acer", "HP", "Dell" };
            string[] MenuTeclado = new string[] { "Gamer", "Inalambrico" };
            string[] MenuCable = new string[] { "Impresora", "Micro USB", "USB C" };
            string[] MenuMemorias = new string[] { "512MB", "1GB", "4GB" };
            //Extra para mejorar
            string[][] menus;
            int opcionSeleccionada = DibujarMenu(MenuPrincipal);
            switch (opcionSeleccionada)
            {
                case 0:
                    DibujarMenu(MenuLaptop);
                    break;
                case 1:
                    DibujarMenu(MenuTeclado);
                    break;
                case 2:
                    DibujarMenu(MenuCable);
                    break;
                case 3:
                    DibujarMenu(MenuMemorias);
                    break;
                case 4:
                    Console.WriteLine("Gracias por utilizar el programa!");
                    break;
                case -1:
                    Console.WriteLine("El valor ingresado no es un numero!");
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta,eliga una opcion del menu");
                    break;
            }
            Console.ReadKey();
        }
        static int DibujarMenu(string[] opciones)
        {
            Console.Clear();
            Console.WriteLine("*****************************");
            Console.WriteLine("MENU: ");
            Console.WriteLine("*****************************"); 
            for (int i = 0; i < opciones.Length; i++)
            {
                Console.WriteLine((i+1) + "-" + opciones[i]);
            }
            string opcionSeleccionada = Console.ReadLine();
            //int op = Convert.ToInt32(opcionSeleccionada);
            //Alternativa que sirve para validar

            int op = 0;
            bool pudoConvertir = Int32.TryParse(opcionSeleccionada, out op); //Int32.TryParse(ParametroAconvertir, out VarParametroConvertido)   -- esto devuelve un bool
            if (pudoConvertir == false)
            {
                op = 0;
            }
            return (op -1);
        }
    }
}

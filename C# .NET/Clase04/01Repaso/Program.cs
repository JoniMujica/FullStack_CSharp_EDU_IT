﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Repaso
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ejemplo de switch sin break
            int edad = 10;
            switch (edad)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Usa talle de ropa bebe");
                    break;
                default:
                    Console.WriteLine("Talle incorrecto");
                    break;
                    //default = opcional
                    //break = obligatorio
            }
        }
    }
}

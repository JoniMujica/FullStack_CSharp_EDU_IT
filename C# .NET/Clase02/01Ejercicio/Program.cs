using System;

namespace _01Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            const decimal ivaRedus = 10.5M;
            const decimal ivaC = 21;
            Console.Write("Profavor, escriba el nombre del producto: ");
            string nombreProducto = Console.ReadLine();
            Console.Write("Porfavor, ingrese el costo del producto: ");
            string costoProducto = Console.ReadLine();

            /*
             * float: tipo de dato de precision simple
             * double: tipo de precision doble
             * decimal tipo de datos para datos monetarios
             */
            decimal costo = Convert.ToDecimal(costoProducto);
            Console.WriteLine("Porfavor, ingrese el IVA del producto: ");
            Console.WriteLine("1) {0}%", ivaRedus);
            Console.WriteLine("2) {0}%", ivaC);
            string tipoIVA = Console.ReadLine();
            /*
            decimal iva;
            if(tipoIVA == "1")
            {
                iva = ivaRedus;
            }
            else
            {
                iva = ivaC;
            }*/

            /*decimal iva = 0;
            switch ()
            {
                case "1":
                    iva = ivaRedus;
                    break;
                default:
                    iva = ivaC;
                    break;
            }*/

            //OPERADOR TERNARIO
            //VARIABLE = CONDICION ? VALOR_VERDADERA : VALOR_FALSA;
            decimal iva = (tipoIVA == "1") ? ivaRedus : ivaC;
            decimal costoCIVA = costo + (costo * iva / 100);

            Console.WriteLine("El producto {0} tiene un precio de {1} y un precio con iva de {2}", nombreProducto, costo, costoCIVA);
            Console.ReadKey();
        }
    }
}

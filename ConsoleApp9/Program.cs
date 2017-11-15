using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {

            double a, b, c, operador, x1, x2;
            Console.Write("Ingrese el valor de a: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de b: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Ingrese el valor de c: ");
            c = double.Parse(Console.ReadLine());
            operador = b * b - 4.0 * a * c;
            if (operador < 0)
            {
                Console.WriteLine("soluciones imaginarias");
                operador = -operador;
            }
            else
                Console.WriteLine("Soluciones:");
            x1 = (-b + Math.Sqrt(operador)) / 2.0 / a;
            x2 = (-b - Math.Sqrt(operador)) / 2.0 / a;
            Console.WriteLine("Valor de x1: " + x1);
            Console.WriteLine("Valor de x2: " + x2);
            Console.WriteLine();
            Console.Write("Presione una tecla para terminar . . . ");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01_CalculoDeCuadrado
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            b = 0;
            Console.WriteLine("Ingrese un numero para calcular su cuadrado que sea mayor a cero:");
            a = Convert.ToInt32(Console.ReadLine());

            while (a <= 0)
            {
                Console.WriteLine("Error, numero ingresado incorrecto, por favor reingrese:");
                a = Convert.ToInt32(Console.ReadLine());

            }
            if (a > 0)
            {
                b = (a * a);
            }
            Console.WriteLine("El cuadrado del numero es: " + b);

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
             // Número de términos en la serie
            int a = 0, b = 1,suma;

            Console.WriteLine("Serie de Fibonacci:");
            for (int i = 0; i < 10; i++)
            {
                suma = a + b;
                Console.WriteLine(suma);
                a = b;
                b = suma;
            }

        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Positvo_o_negativo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite un numero: ");
           float x = Convert.ToSingle(Console.ReadLine());

            if (x == 0)
            {
              
                Console.WriteLine("\nSu numero es neutro\n");
            }
            else
            {
                if (x < 0)
                {
                    Console.WriteLine("\nSu numero es negativo\n");
                }
                else
                {
                    if (x > 0)
                    {
                        Console.WriteLine("\nSu numero es positivo\n");
                    }
                }
            }

        }
    }
}

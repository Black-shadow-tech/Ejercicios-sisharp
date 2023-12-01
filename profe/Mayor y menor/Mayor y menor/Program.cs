using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mayor_y_menor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite un numero: ");
            float x = Convert.ToSingle(Console.ReadLine());

            Console.Write("Digite un numero: ");
            float y = Convert.ToSingle(Console.ReadLine());

            if (x > y)
            {
                Console.WriteLine("El numero {0} es mayor ",x);
            }
            else
            {
                Console.WriteLine("El numero {0} es mayor ", y);
            }


        }
    }
}

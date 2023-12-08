using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma_de_numeros_del_1_al_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;

            Console.Write("Digite el parametro de numeros a sumar: ");//esto es por si al cliente se le ocurre q en vez de 100 sea un 200 0 un 50...
            int para = Convert.ToInt32(Console.ReadLine());

            for (int i=1; i<=para; i++)
            {
                suma += i;
            }
            Console.WriteLine("\n");
            Console.WriteLine("Este es la suma de su conjunto de elementos: {0}",suma);
            Console.WriteLine("\n");
        }
    }
}

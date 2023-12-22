using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_primo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.Write("Digite un numero para saber si es primo o no: ");
            numero = Convert.ToDouble(Console.ReadLine());

            if(numero %2 == 0)
            {
                Console.WriteLine("El numero {0} es primo. ", numero);
            }
            else
            {
                Console.WriteLine("El numero {0} no es primo. ", numero);
            }

        }
    }
}

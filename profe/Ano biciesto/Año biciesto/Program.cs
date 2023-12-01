using System;

namespace Ano_bisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite un año: ");
            int x = Convert.ToInt32(Console.ReadLine());

            if ((x % 4 == 0 && x % 100 != 0)/*Si el residuo de la divicion entre 4 no es igual a 100 entonces no es un ano biciesto*/ || (x % 400 == 0))//si se cumlplen cualquiera de la dos condiciones tonces el año es biciesto
            {
                Console.WriteLine("El {0} es un año bisiesto\n", x);
            }
            else
            {
                Console.WriteLine("El {0} no es un año bisiesto\n", x);
            }
        }
    }
}

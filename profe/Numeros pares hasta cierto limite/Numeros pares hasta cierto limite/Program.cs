using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numeros_pares_hasta_cierto_limite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Limite de numeros a resivir: ");
            int limite = Convert.ToInt32(Console.ReadLine());//por si al cliente se le ocurre definir el limite XD

            Console.Write("Digite un numero par: ");
            int i = Convert.ToInt32(Console.ReadLine());

            if (i %2 ==0) // si no es par no entra al bucle
            {
                Console.WriteLine("\n");
                while (i <= limite)// el iterador llegue hacer igual q el limite salda del bucle..
                {
                    Console.WriteLine(i);
                    i += 2;
                }
                Console.WriteLine("\n");//deberia hacer un salto de linia interno XD
            }
            else
            {
                Console.WriteLine("El numero {0} no es un numero par XD",i);
                Console.WriteLine("\n");
            }
        }
    }
}

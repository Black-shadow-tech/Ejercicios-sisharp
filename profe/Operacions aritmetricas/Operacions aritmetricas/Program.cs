using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operacions_aritmetricas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Operacion aritmetricas con 'int' ");
            //Operador suma(+)
            int n=5, n1=4;
            n += n1; //esto es igual q desir 5 + 4.
            Console.WriteLine("\n\nSuma de numero enteros: (5 + 4) = {0}",n);

            //Operador resta(-).
            int n2 = 13, n3 = 4;
            n2 -= n3;
            Console.WriteLine("Resta de numero enteros: (13 - 4) = {0}", n2);

            //Operador multiplicacion(*).
            int n4 = 3, n5 = 3;
            n4 *= n5;
            Console.WriteLine("Multiplicacion de numero enteros: (3 * 3) = {0}", n4);

            //Operador Divicion(/).
            int n6 = 54, n7 = 6;
            n6 /= n7;
            Console.WriteLine("Divicion de numero enteros: (54 / 6) = {0}", n6);
            Console.Write("\n");


            Console.Write("\nOperacion aritmetricas con 'float' ");
            //Operador suma(+)
            float n8 = 5.16f, n9 = 4.34f; //le ponemos f para la presicion.
            n8 += n9;
            Console.WriteLine("\n\nSuma de numero enteros: (5.16 + 4.34) = {0}", n8);

            //Operador resta(-).
            float n10 = 4.54f, n11 = 4.46f;
            n10 -= n11;
            Console.WriteLine("Resta de numero enteros: (4.54 - 4.46) = {0}", n10);

            //Operador multiplicacion(*).
            float n12 = 65.34f, n13 = 25.56f;
            n12 *= n13;
            Console.WriteLine("Multiplicacion de numero enteros: (65.34 * 25.56) = {0}", n12);

            //Operador Divicion(/).
            float n14 = 54.56f, n15 = 65.45f;
            n14 /= n15;
            Console.WriteLine("Divicion de numero enteros: (54.56 / 65.45) = {0}", n14);
            Console.Write("\n");


        }
    }
}

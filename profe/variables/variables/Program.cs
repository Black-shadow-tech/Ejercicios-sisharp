using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaraciones de variables

            //declaramos la variable int y hacemos una suma sencilla...
            int x = 5;//Asignacion.
            Console.WriteLine(x);// resultado.

            //Declaramos la variable float.
            float y = 5.4f; //si le quitamos la f nos va a dar un error...
            Console.WriteLine(y); 
            
            //Declaramos la variable  double.
            double z = 4.123;//Asignacion.
            Console.WriteLine(z);

            //Declaramo la variable string.
            string l = "Moises XD";
            Console.WriteLine(l);

            //Declaramos la  variable char.
            char  t = 'M';
            Console.WriteLine(t);

            //Declaramos la variable decimal (Ojo creo q nunca la usare).
            decimal d = 12.3456m;//la me es para presicion.
            Console.WriteLine(d);

            //Declaramos la varible bool.
            bool verda = true;
            Console.WriteLine(verda);


        }
    }
}

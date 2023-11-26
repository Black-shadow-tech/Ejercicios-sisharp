using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\tGoogle Chrome");
            Console.WriteLine("\n");

            Console.Write("Nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Apellido: ");
            string apellido =  Console.ReadLine();

            int edad;
            Console.Write("Edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            if (edad >= 18)
            {
                Console.WriteLine("{0}{1}123@gmail.com",nombre,apellido);
                int contra;
                Console.WriteLine("\n");
                Console.Write("Quieres ponerle tu propio 931@gmail.com? ");
              
                Console.Write("Digite (si) o (no): ");
                string a = Convert.ToString(Console.ReadLine());

                if (a == "si")
                {
                    Console.WriteLine("Digite como quiere que le quede su correo eletronico: ");
                    string b = Console.ReadLine().ToString();
                }

                Console.WriteLine("\n");
                Console.Write("Digite una contraseña de mas de 6 digitos: ");
                contra = Convert.ToInt32(Console.ReadLine());

                if (contra > 100000)
                {
                    Console.WriteLine("Su cuenta a sido creada.");
                    Console.WriteLine("\n");
                }
                else
                {
                    Console.WriteLine("Contraseña invalida, vuelva mas tarde XD");
                }
                Console.WriteLine("\n");

            }
            else
            {
                Console.WriteLine("Eres meno de edad:");
                int resta = (edad - 18);
                Console.WriteLine("Te faltan {0} años",resta);
                Console.WriteLine("\n");
            }


            
            

        }
    }
}

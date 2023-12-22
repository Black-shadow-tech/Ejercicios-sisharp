using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        int[] numeros = { 1, 3, 4, 5, 2 };

        Console.Write("Ingrese el número a buscar: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        // Búsqueda lineal
        int indiceEncontrado = -1;
        for (int i = 1; i <= numeros.Length; i++)//length nos mustra todos los elementos de nuestra arraiz
        {
            if (numeros[i] == numero)
            {
                indiceEncontrado = i;
                break;
            }
        }

        if (indiceEncontrado != -1)
        {
            Console.WriteLine($"El elemento {numero} se encuentra en el índice {indiceEncontrado}");
        }
        else
        {
            Console.WriteLine($"El elemento {numero} no se encuentra en el arreglo");
        }
    }
}

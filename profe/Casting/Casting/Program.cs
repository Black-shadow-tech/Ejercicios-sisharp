using System;

class Program
{
    static void Main()
    {
        // Casting 
        int entero = 10;
        double decimalNumero = entero; // Casting implicito de int a double

        Console.WriteLine(decimalNumero);
        // Casting 
        double decimalNumero2 = 15.75;
        int entero2 = (int)decimalNumero2; // Casting explicito de double a int
        Console.WriteLine(entero2);

        
    }
}

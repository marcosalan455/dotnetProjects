using System;

namespace Interface
{
    class Program
    {
        static void Main(string [] args)
        {
            Calculo c = new Calculo();
            c.somar(5, 5);
            Console.WriteLine();

            c.subtrair(10, 5);
        }
    }
}
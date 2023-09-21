using System;

namespace minhasListas
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] pilotos = new string[5] { 
                "Ayrton Senna", "Michael Schumacher",
                "Lewis Hamilton", "Alain Prost", "Rubinho Barrikello" };
            Console.WriteLine(pilotos[4]);
            Console.WriteLine();
            pilotos[3] = "Rubens Barrichello";
            foreach (string piloto in pilotos)
            {
                Console.WriteLine(piloto);
            }
        }
    }
}
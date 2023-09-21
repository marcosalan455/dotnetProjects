using System;

namespace getSet
{
    class Program
    {
        static void Main(string [] args)
        {
            Pessoa p = new Pessoa();
            p.Nome = "Marcos Alan";
            Console.WriteLine(p.Nome);
        }
    }
}
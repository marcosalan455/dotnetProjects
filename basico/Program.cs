using System;
using System.Reflection.Metadata;

namespace basico
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas p = new Pessoas();
            p.nome = "Marcos Alan";
            p.idade = 47;
            p.mensagem();
            
        }
    }
}
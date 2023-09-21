using System;

namespace exercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoas1 p = new Pessoas1();
            p.peso = 99;
            p.altura = 1.74;
            p.mensagem();

            Pessoas1 p1 = new Pessoas1();
            p1.altura = 1.80;
            p1.peso = 100;
            p1.mensagem();
        }
    }
}
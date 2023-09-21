using System;

namespace polimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            Imposto objetoEst = new Estagiario();
            objetoEst.valeAlimentacao(1000);
            objetoEst.valeTransporte(1000);
            Console.WriteLine();

            Imposto objetoGer = new Gerente();
            objetoGer.valeAlimentacao(5000);
            objetoGer.valeTransporte(5000);
            Console.WriteLine();

            Imposto objetoAten = new Atendente();
            objetoAten.valeAlimentacao(2000);
            objetoAten.valeTransporte(2000);
            Console.WriteLine();
        }
    }
}
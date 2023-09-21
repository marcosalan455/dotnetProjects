using System;

namespace abstracao
{
    class Program
    {
        static void Main(string [] args)
        {
            PessoaFisica pf = new PessoaFisica();
            pf.taixaEmprestimo(1000);
            Console.WriteLine();

            PessoaJuridica pj = new PessoaJuridica();
            pj.taixaEmprestimo(1000);
            
        }
    }
}
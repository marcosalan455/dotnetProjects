using System;

namespace exercicioMetodos
{
    class Program
    {
        static void Main(string [] args)
        {
            Aluno a = new Aluno();
            a.nome = "marcos";
            a.nota1 = 8;
            a.nota2 = 10;
            a.mensagem();
        }
    }
}
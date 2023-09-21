using System;

class Pessoas
{
    public void apresentar()
    {
        Console.WriteLine("Olá");
    }

    public void apresentar(string nome)
    {
    Console.WriteLine("Olá "+nome);
    }

    public void apresentar(string nome, int idade)
    {
        Console.WriteLine("olá "+nome+" sua idade é "+idade+" anos");
    }
}
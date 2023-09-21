using System;

class Pessoa
{
    private string nome = "Alan";

    public Pessoa(string nome)
    {
        Console.WriteLine(nome);
        Console.WriteLine(this.nome);
    }
}
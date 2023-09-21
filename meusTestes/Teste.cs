using System;

class Teste
{   
    private string nome = "";
    private int idade;

    public void mensagem()
    {
        Console.WriteLine("Digite seu nome: ");
        nome = Console.ReadLine();

        Console.WriteLine("Digite sua idade: ");
        idade = Convert.ToInt32(Console.ReadLine());

        if (idade <= 21)
        {
            Console.WriteLine("Bom dia " + nome + " Bem vindo! Sua idade é: " + idade + " anos, Você é menor de idade.");
        }
        else if (idade <= 65)
        {
            Console.WriteLine("Bom dia " + nome + " Bem vindo! Sua idade é: " + idade + " anos, Você é maior de idade.");
        }
        else
        {
            Console.WriteLine("Bom dia " + nome + " Bem vindo, Sua idade é: " + idade + " anos, Você está na melhor idade.");
        }

    }
}
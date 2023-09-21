using System;

abstract class Padrao
{
    public abstract void taixaEmprestimo(double valor);

    public void calculoPoupanca(double valor, double taixa)
    {
        Console.WriteLine("Ganhos obtidos pela poupança R$"+valor * taixa);
    }
}
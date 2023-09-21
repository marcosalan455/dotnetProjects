using System;

class PessoaFisica : Padrao
{
    public override void taixaEmprestimo(double valor)
    {
        Console.WriteLine("Taixa de empréstimo para pessoa física R$" + (valor * 0.1));
    }
}
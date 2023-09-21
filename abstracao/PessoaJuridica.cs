using System;

class PessoaJuridica : Padrao
{
    public override void taixaEmprestimo(double valor)
    {
        Console.WriteLine("Taixa de empréstimo para pessoa jurídica R$" + (valor * 0.2));
    }
}
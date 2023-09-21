using System;

class Pessoas1
{
    public double peso, altura;

    public double calculo()
    {
        return peso / (altura * altura);
    }

    public String situacao(double imc)
    {
        string retorno;

        if (imc < 18.5)
        {
            retorno = "Abaixo do peso";
        }
        else if (imc < 25)
        {
            retorno = "Peso normal";
        }
        else if (imc < 25)
        {
            retorno = "Acima do peso";
        }
        else if (imc < 30)
        {
            retorno = "Obesidade1";
        }
        else if (imc < 40)
        {
            retorno = "Obesidade 2";
        }
        else
        {
            retorno = "Obesidade 3";
        }
        return retorno;
    }

    public void mensagem()
    {
        double obterCalculo = calculo();

        string obterSituacao = situacao(obterCalculo);

        Console.WriteLine("Seu IMC é dê: "+obterCalculo);
        Console.WriteLine("Sua situação é "+obterSituacao);
    }

}
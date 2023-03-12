using System;
public class Exercicio1
{
    public static void Main()
    {
        int convidadosNoivo = 300;
        int convidadosNoiva = 600;
        int convidadosPresentesNoivo = 405;
        int convidadosPresentesNoiva = 400;

        if(convidadosNoivo > convidadosNoiva)
        {
            Console.WriteLine("A quantidade de convidados do noivo é maior do que o da noiva");
        }else
        {
            Console.WriteLine("A quantidade de convidados da noiva é maior do que o do noivo");
        }

        if(convidadosPresentesNoivo > convidadosPresentesNoiva)
        {
            Console.WriteLine("Existem pessoas a mais, pois existem mais convidados do noivo do que da noiva");
        }
        else
        {
            Console.WriteLine("Existem Pessoas a mais, pois existem mais convidados da noiva do que do noivo");
        }
    }
};

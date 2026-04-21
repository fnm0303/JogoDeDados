using System;

namespace Dados.ConsoleApp.Entidades;

public class Jogador2
{
    public static int posicao = 0; //atributo da classe
    public static void RodadaDoComputador()
    {
        Random dado = new Random();
        int dadoJogador2 = dado.Next(1, 7);
        posicao += dadoJogador2;

        if (dadoJogador2 == 6)
        {
            Console.WriteLine($"Legal, você tirou {dadoJogador2} e ganhou uma rodada extra.");
            dadoJogador2 = dado.Next(1, 7);
            posicao += dadoJogador2;
        }

        if (posicao == 5 || posicao == 10 || posicao == 15)
        {
            Console.WriteLine($"Legal Jogador 2! Você parou na posição: {posicao} , avance 03 casas!");
            posicao += 3;
        }
        else if (posicao == 7 || posicao == 13 || posicao == 20 || posicao == 29)
        {
            Console.WriteLine($"Pena Jogador 2! Você parou na posição: {posicao} , recue 02 casas!");
            if (posicao >= 2)
                posicao -= 2;
            else
                posicao = 0;
        }

        Console.WriteLine($"Posição do jogador 2: {posicao}");
        ChecarSeComputadorGanhou();
    }
    public static bool VenceuPartida()
    {
        return posicao >= 30;
    }
    private static void ChecarSeComputadorGanhou()
    {
        if (posicao >= 30)
        {
            Console.WriteLine("Parabéns Computador! Você ganhou!");
            Console.ReadLine();
        }
    }
}

using System;

namespace Dados.ConsoleApp.Entidades;

public class Jogador1
{
    public static int posicao = 0; //atributo da classe
    public static void RodadaDoJogador()
    {
        Console.WriteLine("\nPressione ENTER para começar a próxima rodada!");
        Console.ReadLine();

        Random dado = new Random();
        int dadoJogador1 = dado.Next(1, 7);
        posicao += dadoJogador1;

        if (dadoJogador1 == 6)
        {
            Console.WriteLine($"Legal, você tirou {dadoJogador1} e ganhou uma rodada extra.");
            dadoJogador1 = dado.Next(1, 7);
            posicao += dadoJogador1;
        }

        if (posicao == 5 || posicao == 10 || posicao == 15)
        {
            Console.WriteLine($"Legal Jogador 1! Você parou na posição: {posicao} , avance 03 casas!");
            posicao += 3;
        }
        else if (posicao == 7 || posicao == 13 || posicao == 20 || posicao == 29)
        {
            Console.WriteLine($"Pena Jogador 1! Você parou na posição: {posicao} , recue 02 casas!");
            posicao -= 2;
        }

        Console.WriteLine($"Posição do jogador 1: {posicao}");
        ChecarSeJogador1Ganhou();
    }

    public static bool VenceuPartida()
    {
        return posicao >= 30;
    }
    private static void ChecarSeJogador1Ganhou()
    {
        if (posicao >= 30)
        {
            Console.WriteLine("Parabéns Jogador 1! Você ganhou!");
            Console.ReadLine();
        }
    }

}

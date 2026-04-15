/*
Regras e Funcionalidades:
1. Pista:
○ A pista é representada por uma linha numérica (ex.: de 0 a 30).
○ O jogador e o computador começam na posição 0.
2. Turnos:
○ O jogador e o computador alternam turnos para rolar um dado (gerar um número aleatório
entre 1 e 6).
○ O número gerado é somado à posição atual do competidor.
○ O jogo exibe a posição atual do jogador e do computador após cada rodada.
3. Condição de Vitória:
○ O primeiro competidor a alcançar ou ultrapassar a posição final (ex.: 30) vence o jogo.
4. Interação:
○ O jogador rola o dado pressionando uma tecla (ex.: Enter).
○ O computador rola o dado automaticamente no seu turno.

Dificuldades e Conceitos Envolvidos:
● Geração de números aleatórios: Para simular o lançamento do dado.
● Estruturas de repetição: Para controlar os turnos dos competidores.
● Condicionais: Para verificar eventos especiais e a condição de vitória.
● Interação com o usuário: Para permitir que o jogador role o dado.
● Lógica de turnos: Alternar entre o jogador e o computador.

Eventos Especiais:
5. Para tornar o jogo mais interessante, algumas posições na pista podem ter eventos especiais:
○ Avanço extra: Se o competidor parar em uma posição específica (ex.: 5, 10, 15), ele avança +3
casas.
○ Recuo: Se o competidor parar em outra posição específica (ex.: 7, 13, 20), ele recua -2 casas.
○ Rodada extra: Se o competidor tirar 6 no dado, ele ganha uma rodada extra.
*/
class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Console.WriteLine("---------- JOGO DE DADOS ------------");

        int posicaoJogador1 = 0, posicaoJogador2 = 0, numeroRodada = 0;

        do
        {
            numeroRodada += 1;
            posicaoJogador1 = RodadaDoJogador(numeroRodada, posicaoJogador1);

            posicaoJogador2 = RodadaDoComputador(posicaoJogador2);

            if (posicaoJogador1 >= 30)
            {
                Console.WriteLine("Parabéns Jogador 1! Você ganhou!");
                break;
            }
            else if (posicaoJogador2 >= 30)
            {
                Console.WriteLine("Parabéns Jogador 2! Você ganhou!");
                break;
            }

        } while (posicaoJogador1 < 30 && posicaoJogador2 < 30);

        Console.ReadLine();
    }


    static int RodadaDoJogador(int numeroRodada, int posicaoJogador1)
    {
        Console.WriteLine("\nPressione ENTER para começar a próxima rodada!");
        Console.ReadLine();

        Console.WriteLine($"Rodada nº: {numeroRodada}");

        Random dado = new Random();
        int dadoJogador1 = dado.Next(1, 7);
        posicaoJogador1 += dadoJogador1;

        if (dadoJogador1 == 6)
        {
            Console.WriteLine($"Legal, você tirou {dadoJogador1} e ganhou uma rodada extra.");
            dadoJogador1 = dado.Next(1, 7);
            posicaoJogador1 += dadoJogador1;
        }

        if (posicaoJogador1 == 5 || posicaoJogador1 == 10 || posicaoJogador1 == 15)
        {
            Console.WriteLine($"Legal Jogador 1! Você parou na posição: {posicaoJogador1} , avance 03 casas!");
            posicaoJogador1 += 3;
        }
        else if (posicaoJogador1 == 7 || posicaoJogador1 == 13 || posicaoJogador1 == 20 || posicaoJogador1 == 29)
        {
            Console.WriteLine($"Pena Jogador 1! Você parou na posição: {posicaoJogador1} , recue 02 casas!");
            posicaoJogador1 -= 2;
        }

        Console.WriteLine($"Posição do jogador 1: {posicaoJogador1}");
        return posicaoJogador1;
    }

    static int RodadaDoComputador(int posicaoJogador2)
    {
        Random dado = new Random();
        int dadoJogador2 = dado.Next(1, 7);
        posicaoJogador2 += dadoJogador2;

        if (dadoJogador2 == 6)
        {
            Console.WriteLine($"Legal, você tirou {dadoJogador2} e ganhou uma rodada extra.");
            dadoJogador2 = dado.Next(1, 7);
            posicaoJogador2 += dadoJogador2;
        }

        if (posicaoJogador2 == 5 || posicaoJogador2 == 10 || posicaoJogador2 == 15)
        {
            Console.WriteLine($"Legal Jogador 2! Você parou na posição: {posicaoJogador2} , avance 03 casas!");
            posicaoJogador2 += 3;
        }
        else if (posicaoJogador2 == 7 || posicaoJogador2 == 13 || posicaoJogador2 == 20 || posicaoJogador2 == 29)
        {
            Console.WriteLine($"Pena Jogador 2! Você parou na posição: {posicaoJogador2} , recue 02 casas!");
            if (posicaoJogador2 >= 2)
                posicaoJogador2 -= 2;
            else
                posicaoJogador2 = 0;
        }

        Console.WriteLine($"Posição do jogador 2: {posicaoJogador2}");
        return posicaoJogador2;
    }
}
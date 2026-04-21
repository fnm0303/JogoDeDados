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
using Dados.ConsoleApp.Entidades;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("---------- JOGO DE DADOS ------------");
            int numeroRodada = 0;
            Jogador1.posicao = 0;
            Jogador2.posicao = 0;
            do
            {
                numeroRodada += 1;
                Console.WriteLine($"\nRodada nº: {numeroRodada}");

                Jogador1.RodadaDoJogador();

                Jogador2.RodadaDoComputador();

                if (Jogador1.VenceuPartida())
                    break;

                if (Jogador2.VenceuPartida())
                    break;

            } while (Jogador1.posicao < 30 && Jogador2.posicao < 30);

            Console.Write("Deseja jogar novamente? s/N");
            string? opcaoContinuar = Console.ReadLine()?.ToUpper(); //avisando ao compilador que a variável pode ser nula

            if (opcaoContinuar != "S")
                break;
        }
    }
}
using System;

class Program
{
    static void Main()
    {
        char[,] tabuleiro = { { ' ', ' ', ' ' }, { ' ', ' ', ' ' }, { ' ', ' ', ' ' } };
        int jogador = 1, jogadas = 0;
        bool jogoAtivo = true;

        while (jogoAtivo)
        {
            Console.Clear();
            ExibirTabuleiro(tabuleiro);

            Console.WriteLine($"Jogador {jogador}, escolha uma posição (linha e coluna de 1 a 3):");
            int linha = int.Parse(Console.ReadLine()) - 1;
            int coluna = int.Parse(Console.ReadLine()) - 1;

            if (linha >= 0 && linha < 3 && coluna >= 0 && coluna < 3 && tabuleiro[linha, coluna] == ' ')
            {
                tabuleiro[linha, coluna] = jogador == 1 ? 'X' : 'O';
                jogadas++;

                if (VerificarVencedor(tabuleiro, jogador == 1 ? 'X' : 'O'))
                {
                    Console.Clear();
                    ExibirTabuleiro(tabuleiro);
                    Console.WriteLine($"Jogador {jogador} venceu!");
                    jogoAtivo = false;
                }
                else if (jogadas == 9)
                {
                    Console.Clear();
                    ExibirTabuleiro(tabuleiro);
                    Console.WriteLine("Empate!");
                    jogoAtivo = false;
                }
                else
                {
                    jogador = jogador == 1 ? 2 : 1;
                }
            }
            else
            {
                Console.WriteLine("Jogada inválida! Tente novamente.");
                Console.ReadKey();
            }
        }
    }

    static void ExibirTabuleiro(char[,] tabuleiro)
    {
        Console.WriteLine("  1 2 3");
        for (int i = 0; i < 3; i++)
        {
            Console.Write((i + 1) + " ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(tabuleiro[i, j]);
                if (j < 2) Console.Write("|");
            }
            Console.WriteLine();
            if (i < 2) Console.WriteLine("  -----");
        }
    }

    static bool VerificarVencedor(char[,] tabuleiro, char simbolo)
    {
        for (int i = 0; i < 3; i++)
        {
            if ((tabuleiro[i, 0] == simbolo && tabuleiro[i, 1] == simbolo && tabuleiro[i, 2] == simbolo) ||
                (tabuleiro[0, i] == simbolo && tabuleiro[1, i] == simbolo && tabuleiro[2, i] == simbolo))
                return true;
        }
        return (tabuleiro[0, 0] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 2] == simbolo) ||
               (tabuleiro[0, 2] == simbolo && tabuleiro[1, 1] == simbolo && tabuleiro[2, 0] == simbolo);
    }
}
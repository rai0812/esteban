using System;
class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 5]; 

        Console.WriteLine("Digite os 15 números da matriz (3x5):");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Elemento [{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("Soma dos valores de cada linha:");
        for (int i = 0; i < 3; i++)
        {
            int somaLinha = 0;
            for (int j = 0; j < 5; j++)
            {
                somaLinha += matriz[i, j];
            }
            Console.WriteLine($"Linha {i}: {somaLinha}");
        }
    }
}

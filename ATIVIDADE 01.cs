using System;

class Program
{
    static void Main()
    {
        int[] vetor = new int[15];

        Console.WriteLine("Digite 15 números inteiros:");
        for (int i = 0; i < 15; i++)
        {
            Console.Write($"Número {i + 1}: ");
            vetor[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("Números nas posições pares do vetor:");
        for (int i = 0; i < 15; i += 2)
        {
            Console.WriteLine($"Posição {i}: {vetor[i]}");
        }
    }
}


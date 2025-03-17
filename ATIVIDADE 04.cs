using System;
class Program
{
    static void Main()
    {
        int[,] matriz = new int[5, 5];
        int valor = 1;
        for (int i = 0; i < 5; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                matriz[i, j] = valor++;
            }
        }
        Console.WriteLine("Valores da diagonal principal e secundária:");
        for (int i = 0; i < 5; i++)
        {
            Console.Write(matriz[i, i] + " "); 
            if (i != 5 - i - 1)
            {
                Console.Write(matriz[i, 5 - i - 1] + "");
            }
        }
    }
}

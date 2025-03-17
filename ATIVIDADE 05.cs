using System;

class Program
{
    static void Main()
    {
        string[] alunos = new string[10];
        double[,] notas = new double[10, 3];
        double[] medias = new double[10];

        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Digite o nome do aluno {i + 1}: ");
            alunos[i] = Console.ReadLine();

            double soma = 0;
            for (int j = 0; j < 3; j++)
            {
                Console.Write($"Digite a nota {j + 1} de {alunos[i]}: ");
                notas[i, j] = double.Parse(Console.ReadLine());
                soma += notas[i, j];
            }
            medias[i] = soma / 3;
        }

        Console.WriteLine("\nRelatório dos alunos:");
        for (int i = 0; i < 10; i++)
        {
            if (medias[i] >= 7.0)
                Console.ForegroundColor = ConsoleColor.Blue; 
            else
                Console.ForegroundColor = ConsoleColor.Red; 

            Console.Write($"{alunos[i]} - Notas: ");
            for (int j = 0; j < 3; j++)
            {
                Console.Write(notas[i, j] + " ");
            }
            Console.WriteLine($"- Média: {medias[i]:F2} - {(medias[i] >= 7.0 ? "Aprovado" : "Reprovado")}");
        }

        Console.ResetColor(); 
    }
}


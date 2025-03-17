using System;

class Program
{
    static void Main()
    {
        string[] nomes = new string[10];
        double[] precos = new double[10];

        Console.WriteLine("Cadastro de 10 produtos:");
        for (int i = 0; i < 10; i++)
        {
            Console.Write($"Nome do produto {i + 1}: ");
            nomes[i] = Console.ReadLine();

            Console.Write($"Preço do produto {i + 1}: ");
            precos[i] = double.Parse(Console.ReadLine());
        }

        Console.Write("Digite um valor para filtrar os produtos pelo preço: ");
        double valorFiltro = double.Parse(Console.ReadLine());

        Console.WriteLine("Produtos com preço até " + valorFiltro + ":");
        for (int i = 0; i < 10; i++)
        {
            if (precos[i] <= valorFiltro)
            {
                Console.WriteLine($"{nomes[i]} - R${precos[i]:F2}");
            }
        }
    }
}


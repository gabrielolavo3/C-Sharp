using System;

class Program 
{
  public static void Main (string[] args) 
  {
    string[] nomeProduto = new string[3];
    int[,] quantVenda = new int[3,4];
    int[] totalVenda = new int [3];
    int somaValor = 0;
    string produtoMaisVendido = "";
    int maior = int.MinValue;

    for (int a = 0; a < nomeProduto.Length; a++) 
    {
      Console.Write("\nDigite o nome do produto {0}: ", a+1);
      nomeProduto[a] = Console.ReadLine();

      for (int b = 0; b < 4; b++)
      {
        Console.Write("Digite a quantidade vendida no {0}° dia: ", b+1);
        quantVenda[a,b] = int.Parse(Console.ReadLine());

        somaValor += quantVenda[a,b];
      }

      totalVenda[a] = somaValor;
      somaValor = 0;

      maior = maior < totalVenda[a] ? totalVenda[a] : maior;
    }

    for (int a = 0; a < nomeProduto.Length; a++)
    {
      if (maior == totalVenda[a])
      {
        produtoMaisVendido = nomeProduto[a];
      } 
    }

    Console.Clear();
    
    for (int a = 0; a < nomeProduto.Length; a++)
    {
      Console.WriteLine("O produto {0} vendeu {1:c}\n", nomeProduto[a], totalVenda[a]);
    }
    Console.WriteLine("O produto mais vendido foi {0}", produtoMaisVendido);
  }
}
using System;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {
          int valor, soma = 0;
          
          for (byte G = 1; G <= 5; G++) 
          {
                Console.Write($"Digite o {G}º valor: ");
                valor = int.Parse(Console.ReadLine());

                soma+=valor;
          }

          Console.WriteLine("Soma: {0}", soma);

        }
    }
}
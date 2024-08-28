using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int novaPosicao;
            int[] valores = new int[16];

            for (int a = 0; a < valores.Length; a++)
            {
                Console.Write("Digite o valor {0}: ", a+1);
                valores[a] = Convert.ToInt32(Console.ReadLine());
            }

            for (int a = 0; a < 8; a++) 
            {
                novaPosicao = valores[a];
                valores[a] = valores[a+8];
                valores[a+8] = novaPosicao;

                a++;
            }

            for (int a = 0; a < valores.Length; a++)
            {
                Console.WriteLine(valores[a]);
            }
        }
    }
}
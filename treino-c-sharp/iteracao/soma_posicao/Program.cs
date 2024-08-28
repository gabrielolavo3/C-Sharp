using System;

namespace soma_posicao
{
    class Program
    {

        const int max = 12;
        
        static void Main(string[] args)
        {
            int[] num = new int[max];
            int posicaoX,
                posicaoY,
                soma = 0;

            for (int a = 0; a < max; a++) 
            {
                Console.Write("Digite o valor da posição {0}: ", a);
                num[a] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nDiga a primeira posição para somar: ");
            posicaoX = int.Parse(Console.ReadLine());
            Console.Write("Diga a segunda posição para somar: ");
            posicaoY = int.Parse(Console.ReadLine());

            for (int a = 0; a < max; a++) 
            {
                if(a == posicaoX)
                {
                    soma+=num[a];
                }

                if(a == posicaoY)
                {
                    soma+=num[a];
                }
            }

            Console.Clear();

            Console.WriteLine($"A soma da posição {posicaoX} com a posição {posicaoY} é {soma}");
        }
    }
}
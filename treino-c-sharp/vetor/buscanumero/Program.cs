using System;

namespace soma_posicao
{
    class Program
    {
        const int max = 5;
        
        static void Main(string[] args)
        {
            int[] valor = new int[max];
            int valorX,
                busca = 0,
                naoEncontrado = 0;            

            for (int a = 0; a < max; a++) 
            {
                Console.Write("Qual o {0}º numero? ", a+1);
                valor[a] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nDigite o valor que deseja buscar: ");
            valorX = int.Parse(Console.ReadLine());

            for (int a = 0; a < max; a++) 
            {    
                if (valorX == valor[a]) 
                {
                    busca = a;
                    Console.WriteLine($"\nO valor foi encontrado, é {busca}");  // Vai ser executado apenas uma vez, quando valorX == valor[a] 
                } 
                else 
                {
                    naoEncontrado++; // Conta quantas vezes o laço iterou e não obteve resultado
                }
            }
            
            if (naoEncontrado == max)
            {
                Console.WriteLine("O valor não foi encontrado!");
            }
        }
    }
}
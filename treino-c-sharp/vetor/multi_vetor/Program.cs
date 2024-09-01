using System;

namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor1 = new int[10];
            int[] vetor2 = new int[10];

            for (int a = 0; a < vetor1.Length; a++) 
            {
                Console.Write("Insira o valor da posição {0}: ", a);
                vetor1[a] = int.Parse(Console.ReadLine());

                vetor2[a] = vetor1[a];
                vetor2[a] = vetor2[a] * 5;
            }
            
            Console.Clear();

            Console.WriteLine("Primeiro vetor");

            for (int a = 0; a < vetor1.Length; a++) 
            {
                Console.Write("{0} ", vetor1[a]);        
            }

            Console.WriteLine("\n\nSegundo vetor");

            for (int b = 0; b < vetor2.Length; b++) 
            {
                Console.Write("{0} ", vetor2[b]);
            }
        }
    }
}
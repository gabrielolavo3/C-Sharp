using System;

namespace nota_nome
{
    class Program
    {
        const int Max = 2;

        static void Main(string[] args)
        {
            string[] nomeAluno = new string[Max];
            float[,] notas = new float[Max,3];
            float somaNota = 0;   
            float[] media = new float[Max];

            for (byte g = 0; g < Max; g++) 
            {
                Console. Write("Insira o nome do aluno: ");
                nomeAluno[g] = Console.ReadLine();

                for (byte s = 0; s < 3; s++) 
                {
                    Console.Write("Digite a {0}ª nota: ", s+1);
                    notas[g,s] = float.Parse(Console.ReadLine());

                    somaNota += notas[g,s];
                }
                
                media[g] = somaNota / 3;
                somaNota = 0;
            }

            Console.Clear();

            for (byte a = 0; a < Max; a++) 
            {
                Console. WriteLine($"- {nomeAluno[a]}: \n");

                for (byte b = 0; b < 3; b++) 
                {
                    Console.WriteLine(" - {0}ª nota: {1}", b+1, notas[a,b]);
                }

                Console.WriteLine("\nMédia: {0}", media[a]);
            }
        }
    }
}
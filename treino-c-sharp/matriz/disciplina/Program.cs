using System;

namespace disciplina
{
    class Program
    {

        const int Max = 3;
        const int maxScore = 2;

        static void Main(string[] args)
        {
            string[] nomeDisciplina = new string[Max];
            float[] media = new float[Max];
            float[,] notas = new float[Max, maxScore];
            float soma = 0;

            for (int a = 0; a < Max; a++) 
            {
                Console.Write($"\nQual o nome da {a+1}ª disciplina: ");
                nomeDisciplina[a] = Console.ReadLine();
                
                for (int b = 0; b < maxScore; b++) 
                {
                    Console.Write($"Insira a {b+1}ª nota: ");
                    notas[a,b] = float.Parse (Console.ReadLine());
                    soma += notas[a,b];
                }

                media[a] = soma / maxScore;
                soma = 0; // Resertando variável após uso
            }

            Console.Clear();

            for (int a = 0; a < Max; a++) 
            {
                Console.WriteLine($"Nome da disciplina: {nomeDisciplina[a]}");
                
                for (int b = 0; b < maxScore; b++) 
                {
                    Console.WriteLine($"{b+1}ª nota: {notas[a,b]}");
                }

            Console.WriteLine($"Média: {media[a]}\n");
            }
        }
    }
}
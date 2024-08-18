using System;

namespace par_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int valores, 
                somaPar = 0, 
                somaImpar = 0;
            int g;
            
            for (g = 1; g <= 5; g++) 
            {
                Console.Write($"{g}º número: ");
                valores = int.Parse(Console.ReadLine());

                if (valores % 2 == 0) {
                    somaPar++;                
                } 

                if (valores % 2 != 0) {
                    somaImpar++;
                }
            }

            Console.WriteLine("\nQuant. de pares: {0}\nQuant. de ímpares: {1}", somaPar, somaImpar);
        }
    }
}
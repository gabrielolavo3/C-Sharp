using System;

namespace media_positivos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros,
                soma = 0,
                media = 0,
                quant = 0;

            do
            {
                int i = 0; // Exclusiva para o loop

                Console.Write("Insira o {0}º número: ", i+1);
                numeros = int.Parse(Console.ReadLine());

                {
                    soma += numeros;
                    quant++;
                }

                i++;

            } while (numeros > 0);
                
            media = soma / quant;

            Console.WriteLine(media);
        }
    }
}
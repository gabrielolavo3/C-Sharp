using System;

namespace impar_par
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[6];
            int a = 0,
                somaPar = 0,
                somaImpar = 0;
            
            while (a < num.Length)
            {
                Console.Write("Insira o {0}º número: ", a+1);
                num[a] = int.Parse(Console.ReadLine());

                if (num[a] % 2 == 0) {
                    somaPar++;
                
                } else if (num[a] % 2 != 0) {
                    somaImpar++;
                }

                a++;
            }

            Console.WriteLine("Quant. de pares: {0} \nQuant. de ímpares: {1}", somaPar, somaImpar);
        }
    }
}
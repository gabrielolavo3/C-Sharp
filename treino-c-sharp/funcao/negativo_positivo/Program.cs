using System;

namespace Name
{
    class Program
    {

        static bool negPositivo (float valor)  
        {
            bool verdade = false;

            if (valor < 0) {
                verdade = false;
            
            } else if (valor > 0) {
                verdade = true;
            }

            return verdade;
        }

        static void Main(string[] args)
        {
            float numero;

            Console.Write("Digite um número: ");
            numero = float.Parse(Console.ReadLine());

            Console.WriteLine("O valor é " + negPositivo(numero));
        }
    }
}
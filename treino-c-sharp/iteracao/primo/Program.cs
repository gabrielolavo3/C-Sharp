using System;

namespace primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor,
                sobra = 0,
                g = 1;

            Console.Write("Digite um número: ");
            valor = int.Parse(Console.ReadLine());

            while (g <= valor) {

                if (valor % g == 0) {
                    sobra++;
                }

                g++;
            }

            if (sobra == 2) {
                Console.Write("É primo");
            
            } else {
                Console.WriteLine("Não é primo");
            }
        }
    }
}
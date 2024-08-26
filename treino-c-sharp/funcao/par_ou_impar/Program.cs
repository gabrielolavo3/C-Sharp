using System;

namespace par_ou_impar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;

            Console.Write("Digite um número: ");
            numero = int.Parse(Console.ReadLine());

            par_impar(numero);
        }

        static void par_impar(int valor)
        {
            if (valor % 2 == 0) {
                Console.WriteLine("É par!");
            
            } else {
                Console.WriteLine("É ímpar!");
            }
        }
    }
}
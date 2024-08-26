using System;

namespace soma
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor,
                segundoValor,
                resultado;

            Console.Write("Insira o valor 1: ");
            primeiroValor = int.Parse(Console.ReadLine());
            Console.Write("Insira o valor 2: ");
            segundoValor = int.Parse(Console.ReadLine());

            resultado = somar(primeiroValor, segundoValor);

            Console.WriteLine("Soma: {0}", resultado);
        }

        static int somar(int n1, int n2) 
        {
            return n1 + n2;
        }
    }
}
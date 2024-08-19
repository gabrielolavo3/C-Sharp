using System;

namespace out_argumento
{
    class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor = 10,
                segundoValor = 5,
                recebe,
                resultado;
            
            recebe = divisao (primeiroValor, segundoValor, out resultado);
            Console.WriteLine("Quociente: {0} \nResto da divisão: {1}", recebe, resultado);
        }

        // Metodo que retorna 2 valores, com o uso da palavra out na passagem
        static int divisao(int num1, int num2, out int final) {
            int div;

            div = num1 / num2;
            final = num1 % num2;

            return div;
        }
    }
}
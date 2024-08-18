using System;

namespace dados_teclado
{
    class Program
    {
        static void Main(string[] args) 
        {
            int valor1,
                valor2,
                somaTotal;

            Console.Write("Digite o 1º número: ");
            // valor1 = Console.Read(); | Necessário converter para inteiro            
            valor1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o 2º número: ");
            valor2 = int.Parse(Console.ReadLine());            
            
            // valor2 = Convert.ToInt32 (Console.Read());

            somaTotal = valor1 + valor2;

            Console.Write($"Total: {somaTotal}");
        }
    }
}
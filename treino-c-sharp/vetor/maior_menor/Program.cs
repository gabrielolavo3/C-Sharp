using System;

namespace maior_menor
{
    class Program
    {
        const byte fixEd = 5;
        static void Main(string[] args)
        {
            int[] valor = new int[fixEd];
            int i = 0,
                maior = int.MinValue,
                menor = int.MaxValue;

            while (i < valor.Length) 
            {
                Console.Write("Digite um valor: ");
                valor[i] = int.Parse(Console.ReadLine());

                maior = valor[i] > maior ? valor[i] : maior;
                menor = valor[i] < menor ? valor[i] : menor;
                i++;
            }

            Console.Clear();
            
            foreach (int n in valor)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine($"Maior: {maior}\nMenor: {menor}");
        }
    }
}
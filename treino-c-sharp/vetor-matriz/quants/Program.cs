using System;

namespace quants
{
    class Program
    {
        const int Max = 5; 
        static void Main(string[] args)
        {
            int[] valor = new int[Max];
            int quantPar = 0,
                quantImpar = 0,
                positivo = 0,
                negativo = 0,
                maior = int.MinValue,
                menor = int.MaxValue,
                somaTotal = 0,
                mediaPar,
                somaPar = 0,
                count = 0;

            while (count < valor.Length)
            {
                Console.Write("Digite: ");
                valor[count] = Convert.ToInt32(Console.ReadLine());

                somaTotal += valor[count]; 

                // Quantidade de par e ímpar

                if (valor[count] % 2 == 0) {
                    quantPar++;
                    somaPar += valor[count];
                
                } else {
                    quantImpar++;
                }

                // Quantidade de negativos e positivos

                if (valor[count] > 0) {
                    positivo++;
                
                } else if (valor[count] < 0) {
                    negativo++;
                }

                // Maior e menor valor

                maior = valor[count] > maior ? valor[count] : maior;
                menor = valor[count] < menor ? valor[count] : menor;

                count++;
            }

            mediaPar = somaPar / quantPar;

            Console.Clear();

            Console.WriteLine($"Quant. de par: {quantPar} \nQuant. de impar: {quantImpar} \nMedia de par: {mediaPar}\n");
            Console.WriteLine($"Quant. de positivo: {positivo} \nQuant. de negativo: {negativo}\n");
            Console.WriteLine($"Maior: {maior} \nMenor: {menor}\n");
            Console.WriteLine($"Soma dos valores: {somaTotal}");
        }
    }
}
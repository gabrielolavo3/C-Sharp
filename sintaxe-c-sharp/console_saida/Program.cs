using System;

namespace console_saida
{
    class Program
    {
        static void Main(string[] args)  
        {
            byte idade = 22;
            string nome = "Beatrix", 
                   nome2 = "Tarantino", 
                   nome3 = "Mary";
            char sexoF = 'F', 
                 sexoM = 'M';
            string produto = "Pastel";
            float valorVenda,
                  lucro = 0.1F,
                  valorCompra = 5.50F;

                  valorVenda = valorCompra + (valorCompra * lucro);

            // Impressão com quebra de linha
            Console.WriteLine("Hello World");

            // Impressão sem quebra de linha
            Console.Write("Hello");
            Console.Write("World\n");

            // Concatenação
            Console.Write(nome + " possui " + idade + " anos de idade e seu sexo é " + sexoF);

            // Concatenação formatada com indice de variável
            Console.Write("\n{0} possui {1} anos de idade e é do sexo {2}\n", nome2, idade, sexoM);

            
            Console.Write($"{nome3} possui {idade} anos de idade e é do sexo {sexoF}\n\n");

            Console.WriteLine("Produto...........:{0,15:c}", produto);
            Console.WriteLine("Val. Compra.......:{0,15:c}", valorCompra);
            Console.WriteLine("Lucro.............:{0,15:p}", lucro);
            Console.WriteLine("Val. Venda........:{0,15:c}", valorVenda);
        }
    }
}
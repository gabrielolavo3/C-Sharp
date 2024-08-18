using System;

class Program
{
    static void Main(string[] args) 
    {
        string filme;
        char escolha;

        // Criação da label
        inicio:

        Console.Clear(); // LimpaTela

        Console.Write("Digite o nome de um filme: ");
        filme = Console.ReadLine(); 

        Console.WriteLine("Deseja digitar outro filme? [Y | N]");
        escolha = char.Parse(Console.ReadLine());
        
        if (char.ToUpper(escolha) == 'Y') {
            goto inicio;
        
        } else {
            Console.WriteLine("Fim do programa");
        }
    }
}
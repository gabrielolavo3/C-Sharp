using System;

class Program
{

    enum Dados 
    {
        Aventura, 
        Acao,
        Terror
    };

    static void Main(string[] args) 
    {
        // Variavel recebendo valor do enum
        Dados genero = Dados.Aventura;

        // Atribuindo pelo indice do enum
        Dados genero2 = (Dados)2;

        // Atribuindo para variavel explicita
        var genero3 = (Dados)1;

        Console.WriteLine(genero);
        Console.WriteLine(genero2);
        Console.WriteLine(genero3);
    }
}
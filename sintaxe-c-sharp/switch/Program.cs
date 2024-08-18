using System;

class Program 
{

    enum Dias 
    {
        Domingo,
        Segunda,
        Terca,
        Quarta,
        Quinta,
        Sexta,
        Sabado
    };
    static void Main(string[] args)
    {
        byte escolha;

        Console.Write("Insira um numero para saber o dia: ");
        escolha = byte.Parse (Console.ReadLine());

        switch (escolha)
        {
            case 1:
            Console.Write((Dias)0);
                break;
            case 2:
            Console.Write((Dias)1);
                break;
            case 3:
            Console.Write((Dias)2);
                break;
            case 4:
            Console.Write((Dias)3);
                break;
            case 5:
            Console.Write((Dias)4);
                break;
            case 6:
            Console.Write((Dias)5);
                break;
            case 7:
            Console.Write((Dias)6);
                break;
            default:
            Console.Write("Dia inválido!");
                break;
        }
    }
}
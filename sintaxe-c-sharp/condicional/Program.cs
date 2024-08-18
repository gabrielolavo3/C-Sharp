using System;

class Program
{
    static void Main(string[] args) 
    {
        byte nota1, 
             nota2, 
             nota3;
        int media;

        Console.Write("Digite a 1ª nota: ");
        nota1 = byte.Parse (Console.ReadLine());
        Console.Write("Digite a 2ª nota: ");
        nota2 = byte.Parse (Console.ReadLine());
        Console.Write("Digite a 3ª nota: ");
        nota3 = byte.Parse (Console.ReadLine());

        media = (nota1 + nota2 + nota3) / 3;

        if (media >= 7 && media <= 10) {
            if (media == 10) {
                Console.Write ("Aprovado com louvor");
            
            } else {
                Console.Write ("Aprovado");
            }
        
        } else if (media >= 5 && media < 7) {
            Console.Write("Recuperação");
        
        } else {
            Console.WriteLine("Reprovado");
        }

    }
}
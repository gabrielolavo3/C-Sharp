using System;

namespace nota
{
    class Program
    {
        static void Main(string[] args)
        {
           int nota;

           Console.Write("Informe uma nota: ");
           nota = int.Parse(Console.ReadLine());

           while (nota < 0 || nota > 10)
           {
            Console.Clear();
            Console.Write("Nota incorreta!\nInforme de novo: ");
           }

           Console.WriteLine($"Sua nota foi {nota}");
        }
    }
}
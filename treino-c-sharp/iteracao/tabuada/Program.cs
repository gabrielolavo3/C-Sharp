using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[]args)
        {
           byte numero;

           Console.Write("Digite um valor para construir a tabuada: ");
           numero = byte.Parse(Console.ReadLine());

           Console.Clear();
           
           for (int g = 1; g <= 10; g++) {
                Console.WriteLine("{0} x {1} = {2}", numero, g, numero*g);
           }
        }
    }
}
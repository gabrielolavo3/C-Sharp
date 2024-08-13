using System;

namespace constante
{
    class Program
    {
        static void Main(string[] args)
        {
            // const <tipo> <nome> = <valor>;

            const int n = 0;
            const string objeto = "Calculadora";

            Console.WriteLine(n);
            Console.WriteLine($"Valor: {objeto}" + "!");
        }
    }
}

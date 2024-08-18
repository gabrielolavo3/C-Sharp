using System;

namespace par_1_20
{
    class Program
    {
        static void Main(string[] args)
        {
            for (byte a = 1; a <= 20; a++) {
                if (a % 2 == 0) {
                    Console.WriteLine(a);
                }
            }
        }
    }
}
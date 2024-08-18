using System;

namespace par_100_200
{
    class Program
    {
        static void Main(string[] args)
        {

            for (int g = 100; g <= 200; g++) {
                if (g % 2 == 0) {
                    Console.WriteLine(g);
                }
            }
            
        }
    }
}
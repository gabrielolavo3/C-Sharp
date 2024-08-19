using System;

namespace valor0
{
    class Program
    {
        const int fixEd = 5;

        static void Main(string[] args)
        {
            int[] values = new int[fixEd];

            for (byte g = 0; g < values.Length; g++) 
            {
                Console.Write("Informe o número {0}: ", g+1);
                values[g] = Convert.ToInt32(Console.ReadLine());

                if (values[g] < 0)
                {
                    values[g] = 0;
                }
            }

            Console.Clear();
            Console.WriteLine("Numeros:");

            foreach (int valor in values)
            {
                Console.WriteLine(valor);
            }
        }
    }
}
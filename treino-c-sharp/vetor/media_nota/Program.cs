using System;

namespace media_nota
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] nota = new float[3];
            float media = 0,
                  soma = 0;
            string situacao;

            for (byte g = 0; g < nota.Length; g++) 
            {
                Console.Write("Insira a {0}ª nota: ", g+1);
                nota[g] = float.Parse(Console.ReadLine());

                soma += nota[g];
            }

            media = soma / nota.Length;

            if (media >= 7) {
                situacao = "Aprovado!";
            
            } else if (media >= 5 && media < 7) {
                situacao = "Recuperação!";
            
            } else {
                situacao = "Reprovado!";
            }

            Console.Clear();

            foreach (var item in nota)
            {
                Console.WriteLine("{0:F0}", item);
            }
            Console.WriteLine("Media: {0:F0}", media);
            Console.WriteLine("Situação: {0}", situacao);
        }
    }
}
using System;

namespace funcao_static
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 20,
                num2 = 40,
                final;
            float value0 = 10.6F,
                  value1 = 1.5F;
            bool verdade = false;

            console();
            final = soma(num1, num2);
            maior(ref value0, value1, ref verdade);

            Console.WriteLine("O resultado do metódo por valor é {0}", final);
            Console.WriteLine("Passagem por referência: {0}", verdade);
        }

        // Função Static sem Retorno (void) -> É Static por causa do metodo Main
        static void console()
        {
            Console.WriteLine("Console através de função!\n");
        }

        /* Função Static com Retorno (int, float, bool...) - Passagem de parâmetro por valor
        || O retorno tem que ser do mesmo tipo da função - Tem que usar a palavra reservada: return*/
        static int soma(int valor1, int valor2)
        {
            return valor1 + valor2;
        }

        // Passagem de parâmetro por referência (altera o valor da variável passada) | Uso da palavra ref no metodo
        static void maior(ref float val1, float val2, ref bool boleano)
        {

            if (val1 > val2)
            {
                boleano = true;
            }
            else
            {
                boleano = false;
            }
        }
    }
}


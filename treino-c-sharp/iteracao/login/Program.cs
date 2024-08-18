using System;

namespace login
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "plux12", 
                   password = "521", 
                   senhaDigitada,
                   usuarioDigitado;
            
            do
            {
                Console.Write("Digite o nome de usuário: ");
                usuarioDigitado = Console.ReadLine();
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();

                if ((senhaDigitada != password) || (user != usuarioDigitado)) {
                    Console.Clear();
                    Console.WriteLine("Há algo errado! Tente de novo\n");
                }

            } while ((senhaDigitada != password) || (user != usuarioDigitado));

            Console.WriteLine("Acesso Permitido");
        }
    }
}
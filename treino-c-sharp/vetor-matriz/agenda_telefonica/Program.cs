using System;

namespace agenda_telefonica
{
    class Program
    {
        const byte Max = byte.MaxValue;
        static void Main(string[] args)
        {
            string[] telefone = new string[Max];
            string[] nomeContato = new string[Max];
            char menu = '0';
            int loop = 0;

            while (menu != '2')
            {
            Start:
                Console.WriteLine("AGENDA\n");
                Console.WriteLine("CODIGO\t|  FUNCAO");
                Console.WriteLine("   1    |  Adicionar contato");
                Console.WriteLine("   2    |  Sair e exibir");
                Console.Write("Escolha uma opção: ");
                menu = Convert.ToChar(Console.ReadLine());

                switch (menu)
                {
                    case '1':
                        Console.Write("\nOK! DIGITE OS DADOS\n\nInsira o nome do contato: ");
                        nomeContato[loop] = Console.ReadLine();
                        Console.Write("Insira o número do contato: ");
                        telefone[loop] = Console.ReadLine();

                        Console.Clear();

                        loop++;
                        break;

                    case '2':
                        if (loop == 0)
                        {
                            Console.Clear();
                            Console.WriteLine("Não há informação disponível! Faça a inserção!\n");
                            goto Start;
                        }

                        for (int g = 0; g < loop; g++)
                        {
                            if (loop == 1)
                            {
                                Console.Write("\nCONTATO LOCALIZADO!\n");
                            }

                            Console.WriteLine("Nome do Contato: {0} - Telefone: {1}", nomeContato[g], telefone[g]);
                        }
                        break;
                }
            }
        }
    }
}

using System;

namespace Aula16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tempo = 0;
            char escolha = ' ';

        inicio:

            Console.Clear();

            Console.WriteLine("Belo Horizonte a Vitória/ES");
            Console.WriteLine("Escolha o transporte: [a]-aviao | [c] - carro | [o] - onibus ");

            escolha = Char.Parse(Console.ReadLine());

            switch (escolha)
            {
                case 'a':
                case 'A':
                    tempo = 50;
                    break;
                case 'c':
                case 'C':
                    tempo = 480;
                    break;
                case 'o':
                case 'O':
                    tempo = 660;
                    break;
                default:
                    tempo = -1;
                    break;

            }

            if (tempo < 0)
            {
                Console.WriteLine("Transporte indisponível");
            }
            else
            {
                Console.WriteLine($"O tempo de viagem é de {tempo} minutos");

            }

            Console.WriteLine("\nCalcular outro transporte?[s/n]: ");
            escolha = char.Parse(Console.ReadLine());
            if (escolha == 's' || escolha == 'S')
            {
                goto inicio;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Encerrando o programa...");
            }
        }
    }
}

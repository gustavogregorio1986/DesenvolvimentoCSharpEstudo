using System;

namespace Aula31
{
    using System;

    class Program
    {
        static void MoverDiscos(int n, char origem, char destino, char auxiliar)
        {
            if (n == 1)
            {
                Console.WriteLine($"Mover disco 1 de {origem} para {destino}");
                return;
            }

            // Move n-1 discos para o auxiliar
            MoverDiscos(n - 1, origem, auxiliar, destino);

            // Move o maior disco para o destino
            Console.WriteLine($"Mover disco {n} de {origem} para {destino}");

            // Move n-1 discos do auxiliar para o destino
            MoverDiscos(n - 1, auxiliar, destino, origem);
        }

        static void Main(string[] args)
        {
            Console.Write("Digite o número de discos: ");
            int n = int.Parse(Console.ReadLine());

            MoverDiscos(n, 'A', 'C', 'B');
        }
    }
}

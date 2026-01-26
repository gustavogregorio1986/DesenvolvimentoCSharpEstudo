using System;

namespace Aula01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ola Mundo!");

            Console.WriteLine("----------------------------------------------");

            string nome = "Gustavo";
            Console.WriteLine("Olá, " + nome + "!");

            Console.WriteLine("-----------------------------------------------");

            Console.WriteLine("Digite um número:");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("O número " + numero + " é par.");
            }
            else
            {
                Console.WriteLine("O número " + numero + " é ímpar.");
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("Digite sua idade:");
            int idade = int.Parse(Console.ReadLine());

            if (idade >= 18)
            {
                Console.WriteLine("Você é maior de idade.");
            }
            else
            {
                Console.WriteLine("Você é menor de idade.");
            }

        }
    }
}

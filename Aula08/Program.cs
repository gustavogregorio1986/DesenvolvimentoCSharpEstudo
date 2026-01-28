using System;

namespace Aula08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int v1, v2, soma;
            string nome;

            Console.WriteLine("Digite o primeiro valor: ");
            v1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o segundo valor: ");
            v2 = Convert.ToInt32(Console.ReadLine());
            soma = v1 + v2;
            Console.WriteLine("A soma de {0} mais {1} é igual a {2}", v1,v2, soma);
        }
    }
}

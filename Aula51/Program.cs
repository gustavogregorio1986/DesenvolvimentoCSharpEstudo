using System;

namespace Aula51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 1)
            {
                Console.WriteLine("Quangtidade de argumentos {0}", args);
            }
            else
            {
                Console.WriteLine("Não foram passados os argumentos");
            }
        }
    }
}

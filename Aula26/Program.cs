using System;

namespace Aula26
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 50;
            dobrar1(num);
            Console.WriteLine(num);

            int num1 = 50;
            dobrar(ref num1);
            Console.WriteLine(num1);
        }

        static void dobrar1(int valor)
        {
            valor *= 2;
        }

        static void dobrar(ref int valor)
        {
            valor *= 2;
        }
    }
}

using System;

namespace Aula09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 10;

            num = num << 1;

            Console.WriteLine(num);

            int num1 = 10;

            num1 = num1 >> 1;

            Console.WriteLine(num1);

            int num2 = 20;

            num2 = num2 >> 1;

            Console.WriteLine(num2);

            int num3 = 20;

            num3 = num3 << 2;

            Console.WriteLine(num3);
        }
    }
}

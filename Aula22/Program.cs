using System;

namespace Aula22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5] { 11, 22, 33,44,55 };

            Console.WriteLine("Imprimir com o for");

            for(int i=0; i <= num.Length-1; i++)
            {
                Console.WriteLine(num[i]);
            }

            for (int i = 0; i <= num.Length - 1; i++)
            {
                num[i] = 0;
            }

            Console.WriteLine("Imprimir com o foreach");

            foreach (int n in num)
            {
                Console.WriteLine(n);
            }


        }
    }
}

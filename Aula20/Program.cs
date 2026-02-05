using System;

namespace Aula20
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];

            int i = num.Length - 1;
            //while (i < 10)
            //{
            //    Console.WriteLine("CFB Cursos");
            //    i++;
            //}

            //while (i < num.Length)
            //{
            //    num[i] = i;
            //    Console.WriteLine(num[i]);
            //    i++;
            //}

            while (i >0)
            {
                num[i] = i;
                Console.WriteLine(num[i]);
                i--;
            }

            Console.WriteLine("Fim do Loop");
        }
    }
}

using System;

namespace Aula19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for(e1; e2; e3)
            //{

            //}


            int[] num = new int[10];

            for (int i = 0; i < num.Length; i++)
            {
                num[i] = i;
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Valor de num na pos{0} : {1}",i,num[i]);
            }

            //for (int num = 0; num < 10; num++)
            //{
            //    Console.WriteLine("Va,lor de num: {0}", num);
            //}
        }
    }
}

using System;

namespace Aula48
{
    public class Program
    {
        class Calc
        {
            public int soma(params int[] n)
            {
                int s = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    s += n[i];
                }
                return s;
            }

            public double soma(params double[] n)
            {
                double s = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    s += n[i];
                }
                return s;
            }

            //5! = %*4*3*2*1
            public int fat(int n)
            {
                int res;
                if (n <= 1)
                {
                    res = 1;
                }
                else
                {
                    res = n * fat(n - 1);
                }

                return res;

            }
        }


        static void Main(string[] args)
        {
            double res;
            //int res;
            Calc calc = new Calc();
            //res = calc.soma(10.2, 5.4,3.1, 7.2,8.1);
            //res = calc.soma(1, 5, 10, 35);
            res = calc.fat(10);
            //res = calc.soma(10, 5,3);
            Console.WriteLine(res);
        }
    }
}

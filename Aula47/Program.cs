using System;

namespace Aula47
{
    public class Program
    {
        class Calc { 
            public int soma(params int[]n)
            {
                int s = 0;
                for(int i = 0; i<n.Length; i++)
                {
                    s += n[i];
                }
                return s;
            }

            public double soma(params double[]n)
            {
                double s = 0;
                for (int i = 0; i < n.Length; i++)
                {
                    s += n[i];
                }
                return s;
            }

            //public int soma(int n1, int n2)
            //{
            //    return n1 + n2;
            //}

            //public double soma(double n1, double n2)
            //{
            //    return n1 + n2;
            //}

            //public int soma(int n1, int n2, int n3)
            //{
            //    return n1 + n2 + n3;
            //}

            //public int soma(int n1, int n2, int n3, int n4)
            //{
            //    return n1 + n2 + n3;
            //}
        }


        static void Main(string[] args)
        {
            double res;
           //int res;
            Calc calc = new Calc();
            //res = calc.soma(10.2, 5.4,3.1, 7.2,8.1);
            res = calc.soma(1, 5, 10, 35);
            //res = calc.soma(10, 5,3);
            Console.WriteLine(res);
        }
    }
}

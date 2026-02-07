using System;

namespace Aula24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 10; i++)
            //{
            //    cfb();
            //}

            cfb();
            somar(81, 12);

            int v1, v2, r;

            v1=int.Parse(Console.ReadLine());
            v1 = int.Parse(Console.ReadLine());

            somar(v1, v2);
            r = soma(v1, v2);
            Console.WriteLine("A soma de {0} e {1} é: {2}", v1,v2,r);
        }

        static double nome(int n1, int n2, string texto)
        {
            double t;
            return t;
        }
        {

        }

        static void cfb()
        {
            Console.WriteLine("CFB Cursos");
            Console.WriteLine("Curso de C#");
            Console.WriteLine("youtube.com/cbfcursos");
        }

        static void somar(int n1, int n2)
        {
            int res = n1 + n2;
            Console.WriteLine("A Soma de {0} e {1}: {2}", n1, n2, res);
           
        }

        static int soma(int v1, int v2)
        {
            int res = v1 + v2;
            return res;

        }
    }
}

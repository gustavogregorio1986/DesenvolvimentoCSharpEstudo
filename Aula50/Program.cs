using System;

namespace Aula50
{
    public class Program
    {
        // Delegate que recebe dois inteiros e retorna um inteiro
        delegate int Op(int n1, int n2);

        class Mat
        {
            public static int soma(int n1, int n2)
            {
                return n1 + n2;
            }

            public static int mult(int n1, int n2)
            {
                return n1 * n2;
            }
        }

        static void Main(string[] args)
        {
            int res;

            // Criando delegate para soma
            Op d1 = new Op(Mat.soma);
            res = d1(10, 5);
            Console.WriteLine("Soma: " + res);

            // Criando delegate para multiplicação
            Op d2 = new Op(Mat.mult);
            res = d2(10, 5);
            Console.WriteLine("Multiplicação: " + res);
        }
    }
}
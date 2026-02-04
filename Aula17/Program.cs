using System;

namespace Aula17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n1, n2, n3, n4, n5;
            int[] n = new int[5]; //não é 1 , vai ser sempre 0 a 4
            int[] num = new int[3] { 55,77,99 };
            int[] numero = { 5, 10, 15, 20, 25, 66,88 };
            string[] veiculos = new string[3];

            veiculos[0] = "Carro";
            veiculos[1] = "Avião";
            veiculos[2] = "Navio";

            n[0]=111;
            n[1] = 11;
            n[2] = 22;
            n[3] = 33;
            n[4] = 44;

            Console.WriteLine(n[0]);

            Console.WriteLine(num[2]);

        }
    }
}

using System;

namespace Aula06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;

            n1 = 10; n2 = 20; n3 = 30;

            Console.WriteLine(n1 + "," + n2 + "," + n3);

            Console.WriteLine("n1=\t{0}\n n2=\t{1}\n n3=\t{2}\n", n1, n2,n3);

            double valorCompra = 5.50;
            double valorVenda;
            double lucro=0.1;
            string produto="Pastel";

            valorVenda = valorCompra + (valorCompra * lucro);

            Console.WriteLine("Produto................{0,15}", produto);
            Console.WriteLine("Val.Compra.............{0,15:c}", valorCompra);
            Console.WriteLine("Lucro..................{0,15:p}", lucro);
            Console.WriteLine("Val.Venda..............{0,15:c}", valorVenda);
        }
    }
}

using System;

namespace Aula52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, res;

            res = n1 = n2 = 0;
            n1 = 10;
            n2 = 0;
            try
            {
                res = n1 / n2;

                Console.WriteLine("{0}/{1}={2}", n1, n2, res);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu erro: {0}", e.Message);
                Console.WriteLine("Ex: {0}", e.GetType());
            }
            
        }
    }
}

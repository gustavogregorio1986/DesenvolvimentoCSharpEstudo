using System;

namespace Aula54
{
    class Area
    {
        public static float Quad(float bas, float alt)
        {
            if (bas == 0 || alt == 0)
            {
                throw new Exception("Base ou altura não podem ser zero");
            }

            return bas * alt;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            float area = 0;

            try
            {
                area = Area.Quad(10F, 5F);
                Console.WriteLine("Área do quadrado: {0}", area);
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu erro: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("Fim do processo");
            }

            int n1, n2, res;

            res = n1 = n2 = 0;
            n1 = 10;
            n2 = 5;
            try
            {
                res = n1 / n2;

                Console.WriteLine("{0}/{1}={2}", n1, n2, res);

                throw new Exception("CFB Currsos");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ocorreu erro: {0}", e.Message);
                Console.WriteLine("Ex: {0}", e.GetType());
            }
            finally
            {
                Console.WriteLine("Fim do processo");
            }
        }
    }
}

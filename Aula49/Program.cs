using System;

namespace Aula49
{
    class Mat
    {
        public static double PI = 3.14;

        public static int dobro(int n)
        {
            return n * 2;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            double vpi = Mat.PI;
            int num = 10;

            //Mat m1 = new Mat(); Não precisa fazer a instancia do objeto pois o metodo dobro esta  como static 

            Console.WriteLine(vpi);
            Console.WriteLine(Mat.dobro(num));
        }
    }
}

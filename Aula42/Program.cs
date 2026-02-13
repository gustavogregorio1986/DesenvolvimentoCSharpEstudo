using System;

namespace Aula41
{
    class Carro
    {
        private int[] velMax = new int[5] { 80, 120, 160, 240, 300 };

        public Carro()
        {
            
        }

        public int this[int i]
        {
            get
            {
                return velMax[i];
            }
            set
            {
                if (value < 0)
                {
                    this.velMax[i] = value;
                }
                else if (value > 300)
                {
                    velMax[i] = 300;
                }
                else
                {
                    velMax[i] = value;
                }
            }
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro[4] = 200;

            Console.WriteLine("Velocidade:{0}",carro[4]);
        }
    }
}

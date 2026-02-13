using System;

namespace Aula41
{
    class Carro {
        private int velMax;

        public Carro()
        {
            this.velMax = 120;
        }

        public int VM
        {
            get
            {
               return this.velMax;
            }
            set
            {
                if(value < 0)
                {
                    this.velMax = value;
                }else if (value > 300)
                {
                    velMax = 300;
                }
                else
                {
                    velMax = value;
                }
            }
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            carro.VM = 1;

            Console.WriteLine(carro.VM);
        }
    }
}

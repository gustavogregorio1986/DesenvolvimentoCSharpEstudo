using System;

namespace Aula37
{

    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da classe base");
        }
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe Derivada 1");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe Derivada 2");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Derivada2 derivada2 = new Derivada2();
            Console.WriteLine(derivada2);
        }
    }
}

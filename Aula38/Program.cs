using System;

namespace Aula38
{

    class Base
    {
        public Base()
        {
            Console.WriteLine("Construtor da classe base");
        }

        virtual public void info()
        {
            Console.WriteLine("base");
        }
    }

    class Derivada1 : Base
    {
        public Derivada1()
        {
            Console.WriteLine("Construtor da classe Derivada 1");
        }

        override public void info()
        {
            Console.WriteLine("Derivada 1");
        }
    }

    class Derivada2 : Derivada1
    {
        public Derivada2()
        {
            Console.WriteLine("Construtor da classe Derivada 2");
        }

        override public void info()
        {
            Console.WriteLine("Derivada 2");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Base Ref;
            Derivada1 derivada1 = new Derivada1();
            Derivada2 derivada2 = new Derivada2();
            Console.WriteLine(derivada2);
            derivada1.info();
            derivada2.info();
            Ref= derivada1;
            Ref.info();

            Ref = derivada2;
            Ref.info();
        }
    }
}

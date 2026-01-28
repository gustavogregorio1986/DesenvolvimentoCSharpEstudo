using System;

namespace Aula10
{
    public class Program
    {
        enum DiasSemanas { Domingo, Segunda, Terca, Quarta, Quinta, Sexta, Sabado };

        static void Main(string[] args)
        {
           DiasSemanas ds = DiasSemanas.Domingo;

           Console.WriteLine(ds);

            DiasSemanas ds1 = (DiasSemanas)3;

            Console.WriteLine(ds1);

            DiasSemanas ds2 = (DiasSemanas)0;

            Console.WriteLine(ds2);

        }
    
    }
}

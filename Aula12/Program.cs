using System;

namespace Aula12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SE (E_L{}
            //> m >= >= == !-

            int n1, n2, n3, n4, res;
            res=n1=n2=n3=n4=0;

            Console.WriteLine("Digite a nota 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");
            
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");
            
            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4: ");
            
            n4 = int.Parse(Console.ReadLine());
            string resultado = "Reprovado";

            res=n1+n2+n3+n4;

            if (res > 60){
                resultado = "Aprovado";
            }

            Console.WriteLine("Nota: {0} - Resultado:{1}", res, resultado);
        }
    }
}

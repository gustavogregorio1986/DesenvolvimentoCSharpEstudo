using System;

namespace Aula14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //SE (E_L{}
            //> m >= >= == !-

            int n1, n2, n3, n4, res;
            res = n1 = n2 = n3 = n4 = 0;

            Console.WriteLine("Digite a nota 1: ");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 2: ");

            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 3: ");

            n3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a nota 4: ");

            n4 = int.Parse(Console.ReadLine());
            string resultado;

            res = n1 + n2 + n3 + n4;

            //>- 60 - Aprovado
            // <=- 59 e 40 - Reprovado
            // <40 - Reprovado

            if (res >= 60)
            {
                if(res >= 90)
                {
                    resultado = "Aprovado com louvor";
                }
                else
                {
                    resultado = "Aprovado";
                }
            }
            else
            {
                if(res >= 40)
                {
                    if (res >= 99)
                    {
                        resultado = "Aprovado com super louvor";
                    }
                    else
                    {
                        resultado = "Recuperação";
                    }
                }
                else
                {
                    resultado = "Reprovado";
                }
            }


            Console.WriteLine("Nota: {0} - Resultado:{1}", res, resultado);
        }
    }
}

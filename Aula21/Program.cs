using System;

namespace Aula21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int num = 5;

            //do {
            //    Console.WriteLine("CFB Curso");
            //} while (num < 5);

            string senha = "123";
            string senhauser;
            int tentativas = 0;


            do {
                Console.Clear();
                Console.WriteLine("Digite a senha: ");
                senhauser = Console.ReadLine();
                tentativas++;
            } while (senha != senhauser);

            Console.Clear();
            Console.WriteLine("Senha Correta, tentativas: {0}", tentativas);
        }
    }
}

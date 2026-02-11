using System;

namespace Aula33
{
    class Jogador
    {
        public int energia;

        public string nome;

        public Jogador(string nome)
        {
            this.nome = nome;
            energia = 100;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Jogador j1 = new Jogador("Bruno");

            Console.WriteLine("Nome.....: {0}", j1.nome);
            Console.WriteLine("Energia..: {0} ", j1.energia);

        }
    }
}

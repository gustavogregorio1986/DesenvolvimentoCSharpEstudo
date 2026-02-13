using System;

namespace Aula36
{
    class Veiculo { //Base
        public int VelAtual;

        private int velMax;

        protected bool ligado;

        public Veiculo(int velMax)
        {
            VelAtual = 0;
            this.velMax = velMax;
            ligado = false;
        }

        public bool getLigado()
        {
            return ligado;
        }

        public int getVelMax()
        {
            return velMax;
        }
    }


    class Carro : Veiculo { //Derivada
        public string nome;
        public Carro(string nome, int vm) : base(vm)
        {
            this.nome = nome;
            ligado = true;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro("Bonitão", 120);

            Console.WriteLine("Nome.........:{0}",carro.nome);
            Console.WriteLine("VelMaxima....:{0}", carro.getVelMax());
            Console.WriteLine("Vel.Máxima{0}:{0}", carro.getLigado());
        }
    }
}

using System;

namespace Aula39
{
    abstract class Veiculo { // Classe base abstrata
        protected int VelMaxima;
        protected int VelAtual;
        protected bool ligado;
        public Veiculo()
        {
            ligado = false;
            VelAtual = 0;
        }

        public void setLigado(bool ligado)
        {
            this.ligado = ligado; 
        }

        public int getVelAtual()
        {
            return VelAtual;
        }

        abstract public void aceleracao(int mult);
    }

    class Carro : Veiculo
    {
        public Carro()
        {
            VelMaxima = 120;
        }

        public override void aceleracao(int mult)
        {
           VelAtual += 10*mult;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro();
            Console.WriteLine(carro);

            carro.aceleracao(1);
            carro.aceleracao(-1);

            Console.WriteLine(carro.getVelAtual());
        }
    }
}

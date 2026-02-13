using System;

namespace Aula43
{

    public interface Veiculo {
        void ligar();

        void desligar();

        void info();
    }

    public interface Combate
    {
        void disparar();
    }

    class Carro : Veiculo, Combate
    {
        public bool ligado;

        public int municao;

        public Carro()
        {
            setMunbicao(100);
        }

        public void setMunbicao(int qtde)
        {
            this.municao = qtde;
        }

        public void desligar()
        {
            this.ligado = false;
        }

        public void disparar()
        {
            
        }

        public void info()
        {
            
        }

        public void ligar()
        {
            this.ligado = true;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
           Carro carro = new Carro();
            Console.WriteLine(carro);
        }
    }
}

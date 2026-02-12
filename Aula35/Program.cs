using System;

namespace Aula35
{
    class Veiculo  //Classe Base
    {
        private int rodas;

        public int velMax;

        private bool ligado;

        public Veiculo(int rodas)
        {
            this.rodas = rodas;
        }

        public void ligar()
        {
            ligado = true;
        }

        public void desligar()
        {
            ligado = false;
        }

        public string getLigado()
        {
            return (ligado ? "sim" : "não");
        }

        public int getRodas()
        {
            return rodas; 
        }
    }

    class Carro : Veiculo
    {  //Clase derivado
        public string nome;
        public string cor;

        public Carro(string nome, string cor) :base(4)
        {
            desligar();
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }

    
    public class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Rapdão", "Vermelho");

            //c1.ligado = true;

            Console.WriteLine("Cor......: {0}", c1.cor);
            Console.WriteLine("Nome.....: {0}", c1.nome);
            Console.WriteLine("Rodas....: {0}", c1.getRodas());
            Console.WriteLine("Ve.Maxima: {0}", c1.velMax);
            Console.WriteLine("Ligado....:{0}", c1.getLigado());
        }
    }
}

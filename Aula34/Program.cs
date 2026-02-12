using System;

namespace Aula34
{
    class Veiculo  //Classe Base
    {
        public int rodas;
       
        public int velMax;

        public bool ligado;

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
            if (ligado)
            {
                return "sim";
            }
            else
            {
                return "não";
            }
        }
    }

    class Carro : Veiculo {  //Clase derivado
        public string nome;
        public string cor;

        public Carro(string nome, string cor)
        {
            desligar();
            rodas = 4;
            velMax = 120;
            this.nome = nome;
            this.cor = cor;
        }
    }


    public class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Rapdão","Vermelho");

            c1.ligado = true;

            Console.WriteLine("Cor......: {0}", c1.cor);
            Console.WriteLine("Nome.....: {0}", c1.nome);
            Console.WriteLine("Rodas....: {0}", c1.rodas);
            Console.WriteLine("Ve.Maxima: {0}", c1.velMax);
            Console.WriteLine("Ligado....:{0}", c1.getLigado());
        }
    }
}

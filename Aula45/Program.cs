using System;

namespace Aula45
{
    struct Carro
    {
        public string modelo;
        public string cor;

        public Carro(string modelo, string cor)
        {
            this.modelo = modelo;
            this.cor = cor;
        }

        public void info()
        {
            Console.WriteLine("Modelo:{0}", this.modelo);
            Console.WriteLine("Cor...: {0}", this.cor);

            Console.WriteLine("------------------------------------");
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {


            //Carro c1 = new Carro("Honda", "HRV", "Prata");

            //c1.marca = "VW";
            //c1.modelo = "Golf";
            //c1.cor = "Azul";

            int[] numeros = new int[10];


            Carro[] carros = new Carro[5];


            carros[0].modelo = "HRV";
            carros[0].cor = "Prata";

            carros[1].modelo = "Golf";
            carros[1].cor = "Azul";

            carros[2].modelo = "Jetta";
            carros[2].cor = "Branco";

            carros[3].modelo = "Jetta";
            carros[3].cor = "Branco";

            for(int i =0; i < carros.Length; i++)
            {
                carros[i].info();
            }
            
            //carros[0].info();
            //carros[1].info();
            //carros[2].info();
            //carros[3].info();
        }
    }
}

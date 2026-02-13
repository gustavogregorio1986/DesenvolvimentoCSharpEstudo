using System;

namespace Aula44
{
    struct Carro
    {
        public string marca;
        public string modelo;
        public string cor;

        public Carro(string marca, string modelo, string cor)
        {
            this.marca = marca;
            this.modelo = modelo;
            this.cor = cor;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            Carro c1 = new Carro("Honda", "HRV", "Prata");

            //c1.marca = "VW";
            //c1.modelo = "Golf";
            //c1.cor = "Azul";

            Console.WriteLine("Marca.: {0}", c1.marca);
            Console.WriteLine("Modelo:{0}", c1.modelo);
            Console.WriteLine("Cor...: {0}", c1.cor);

        }
    }
}

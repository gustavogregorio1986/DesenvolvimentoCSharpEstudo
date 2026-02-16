using System;
using System.Collections.Generic;
using System.Linq;

namespace Aula55
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> veiculos = new Dictionary<int, string>();

            veiculos.Add(10, "Carro");
            veiculos.Add(5, "Aviao");
            veiculos.Add(0, "Navio");
            veiculos.Add(20, "Moto");
            veiculos.Add(15, "Patinete");

            //veiculos.Clear(); Antes dele chamar o count , ele limpou os valors do dicionário, por isso o count é 0
            Console.WriteLine("Tamanho do Dictionary: {0}", veiculos.Count);

            int chave = 22;
            if (veiculos.ContainsKey(chave))
            {
                Console.WriteLine("A chave {0} esta na coleção", chave);
            }
            else
            {
                Console.WriteLine("A chave {0} não esta na coleção", chave);
            }

            string valor = "Navio";
            if (veiculos.ContainsValue(valor))
            {
                Console.WriteLine("O valor {0} esta na coleção", valor);
            }
            else
            {
                Console.WriteLine("O valor {0} não esta na coleção", valor);
            }



            valor = "Bicicleta";
            if (veiculos.ContainsValue(valor))
            {
                Console.WriteLine("O valor {0} esta na coleção", valor);
            }
            else
            {
                Console.WriteLine("O valor {0} não esta na coleção", valor);
            }

            veiculos.Remove(20);

            chave = 20;
            if (veiculos.ContainsKey(chave))
            {
                Console.WriteLine("A chave {0} esta na coleção", chave);
            }
            else
            {
                Console.WriteLine("A chave {0} não esta na coleção", chave);
            }

            veiculos[15] = "Bicicleta";

            valor = "Bicicleta";
            if (veiculos.ContainsValue(valor))
            {
                Console.WriteLine("O valor {0} esta na coleção", valor);
            }
            else
            {
                Console.WriteLine("O valor {0} não esta na coleção", valor);
            }

            //Dictionary<int, string>.ValueCollection va = veiculos.Values;

            //foreach (KeyValuePair<int, string> va in veiculos)
            //{
             //   Console.WriteLine(va.Key);
            //}

            Dictionary<int, string>.ValueCollection valores = veiculos.Values;

            foreach (string v in valores)
            {
                Console.WriteLine(v);
            }
        }
    }
}

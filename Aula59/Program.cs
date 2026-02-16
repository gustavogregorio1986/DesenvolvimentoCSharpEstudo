using System;
using System.Collections;
using System.Collections.Generic;

namespace Aula59
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] vs = {"Carro","Moto","Navio","Aviao"};
            //Queue<string> veiculos = new Queue<string>(v);
            Queue<string> veiculos = new Queue<string>();

            veiculos.Enqueue("Carro");
            veiculos.Enqueue("Moto");
            veiculos.Enqueue("Navio");
            veiculos.Enqueue("Aviao");

            //string v = "Patinete";
            //if (veiculos.Contains(v))
            //{
            //    Console.WriteLine("Veiculo " + v + " encontrado");
            //}
            //else
            //{
            //    Console.WriteLine("Veiculo " + v + " não esta na fila  encontrado");
            //}

            //veiculos.Clear();
            //Console.WriteLine("Primeiro Veiculo " + veiculos.Dequeue());
            //Console.WriteLine("Primeiro Veiculo " + veiculos.Peek());
            //Console.WriteLine("Tamanho Fila: " + veiculos.Count);

            foreach (string v in veiculos)
            {
                veiculos.Dequeue();
                Console.WriteLine("Veiculo removido: " + v);
            }
        }
    }
}

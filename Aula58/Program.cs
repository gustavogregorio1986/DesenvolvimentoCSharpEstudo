using System;
using System.Collections.Generic;

namespace Aula58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> carros = new List<string>();
            List<string> carros2 = new List<string>();
            string[] carros3 = new string[4];

            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");

            carros2.AddRange(carros);

            //carros.Clear();
            //carros.Clear();

            if (carros.Contains("Gol"))
            {
                Console.WriteLine("Esta na lista");
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }

            carros.CopyTo(carros3, 2);

            foreach (string c in carros)
            {
                Console.WriteLine("Carro: {0}", c);
            }

            Console.WriteLine("Mesma lista");

            foreach (string c in carros2)
            {
                Console.WriteLine("Carro: {0}", c);
            }
        }
    }
}

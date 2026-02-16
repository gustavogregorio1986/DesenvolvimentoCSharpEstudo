using System;
using System.Collections.Generic;

namespace Aula56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> transp = new LinkedList<string>();

            transp.AddFirst("Carro");
            transp.AddFirst("Aviao");
            transp.AddFirst("Navio");
            transp.AddFirst("Motocicleta");

            transp.AddLast("Bicicleta");

            LinkedListNode<string> no;
            no = transp.FindLast("Navio");
            transp.AddAfter(no,"Patinete");
            no = transp.FindLast("Navio");
            transp.AddBefore(no, "Patins");

            //transp.Clear();
            if(transp.Find("Carro")==null)
            {
                Console.WriteLine("Não encontrado");
            }
            else
            {
                Console.WriteLine("Elemento encontrado");
            }


            foreach (string t in transp)
            {
                Console.WriteLine("Transporte: {0}", t);
            }

            //transp.Remove("Navio");
            //Console.WriteLine("Removido o Navio");

            transp.RemoveFirst(); // Remove o primeiro
            transp.RemoveLast(); //Remove o ultimo
        }
    }
}

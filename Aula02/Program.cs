using System;

namespace Aula02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            args = new string[] { "CPB Cursos" };
            if(args.GetLength(0) > 0)
            {
                Console.Write(args.GetValue(0));
            }
        }
    }
}

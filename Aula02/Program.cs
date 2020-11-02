using System;

namespace aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá Mundo!");
            if (args.GetLength(0) > 0 )
            {
                Console.Write(args.GetValue(0));

            }
        }
    }
}

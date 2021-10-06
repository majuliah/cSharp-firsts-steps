using System;

namespace Resto2_1075
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Entre com um número");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 1000; i++)
            {
                if (i % numero == 2)
                    Console.WriteLine(i);
            }
        }
    }
}
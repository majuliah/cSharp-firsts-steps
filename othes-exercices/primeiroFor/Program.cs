using System;

namespace primeiroFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, x, soma = 0;
            Console.WriteLine("Entre com um número");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
               x = int.Parse(Console.ReadLine());
               soma += x;
            }

            Console.WriteLine($"A soma é {soma}");
            Console.WriteLine(' ');
        }
    }
}
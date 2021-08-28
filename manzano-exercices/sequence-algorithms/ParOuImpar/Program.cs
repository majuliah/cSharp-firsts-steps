using System;

namespace ParOuImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Entre com um número");
            numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
            {
                Console.WriteLine("Número é par!");
            }
            else
            {
                Console.WriteLine("Número ímpar!");
            }
        }
    }
}
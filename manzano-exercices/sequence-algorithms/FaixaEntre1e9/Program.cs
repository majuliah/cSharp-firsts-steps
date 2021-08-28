using System;

namespace FaixaEntre1e9
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Entre com um número");
            numero = int.Parse(Console.ReadLine());

            if (numero >= 1 && numero <= 9)
            {
                Console.WriteLine("O número está na faixa!");
            }
            else
            {
                Console.WriteLine("O número está fora da faixa.");
            }
        }
    }
}
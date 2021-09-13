using System;
using System.IO;

namespace Teste2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros, soma = 0;

            Console.WriteLine("Entre com um número");
            numeros = int.Parse(Console.ReadLine());

            while (numeros != 0)
            {
                soma = soma + numeros;
                numeros = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A soma dos números é: {soma}");
        }
    }
}
using System;

namespace ResultadoMaiorQue30
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, multiplicaPorDois;
            Console.WriteLine("Entre com um número");

            numero = int.Parse(Console.ReadLine());
            multiplicaPorDois = numero * 2;

            if (multiplicaPorDois >= 30)
            {
                Console.WriteLine($"O resultado é {multiplicaPorDois}");
            }
            else
            {
                Console.WriteLine("O resultado é menor que 30");
            }

        }
    }
}
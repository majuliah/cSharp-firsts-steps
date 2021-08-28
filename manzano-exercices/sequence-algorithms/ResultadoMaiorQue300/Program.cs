using System;

namespace ResultadoMaiorQue300
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros;
            double num1, num2, num3, soma;
            Console.WriteLine("Entre com 3 números");

            numeros = Console.ReadLine().Split(' ');
            num1 = double.Parse(numeros[0]);
            num2 = double.Parse(numeros[1]);
            num3 = double.Parse(numeros[2]);

            soma = num1 + num2 + num3;

            if (soma >= 100)
            {
                Console.WriteLine($"A soma é {soma}");
            }
            else
            {
                Console.WriteLine("Soma menor que 100");
            }
        }
    }
}
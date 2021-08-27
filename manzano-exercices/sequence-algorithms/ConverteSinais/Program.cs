using System;

namespace ConverteSinais
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;
            Console.WriteLine("Entre com um número inteiro");

            numero = int.Parse(Console.ReadLine());

            if (numero < 0)
            {
                resultado = numero * (-1);
                Console.WriteLine($"O número convertido é: {resultado}");
            }
            else
            {
                Console.WriteLine("Número positivo!");
            }
        }
    }
}
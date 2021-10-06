using System;
using System.Globalization;

namespace DividindoXporY1116
{
    class Program
    {
        static void Main(string[] args)
        {
            int vezes;
            double divisao, numero1, numero2;
            string[] numeros;
            Console.WriteLine("Escreva quantas vezes deseja fazer divisões:" );
            vezes = int.Parse(Console.ReadLine());

            for (int i = 0; i < vezes; i++)
            {
                Console.WriteLine("Entre com X e Y");
                numeros = Console.ReadLine().Split(' ');
                numero1 = int.Parse(numeros[0]);
                numero2 = int.Parse(numeros[1]);
                
                if (numero2 == 0)
                {
                    Console.WriteLine("Divisão impossível");
                }
                else
                {
                    divisao = numero1 / numero2;
                    Console.WriteLine($"Resultado: {divisao.ToString("F1", CultureInfo.InvariantCulture)}");
                }
            }
        }
    }
}
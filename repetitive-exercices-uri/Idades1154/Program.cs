using System;
using System.Globalization;

namespace Idades1154
{
    class Program
    {
        static void Main(string[] args)
        {
            double media, idade, contador = 0.0, soma = 0.0;
            
            Console.WriteLine("Entre com idades");

            idade = int.Parse(Console.ReadLine());

            while (idade > 0)
            {
                contador += 1.0;
                soma += idade;
                idade = int.Parse(Console.ReadLine());
            }

            media = soma / contador;
            Console.WriteLine($"A mpedia das idades é: {media.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
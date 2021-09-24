using System;
using System.Globalization;

namespace PositivosEmedia1064
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeros = 0.0, media, positivos = 0.0, cont = 0.0;
            Console.WriteLine("Entre com 6 números");
            for (int i = 0; i <= 5; i++)
            {
                numeros = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                if (numeros > 0)
                {
                    positivos = positivos + numeros;
                    cont += 1;
                }
            }

            Console.WriteLine($"{cont} valores positivos");
            media = positivos / cont;
            Console.WriteLine($"A média é {media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
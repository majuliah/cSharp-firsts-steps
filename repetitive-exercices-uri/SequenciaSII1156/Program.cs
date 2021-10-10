using System;
using System.Globalization;

namespace SequenciaSII1156
{
    class Program
    {
        static void Main(string[] args)
        {
            double soma = 0.0, den = 1.0;
            for (int num = 1; num <= 39; num *= 2)
            {
                den += 2;
                soma += num / den;
            }

            Console.WriteLine($"A soma é: {soma.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
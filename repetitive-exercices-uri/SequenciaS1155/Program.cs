using System;
using System.Globalization;

namespace SequenciaS1155
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            double soma = 0;

            for (int i = 1; i <= 100; i++)
            {
                soma += (1.0 / i);
            }
            Console.WriteLine($"A soma foi {soma.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
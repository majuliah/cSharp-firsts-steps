using System;
using System.Globalization;

namespace ConverteRealParaDolar
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar, conversaoRealParaDolar;
            Console.WriteLine("Entre com o valor em reais para ser convertido para dólar");
            real = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            dolar = 5.20;

            conversaoRealParaDolar = real / dolar;

            Console.WriteLine("Você pode comprar " + conversaoRealParaDolar.ToString("F2", CultureInfo.InvariantCulture) + "$ dólares");
        }
    }
}

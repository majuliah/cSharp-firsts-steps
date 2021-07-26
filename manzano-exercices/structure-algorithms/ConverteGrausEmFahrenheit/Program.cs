using System;
using System.Globalization;

namespace ConverteGrausEmFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double temperaturaCelcius, temperaturaFahrenheit;
            Console.WriteLine("Entre com a temperatura em Celcius");
            temperaturaCelcius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            temperaturaFahrenheit = (9 * temperaturaCelcius + 160) / 5;

            Console.WriteLine("A temperatura convertida é: " + temperaturaFahrenheit.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}

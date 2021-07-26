using System;
using System.Globalization;

namespace FahrenheitParaCelcius
{
    class Program
    {
        static void Main(string[] args)
        {
            double grausFahrenheit, grausCelcius;
            Console.WriteLine("Entre com a temperatura em Fahrenheit");
            grausFahrenheit = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            grausCelcius = ((grausFahrenheit - 32) * 5) / 9;
            Console.WriteLine("A temperatura convertida para celcius é: " + grausCelcius.ToString("F1",CultureInfo.InvariantCulture) + "º celcius");
        }
    }
}

using System;
using System.Globalization;

namespace CalcularVolumeLataOleo
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, altura, raio, PI;
            PI = 3.14159;
            Console.WriteLine("Entre com o raio e a altura");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = PI * Math.Pow(raio, 2) * altura;

            Console.WriteLine("O volume da lata de óleo é: " + volume.ToString("F1", CultureInfo.InvariantCulture) + "L.");
            
        }
    }
}

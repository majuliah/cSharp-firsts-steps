using System;
using System.Globalization;

namespace CalculoVolumeEsfera
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, raio, PI;
            PI = 3.14159;
            Console.WriteLine("Entre com o valor do raio para calcular o volume da esfera");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = (4.0 / 3) * PI * Math.Pow(raio, 3);

            Console.WriteLine("O volume da esfera é: " + volume.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

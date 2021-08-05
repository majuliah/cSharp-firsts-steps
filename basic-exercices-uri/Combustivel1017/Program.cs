using System;
using System.Globalization;

namespace Combustivel1017
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempo, velocidade, kml;
            double litros;
            kml = 12;
            Console.WriteLine("Entre com o tempo e a velocidade");
            tempo = double.Parse(Console.ReadLine());
            velocidade = double.Parse(Console.ReadLine());

            litros = (tempo * velocidade) / kml;

            


            Console.WriteLine(litros.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}

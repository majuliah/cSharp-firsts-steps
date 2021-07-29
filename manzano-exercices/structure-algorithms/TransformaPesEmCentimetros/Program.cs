using System;
using System.Globalization;

namespace TransformaPesEmCentimetros
{
    class Program
    {
        static void Main(string[] args)
        {
            double pes, centimetros, resultado;
            Console.WriteLine("Entre com o tamanho em pés para ser convertido para centímetros");
            centimetros = 30.48;
            pes = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = pes * centimetros;

            Console.WriteLine("A conversão de " + pes + " para centímetros é: " + resultado.ToString("F2",CultureInfo.InvariantCulture) +" cms");
        }
    }
}

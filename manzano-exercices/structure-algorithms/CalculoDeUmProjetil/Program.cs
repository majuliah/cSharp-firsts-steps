using System;
using System.Globalization;

namespace CalculoDeUmProjetil
{
    class Program
    {
        static void Main(string[] args)
        {
            double velocidade;
            int tempo, distancia;
            Console.WriteLine("Entre com o tempo e distância");
            tempo = int.Parse(Console.ReadLine());
            distancia = int.Parse(Console.ReadLine());

            velocidade = (distancia * 1000) / (tempo * 60);

            Console.WriteLine("A distância percorrida pelo projétil foi de " + velocidade.ToString(CultureInfo.InvariantCulture) + "m/s.");
        }
    }
}

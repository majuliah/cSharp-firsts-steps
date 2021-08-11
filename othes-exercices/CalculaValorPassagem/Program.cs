using System;
using System.Globalization;

namespace CalculaValorPassagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com a distância de sua viagem");
            int distancia = int.Parse(Console.ReadLine());
            double valorPassagem;

            if(distancia <= 200)
            {
                valorPassagem = distancia * 0.50;
                Console.WriteLine("O valor da passagem é: R$" + valorPassagem.ToString("F2", CultureInfo.InvariantCulture));
            } else
            {
                valorPassagem = distancia * 0.45;
                Console.WriteLine("O valor da passagem é: R$" + valorPassagem.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}

using System;
using System.Globalization;

namespace CombustivelGastoNaViagem
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempoGasto, velocidadeMedia, distancia, litrosUsados;
            Console.WriteLine("Entre com o tempo gasto e com a velocidade média");
            tempoGasto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            velocidadeMedia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            distancia = tempoGasto * velocidadeMedia;
            litrosUsados = distancia / 12;

            Console.WriteLine("O tempo gasto foi de " + tempoGasto + " e a velocidade média foi de ", + velocidadeMedia);
            Console.WriteLine("Portanto, a distância percorrida foi de: " + distancia + " e o total de litros usados foi: " + litrosUsados.ToString(CultureInfo.InvariantCulture));
        }
    }
}

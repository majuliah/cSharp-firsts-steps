using System;
using System.Globalization;

namespace VolumeCaixaRetangular
{
    class Program
    {
        static void Main(string[] args)
        {
            double volume, comprimento, largura, altura;
            Console.WriteLine("Entre com o comprimento, largura e altura de uma caixa retangular");
            comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = comprimento * largura * altura;

            Console.WriteLine("O volume da caixa retangular é: " + volume.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

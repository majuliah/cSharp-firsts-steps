using System;
using System.Globalization;

namespace QuadradoDaDivisao
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2, resultado;
            Console.WriteLine("Entre com dois valores reais");
            numero1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            numero2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            resultado = Math.Pow(numero1 / numero2, 2);

            Console.WriteLine("O quadrado da divisão entre " + numero1 + " e " + numero2 + " é " + resultado.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

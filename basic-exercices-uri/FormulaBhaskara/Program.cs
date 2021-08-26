using System;
using System.Globalization;

namespace FormulaBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            double valorA, valorB, valorC, x1, x2, delta, div, raiz;
            Console.WriteLine("Entre com três valores!");

            valores = Console.ReadLine().Split(' ');
            valorA = double.Parse(valores[0], CultureInfo.InvariantCulture);
            valorB = double.Parse(valores[1], CultureInfo.InvariantCulture);
            valorC = double.Parse(valores[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(valorB, 2) - (4 * valorA * valorC);
            raiz = Math.Sqrt(delta);
            div = (2 * valorA);

            if (raiz > 0 && div > 0)
            {
                x1 = (-valorB + raiz) / div;
                x2 = (-valorB - raiz) / div;
                Console.WriteLine($"{x1} X1 e {x2} X2");
            }
            else
            {
                Console.WriteLine("Ímpossível Calcular");
                
            }

        }
    }
}

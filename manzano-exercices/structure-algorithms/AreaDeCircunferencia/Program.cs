using System;
using System.Globalization;

namespace AreaDeCircunferencia
{
    class Program
    {
        static void Main(string[] args)
        {
            double PI, raio, area;
            PI = 3.14159265;
            Console.WriteLine("Entre com o valor do raio da circunferência");
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            area = PI * Math.Pow(raio, 2);

            Console.WriteLine("A área da circunferência é de: " + area.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

using System;
using System.Globalization;

namespace Esphere1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double R, PI, ray;
            PI = 3.141559;

            Console.WriteLine("Please, enter with a number for R");
            R = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            ray = (4.0 / 3) * PI * Math.Pow(R, 3);

            Console.WriteLine("The ray is: " + ray.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}

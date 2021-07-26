using System;
using System.Globalization;

namespace DistanceBetweenTwoDots1015
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1, x2, y1, y2, distance;

            Console.WriteLine("Please, enter with two numbers");
            string[] values = Console.ReadLine().Split(' ');
            x1 = double.Parse(values[0], CultureInfo.InvariantCulture);
            y1 = double.Parse(values[1], CultureInfo.InvariantCulture);

            Console.WriteLine("Enter with other two numbers");
            values = Console.ReadLine().Split(' ');
            x2 = double.Parse(values[0], CultureInfo.InvariantCulture);
            y2 = double.Parse(values[1], CultureInfo.InvariantCulture);

            distance = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));
            //raiz     //elevado

            Console.WriteLine("The distance between two dots is: " + distance.ToString("F4", CultureInfo.InvariantCulture));

        }
    }
}

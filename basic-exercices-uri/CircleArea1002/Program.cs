using System;
using System.Globalization;

namespace CircleArea1002
{
    class Program
    {
        static void Main(string[] args)
        {
            double radius, piNumber, area;
            int two = 2;
            piNumber = 3.14159;

            Console.WriteLine("Please, enter with the radius of the cicle");
            radius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            area = piNumber * (Math.Pow(radius, two));

            Console.WriteLine("The cicle area is: " + area.ToString("F4", CultureInfo.InvariantCulture));
        }
    }
}

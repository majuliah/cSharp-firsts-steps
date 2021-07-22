using System;
using System.Globalization;

namespace Area1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, areaTriangle, areaCircle, areaTrapeze, areaSquare, areaRectangle, PI;
            PI = 3.14159;
            Console.WriteLine("Please, enter with three values for A, B and C");
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            areaTriangle = (A * C)/2;
            areaCircle = Math.Pow(C,2) * PI; 
            areaTrapeze = ((A + B) * C) / 2;
            areaSquare = Math.Pow(B, 2);
            areaRectangle = (A * B);

            Console.WriteLine("Triangle = " + areaTriangle.ToString("F3", CultureInfo.InvariantCulture) + Environment.NewLine + "Circle = " + areaCircle.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("Trapeze = " + areaTrapeze.ToString("F3", CultureInfo.InvariantCulture) + Environment.NewLine + "Square = " + areaSquare.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("And the Rectangle = " + areaRectangle.ToString("F3", CultureInfo.InvariantCulture));







        }
    }
}

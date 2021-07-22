using System;
using System.Globalization;

namespace TheBigest1013
{
    class Program
    {
        static void Main(string[] args)
        {
            double value1, value2, value3, bigestAB, bigestABC;
            Console.WriteLine("Enter with three numbers");
            value1 = double.Parse(Console.ReadLine());
            value2 = double.Parse(Console.ReadLine());
            value3 = double.Parse(Console.ReadLine());

            bigestAB = (value1 + value2 + Math.Abs(value1 - value2)) / 2;
            bigestABC = (bigestAB + value3 + Math.Abs(bigestAB - value3)) / 2;

            Console.WriteLine("The result is: " + bigestABC.ToString("F1", CultureInfo.InvariantCulture));

            
        }
    }
}

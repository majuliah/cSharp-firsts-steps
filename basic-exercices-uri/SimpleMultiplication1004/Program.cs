using System;
using System.Globalization;

namespace SimpleMultiplication1004
{
    class Program
    {
        static void Main(string[] args)
        {
            double number1, number2, result;

            Console.WriteLine("Please, enter with two float numbers");
            number1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            number2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            result = number1 * number2;

            Console.WriteLine("The result betwen the multiplication is: " + result.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

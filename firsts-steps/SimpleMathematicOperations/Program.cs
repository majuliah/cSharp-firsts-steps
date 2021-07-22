using System;
using System.Globalization;

namespace SimpleMathematicOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3;
            double number4, number5, add, subtract, multiply, divide;

            Console.WriteLine("Please, enter with 3 integer numbers");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Now with other 2 doubles");
            number4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            number5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            add = number1 + number5;
            subtract = number3 - number4;
            multiply = number4 * number5;
            divide = (number2 / number3);

            Console.WriteLine("The results are: " + Environment.NewLine + "add = " + add + Environment.NewLine + "subtract = " + subtract);
            Console.WriteLine("multiply = " + multiply + Environment.NewLine + "and the divide = " + divide.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

using System;

namespace ExtremamenteBasico1001
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1, value2, result;

            Console.WriteLine("Please, enter with two integer numbers");
            value1 = int.Parse(Console.ReadLine());
            value2 = int.Parse(Console.ReadLine());
            result = value1 + value2;

            Console.WriteLine("The result betwen the sum of the numbers is: " + result);

        }
    }
}

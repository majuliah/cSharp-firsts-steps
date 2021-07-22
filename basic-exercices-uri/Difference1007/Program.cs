using System;

namespace Difference1007
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2, number3, number4, difference;

            Console.WriteLine("Hello, please enter with four integer numbers");
            number1 = int.Parse(Console.ReadLine());
            number2 = int.Parse(Console.ReadLine());
            number3 = int.Parse(Console.ReadLine());
            number4 = int.Parse(Console.ReadLine());

            difference = (number1 * number2) - (number3 * number4);

            Console.WriteLine("The difference betwen (number1 * number2) and (number3 * number4) is: " + difference);


        }
    }
}

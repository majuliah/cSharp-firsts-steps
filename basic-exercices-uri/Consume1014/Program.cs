using System;
using System.Globalization;

namespace Consume1014
{
    class Program
    {
        static void Main(string[] args)
        {
            int kilometers;
            double money, consume;

            Console.WriteLine("Enter with the distance and the fue/value");
            kilometers = int.Parse(Console.ReadLine());
            money = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            consume = (kilometers / money);

            Console.WriteLine("Result is: " + consume.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}

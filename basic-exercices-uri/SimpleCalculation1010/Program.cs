using System;
using System.Globalization;

namespace SimpleCalculation1010
{
    class Program
    {
        static void Main(string[] args)
        {
            int codePeace1, codePeace2, numberPeaces1, numberPeaces2;
            double valuePeace1, valuePeace2, total;

            Console.WriteLine("Please. Enter with a code, number of unitys and the value of a peace");
            string[] peaces = Console.ReadLine().Split(' ');
            codePeace1 = int.Parse(peaces[0]);
            numberPeaces1 = int.Parse(peaces[1]);
            valuePeace1 = double.Parse(peaces[2], CultureInfo.InvariantCulture);

            Console.WriteLine("Now enter with the same informations for a secon peace.");
            peaces = Console.ReadLine().Split(' ');
            codePeace2 = int.Parse(peaces[0]);
            numberPeaces2 = int.Parse(peaces[1]);
            valuePeace2 = double.Parse(peaces[2], CultureInfo.InvariantCulture);

            total = (numberPeaces1 * valuePeace1) + (numberPeaces2 * valuePeace2);

            Console.WriteLine("The total of peaces is: " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

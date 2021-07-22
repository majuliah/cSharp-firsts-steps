using System;
using System.Globalization;

namespace Average02_1006
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNote, secondNote, thirdNote, weightFirstNote, weightSecondNote, weightThirdNote, weightSum, average;
            weightFirstNote = 2.0;
            weightSecondNote = 3.0;
            weightThirdNote = 5.0;
            weightSum = 10.0;

            Console.WriteLine("Enter with your three notes");
            firstNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            secondNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            thirdNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            average = ((firstNote * weightFirstNote) +
                        (secondNote * weightSecondNote) + 
                         (thirdNote * weightThirdNote)) / weightSum;

            Console.WriteLine("The average of your three notes is: " +  average.ToString("F1", CultureInfo.InvariantCulture));
        }
    }
}

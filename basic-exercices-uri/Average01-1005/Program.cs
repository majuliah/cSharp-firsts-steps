using System;
using System.Globalization;

namespace Average01_1005
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNote, secondNote, average, weightFirstNote, weightSecondNote, weightSum;
            weightFirstNote = 3.5;
            weightSecondNote = 7.5;
            weightSum = 11;

            Console.WriteLine("Please, enter with your first and your second school note");
            firstNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            secondNote = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            average = ((firstNote * weightFirstNote) + (secondNote * weightSecondNote)) / weightSum;

            Console.WriteLine("The average of your notes is " + average.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

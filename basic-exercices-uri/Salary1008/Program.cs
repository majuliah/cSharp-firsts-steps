using System;
using System.Globalization;

namespace Salary1008
{
    class Program
    {
        static void Main(string[] args)
        {
            int idEmployee, hoursWorked;
            double valueHour, totalSalary;

            Console.WriteLine("Please, enter with an emplyee id, the total hours worked and the value hour");

            idEmployee = int.Parse(Console.ReadLine());
            hoursWorked = int.Parse(Console.ReadLine());
            valueHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            totalSalary = (hoursWorked * valueHour);

            Console.WriteLine("The employee of id: " + idEmployee + "have worked for " + hoursWorked + " and the final salary is: R$" + totalSalary.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}

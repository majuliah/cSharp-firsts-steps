using System;
using System.Globalization;

namespace SalaryWithBonus1009
{
    class Program
    {
        static void Main(string[] args)
        {
            string employeeName;
            double employeeFixSalary, finalSalary,totalSale;


            Console.WriteLine("Please, enter with a name, the fix salary and the total of sele made");
            employeeName = Console.ReadLine();
            employeeFixSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            totalSale = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            finalSalary = employeeFixSalary + (totalSale * 0.15);

            Console.WriteLine("The employee " + employeeName + " made a sale of " + totalSale + " and the salary gonna be R$" + finalSalary.ToString("F2", CultureInfo.InvariantCulture));
        
        }
    }
}

using System;
using System.Globalization;

namespace ReajustaSalarioMensal
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, salarioReajustado, valorReajuste;
            Console.WriteLine("Entre com o valor do seu salário e o valor do reajuste");
            salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorReajuste = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salarioReajustado = salario + (salario * (valorReajuste / 100));

            Console.WriteLine("O valor do reajuste é: " + salarioReajustado.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

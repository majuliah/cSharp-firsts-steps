using System;
using System.Globalization;

namespace CalculaReajuste
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste;
            int anos;
            Console.WriteLine("Entre com o seu nome, seu salário e quantos anos está na empresa");
            string[] funcionario = Console.ReadLine().Split(' ');
            string nome = funcionario[0];
            salario = double.Parse(funcionario[1], CultureInfo.InvariantCulture);
            anos = int.Parse(funcionario[2]);

            if (anos <= 3)
            {
                reajuste = (salario * (3.0 / 100)) + salario;
                Console.WriteLine($"{nome}, o seu novo salário será R${reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
            } else if ( anos > 3 & anos <= 10)
            {
                reajuste = (salario * (12.5 / 100)) + salario;
                Console.WriteLine($"{nome}, o seu novo salário será R${reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
            } else
            {
                reajuste = (salario * (20.0 / 100)) + salario;
                Console.WriteLine($"{nome}, seu novo salário será de R${reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}

using System;
using System.Globalization;

namespace ReajusteSalario
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario, reajuste;
            int anos;
            char genero;
            Console.WriteLine("Entre com o salário, gênero e quantos anos está na empresa");

            string[] funcionario = Console.ReadLine().Split(' ');
            salario = double.Parse(funcionario[0], CultureInfo.InvariantCulture);
            genero = char.Parse(funcionario[1]);
            anos = int.Parse(funcionario[2]);

            switch (genero)
            {
                case 'F':
                    if(anos < 15)
                    {
                        reajuste = (salario * (5 / 100)) + salario;
                        Console.WriteLine($"Seu salário será reajustado para R${reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                    } else if (anos >= 15 & anos <= 20)
                    {
                        reajuste = (salario * (12 / 100)) + salario;
                        Console.WriteLine($"Seu salário será reajustado para R${reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                    } else
                    {
                        reajuste = (salario * (20 / 100)) + salario;
                        Console.WriteLine($"Seu salário será reajustado para R${reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    break;

                case 'M':
                    if (anos < 20)
                    {
                        reajuste = (salario * (3 / 100)) + salario;
                        Console.WriteLine($"Seu salário será reajustado para R${reajuste.ToString("F2", CultureInfo.InvariantCulture)}");

                    }
                    else if (anos >= 20 & anos < 30)
                    {
                        reajuste = (salario * (13 / 100)) + salario;
                        Console.WriteLine($"Seu salário será reajustado para R${reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    else
                    {
                        reajuste = (salario * (25 / 100)) + salario;
                        Console.WriteLine($"Seu salário será reajustado para R${reajuste.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    break;
                default:
                    Console.WriteLine("Gênero não identificado");
                    break;
            }
        }
    }
}

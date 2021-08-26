using System;
using System.Globalization;

namespace DiferencaMaiorPorMenor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros;
            double numero1, numero2, resultado;
            Console.WriteLine("Entre com dois números");
            numeros = Console.ReadLine().Split(' ');
            numero1 = double.Parse(numeros[0], CultureInfo.InvariantCulture);
            numero2 = double.Parse(numeros[1], CultureInfo.InvariantCulture);

            if (numero1 > numero2)
            {
                resultado = numero1 - numero2;
                Console.WriteLine($"O numero {numero1} menos o número {numero2} é igual a {resultado}.");
            }else
            {
                resultado = numero2 - numero1;
                Console.WriteLine($"O numero {numero2} menos o número {numero1} é igual a {resultado}.");
            }

            
        }
    }
}
using System;
using System.Globalization;

namespace CalculaIMC
{
    class Program
    {
        static void Main(string[] args)
        {
            double altura, peso, calculoImc;
            Console.WriteLine("Entre com sua altura e peso");
            string[] imc = Console.ReadLine().Split(' ');
            altura = double.Parse(imc[0], CultureInfo.InvariantCulture);
            peso = double.Parse(imc[1], CultureInfo.InvariantCulture);

            calculoImc = peso / (Math.Pow(altura, 2));

            if (calculoImc < 18.5)
            {
                Console.WriteLine("Abaixo do peso!");
            } else if (calculoImc >= 18.5 & calculoImc <= 25.0)
            {
                Console.WriteLine("Peso ideal!");
            } else if (calculoImc > 25.0 & calculoImc <= 30.0)
            {
                Console.WriteLine("Sobrepeso!");
            } else if (calculoImc > 30.0 & calculoImc <= 40.0)
            {
                Console.WriteLine("Acima do peso!");
            } else
            {
                Console.WriteLine("Obesidade Mórbida!");
            }
            Console.WriteLine($"Seu imc é {calculoImc}");
        }
    }
}

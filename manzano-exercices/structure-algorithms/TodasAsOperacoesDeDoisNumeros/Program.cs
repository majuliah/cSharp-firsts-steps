using System;
using System.Globalization;

namespace TodasAsOperacoesDeDoisNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, soma, subtracao, divisao, multiplicacao;
            Console.WriteLine("Entre com dois numeros reais");
            num1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            num2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            soma = num1 + num2;
            subtracao = num1 - num2;
            divisao = num1 / num2;
            multiplicacao = num1 * num2;

            Console.WriteLine("Soma é: " + soma.ToString("F2", CultureInfo.InvariantCulture) + " e a subtração é: " + subtracao.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Divisão é: " + divisao.ToString("F2", CultureInfo.InvariantCulture) + " e multiplicação é: " + multiplicacao.ToString(CultureInfo.InvariantCulture));

        }
    }
}

using System;
using System.Globalization;

namespace PrestacaoBemAtrasado
{
    class Program
    {
        static void Main(string[] args)
        {
            double valor, prestacao, taxa;
            int tempo;

            Console.WriteLine("Entre com o tempo da dívida e com o valor e taxa para pagar.");
            tempo = int.Parse(Console.ReadLine());
            valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            taxa = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            prestacao = valor + (valor * (taxa / 100) * tempo);

            Console.WriteLine("O valor da prestação é: " + prestacao);

        }
    }
}

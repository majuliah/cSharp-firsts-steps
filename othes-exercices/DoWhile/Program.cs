using System;
using System.Globalization;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversão de Celcius para Farenheit!");
            double celcius, farenheit;
            char resposta = 's';
            
            do
            {
                Console.WriteLine("Entre com a temperatura em celcius: ");
                celcius = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                farenheit = (9 * celcius) / 5 + 32;
                Console.WriteLine("A temperatura convertida é: " +
                                  $"{farenheit.ToString("F1", CultureInfo.InvariantCulture)}");
                Console.WriteLine("Deseja repetir? (s/n)");
                resposta = char.Parse(Console.ReadLine());

            } while (resposta == 's');
        }
    }
}
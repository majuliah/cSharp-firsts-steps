using System;
using System.Globalization;

namespace ConverteDolarParaReal
{
    class Program
    {
        static void Main(string[] args)
        {
            double dolar, valorDolarEmReal, conversaoDolarParaReal;
            Console.WriteLine("Entre com o valor em dólar que você possui e o valor do dólar");
            dolar = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            valorDolarEmReal = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            conversaoDolarParaReal = dolar * valorDolarEmReal;

            Console.WriteLine("Você possui " + conversaoDolarParaReal.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

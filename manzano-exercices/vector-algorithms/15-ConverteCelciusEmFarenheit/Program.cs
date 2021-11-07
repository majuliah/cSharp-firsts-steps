using System.Globalization;
using static System.Console;

namespace _15_ConverteCelciusEmFarenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetorCelcius = new double[5];
            double[] vetorFahrenheit = new double[5];
            string[] graus;
            
            WriteLine("Entre com as temperaturas em graus celcius");
            graus = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetorCelcius[i] = double.Parse(graus[i],CultureInfo.InvariantCulture);
                vetorFahrenheit[i] = (vetorCelcius[i] * 9) / 5 + 32.0;
            }

            foreach (var grau in vetorFahrenheit)
                Write(grau.ToString("F1", CultureInfo.InvariantCulture) + " ");
        }
    }
}

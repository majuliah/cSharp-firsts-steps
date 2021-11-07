using System.Globalization;
using static System.Console;

namespace _14_MediaMenorEmaior
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] vetor = new double[5];
            string[] valores;
            double media = 0, maior = 0, menor = 0, contador = 0;

            WriteLine("Entre com os valores");
            valores = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
            {
                vetor[i] = double.Parse(valores[i], CultureInfo.InvariantCulture);

                if (vetor[i] > maior)
                    maior = vetor[i];
                
                if (vetor[i] < maior)
                    menor = vetor[i]; 
                
                contador += vetor[i];
            }

            for (int i = 0; i < 5; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];
            }

            media = (contador / 5);
            
            WriteLine(menor.ToString("F2", CultureInfo.InvariantCulture));
            WriteLine(maior.ToString("F2", CultureInfo.InvariantCulture));
            WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}

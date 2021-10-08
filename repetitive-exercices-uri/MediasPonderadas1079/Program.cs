using System;
using System.Globalization;

namespace MediasPonderadas1079
{
    class Program
    {
        static void Main(string[] args)
        {
            int entrada;
            double nota1, nota2, nota3, media;
            string[] notas;
            Console.WriteLine("Entre com a quantidade de vezes que deseja fazer o teste");
            entrada = int.Parse(Console.ReadLine());

            for (int i = 1; i <= entrada ; i++)
            {
                Console.WriteLine($"Entrar com as {entrada} notas" );
                notas = Console.ReadLine().Split(' ');
                nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
                nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
                nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);

                media = (nota1 * 2.0 + nota2 * 3.0 + nota3 * 5.0) / (2.0 + 3.0 + 5.0);

                Console.WriteLine($"Média é {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            
        }
    }
}
using System;
using System.Globalization;

namespace CalculaMediaAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            Console.WriteLine("Entre com suas duas notas");
            string[] notas = Console.ReadLine().Split(' ');
            nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);

            media = (nota1 + nota2) / 2;

            if (media < 4.9)
            {
                Console.WriteLine($"Sua média foi {media.ToString("F1", CultureInfo.InvariantCulture)} e você está REPROVADO");

            } else if ( media > 4.9 & media <= 6.0)
            {
                Console.WriteLine($"Sua média foi: {media.ToString("F1", CultureInfo.InvariantCulture)} e você está de RECUPERAÇÃO");

            }
            else
            {
                Console.WriteLine($"Sua média foi: {media.ToString("F1", CultureInfo.InvariantCulture)} e você está APROVADO!!!");
            }

        }
    }
}

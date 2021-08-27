using System;
using System.Globalization;

namespace QuatroMediasDeUmAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notas;
            double nota1, nota2, nota3, nota4, media;
            Console.WriteLine("Entre com as quatro notas do ano.");

            notas = Console.ReadLine().Split(' ');
            nota1 = Double.Parse(notas[0], CultureInfo.InvariantCulture);
            nota2 = Double.Parse(notas[1], CultureInfo.InvariantCulture);
            nota3 = Double.Parse(notas[2], CultureInfo.InvariantCulture);
            nota4 = Double.Parse(notas[3], CultureInfo.InvariantCulture);

            media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media <= 5)
            {
                Console.WriteLine("Você foi reprovado.");
            }
            else
            {
                Console.WriteLine("Aprovado!");
            }

            Console.WriteLine($"Sua média foi {media.ToString("F1", CultureInfo.InvariantCulture)}");
        }
    }
}
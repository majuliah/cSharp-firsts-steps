using System;
using System.Globalization;

namespace ValidacaoDeNota1117
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            Console.WriteLine("Entre com as duas notas");

            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            while ((nota1 < 0.0 || nota1 > 10.0) || (nota2 < 0.0 || nota2 > 10.0))
            {
                Console.WriteLine("Nota Inválida");
                nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }
            
            media = (nota1 + nota2) / 2.0;
            if (media <= 1.0)
            {
                Console.WriteLine("Notas inválidas");
            }
            else
            {
                Console.WriteLine($"A média das notas é {media.ToString("F1", CultureInfo.InvariantCulture)}");
            }

        }
    }
}
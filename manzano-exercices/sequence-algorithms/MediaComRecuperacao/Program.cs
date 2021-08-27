using System;
using System.Globalization;

namespace MediaComRecuperacao
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notas;
            double media1, media2, nota1, nota2, nota3, nota4, nota5;
            Console.WriteLine("Entre com as quatro notas do ano.");

            notas = Console.ReadLine().Split();
            nota1 = double.Parse(notas[0], CultureInfo.InvariantCulture);
            nota2 = double.Parse(notas[1], CultureInfo.InvariantCulture);
            nota3 = double.Parse(notas[2], CultureInfo.InvariantCulture);
            nota4 = double.Parse(notas[3], CultureInfo.InvariantCulture);
            media1 = (nota1 + nota2 + nota3 + nota4) / 4;

            if (media1 >= 7)
            {
                Console.WriteLine("Aprovado!" + "\n" + "Sua média foi: " + media1.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine("Entre com a nota da sua recuperação.");
                nota5 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                media2 = (media1 + nota5) / 2;

                if (media2 <= 5)
                {
                    Console.WriteLine("Reprovado!" + "\n" + "Sua média foi: " + media2.ToString("F1", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Aprovado com exame final! " + "\n" + "Sua média foi: " + media2.ToString("F1", CultureInfo.InvariantCulture));
                }
            }
        }
    }
}
using System;
using System.Globalization;

namespace CalculaAproveitamento
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            double nota1, nota2, media;
            Console.WriteLine("Entre com o seu nome");
            nome = Console.ReadLine();
            Console.WriteLine("Entre com suas notas");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = (nota1 + nota2) / 2;

            if (media > 7.0)
            {
                Console.WriteLine(nome +", aproveitamento bom! Sua méda foi: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
            else
            {
                Console.WriteLine(nome + ", aproveitamento ruim. Sua média foi: " + media.ToString("F1", CultureInfo.InvariantCulture));
            }
        }
    }
}

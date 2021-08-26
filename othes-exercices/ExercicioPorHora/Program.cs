using System;
using System.Globalization;

namespace ExercicioPorHora
{
    class Program
    {
        static void Main(string[] args)
        {
            int horas, pontos;
            double dinheiro;
            Console.WriteLine("Entre com o total de horas de exercícios no mês");
            horas = int.Parse(Console.ReadLine());

            if (horas <= 10)
            {
                pontos = 2 * horas;
                dinheiro = pontos * 0.05;
                Console.WriteLine($"Você tem {pontos} pontos e tem direito à R${dinheiro.ToString("F2", CultureInfo.InvariantCulture)}");
            } else if (horas > 10 & horas < 20)
            {
                pontos = 5 * horas;
                dinheiro = pontos * 0.05;
                Console.WriteLine($"Você tem {pontos} pontos e tem direito à R${dinheiro.ToString("F2", CultureInfo.InvariantCulture)}");
            } else
            {
                pontos = 10 * horas;
                dinheiro = pontos * 0.05;
                Console.WriteLine($"Você tem {pontos} pontos e tem direito à R${dinheiro.ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}

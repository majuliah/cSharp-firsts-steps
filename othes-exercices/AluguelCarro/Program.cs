using System;
using System.Globalization;

namespace AluguelCarro
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias, kms;
            double valorAluguel;
            Console.WriteLine("Entre com o carro alugado, quantos dias e quantos km foram percorridos");
            string[] aluguel = Console.ReadLine().Split(' ');
            string carro = aluguel[0];
            dias = int.Parse(aluguel[1]);
            kms = int.Parse(aluguel[2]);

            switch (carro.ToLower())
            {
                case "economico":
                    if (kms <= 100)
                    {
                        valorAluguel = (dias * 90.0) + (kms * 0.20);
                        Console.WriteLine($"O valor do aluguel é: {valorAluguel.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    else
                    {
                        valorAluguel = (dias * 90.0) + (kms * 0.10);
                        Console.WriteLine($"O valor do aluguel é: {valorAluguel.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    break;

                case "luxo":
                    if (kms <= 200)
                    {
                        valorAluguel = (dias * 150.0) + (kms * 0.30);
                        Console.WriteLine($"O valor do aluguel é: {valorAluguel.ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    else
                    {
                        valorAluguel = (dias * 150.0)  + (kms * 0.25);
                        Console.WriteLine($"O valor do aluguel é: {valorAluguel.ToString("F2", CultureInfo.InvariantCulture)}");

                    }
                    break;
                default:
                    Console.WriteLine("carro não encontrado");
                    break;
            }
        }
    }
}

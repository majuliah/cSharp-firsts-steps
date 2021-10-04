using System;

namespace ParOuImpar1074
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, numero;
            Console.WriteLine("Entre com uma quantidade de valores");
            numero = int.Parse(Console.ReadLine());

            for (int i = 0; i < numero; i++)
            {
                Console.WriteLine($"Entre com o {i + 1}º numero");
                number = int.Parse(Console.ReadLine());

                if (number % 2 == 0 && number > 0)
                    Console.WriteLine("EVEN POSITIVE");
                else if (number % 2 == 0 && number < 0)
                    Console.WriteLine("EVEN NEGATIVE");
                else if (number % 2 != 0 && number > 0)
                    Console.WriteLine("ODD POSITIVE");
                else if (number % 2 != 0 && number < 0)
                    Console.WriteLine("ODD NEGATIVE");
                 else
                     Console.WriteLine("NULL");
            }
        }
    }
}
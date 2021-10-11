using System;

namespace FatorialSimples1153
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, fatorial = 0;
            Console.WriteLine("Entre com um número!");
            numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                fatorial += numero * (numero - i);
            }
            Console.WriteLine($"Fatorial é: {fatorial}");
        }
    }
}
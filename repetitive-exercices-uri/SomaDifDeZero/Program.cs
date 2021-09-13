using System;

namespace SomaDifDeZero
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, soma = 0;
            Console.WriteLine("Soma números diferentes de 0");

            numero = int.Parse(Console.ReadLine());
            while (numero != 0)
            {
                soma += numero;
                numero = int.Parse(Console.ReadLine());
                
            }
            Console.WriteLine($"A soma é {soma}");
        }
    }
}
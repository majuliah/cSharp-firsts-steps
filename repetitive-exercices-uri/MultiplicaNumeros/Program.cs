using System;

namespace MultiplicaNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, multiplicacao = 1;
            Console.WriteLine("Entre com números diferentes de 0");

            numero = int.Parse(Console.ReadLine());

            while (numero != 0)
            {
                multiplicacao = multiplicacao * numero;
                numero = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A multiplicação é {multiplicacao}");
        }
    }
}
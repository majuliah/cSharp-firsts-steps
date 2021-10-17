using System;

namespace UltrapassandoZ1150
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, soma;
            Console.WriteLine("Entre com dois valores");
            int valor1 = int.Parse(Console.ReadLine());
            int valor2 = int.Parse(Console.ReadLine());

            while (valor2 <= valor1)
            {
                valor2 = int.Parse(Console.ReadLine());
            }
            soma = valor1;
            do
            {
                valor1 += 1;
                soma += valor1;
                cont += 1;

            } while (soma <= valor2);
            Console.WriteLine(cont);
        }
    }
}
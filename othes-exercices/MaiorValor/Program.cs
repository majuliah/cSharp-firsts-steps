using System;

namespace MaiorValor
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero1, numero2;
            Console.WriteLine("Entre com dois números inteiros");
            numero1 = int.Parse(Console.ReadLine());
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("O primeiro é maior");
            } else if (numero1 < numero2)
            {
                Console.WriteLine("O segundo é maior");
            } else
            {
                Console.WriteLine("Números iguais!");
            }


        }
    }
}

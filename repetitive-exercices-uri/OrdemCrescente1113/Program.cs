using System;

namespace OrdemCrescente1113
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numeros;
            int numero1, numero2;
            Console.WriteLine("Entre com dois numeros");

            numeros = Console.ReadLine().Split(' ');
            numero1 = int.Parse(numeros[0]);
            numero2 = int.Parse(numeros[1]);

            while (numero1 != numero2)
            {
                if (numero1 < numero2)
                {
                    Console.WriteLine("Crescente");
                }
                else
                {
                    Console.WriteLine("Decrescente");
                }
                
                numeros = Console.ReadLine().Split(' ');
                numero1 = int.Parse(numeros[0]);
                numero2 = int.Parse(numeros[1]);

            }
        }
    }
}
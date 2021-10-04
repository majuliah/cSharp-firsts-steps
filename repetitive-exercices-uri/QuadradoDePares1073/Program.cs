using System;

namespace QuadradoDePares1073
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor;
            Console.WriteLine("Entre com um valor.");
            valor = int.Parse(Console.ReadLine());

            if (valor % 2 == 0)
            {
                for (int i = 2; i <= valor; i += 2)
                {
                    Console.WriteLine($"{i} ^ 2 = {Math.Pow(i, 2)}");
                }    
            }
            else
            {
                for (int i = 2; i < valor; i += 2)
                {
                    Console.WriteLine($"{i} ^ 2 = {Math.Pow(i, 2)}");
                }
            }
            
        }
    }
}
using System;

namespace Tabuada1078
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;
            numero = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= 10; i++)
            {
                resultado = i * numero;
                Console.WriteLine($"{numero} * {i} = {resultado}");
            }
        }
    }
}
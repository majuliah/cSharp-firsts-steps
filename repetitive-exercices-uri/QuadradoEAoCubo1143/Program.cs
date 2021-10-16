using System;

namespace QuadradoEAoCubo1143
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com um número");
            int numero = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numero; i++)
            {
                int primeiro = i;
                int segundo = i * i;
                int terceiro = i * i * i;
                Console.WriteLine($"{primeiro}  {segundo}  {terceiro}");
            }
        }
    }
}
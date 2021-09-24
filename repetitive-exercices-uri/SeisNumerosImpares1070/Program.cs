using System;

namespace SeisNumerosImpares1070
{
    class Program
    {
        static void Main(string[] args)
        {
            int x;
            x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                x += 1;
                Console.WriteLine($"{x}");
                for (int i = 0; i <= 4; i++)
                {
                    x += 2;
                    Console.WriteLine($"{x}");
                }
            }
            else
            {
                for (int i = 0; i <= 5; i++)
                {
                    x += 2;
                    Console.WriteLine($"{x}");
                }
            }
            
        }
    }
}
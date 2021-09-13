using System;

namespace NumerosPositivos1060
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, cont = 0, totPos = 0;
            
            while (cont < 6)
            {
                num = int.Parse(Console.ReadLine());
                cont += 1;
                if (num > 0)
                {
                    totPos += + 1;
                }
            }

            Console.WriteLine($"{totPos} valores positivos");
        }
    }
}
using System;

namespace TesteDeSelecao1035
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C, D, SOMACD, SOMAAB, PAR;
            Console.WriteLine("Entre com um valor para A");
            A = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um valor pra B");
            B = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um valor pra C");
            C = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com um valor pra ");
            D = int.Parse(Console.ReadLine());

            SOMACD = C + D;
            SOMAAB = A + B;

            if ((B > C & D > A) & (SOMACD > SOMAAB) & (C > 0 & D > 0) & (A % 2 == 0))
            {
                Console.WriteLine("Valores Aceitos");
            } else
            {
                Console.WriteLine("Valores não aceitos");
            }


        }
    }
}

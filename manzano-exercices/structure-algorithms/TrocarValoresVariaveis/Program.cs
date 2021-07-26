using System;

namespace TrocarValoresVariaveis
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B, C;
            Console.WriteLine("Entre com dois valores inteiros");
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            C = A;
            A = B;
            B = C;

            Console.WriteLine("Os valores trocados são: " + A + " e " + B);
        }
    }
}

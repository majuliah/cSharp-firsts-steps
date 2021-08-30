using System;
using System.Globalization;

namespace TipoDoTriangulo1045_melhorado
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split(' ');
            double n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            double n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            double n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            double A, B, C;

            if (n1 > n2 && n1 > n3)
            {
                A = n1;
                if (n2 > n3)
                {
                    B = n2;
                    C = n3;
                }
                else
                {
                    B = n3;
                    C = n2;
                }
            }else if (n2 > n3)
            {
                A = n2;
                if (n3 > n1)
                {
                    B = n3;
                    C = n1;
                }
                else
                {
                    B = n1;
                    C = n3;
                }
            }
            else
            {
                A = n3;
                if (n2 > n1)
                {
                    B = n2;
                    C = n1;
                }
                else
                {
                    B = n1;
                    C = n2;
                }
            }

            if (A >= B + C)
            {
                Console.WriteLine("NÃO FORMA TRIANGLE");
            }
            else
            {
                if (A * A == B * B + C * C)
                {
                    Console.WriteLine("TRIANGLE RETANGLE");
                }else if (A * A > B * B + C * C)
                {
                    Console.WriteLine("Triangle obtusangle");
                }
                else
                {
                    Console.WriteLine("Triangle Acutangle");
                }

                if (A == B && B == C)
                {
                    Console.WriteLine("Triangle Equilátero");
                }else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("Triangle Isósceles");
                }
                
            }
            
        }
    }
}
using System;
using System.Globalization;

namespace TiposDeTriangulo1045
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lados;
            double ladoA = 0, ladoB = 0, ladoC = 0, maiorA, meioB, menorC;
            Console.WriteLine("Entre com 3 lados de um triângulo.");

            lados = Console.ReadLine().Split();
            ladoA = double.Parse(lados[0], CultureInfo.InvariantCulture);
            ladoB = double.Parse(lados[1], CultureInfo.InvariantCulture);
            ladoC = double.Parse(lados[2], CultureInfo.InvariantCulture);

            if (ladoA > ladoB && ladoA > ladoC)
            {
                maiorA = ladoA;
                if (ladoB > ladoC)
                {
                    meioB = ladoB;
                    menorC = ladoC;
                }
                else
                {
                    meioB = ladoC;
                    menorC = ladoB;
                }
            }else if (ladoB > ladoA && ladoB > ladoC)
            {
                maiorA = ladoB;
                if (ladoA > ladoC)
                {
                    meioB = ladoA;
                    menorC = ladoC;
                }
                else
                {
                    meioB = ladoC;
                    menorC = ladoA;
                }
            }else
            {
                maiorA = ladoC;
                if (ladoA > ladoB)
                {
                    meioB = ladoA;
                    menorC = ladoB;
                }
                else
                {
                    meioB = ladoB;
                    menorC = ladoA;
                }
            }

            Console.WriteLine($"{maiorA}, {meioB}, {menorC}");

            if (maiorA >= meioB + menorC)
            {
                Console.WriteLine("NÃO FORMA TRIÂNGULO!");
            }else if (Math.Pow(maiorA, 2) == Math.Pow(meioB, 2) + Math.Pow(menorC, 2))
            {
                Console.WriteLine("TRIÂNGULO RETÂNGULO!!!!!!!");
            }else if (Math.Pow(maiorA, 2) > Math.Pow(meioB, 2) + Math.Pow(menorC, 2))
            {
                Console.WriteLine("TRIÂNGULO OBTUSÂNGULO!!!!!!!!!!!!");
            }else if (Math.Pow(maiorA, 2) < Math.Pow(meioB, 2) + Math.Pow(menorC, 2))
            {
                Console.WriteLine("TRIÂNGULO ACUTÂNGULO!!!!!!!!!!!!");
            }else if (maiorA == meioB && meioB == menorC)
            {
                Console.WriteLine("TRIÂNGULO EQUILÁTEROOOO!!!!!!!!!!!!!!!!!");
            }else if (maiorA == meioB || maiorA == menorC || meioB == menorC)
            {
                Console.WriteLine("TRIANGULO ISÓCSELESSS");
            }
           
        }
            
    }
        
    
}
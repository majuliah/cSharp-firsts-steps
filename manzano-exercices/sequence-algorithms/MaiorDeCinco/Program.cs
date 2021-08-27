using System;

namespace MaiorDeCinco
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int valorA, valorB, valorC, valorD, valorE, maior;
            Console.WriteLine("Entre com 5 números");

            valores = Console.ReadLine().Split(' ');
            valorA = int.Parse(valores[0]);
            valorB = int.Parse(valores[1]);
            valorC = int.Parse(valores[2]);
            valorD = int.Parse(valores[3]);
            valorE = int.Parse(valores[4]);

            if (valorA > valorB && valorA > valorC && valorA > valorD && valorA > valorE)
            {
                maior = valorA;
            }
            else if (valorB > valorA && valorB > valorC && valorB > valorD && valorB > valorE)
            {
                maior = valorB;
            }
            else if (valorC > valorA && valorC > valorB && valorC > valorD && valorC > valorE)
            {
                maior = valorC;
            }else if (valorD > valorA && valorD > valorB && valorD > valorC && valorD > valorE)
            {
                maior = valorD;
            }
            else
            {
                maior = valorE;
            }

            Console.WriteLine("Maior valor é: " + maior);
            
        }
    }
}
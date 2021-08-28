using System;
using System.Globalization;

namespace Triangulo1043
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] medidas;
            double pontoA, pontoB, pontoC, area, perimetro;
            Console.WriteLine("Entre com três medidas para realizar o cálculo");

            medidas = Console.ReadLine().Split(' ');
            pontoA = double.Parse(medidas[0], CultureInfo.InvariantCulture);
            pontoB = double.Parse(medidas[1], CultureInfo.InvariantCulture);
            pontoC = double.Parse(medidas[2], CultureInfo.InvariantCulture);

            if (( pontoB - pontoC < pontoA && pontoA < pontoB + pontoC ) 
                && ( pontoA - pontoC < pontoB && pontoB < pontoA + pontoC )
                  &&  ( pontoA - pontoB < pontoC && pontoC < pontoA + pontoB ))
            {
                perimetro = pontoA + pontoB + pontoC;
                Console.WriteLine($"Perímetro = {perimetro.ToString("F1", CultureInfo.InvariantCulture)}");
            }
            else
            {
                area = ((pontoA + pontoB) * pontoC) / 2;
                Console.WriteLine($"A área do trapézio é: {area.ToString("F1", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
using System;
using System.Globalization;

namespace CoordenadasDeUmPonto1041
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas;
            double coordenadaX, coordenadaY;
            Console.WriteLine("Entre com duas coordenadas");

            coordenadas = Console.ReadLine().Split(' ');
            coordenadaX = double.Parse(coordenadas[0], CultureInfo.InvariantCulture);
            coordenadaY = double.Parse(coordenadas[1], CultureInfo.InvariantCulture);

            if (coordenadaX == 0 & coordenadaY == 0)
            {
                Console.WriteLine("Origem");
            }else if (coordenadaX > 0 & coordenadaY > 0)
            {
                Console.WriteLine("Q1");
            }else if (coordenadaX > 0 & coordenadaY < 0)
            {
                Console.WriteLine("Q4");
            }else if (coordenadaX < 0 & coordenadaY < 0)
            {
                Console.WriteLine("Q3");
            }
            else
            {
                Console.WriteLine("Q2");
            }
            
            
        }
    }
}
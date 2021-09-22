using System;

namespace Quadrante1115
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] coordenadas;
            int x, y;
            Console.WriteLine("Entre com as coordenadas de X e Y reespectivamente");
            coordenadas = Console.ReadLine().Split(' ');
            x = int.Parse(coordenadas[0]);
            y = int.Parse(coordenadas[1]);

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("Quadrante 1");
                }else if (x < 0 && y < 0)
                {
                    Console.WriteLine("Quadrante 3");
                }else if (x > 0 && y < 0)
                {
                    Console.WriteLine("Quadrante 4");
                }
                else
                {
                    Console.WriteLine("Quadrante 2");
                }
                coordenadas = Console.ReadLine().Split(' ');
                x = int.Parse(coordenadas[0]);
                y = int.Parse(coordenadas[1]);
            }

        }
    }
}
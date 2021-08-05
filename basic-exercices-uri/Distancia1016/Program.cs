using System;

namespace Distancia1016
{
    class Program
    {
        static void Main(string[] args)
        {
            int distancia, tempo, minuto;
            minuto = 2;
            Console.WriteLine("Entre com a distância");
            distancia = int.Parse(Console.ReadLine());

            tempo = distancia * minuto;

            Console.WriteLine("A distância é de : " + tempo);
        }
    }
}

using System;

namespace ConverteSegundos1019
{
    class Program
    {
        static void Main(string[] args)
        {
            int duracaoEmsegundos, horas, resto, minutos, segundos;
            duracaoEmsegundos = int.Parse(Console.ReadLine());

            horas = duracaoEmsegundos / 3600;
            resto = duracaoEmsegundos % 3600;
            minutos = resto / 60;
            segundos = resto % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);
        }
    }
}

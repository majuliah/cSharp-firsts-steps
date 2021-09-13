using System;

namespace TempoDeJogo1046
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] horas;
            int horaInicial, horaFinal, tempoTotal = 0;
            Console.WriteLine("Entre com a hora inicial e a hora final de um jogo");

            horas = Console.ReadLine().Split(' ');
            horaInicial = int.Parse(horas[0]);
            horaFinal = int.Parse(horas[1]);

           
            if (horaInicial < horaFinal)
            {
                tempoTotal = horaFinal - horaInicial;
            }
            else
            {
                tempoTotal = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine($"O jogo durou {tempoTotal} horas.");
            
        }
    }
}
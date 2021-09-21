using System;

namespace TempoDeJogo1047
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tempo;
            int horaInicial, minutoInicial, horaFinal, minutoFinal, minutosInicio, minutosFim, duracaoEvento, duracaoEmHora, duracaoEmMinuto;
            Console.WriteLine("Entre com a hora e minuto inicial e depois hora e minuto final");
            tempo = Console.ReadLine().Split(' ');

            horaInicial = int.Parse(tempo[0]);
            minutoInicial = int.Parse(tempo[1]);
            horaFinal = int.Parse(tempo[2]);
            minutoFinal = int.Parse(tempo[3]);

            minutosInicio = (horaInicial * 60) + minutoInicial;
            minutosFim = (horaFinal * 60) + minutoFinal;

            if (minutosInicio < minutosFim)
            {
                duracaoEvento = minutosFim - minutosInicio;
            }
            else
            {
                duracaoEvento = (24 * 60 - minutosInicio) + minutosFim;
            }

            duracaoEmHora = duracaoEvento / 60;
            duracaoEmMinuto = duracaoEvento % 60;

            Console.WriteLine($"O evento durou {duracaoEmHora} hora(s) e {duracaoEmMinuto} minuto(s)");
            
        }
    }
}
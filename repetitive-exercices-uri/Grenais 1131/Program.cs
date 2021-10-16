using System;
using System.Threading.Channels;

namespace Grenais_1131
{
    class Program
    {
        static void Main(string[] args)
        {
            int resposta, time1, time2, cont = 0, inter = 0, gremio = 0, empate = 0;
            string[] gols;

            do
            {
                gols = Console.ReadLine().Split(' ');
                time1 = int.Parse(gols[0]);
                time2 = int.Parse(gols[1]);
                
                if (time1 > time2)
                    inter += 1;
                else
                    gremio += 1;
                
                if (inter == gremio)
                {
                    empate += 1;
                }

                Console.WriteLine("Novo Grenal (1-sim 2-não)");
                resposta = int.Parse(Console.ReadLine());
                cont += 1;
            } while (resposta == 1);

            Console.WriteLine($"{cont} grenais");
            Console.WriteLine($"Inter: {inter}" + "\n" + $"Grêmio: {gremio}");
            if (empate > 1)
            {
                Console.WriteLine($"Empates: {empate}");
            }
        }
    }
}
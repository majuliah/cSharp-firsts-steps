using System;
using System.Globalization;

namespace CrescimentoPopulacional1160
{
    class Program
    {
        static void Main(string[] args)
        {
            int cidadeA, cidadeB, testes, anos = 0, totalA, totalB;
            double crescimentoA, crescimentoB;
            string[] infos;
            Console.WriteLine("Entre com a quantidade de testes");
            testes = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < testes; i++)
            {
                infos = Console.ReadLine().Split(' ');
                cidadeA = int.Parse(infos[0]); //população da cidade A
                cidadeB = int.Parse(infos[1]); //população da cidade B
                crescimentoA = double.Parse(infos[2], CultureInfo.InvariantCulture); //crescimento populacional de A
                crescimentoB = double.Parse(infos[3], CultureInfo.InvariantCulture); //crescimento populacional de B

                totalA = cidadeA;
                totalB = cidadeB;

                while (totalA <= totalB)
                {
                    totalA += (int)(totalA * (crescimentoA / 100));
                    totalB += (int)(totalB * (crescimentoB / 100));
                    anos += 1;

                }

                if (anos > 100)
                {
                    Console.WriteLine("Mais de um século");
                }
                else
                {
                    Console.WriteLine($"{anos} anos");
                }   
            }
        }
    }
}
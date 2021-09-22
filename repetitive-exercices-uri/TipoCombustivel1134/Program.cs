using System;

namespace TipoCombustivel1134
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int escolha ,sim = 1, alcool = 0, gasolina = 0, diesel = 0, fim = 4;
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("--Bem-Vindo Ao Posto Boneco Bombado!--");
            Console.WriteLine("-- 01:    ALCOOL                    --");
            Console.WriteLine("-- 02:    GASOLINA                  --");
            Console.WriteLine("-- 03:    DIESEL                    --");
            Console.WriteLine("-- 04:    SAIR                      --");
            Console.WriteLine("--------------------------------------");

            while (sim == 1)
            {
                escolha = int.Parse(Console.ReadLine());
                switch (escolha)
                {
                    case 1:
                        alcool += 1;
                        break;
                    case 2:
                        gasolina += 1;
                        break;
                    case 3:
                        diesel += 1;
                        break;
                }
                Console.WriteLine("Votar novamente?");
                sim = int.Parse(Console.ReadLine());
                while (sim != 1 && sim != 4)
                {
                    Console.WriteLine("Votar novamente?");
                    sim = int.Parse(Console.ReadLine());
                }

                
            }
            Console.WriteLine("----------------------------------");
            Console.WriteLine("      AGRADECEMOS POR VOTAR!!     ");
            Console.WriteLine($" {alcool}     ALCOOL             ");
            Console.WriteLine($" {gasolina}   GASOLINA           ");
            Console.WriteLine($" {diesel}     DIESEL             ");
            Console.WriteLine("----------------------------------");

            
        }
    }
}
using System;

namespace NumeroPrimo1165
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com o número de verificações: ");
            int verificacoes = int.Parse(Console.ReadLine());

            for (int i = 0; i < verificacoes; i++)
            {
                int numero = int.Parse(Console.ReadLine());
                int metade = numero / 2;


                bool primo = true;

                for (int j = 2; j <= metade; j++)
                {
                    if (numero / 2 == 0)
                    {
                        primo = false;
                        break;
                    }
                }

                if (primo)
                {
                    Console.WriteLine("Ehr primo");
                }
                else
                {
                    Console.WriteLine("Não ehr primo");
                }
            }
        }
    }
}
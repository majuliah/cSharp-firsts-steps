using System;

namespace ParesImparesPosEneg1066
{
    class Program
    {
        static void Main(string[] args)
        {
            int valores, par = 0, impar = 0, positivo = 0, negativo = 0;

            for (int i = 0; i <= 4; i++)
            {
                valores = int.Parse(Console.ReadLine());

                if (valores % 2 == 0)
                {
                    par ++;
                }
                else
                {
                    impar ++;
                }

                if (valores >= 0)
                {
                    positivo ++;
                }
                else
                {
                    negativo ++;
                }

            }

            Console.WriteLine(par + " valor(es) par(es)");
            Console.WriteLine(impar + " valor(es) impar(es)");
            Console.WriteLine(positivo + " valor(es) positivo(s)");
            Console.WriteLine(negativo + " valor(es) negativo(s)");
        }
    }
}
using System;

namespace OrdemCrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores;
            int valor1, valor2, valor3, valor4;
            Console.WriteLine("Entre com 3 valores");

            valores = Console.ReadLine().Split(' ');
            valor1 = int.Parse(valores[0]);
            valor2 = int.Parse(valores[1]);
            valor3 = int.Parse(valores[2]);

            if (valor1 > valor2 && valor1 > valor3)
            {
                valor1 = valor1;

                if (valor2 > valor3)
                {
                    valor2 = valor2;
                    valor3 = valor3;
                }
                else
                {
                    valor4 = valor2;
                    valor2 = valor3;
                    valor3 = valor4;
                }

                Console.WriteLine(valor1 + " " + valor2 + " " + valor3);
            }
            else if (valor2 > valor1 && valor2 > valor3)
            {
                valor4 = valor1;
                valor1 = valor2;

                if (valor1 > valor3)
                {
                    valor2 = valor4;
                }
                else
                {
                    valor2 = valor3;
                    valor3 = valor4;
                }

                Console.WriteLine(valor1 + " " + valor2 + " " + valor3);
            }
            else
            {
                valor4 = valor1;
                valor1 = valor3;

                if (valor2 > valor1)
                {
                    valor3 = valor4;
                }
                else
                {
                    valor3 = valor2;
                    valor2 = valor4;
                }
                Console.WriteLine(valor1 + " " + valor2 + " " + valor3);
            }
        }
    }
}
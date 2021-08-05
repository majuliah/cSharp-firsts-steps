using System;

namespace Cedulas1018
{
    class Program
    {
        static void Main(string[] args)
        {
            int dinheiro, cem, cinquenta, vinte, dez, cinco, dois, um, resto;
            Console.WriteLine("Entre com a quantidade em dinheiro");
            dinheiro = int.Parse(Console.ReadLine());

            cem = dinheiro / 100;
            resto = dinheiro % 100;
            cinquenta = resto / 50;
            resto = resto % 50;
            vinte = resto / 20;
            resto = resto % 20;
            dez = resto / 10;
            resto = resto % 10;
            cinco = resto / 5;
            resto = resto % 5;
            dois = resto / 2;
            resto = resto % 2;
            um = resto;

            Console.WriteLine(cem);
            Console.WriteLine(cinquenta);
            Console.WriteLine(vinte);
            Console.WriteLine(dez);
            Console.WriteLine(cinco);
            Console.WriteLine(dois);
            Console.WriteLine(um);

            //outra forma mais fácil de desenvolver:
            /* using System;

            namespace uri1018 {
            class Program {
            static void Main(string[] args) {
            int N, quociente, resto, nota;

            N = int.Parse(Console.ReadLine());
            Console.WriteLine(N);

            resto = N;

            nota = 100;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 50;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 20;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 10;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 5;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            nota = 2;
            quociente = resto / nota;
            Console.WriteLine(quociente + " nota(s) de R$ " + nota + ",00");
            resto = resto % nota;

            Console.WriteLine(resto + " nota(s) de R$ 1,00");
            }
            }
            }
            */
        }
    }

}

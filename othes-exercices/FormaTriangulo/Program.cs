using System;

namespace FormaTriangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entre com as três medidas de um triangulo");
            int ladoA = int.Parse(Console.ReadLine());
            int ladoB = int.Parse(Console.ReadLine());
            int ladoC = int.Parse(Console.ReadLine());

            int somaAb, somaAc, somaBc;
            somaAb = ladoA + ladoB;
            somaBc = ladoB + ladoC;
            somaAc = ladoA + ladoC;

            if ((ladoA < somaBc) & (ladoB < somaAc) & (ladoC < somaAb))
            {
                Console.WriteLine("Triângulo Isósceles!");
            }
            else
            {
                Console.WriteLine("Não é possível formar um triângulo!");
            }
        }
    }
}

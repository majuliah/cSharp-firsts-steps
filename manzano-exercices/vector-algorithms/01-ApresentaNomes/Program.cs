using static System.Console;

namespace _01_ApresentaNomes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string[10];
            WriteLine("Entre com 10 nomes :)");

            for (int i = 0; i < 10; i++)
                nomes[i] = ReadLine();
            
            for (int i = 0; i < 10; i++)
                Write(nomes[i] + " ");
            
        }
    }
}

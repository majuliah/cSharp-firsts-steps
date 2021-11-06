using static System.Console;

namespace _07_NomeEIdade
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] idades = new int[5];
            string[] nomes = new string[5];
            string[] informacoes = new string[10];
            string[] dados;
            int cont = 0, conta = 0;
            
            
            WriteLine("Entre com os nomes das pessoas");
            dados = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
                nomes[i] = dados[i];
            
            WriteLine("Agora com as idades das pessoas");
            dados = ReadLine().Split(' ');

            for (int i = 0; i < 5; i++)
                idades[i] = int.Parse(dados[i]);

            for (int i = 0; i < 10; i++)
            {
                if (i == 0 || i % 2 == 0)
                {
                    informacoes[i] = nomes[cont];
                    cont++;
                }
                else
                {
                    informacoes[i] = dados[conta];
                    conta++;
                }
            }
            foreach (var info in informacoes)
                Write(info + " ");
        }
    }
}

using static System.Console;
namespace MedotoDeBuscaSequencial
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int total = 0;
            string[] nomes = new string[8];
            bool continua = true;
            string nome, continuar;
            
            WriteLine("Entre com os nomes para compor o vetor: ");
            nomes = ReadLine().Split(' ');

            do
            {
                WriteLine("Escreva o nome que quer pesquisar: ");
                nome = ReadLine()
                    ;
                for (int i = 0; i < 8; i++)
                {
                    if (nomes[i] == nome)
                    {
                        WriteLine($"O nome {nome} está contido na posição {i} do vetor.");
                        total++;
                        break;
                    }
                }

                if (total == 0)
                {
                    WriteLine("Não existe este nome no vetor.");
                }

                WriteLine("Deseja continuar?");
                continuar = ReadLine();

                if (continuar != "Sim".ToLower())
                    continua = false;
                
            } while (continua);
        }
    }
}
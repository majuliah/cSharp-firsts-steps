using static System.Console;
namespace OrdenacaoComNumeros
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] resultado = new int[8];
            string[] entrada;
            int numero;
            
            WriteLine("Entre com os números (8 somente)");
            entrada = ReadLine().Split(' ');

            for (int i = 0; i < 8; i++)
                resultado[i] = int.Parse(entrada[i]);

            for (int i = 0; i < 7; i++)
            {
                for (int j = i + 1; j < 8; j++)
                {
                    if (resultado[i] < resultado[j])
                    {
                        numero = resultado[i];
                        resultado[i] = resultado[j];
                        resultado[j] = numero;
                    }
                }
            }

            for (int i = 0; i < 8; i++)
            {
                Write(resultado[i] + " ");
            }



        }
    }
}
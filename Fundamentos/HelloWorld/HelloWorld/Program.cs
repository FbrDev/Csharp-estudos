using System.Collections;
using static System.Console; // Importação de bibliotecas

namespace HelloWorld
{
    internal class Program // Programa Inicial
    {
        static void Main(string[] args) // Metódo de inicialização da aplicação
        {
            for (int i = 0; i <= 10; i++)
            {
                WriteLine(i);
            }

            string[] nomes = new string[] { "Fabrício", "Patinhas", "Musk" };
            for (int i = 0; i < nomes.Length; i++)
            {
                WriteLine(nomes[i]);
            }
        }
    }
}
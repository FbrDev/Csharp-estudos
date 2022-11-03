using System.Collections;
using static System.Console; // Importação de bibliotecas

namespace HelloWorld
{
    internal class Program // Programa Inicial
    {
        static void Main(string[] args) // Metódo de inicialização da aplicação
        {
            var i = 0;
            while (i <= 10)
            {
                if(i == 10) break;

                if(i == 4) continue;

                Write(i);
                i++;
            }

            string[] nomes = new string[] { "Fabrício", "Patinhas", "Musk" };
            int x = 0;

            while(x < nomes.Length)
            {
                WriteLine(nomes[x]);
                x++;
            }

            do
            {
                Write(i);
                i++;
            } while (i <= 10);

        }
    }
}
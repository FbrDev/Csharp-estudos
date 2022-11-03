using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Aula12For
    {
        static void Aula12()
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

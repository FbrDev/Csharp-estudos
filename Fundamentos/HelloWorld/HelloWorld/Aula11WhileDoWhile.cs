using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Aula11WhileDoWhile
    {
        static void Aula11()
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

using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Aula08Tuplas
    {
        static void Aula08()
        {
            //Tuplas podemos ter vários valores de tipos diferentes

            (string, string, double) brasil = ("Brasil", "Brasília", 1268.33);
            WriteLine($"O {brasil.Item1}, cuja sua capital é {brasil.Item2} tem a rpc de R$ {brasil.Item3}");

            (string nome, int populacao, string capital, double rpc) portugal = ("Portugal", 10000000, "Lisboa", 740.83);
            WriteLine($"O {portugal.nome}, cuja sua capital é {portugal.capital} tem a rpc de R$ {portugal.rpc} e a população de {portugal.populacao}");
        }
    }
}

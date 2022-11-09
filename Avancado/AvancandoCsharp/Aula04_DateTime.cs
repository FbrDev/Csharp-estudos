using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvancandoCsharp
{
    internal class Aula04_DateTime
    {
        static void Aula04()
        {
            Console.WriteLine("{0}", DateTime.Now); // Data atual
            Console.WriteLine("{0}", DateTime.Now.AddDays(10)); //Valor positivo adiciona e negativo subtrai
            Console.WriteLine("{0}", DateTime.Now);
        }
    }
}

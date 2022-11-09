using System.Globalization;
using System.Text;

namespace AvancandoCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("{0}", DateTime.Now); // Data atual
            Console.WriteLine("{0}", DateTime.Now.AddDays(10)); //Valor positivo adiciona e negativo subtrai
            Console.WriteLine("{0}", DateTime.Now);
        }
    }
}